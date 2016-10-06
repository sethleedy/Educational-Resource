Imports System.Data.SqlClient ' Test
Module SQL_Functions
    Function SQLTest() As Boolean


        Dim command As SqlCommand
        Dim sql As String

        ' Change ServerName to localhost or remote server
        'connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"


        sql = "USE test1; Select * from Products;"

        Dim connection As SqlConnection = openSQL()

        Try

            command = New SqlCommand(sql, connection)

            Dim sqlReader As SqlDataReader = command.ExecuteReader()
            While sqlReader.Read()
                MsgBox(sqlReader.Item("type").ToString & "  -  " & sqlReader.Item("name").ToString & "  -  " & sqlReader.Item("amount").ToString)

            End While

            sqlReader.Close()
            command.Dispose()


        Catch ex As Exception
            closeSQL(connection)
            MsgBox("Can not open connection!: " & ex.Message)
            Return False
        End Try

        closeSQL(connection)

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

    Function SQLCreateDB() As Boolean

    End Function

    Function SQLTestConnection() As Boolean

    End Function

    Function openSQL() As SqlConnection

        Dim connectionString As String
        Dim connection As SqlConnection

        ' Pulled from Visual Studio SQL Server Object Explorer
        connectionString = "Data Source=DEV-WIN;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NORTHWND;"


        connection = New SqlConnection(connectionString)
        connection.Open()

        Return connection

    End Function
    Function closeSQL(connection As SqlConnection) As Boolean

        connection.Close()

        Return True

    End Function


End Module
