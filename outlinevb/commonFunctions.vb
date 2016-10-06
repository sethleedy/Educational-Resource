Imports System.IO ' Test﻿
Imports System.Data.SqlClient ' Test
Module commonFunctions


    Function openSpreadSheet(path As String) As Boolean

        Dim OLEConnection As OleDbConnection
        Dim dataSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        Dim sheetNames1 As ArrayList
        Dim tmpSheetName As String

        ' Connection string changes with OLE componet being used.
        ' Debug Line
        ' Seth's Debug Line
        Dim OleConnectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Seth\Documents\Syncs\WindowsShare\Schooling Resources\Stark State 2016\Fall\ANLYZNG SFTWRE REQ AND DEV SOL\Project todo\Code and resources\keep unconverted - Fall_2016_Schedule_for_CSE236.xlsx;Persist Security Info=False;Extended Properties=" & Chr(34) & "Excel 12.0;IMEX=1;HDR=Yes" & Chr(34) ' Connection string for 2004 .xlsx files and older.
        ' Production Line
        'Dim OleConnectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=False;Extended Properties=" & Chr(34) & "Excel 12.0;IMEX=1;HDR=Yes" & Chr(34) ' Connection string for 2004 .xlsx files and older.

        ' Open main connection
        OLEConnection = New OleDbConnection(OleConnectionStr)
        Try
            If Not OLEConnection.State = ConnectionState.Open Then
                OLEConnection.Open()

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try


        ' Check for open connection. .Open() errors sometimes.
        ' May be reduntant due to catch block above.
        If Not OLEConnection.State = ConnectionState.Open Then
            Throw New Exception("OLEConnection refused to open")
            Return False
        End If

        ' Try get Sheet Names, opens it's own connection. Issues ?
        'sheetNames1 = GetSchemaTable(OleConnectionStr)
        sheetNames1 = GetSchemaTable(OLEConnection)

        ObjectDumper.ObjectDumperExtensions.DumpToString(sheetNames1, "sheetNames1")

        tmpSheetName = sheetNames1.Item(0).ToString ' Assumming only the first tab is being used. Should offer on the form which to use or all.
        'Dim tmpSheetName As String = "Test1"


        'MsgBox(DataGridView1.RowCount) ' Count 13


        Try
            'For Each tmpSheetName In sheetNames1
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [" + tmpSheetName + "]", OLEConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)

            ' Set DataGrid to display data from this SheetName, overriding prev because of loop. Need to hold all. Append function ?
            'DataGridView1.DataSource = dataSet.Tables(0) 
            'MsgBox("Data Opened")

            ' Goto this function to parse the records and place into the SQL.
            Dim returnValue = SQL_Functions.parseSpreadSheet()


            'Next


            OLEConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

        Return True

    End Function

    Function GetSchemaTable(ByVal connectionObj As OleDbConnection) As ArrayList ' https://codereview.stackexchange.com/questions/20393/using-statement-for-oledb-is-this-overkill
        ' Try get Sheet Names, opens it's own connection.

        'Dim schemaTable As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        Dim schemaTable As DataTable = connectionObj.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
        Dim strColumnName As New ArrayList ' Array of Strings

        'Using connectionObj 'As New OleDbConnection(connectionObj)
        Try
            'MsgBox(connection.GetSchema("Columns").Rows(0).Item(2))

            ' Loop and add to the array for each unique item
            For Each tmpRow As DataRow In schemaTable.Rows

                'If Not strColumnName.Contains(tmpRow.ToString) Then
                strColumnName.Add(tmpRow.Item("TABLE_NAME").ToString)

                'End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' Any sheet names ?
        If (strColumnName.Count = 0) Then
            Throw New Exception("Unable to detect the spreadsheet tab names.")
        Else
            ObjectDumper.ObjectDumperExtensions.DumpToString(strColumnName, "strColumnName") ' https://objectdumper.codeplex.com/ | https://www.nuget.org/packages/ObjectDumper/
            Return strColumnName
        End If

        'End Using
    End Function

    Function saveSettings() As Boolean
        ' Save all the settings before closing the form
        Try
            My.Settings.Save() ' Needed for the controls on this form
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End Try

    End Function
End Module

