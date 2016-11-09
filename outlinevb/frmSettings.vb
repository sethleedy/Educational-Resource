Imports System.ComponentModel

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

        '''' Load form values.
        ' Database connection info
        strDBServerAddress.Text = My.Settings.strDBServerAddress
        strDBUsername.Text = My.Settings.strDBUserName
        strDBPassword.Text = My.Settings.strDBPassword
        intDBPort.Text = CStr(My.Settings.intDBPort)

        ' Check if the DB exists
        If checkForProgramDB1() Then

            ' Set and fill Semester combobox on tab Semesters
            ' Call function to fill in combobox with all the semesters in SQL server.
            listSemestersInDB(Me.semesterComboBox1)
            ' Set the default index on the semester selection on tab Database Information
            comboSelectSemester.SelectedIndex = 0

        End If

        ' Security login on load ?
        chkRunWithoutSecurity.Checked = My.Settings.chkRunWithoutSecurity


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
        My.Settings.strDBInstance = strDBInstance.Text
        My.Settings.intDBPort = CInt(intDBPort.Text)
        My.Settings.strDBUserName = strDBUsername.Text
        My.Settings.strDBPassword = strDBPassword.Text
        My.Settings.goodDBSettings = False ' Reset to false to test the new settings. If settings prove to be good, set to true.

        ' Save settings
        My.Settings.Save()

        ' Test if the SQL Server connection is good
        Dim testReturn As Boolean = SQL_Functions.SQLTestConnection()

        ' True if the settings worked and the connection is open.
        If (testReturn = True) Then
            ' Flag to rest of the program, we can use the DB. It has been tested.
            My.Settings.goodDBSettings = True

            ' Call function to fill in combobox with all the semesters in SQL server.
            SQL_Functions.listSemestersInDB(Me.semesterComboBox1)

            MsgBox("Connection was successful.", MsgBoxStyle.OkOnly, "Database Connection Test")
        Else
            MsgBox("Connection unsuccessful.", MsgBoxStyle.Exclamation, "Database Connection Test")
        End If



    End Sub

    Private Sub DBReset_Click(sender As Object, e As EventArgs) Handles DBReset.Click

        ' Create the database for the selected semester
        Dim a As Boolean = SQLCreateSemesterDB()

        ' Important, create the Auth DB LAST!
        ' Both for the sake of SQL DB creation errors(errors out and we can still login to fix it/try again), but also for setting the Semester within the code when the SemesterDB gets created.

        ' Create it if it does not exists. Function will check and will not overwrite.
        Dim b As Boolean = sqlCreateAuthDB()

        ' Test if db created ok, then flag it as done
        If a And b Then

            ' Tell program we can use the DB created
            My.Settings.DBCreated = True
            My.Settings.Save()

            ' Call function to fill in combobox with all the semesters in SQL server.
            SQL_Functions.listSemestersInDB(Me.semesterComboBox1)

        Else
            MsgBox("Error creating the Databases", MsgBoxStyle.Critical, "Creating Databases Failed")
        End If



    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        ' Check if the account exists.

        ' If exists, alert user to change the username.
        'Else, INSERT to DB the username in the username table.

        ' Encrypt the password and INSERT it into the passwords table.


    End Sub


    Private Sub frmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        My.Settings.Save()

        ' Close DB connection ?
        'SQL_Functions.closeCompletelySQL()

    End Sub

    Private Sub chkRunWithoutSecurity_Click(sender As Object, e As EventArgs) Handles chkRunWithoutSecurity.Click
        ' Set the value from the checkbox
        My.Settings.chkRunWithoutSecurity = chkRunWithoutSecurity.Checked

        ' Save settings
        'MsgBox("Saving Settings")
        My.Settings.Save()
    End Sub

    Private Sub semesterComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semesterComboBox1.SelectedIndexChanged
        Dim selectedDB As String = semesterComboBox1.Text

        My.Settings.CurrentDB = selectedDB

        My.Settings.Save()
    End Sub
End Class