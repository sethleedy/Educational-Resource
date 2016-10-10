Imports System.Data.SqlClient ' Test
Module SQL_Functions
    Dim sqlConn As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataSet As New DataSet

    Function SQLTest() As Boolean

        Dim sql As String
        Dim numberOfAffectedRowsOrResults As Integer

        ' Change ServerName to localhost or remote server
        'connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"

        sql = "Select * from Contacts;"

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

    Function SQLCreateDB() As Boolean

    End Function

    Function SQLTestConnection() As Boolean

    End Function

    Function openSQL() As SqlConnection

        Dim sqlConnBuilder As New SqlConnectionStringBuilder()

        ' Pulled from Visual Studio SQL Server Object Explorer
        ' Seth's machine connection
        ' "Data Source=IP,PORT;" Typical Port is 1433
        ' User ID=myUsername;Password=myPassword;"

        'connectionString = "Data Source=DEV-WIN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=EduResSch;"
        sqlConnBuilder.DataSource = "DEV-WIN"
        'sqlConnBuilder.InitialCatalog = "EduResSch"
        sqlConnBuilder.InitialCatalog = "database1"
        sqlConnBuilder.IntegratedSecurity = True
        sqlConnBuilder.ConnectTimeout = 10
        sqlConnBuilder.Encrypt = False ' What is the requirements for True ?
        sqlConnBuilder.TrustServerCertificate = True
        sqlConnBuilder.ApplicationIntent = ApplicationIntent.ReadWrite

        sqlConn = New SqlConnection(sqlConnBuilder.ToString)
        sqlConn.Open()



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
            MsgBox("Can not sqlCommand.ExecuteNonQuery() !: " & ex.Message)
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

            For Each row As DataRow In sqlDataSet.Tables(sqlDataSet.Tables.Count - 1).Rows

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

        Return sqlDataSet.Tables(sqlDataSet.Tables.Count).Rows.Count


    End Function
End Module
