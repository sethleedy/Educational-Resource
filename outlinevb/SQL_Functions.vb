Imports System.Data.SqlClient ' Test
Module SQL_Functions

    ' https://www.tutorialspoint.com/vb.net/vb.net_database_access.htm

    Dim sqlConn As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataSet As New DataSet

    Function SQLTest() As Boolean

        'Dim sql As String
        'Dim numberOfAffectedRowsOrResults As Integer

        '' Change ServerName to localhost or remote server
        ''connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"

        'sql = "Select * from Rooms;"

        '' Parameterized SQL command which prevents SQL injections.
        '' It Is best practice to use parameterized commands for security and performance
        ''cmd = New SqlCommand("update Books set Name = @name where Id = @id")
        'sqlCommand = New SqlCommand(sql)
        ''sqlCommand.Parameters.Add(New SqlParameter("@name", txtName.Text))
        ''sqlCommand.Parameters.Add(New SqlParameter("@id", txtId.Text))

        'sqlCommand.Connection = openSQL() ' sqlCommand can hold the connection object, as returned by the function openSQL.
        'numberOfAffectedRowsOrResults = selectSQL(sqlCommand)

        ' return info ?
        Return True

    End Function

    Function parseSpreadSheet() As Boolean

        ' Open SQL

        ' Loop spreadsheet

        ' Insert into SQL

        ' Close SQL

        ' Test
        SQLTest()

        Return True

    End Function

    Function SQLCreateSemesterDB() As Boolean

        '''' Database template1 for Semesters

        Dim execStr1 As String
        Dim dbname As String = "EduResSch-" & frmSettings.comboSelectSemester.SelectedItem.ToString & frmSettings.DateTimePickSemesterYear.Value.Year.ToString

        Dim sqlConn As SqlConnection = openSQL(False, True)


        ' The entire string to create the database and tables is stored in the Settings of the project.
        execStr1 = My.Settings.strCreateDatabase1 ' This one does the first Semester database

        ' We will modify the string to create the specific database we want. Eg: spring2017 or fall2018
        ' The sql script comes with the default of "EduResSch-template1"
        execStr1 = execStr1.Replace("EduResSch-template1", dbname)

        Dim myCommand As SqlCommand = New SqlCommand(execStr1, sqlConn)

        ' Then exec the SQL and look for errors.
        Try
            ' Split SQL-Scripts at the GO keyword (like SSMS)
            ' Blorgbeard's Solution
            ' https://github.com/ststeiger/ScriptSplitter
            For Each sqlBatch As String In execStr1.Split(New String() {"GO", "Go", "go"}, StringSplitOptions.RemoveEmptyEntries)
                myCommand.CommandText = sqlBatch
                myCommand.ExecuteNonQuery()
            Next

            MessageBox.Show("Database " + dbname + " is created successfully", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error in creating the database! " & ex.Message.ToString, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        Finally
            If (sqlConn.State = ConnectionState.Open) Then
                closeCompletelySQL(sqlConn)
            End If

        End Try

        ' Set the Semester in use to this one in the frmSettings form.
        My.Settings.strInitialCatalog = frmSettings.comboSelectSemester.SelectedItem.ToString & frmSettings.DateTimePickSemesterYear.Value.Year.ToString

        ' Call function to fill in combobox with all the semesters in SQL server.
        listSemestersInDB(frmSettings.semesterComboBox1)

        Return True

    End Function

    Function sqlCreateAuthDB() As Boolean

        '''' Database template2 for Username/Passwords

        Dim execStr2 As String
        Dim dbname As String = "EduResSch-auth"


        ' We do NOT want to overwrite this database.
        ' Check if exists and return false if so.
        If CheckDatabaseExists(dbname) Then
            ' Make a note in the log...


            Return False
        End If

        execStr2 = My.Settings.strCreateDatabase2 ' This holds the SQL code for creating the database

        Dim sqlConn As SqlConnection = openSQL()


        ' We will modify the string to create the specific database we want. Eg: spring2017 or fall2018
        ' The sql script comes with the default of "EduResSch-template2"
        execStr2 = execStr2.Replace("EduResSch-template2", dbname)

        Dim myCommand2 As SqlCommand = New SqlCommand(execStr2, sqlConn)

        ' Then exec the SQL and look for errors.
        Try
            ' Split SQL-Scripts at the GO keyword (like SSMS)
            ' Blorgbeard's Solution
            ' https://github.com/ststeiger/ScriptSplitter
            For Each sqlBatch As String In execStr2.Split(New String() {"GO", "Go", "go"}, StringSplitOptions.RemoveEmptyEntries)
                myCommand2.CommandText = sqlBatch
                myCommand2.ExecuteNonQuery()
            Next

            MessageBox.Show("Database " + dbname + " is created successfully", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())

            If (sqlConn.State = ConnectionState.Open) Then
                closeCompletelySQL(sqlConn)
            End If

            Return False

        Finally
            If (sqlConn.State = ConnectionState.Open) Then
                closeCompletelySQL(sqlConn)
            End If
        End Try

        Return True

    End Function

    Private Function CheckDatabaseExists(database As String) As Boolean

        Dim cmdText As String = "select * from master.dbo.sysdatabases where name LIKE '" & database & "%'"
        Dim sqlConn As SqlConnection = openSQL()
        Dim bRet As Boolean = False

        Using sqlConn

            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConn)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using

        sqlConn.Close()

        Return bRet

    End Function

    Function SQLTestConnection() As Boolean

        Dim testconn As SqlConnection = openSQL(True)

        If testconn.State = ConnectionState.Closed Then
            Return False
        ElseIf testconn.State = ConnectionState.Open Then
            closeCompletelySQL(testconn)

            Return True
        End If

        MsgBox("Undetermined connection state: " & testconn.State.ToString)
        Return False

    End Function

    Public Function openSQL(Optional test As Boolean = False, Optional skipInitalCatalog As Boolean = False) As SqlConnection

        ' All information should be coming from My.Settings which are updated from frmSettings.
        ' https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlconnection.connectionstring(v=vs.110).aspx

        ' Test for flag saying we have tested SQL settings. Eg: username, password. From the Database Test Button in Settings Form.
        If My.Settings.goodDBSettings = True Or test = True Then

            ' Test for local network connection
            If checkForLocalNetworkConnection() = True Then ' Should be checking a LAN resource. DB is likely to be on the local network.

                Dim sqlConnBuilder As New SqlConnectionStringBuilder()

                ' We can connect with an Instance or just the normal port number.
                If My.Settings.strDBInstance <> "" Then

                    ' Instance with port
                    sqlConnBuilder.DataSource = My.Settings.strDBServerAddress & "\" & My.Settings.strDBInstance & "," & My.Settings.intDBPort
                Else
                    ' Normal connection
                    sqlConnBuilder.DataSource = My.Settings.strDBServerAddress

                End If

                If skipInitalCatalog = False And test = False Then
                    If My.Settings.CurrentDB <> "" Then
                        sqlConnBuilder.InitialCatalog = My.Settings.CurrentDB ' Like EduResSch-spring2017

                    Else
                    End If
                ElseIf test = True Or skipInitalCatalog = True Then
                    sqlConnBuilder.InitialCatalog = "" ' My.Settings.strDBPrefix & My.Settings.strInitialCatalog

                End If

                sqlConnBuilder.IntegratedSecurity = False
                sqlConnBuilder.ConnectTimeout = 10
                sqlConnBuilder.Encrypt = False ' What are the requirements for True ?
                sqlConnBuilder.TrustServerCertificate = True
                sqlConnBuilder.ApplicationIntent = ApplicationIntent.ReadWrite

                ' Get auth info and use it here to open SQL server
                sqlConnBuilder.UserID = My.Settings.strDBUserName
                sqlConnBuilder.Password = My.Settings.strDBPassword


                Try
                    sqlConn = New SqlConnection(sqlConnBuilder.ToString)
                    sqlConn.Open()

                Catch ex As Exception

                    If test = False Then
                        MsgBox("Error opening the MSSQL connection: " + ex.Message, MsgBoxStyle.Critical, "Connection did not succeed.")
                    End If

                    ' Connection Failed. Return something..
                    Return sqlConn
                End Try

                ' It opened and everything is good.
                Return sqlConn
            End If
        End If

        Return New SqlConnection ' Proper coding with methods should resolve this.

    End Function
    Function closeCompletelySQL(connection As SqlConnection) As Boolean

        connection.ClearAllPools()
        connection.Close()
        connection.Dispose()

        If connection.State = ConnectionState.Closed Then
            Return True
        Else
            MsgBox("Connection did not close as expected.", MsgBoxStyle.Exclamation, "SQL Connection")
            Return False
        End If

    End Function

    Function updateSQL() As Boolean

        Return True

    End Function

    Function insertSQL(sqlCommand As SqlCommand) As Integer

        Dim numberOfAffectedRows As Integer

        Try
            numberOfAffectedRows = sqlCommand.ExecuteNonQuery()

        Catch ex As Exception

            closeCompletelySQL(sqlCommand.Connection)
            MsgBox("Can not execute sqlCommand.ExecuteNonQuery() !: " & ex.Message)
            Return -1
        End Try

        Return numberOfAffectedRows
    End Function

    Function selectSQL(sqlCommand As SqlCommand) As Integer

        Dim sqlReader As SqlDataReader
        Dim sqlNewDataTable As New DataTable

        sqlReader = sqlCommand.ExecuteReader() ' Allow access to the returned values.

        Try

            ' Add the current returned SQL data to the programs tab of tables
            ' Example: https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Data.DataSet.Tables);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6.1);k(DevLang-VB)&rd=true
            sqlNewDataTable.Load(sqlReader) ' Load the info from the reader
            sqlDataSet.Tables.Add(sqlNewDataTable) ' Place it into the program tables to be called upon later.

            For Each row As DataRow In sqlDataSet.Tables(sqlDataSet.Tables.Count - 1).Rows ' Zero based count in Tables...

                MsgBox(row.Item("contact_id").ToString & "  -  " & row.Item("username").ToString & "  -  " & row.Item("email").ToString)

            Next row

        Catch ex As Exception

            sqlReader.Close()
            closeCompletelySQL(sqlCommand.Connection)

            MsgBox("Can not open connection!: " & ex.Message)

            Return -1

        End Try

        sqlReader.Close()
        closeCompletelySQL(sqlCommand.Connection)

        Return sqlDataSet.Tables(sqlDataSet.Tables.Count - 1).Rows.Count


    End Function

    Function listSemestersInDB(cBox As ComboBox) As Boolean

        ' Test if the DB is even created yet.
        If My.Settings.DBCreated = True Then

            ' Dataset that the combobox is going to tie into.
            Dim ds1 As New DataSet()
            Dim ds2 As New DataSet()
            Dim ds3 As New DataSet()
            Dim command As SqlCommand
            Dim adapter As New SqlDataAdapter()

            ' Open connection to Master DB
            Dim sqlConnList As SqlConnection = openSQL(False, True) ' #2 True, to skip connecting to a specific database

            ' Test if the connection opened!
            If sqlConnList.State = ConnectionState.Open Then

                ' Three searches, one for each semester.
                Dim Sql1 = "select dbid, name from master.dbo.sysdatabases where name LIKE '" & My.Settings.strDBPrefix & "spring%'"
                Dim Sql2 = "select dbid, name from master.dbo.sysdatabases where name LIKE '" & My.Settings.strDBPrefix & "summer%'"
                Dim Sql3 = "select dbid, name from master.dbo.sysdatabases where name LIKE '" & My.Settings.strDBPrefix & "fall%'"

                ' SQL1 to DS1
                Try
                    command = New SqlCommand(Sql1, sqlConnList)
                    adapter.SelectCommand = command
                    adapter.Fill(ds1)

                    adapter.Dispose()
                    command.Dispose()


                Catch ex As Exception
                    MessageBox.Show("Error in listing semesters for a combobox: " & ex.Message.ToString)

                    Return False
                End Try

                ' SQL2 to DS2
                Try
                    command = New SqlCommand(Sql2, sqlConnList)
                    adapter.SelectCommand = command
                    adapter.Fill(ds2)

                    adapter.Dispose()
                    command.Dispose()


                Catch ex As Exception
                    MessageBox.Show("Error in listing semesters for a combobox: " & ex.Message.ToString)

                    Return False
                End Try

                ' SQL3 to DS3
                Try
                    command = New SqlCommand(Sql3, sqlConnList)
                    adapter.SelectCommand = command
                    adapter.Fill(ds3)

                    adapter.Dispose()
                    command.Dispose()


                Catch ex As Exception
                    MessageBox.Show("Error in listing semesters for a combobox: " & ex.Message.ToString)

                    Return False
                End Try

                ' Merge our three search results
                ds1.Merge(ds2)
                ds1.Merge(ds3)

                ' Setup the passed combobox for displaying our dataset
                cBox.DataSource = ds1.Tables(0)
                cBox.ValueMember = "dbid"
                cBox.DisplayMember = "name"


                closeCompletelySQL(sqlConnList)

                Return True
            Else
                Return False
            End If

        End If

    End Function
    Function listCampusesInListBox(lbox As ListBox) As Boolean

        ' Test if the DB is even created yet.
        If My.Settings.DBCreated = True Then

            ' Dataset that the combobox is going to tie into.
            Dim ds1 As New DataSet()
            Dim command As SqlCommand
            Dim adapter As New SqlDataAdapter()

            ' Open connection to Master
            Dim sqlConnList As SqlConnection = openSQL(False, False) ' #2 True, to skip connecting to a specific database

            ' Test if the connection opened!
            If sqlConnList.State = ConnectionState.Open Then

                ' Test if the table exists !


                ' search for all campuses in selected database.
                '"Select campusId, campusName from campus"


                Dim sql = "Select campusId, campusName from campus"


                ' SQL to DS1
                Try
                    command = New SqlCommand(sql, sqlConnList)
                    adapter.SelectCommand = command
                    adapter.Fill(ds1)

                    adapter.Dispose()
                    command.Dispose()


                Catch ex As Exception
                    MessageBox.Show("Error in listing campuses for a listbox: " & ex.Message.ToString)

                    Return False
                End Try


                ' Setup the passed combobox for displaying our dataset
                lbox.DataSource = ds1.Tables(0)
                lbox.ValueMember = "campusId"
                lbox.DisplayMember = "campusName"

                closeCompletelySQL(sqlConnList)

                Return True

            Else
                Return False
            End If
        End If
    End Function

End Module
