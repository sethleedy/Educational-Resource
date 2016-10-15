Public Class frmSettings

    Private Sub frmSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Save all the settings before closing the form
        Try
            My.Settings.Save() ' Needed for the controls on this form
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Check Security

        ' All good ?

        ' Load form values.
        strDBServerAddress.Text = My.Settings.strDBServerAddress
        strDBUsername.Text = My.Settings.strDBUserName
        strDBPassword.Text = My.Settings.strDBPassword
        intDBPort.Text = CStr(My.Settings.intDBPort)

        ' Set the default index on the semester selection
        comboSelectSemester.SelectedIndex = 0


    End Sub

    Private Sub browseSpreadSheet_Click_1(sender As Object, e As EventArgs) Handles browseSpreadSheet.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim myStream As Stream = Nothing
        Dim XLSpath As String = " "

        openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog1.Filter = "Excel Files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()

                XLSpath = openFileDialog1.FileName ' This be the magic filename with path that we needed to load the spreadsheet from selected location.
                'MessageBox.Show(XLSpath)
                'Console.Write(XLSpath)

                'If (myStream IsNot Nothing) Then
                '    ' Insert code to read the stream here.
                'End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try

            ' The following is the routine to open the spreadsheet.
            If (Not commonFunctions.openSpreadSheet(XLSpath)) Then
                MsgBox("Error in loading the spreadsheet", MsgBoxStyle.Critical)
            End If


        End If
    End Sub

    Private Sub DBTestConnection_Click(sender As Object, e As EventArgs) Handles DBTestConnection.Click

        ' Save the settings
        My.Settings.strDBServerAddress = strDBServerAddress.Text
        My.Settings.intDBPort = CInt(intDBPort.Text)
        My.Settings.strDBUserName = strDBUsername.Text
        My.Settings.strDBPassword = strDBPassword.Text

        ' Save settings
        My.Settings.Save()

        ' Test if the SQL Server connection is good
        Dim testReturn As Boolean = SQL_Functions.SQLTestConnection()

        ' True if the settings worked and the connection is open.
        MsgBox(testReturn)



    End Sub
End Class