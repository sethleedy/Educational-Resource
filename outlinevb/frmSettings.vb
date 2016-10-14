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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SQLCreateDB()

    End Sub
End Class