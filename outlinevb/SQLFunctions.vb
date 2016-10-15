Imports System.Data.SqlClient ' Test
Module SQL_Functions

    ' https://www.tutorialspoint.com/vb.net/vb.net_database_access.htm

    Dim sqlConn As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataSet As New DataSet

    Function SQLTest() As Boolean

        Dim sql As String
        Dim numberOfAffectedRowsOrResults As Integer

        ' Change ServerName to localhost or remote server
        'connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"

        sql = "Select * from Rooms;"

        ' Parameterized SQL command which prevents SQL injections.
        ' It Is best practice to use parameterized commands for security and performance
        'cmd = New SqlCommand("update Books set Name = @name where Id = @id")
        sqlCommand = New SqlCommand(sql)
        'sqlCommand.Parameters.Add(New SqlParameter("@name", txtName.Text))
        'sqlCommand.Parameters.Add(New SqlParameter("@id", txtId.Text))

        sqlCommand.Connection = openSQL() ' sqlCommand can hold the connection object, as returned by the function openSQL.
        numberOfAffectedRowsOrResults = selectSQL(sqlCommand)

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

        Dim execStr1 As String
        Dim dbname As String = "EduResSch-" & frmSettings.comboSelectSemester.SelectedText & frmSettings.DateTimePickSemesterYear.Value.ToString

        Dim sqlConn As SqlConnection = openSQL()


        ' The entire string to create the database and tables is stored in the Settings of the project.
        execStr1 = My.Settings.strCreateDatabase1 ' This one does the first Semester database

        '''' Database 1 for Semesters

        ' We will modify the string to create the specific database we want. Eg: spring2017 or fall2018
        ' The sql script comes with the default of "EduResSch-template"
        ' Testing with summer2018
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
            MessageBox.Show(ex.ToString())
            Return False
        Finally
            If (sqlConn.State = ConnectionState.Open) Then
                closeSQL(sqlConn)
            End If

        End Try

        ' test
        sqlCreateAuthDB()

        Return True

    End Function

    Function sqlCreateAuthDB() As Boolean

        '''' Database 2 for Username/Passwords

        Dim execStr2 As String
        Dim dbname As String = "EduResSch-auth"

        execStr2 = My.Settings.strCreateDatabase2 ' This holds the username and passwords for program login.

        Dim sqlConn As SqlConnection = openSQL()


        ' We will modify the string to create the specific database we want. Eg: spring2017 or fall2018
        ' The sql script comes with the default of "EduResSch-template"
        ' Testing with summer2018
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
            Return False

        Finally
            If (sqlConn.State = ConnectionState.Open) Then
                closeSQL(sqlConn)
            End If
        End Try

        Return True

    End Function

    Function SQLTestConnection() As Boolean

        Dim testconn As SqlConnection = openSQL(True)

        If testconn.State = ConnectionState.Closed Then
            Return False
        Else
            Return True
        End If


    End Function

    Function openSQL(Optional test As Boolean = False) As SqlConnection

        Dim sqlConnBuilder As New SqlConnectionStringBuilder()

        ' All information should be coming from My.Settings which are updated from frmSettings.

        sqlConnBuilder.DataSource = My.Settings.strDBServerAddress & My.Settings.intDBPort ' Port is included here, but must not contain a space. - stringBuilder.DataSource = @"myServer\InstanceName,1433";
        'sqlConnBuilder.DataSource = "DEV-WIN"

        'sqlConnBuilder.InitialCatalog = "EduResSch-summer2018" ' Set to currently selected database semester. Catch 22 here.
        sqlConnBuilder.InitialCatalog = My.Settings.strInitialCatalog


        sqlConnBuilder.IntegratedSecurity = True
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
                MsgBox("Error opening the MSSQL connection: " + ex.Message)
            End If

            Return sqlConn
        End Try


        Return sqlConn

    End Function
    Function closeSQL(connection As SqlConnection) As Boolean

        connection.Close()

        Return True

    End Function

    Function updateSQL() As Boolean

    End Function

    Function insertSQL(sqlCommand As SqlCommand) As Integer

        Dim numberOfAffectedRows As Integer

        Try
            numberOfAffectedRows = sqlCommand.ExecuteNonQuery()

        Catch ex As Exception

            closeSQL(sqlCommand.Connection)
            MsgBox("Can not execute sqlCommand.ExecuteNonQuery() !: " & ex.Message)
            Return -1
        End Try

        Return numberOfAffectedRows
    End Function

    Function selectSQL(sqlCommand As SqlCommand) As Integer

        Dim sqlReader As SqlDataReader
        Dim sqlNewDataTable As New DataTable

        Try

            sqlReader = sqlCommand.ExecuteReader() ' Allow access to the returned values.

            ' Add the current returned SQL data to the programs tab of tables
            ' Example: https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Data.DataSet.Tables);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6.1);k(DevLang-VB)&rd=true
            sqlNewDataTable.Load(sqlReader) ' Load the info from the reader
            sqlDataSet.Tables.Add(sqlNewDataTable) ' Place it into the program tables to be called upon later.

            For Each row As DataRow In sqlDataSet.Tables(sqlDataSet.Tables.Count - 1).Rows ' Zero based count in Tables...

                MsgBox(row.Item("contact_id").ToString & "  -  " & row.Item("username").ToString & "  -  " & row.Item("email").ToString)

            Next row

        Catch ex As Exception

            sqlReader.Close()
            closeSQL(sqlCommand.Connection)

            MsgBox("Can not open connection!: " & ex.Message)

            Return -1

        End Try

        sqlReader.Close()
        closeSQL(sqlCommand.Connection)

        Return sqlDataSet.Tables(sqlDataSet.Tables.Count - 1).Rows.Count


    End Function
End Module
