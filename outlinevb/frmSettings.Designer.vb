<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.browseSpreadSheet = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.semesterComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickSemesterYear = New System.Windows.Forms.DateTimePicker()
        Me.comboSelectSemester = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DBBackup = New System.Windows.Forms.Button()
        Me.DBReset = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.strDBInstance = New System.Windows.Forms.TextBox()
        Me.DBTestConnection = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.strDBPassword = New System.Windows.Forms.TextBox()
        Me.strDBUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.intDBPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strDBServerAddress = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(704, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(122, 19)
        Me.ToolStripMenuItem1.Text = "Return to scheduler"
        '
        'browseSpreadSheet
        '
        Me.browseSpreadSheet.Location = New System.Drawing.Point(7, 26)
        Me.browseSpreadSheet.Margin = New System.Windows.Forms.Padding(4)
        Me.browseSpreadSheet.Name = "browseSpreadSheet"
        Me.browseSpreadSheet.Size = New System.Drawing.Size(145, 30)
        Me.browseSpreadSheet.TabIndex = 4
        Me.browseSpreadSheet.Text = "Load Spreadsheet"
        Me.browseSpreadSheet.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(704, 337)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(696, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semesters"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.semesterComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select semester for use"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Select based on semester && year"
        '
        'semesterComboBox1
        '
        Me.semesterComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semesterComboBox1.FormattingEnabled = True
        Me.semesterComboBox1.Location = New System.Drawing.Point(6, 25)
        Me.semesterComboBox1.Name = "semesterComboBox1"
        Me.semesterComboBox1.Size = New System.Drawing.Size(200, 25)
        Me.semesterComboBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.browseSpreadSheet)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New semester"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(696, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Database information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePickSemesterYear)
        Me.GroupBox4.Controls.Add(Me.comboSelectSemester)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DBBackup)
        Me.GroupBox4.Controls.Add(Me.DBReset)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(680, 100)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Database operations"
        '
        'DateTimePickSemesterYear
        '
        Me.DateTimePickSemesterYear.CustomFormat = "yyyy"
        Me.DateTimePickSemesterYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickSemesterYear.Location = New System.Drawing.Point(599, 21)
        Me.DateTimePickSemesterYear.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickSemesterYear.Name = "DateTimePickSemesterYear"
        Me.DateTimePickSemesterYear.ShowUpDown = True
        Me.DateTimePickSemesterYear.Size = New System.Drawing.Size(75, 26)
        Me.DateTimePickSemesterYear.TabIndex = 5
        Me.DateTimePickSemesterYear.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'comboSelectSemester
        '
        Me.comboSelectSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSelectSemester.FormattingEnabled = True
        Me.comboSelectSemester.Items.AddRange(New Object() {"Spring", "Summer", "Fall"})
        Me.comboSelectSemester.Location = New System.Drawing.Point(459, 22)
        Me.comboSelectSemester.Name = "comboSelectSemester"
        Me.comboSelectSemester.Size = New System.Drawing.Size(134, 25)
        Me.comboSelectSemester.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.comboSelectSemester, "Choose the new Semester to setup in a database.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Backup the database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create anew or reset existing database"
        '
        'DBBackup
        '
        Me.DBBackup.Location = New System.Drawing.Point(6, 54)
        Me.DBBackup.Name = "DBBackup"
        Me.DBBackup.Size = New System.Drawing.Size(75, 23)
        Me.DBBackup.TabIndex = 1
        Me.DBBackup.Text = "Go!"
        Me.ToolTip1.SetToolTip(Me.DBBackup, "The backup will goto a yet to be chosen folder")
        Me.DBBackup.UseVisualStyleBackColor = True
        '
        'DBReset
        '
        Me.DBReset.Location = New System.Drawing.Point(6, 25)
        Me.DBReset.Name = "DBReset"
        Me.DBReset.Size = New System.Drawing.Size(75, 23)
        Me.DBReset.TabIndex = 0
        Me.DBReset.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.DBReset, "This will create a new database with the name containing the semester and year se" &
        "lected.")
        Me.DBReset.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.strDBInstance)
        Me.GroupBox3.Controls.Add(Me.DBTestConnection)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.strDBPassword)
        Me.GroupBox3.Controls.Add(Me.strDBUsername)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.intDBPort)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.strDBServerAddress)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 191)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Database server location"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Instance"
        '
        'strDBInstance
        '
        Me.strDBInstance.Location = New System.Drawing.Point(6, 58)
        Me.strDBInstance.Name = "strDBInstance"
        Me.strDBInstance.Size = New System.Drawing.Size(200, 26)
        Me.strDBInstance.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.strDBInstance, "Optional instance name to connect to.")
        '
        'DBTestConnection
        '
        Me.DBTestConnection.Location = New System.Drawing.Point(599, 28)
        Me.DBTestConnection.Name = "DBTestConnection"
        Me.DBTestConnection.Size = New System.Drawing.Size(75, 23)
        Me.DBTestConnection.TabIndex = 8
        Me.DBTestConnection.Text = "Test"
        Me.ToolTip1.SetToolTip(Me.DBTestConnection, "Test the connection to MSSQL server.")
        Me.DBTestConnection.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username"
        '
        'strDBPassword
        '
        Me.strDBPassword.Location = New System.Drawing.Point(6, 157)
        Me.strDBPassword.Name = "strDBPassword"
        Me.strDBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9578)
        Me.strDBPassword.Size = New System.Drawing.Size(200, 26)
        Me.strDBPassword.TabIndex = 5
        Me.strDBPassword.UseSystemPasswordChar = True
        Me.strDBPassword.WordWrap = False
        '
        'strDBUsername
        '
        Me.strDBUsername.Location = New System.Drawing.Point(6, 125)
        Me.strDBUsername.Name = "strDBUsername"
        Me.strDBUsername.Size = New System.Drawing.Size(200, 26)
        Me.strDBUsername.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.strDBUsername, "Please ensure that the user has 'dbcreator' permission to create the database.")
        Me.strDBUsername.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port"
        '
        'intDBPort
        '
        Me.intDBPort.Location = New System.Drawing.Point(6, 93)
        Me.intDBPort.Name = "intDBPort"
        Me.intDBPort.Size = New System.Drawing.Size(200, 26)
        Me.intDBPort.TabIndex = 2
        Me.intDBPort.Text = "1433"
        Me.ToolTip1.SetToolTip(Me.intDBPort, "If not using the standard port, specify here.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Database server address"
        '
        'strDBServerAddress
        '
        Me.strDBServerAddress.Location = New System.Drawing.Point(6, 25)
        Me.strDBServerAddress.Name = "strDBServerAddress"
        Me.strDBServerAddress.Size = New System.Drawing.Size(200, 26)
        Me.strDBServerAddress.TabIndex = 0
        Me.strDBServerAddress.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(696, 344)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "User accounts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 362)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSettings"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents browseSpreadSheet As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents semesterComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents intDBPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents strDBServerAddress As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DBBackup As Button
    Friend WithEvents DBReset As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents strDBPassword As TextBox
    Friend WithEvents strDBUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DBTestConnection As Button
    Friend WithEvents DateTimePickSemesterYear As DateTimePicker
    Friend WithEvents comboSelectSemester As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents strDBInstance As TextBox
End Class
