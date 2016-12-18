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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSelectSemester = New System.Windows.Forms.Button()
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnDeleteAccount = New System.Windows.Forms.Button()
        Me.listAccounts = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkAdminType = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkRunWithoutSecurity = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnDeleteSubject = New System.Windows.Forms.Button()
        Me.btnUpdateSubject = New System.Windows.Forms.Button()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.txtSubjectNickName = New System.Windows.Forms.TextBox()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.BtnUpdateCourse = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CBSubjects = New System.Windows.Forms.ComboBox()
        Me.txtCourseNum = New System.Windows.Forms.TextBox()
        Me.txtCRN = New System.Windows.Forms.TextBox()
        Me.DGVCourses = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDBFilePath = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBckUpPath = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DGVCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 19)
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
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(841, 480)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semesters"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.btnSelectSemester)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.semesterComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select semester for use"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(5, 71)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSelectSemester
        '
        Me.btnSelectSemester.Location = New System.Drawing.Point(212, 26)
        Me.btnSelectSemester.Name = "btnSelectSemester"
        Me.btnSelectSemester.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectSemester.TabIndex = 2
        Me.btnSelectSemester.Text = "Select"
        Me.btnSelectSemester.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 26)
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
        Me.TabPage2.Size = New System.Drawing.Size(833, 450)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Database information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtBckUpPath)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtDBFilePath)
        Me.GroupBox4.Controls.Add(Me.DateTimePickSemesterYear)
        Me.GroupBox4.Controls.Add(Me.comboSelectSemester)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DBBackup)
        Me.GroupBox4.Controls.Add(Me.DBReset)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(789, 220)
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
        Me.comboSelectSemester.Location = New System.Drawing.Point(467, 22)
        Me.comboSelectSemester.Name = "comboSelectSemester"
        Me.comboSelectSemester.Size = New System.Drawing.Size(126, 25)
        Me.comboSelectSemester.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.comboSelectSemester, "Choose the new Semester to setup in a database.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(463, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Backup the database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create anew or reset existing database"
        '
        'DBBackup
        '
        Me.DBBackup.Location = New System.Drawing.Point(632, 177)
        Me.DBBackup.Name = "DBBackup"
        Me.DBBackup.Size = New System.Drawing.Size(150, 30)
        Me.DBBackup.TabIndex = 1
        Me.DBBackup.Text = "Go!"
        Me.ToolTip1.SetToolTip(Me.DBBackup, "The backup will goto a yet to be chosen folder")
        Me.DBBackup.UseVisualStyleBackColor = True
        '
        'DBReset
        '
        Me.DBReset.Location = New System.Drawing.Point(6, 25)
        Me.DBReset.Name = "DBReset"
        Me.DBReset.Size = New System.Drawing.Size(150, 30)
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
        Me.DBTestConnection.Location = New System.Drawing.Point(524, 17)
        Me.DBTestConnection.Name = "DBTestConnection"
        Me.DBTestConnection.Size = New System.Drawing.Size(150, 30)
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
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(833, 307)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "User accounts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnChangePassword)
        Me.GroupBox6.Controls.Add(Me.btnDeleteAccount)
        Me.GroupBox6.Controls.Add(Me.listAccounts)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 195)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(680, 104)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Change an account"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(524, 54)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(150, 30)
        Me.btnChangePassword.TabIndex = 2
        Me.btnChangePassword.Text = "Change password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.Location = New System.Drawing.Point(524, 18)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.Size = New System.Drawing.Size(150, 30)
        Me.btnDeleteAccount.TabIndex = 1
        Me.btnDeleteAccount.Text = "Delete account"
        Me.btnDeleteAccount.UseVisualStyleBackColor = True
        '
        'listAccounts
        '
        Me.listAccounts.FormattingEnabled = True
        Me.listAccounts.ItemHeight = 17
        Me.listAccounts.Location = New System.Drawing.Point(6, 25)
        Me.listAccounts.Name = "listAccounts"
        Me.listAccounts.Size = New System.Drawing.Size(200, 72)
        Me.listAccounts.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkAdminType)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.btnCreateAccount)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtPassword)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtUsername)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(680, 186)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Create an account"
        '
        'chkAdminType
        '
        Me.chkAdminType.AutoSize = True
        Me.chkAdminType.Location = New System.Drawing.Point(7, 122)
        Me.chkAdminType.Name = "chkAdminType"
        Me.chkAdminType.Size = New System.Drawing.Size(223, 23)
        Me.chkAdminType.TabIndex = 15
        Me.chkAdminType.Text = "Is this an admin account ?"
        Me.chkAdminType.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(212, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 26)
        Me.TextBox1.TabIndex = 12
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(524, 17)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(150, 30)
        Me.btnCreateAccount.TabIndex = 2
        Me.btnCreateAccount.Text = "Create account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(6, 57)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9578)
        Me.txtPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.WordWrap = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(6, 25)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 26)
        Me.txtUsername.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Please ensure that the user has 'dbcreator' permission to create the database.")
        Me.txtUsername.WordWrap = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(833, 307)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Misc"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(680, 145)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Security"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.chkRunWithoutSecurity)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 25)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(668, 116)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Security login on load"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 22)
        Me.Label12.MaximumSize = New System.Drawing.Size(600, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(488, 38)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "This will allow anyone to load the program to view information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Upon trying to s" &
    "ave, it will still require the user to login."
        '
        'chkRunWithoutSecurity
        '
        Me.chkRunWithoutSecurity.AutoSize = True
        Me.chkRunWithoutSecurity.Checked = True
        Me.chkRunWithoutSecurity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRunWithoutSecurity.Location = New System.Drawing.Point(10, 63)
        Me.chkRunWithoutSecurity.Name = "chkRunWithoutSecurity"
        Me.chkRunWithoutSecurity.Size = New System.Drawing.Size(371, 23)
        Me.chkRunWithoutSecurity.TabIndex = 15
        Me.chkRunWithoutSecurity.Text = "Load the program without the security login ?"
        Me.chkRunWithoutSecurity.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnDeleteSubject)
        Me.TabPage5.Controls.Add(Me.btnUpdateSubject)
        Me.TabPage5.Controls.Add(Me.btnAddSubject)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.txtSubjectName)
        Me.TabPage5.Controls.Add(Me.txtSubjectNickName)
        Me.TabPage5.Controls.Add(Me.dgvSubjects)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(833, 307)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Subjects"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnDeleteSubject
        '
        Me.btnDeleteSubject.Location = New System.Drawing.Point(423, 59)
        Me.btnDeleteSubject.Name = "btnDeleteSubject"
        Me.btnDeleteSubject.Size = New System.Drawing.Size(126, 23)
        Me.btnDeleteSubject.TabIndex = 7
        Me.btnDeleteSubject.Text = "Delete Subject"
        Me.btnDeleteSubject.UseVisualStyleBackColor = True
        '
        'btnUpdateSubject
        '
        Me.btnUpdateSubject.Location = New System.Drawing.Point(249, 59)
        Me.btnUpdateSubject.Name = "btnUpdateSubject"
        Me.btnUpdateSubject.Size = New System.Drawing.Size(131, 23)
        Me.btnUpdateSubject.TabIndex = 6
        Me.btnUpdateSubject.Text = "Update Subject"
        Me.btnUpdateSubject.UseVisualStyleBackColor = True
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Location = New System.Drawing.Point(89, 59)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(108, 23)
        Me.btnAddSubject.TabIndex = 5
        Me.btnAddSubject.Text = "Add Subject"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(264, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Subject NickName:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 19)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Subject Name:"
        '
        'txtSubjectName
        '
        Me.txtSubjectName.Location = New System.Drawing.Point(139, 23)
        Me.txtSubjectName.MaxLength = 50
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(100, 26)
        Me.txtSubjectName.TabIndex = 2
        '
        'txtSubjectNickName
        '
        Me.txtSubjectNickName.Location = New System.Drawing.Point(423, 23)
        Me.txtSubjectNickName.MaxLength = 50
        Me.txtSubjectNickName.Name = "txtSubjectNickName"
        Me.txtSubjectNickName.Size = New System.Drawing.Size(100, 26)
        Me.txtSubjectNickName.TabIndex = 1
        '
        'dgvSubjects
        '
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AllowUserToDeleteRows = False
        Me.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjects.Location = New System.Drawing.Point(89, 88)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjects.Size = New System.Drawing.Size(460, 213)
        Me.dgvSubjects.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnDeleteCourse)
        Me.TabPage6.Controls.Add(Me.BtnUpdateCourse)
        Me.TabPage6.Controls.Add(Me.btnAddCourse)
        Me.TabPage6.Controls.Add(Me.Label17)
        Me.TabPage6.Controls.Add(Me.Label16)
        Me.TabPage6.Controls.Add(Me.Label15)
        Me.TabPage6.Controls.Add(Me.CBSubjects)
        Me.TabPage6.Controls.Add(Me.txtCourseNum)
        Me.TabPage6.Controls.Add(Me.txtCRN)
        Me.TabPage6.Controls.Add(Me.DGVCourses)
        Me.TabPage6.Location = New System.Drawing.Point(4, 26)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(833, 307)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Courses"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnDeleteCourse
        '
        Me.btnDeleteCourse.Location = New System.Drawing.Point(447, 59)
        Me.btnDeleteCourse.Name = "btnDeleteCourse"
        Me.btnDeleteCourse.Size = New System.Drawing.Size(124, 23)
        Me.btnDeleteCourse.TabIndex = 9
        Me.btnDeleteCourse.Text = "Delete Course"
        Me.btnDeleteCourse.UseVisualStyleBackColor = True
        '
        'BtnUpdateCourse
        '
        Me.BtnUpdateCourse.Location = New System.Drawing.Point(260, 59)
        Me.BtnUpdateCourse.Name = "BtnUpdateCourse"
        Me.BtnUpdateCourse.Size = New System.Drawing.Size(130, 23)
        Me.BtnUpdateCourse.TabIndex = 8
        Me.BtnUpdateCourse.Text = "Update Course"
        Me.BtnUpdateCourse.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(89, 59)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(121, 23)
        Me.btnAddCourse.TabIndex = 7
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(429, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 19)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Subject:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(212, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 19)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Course#:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 19)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "CRN:"
        '
        'CBSubjects
        '
        Me.CBSubjects.FormattingEnabled = True
        Me.CBSubjects.Location = New System.Drawing.Point(498, 6)
        Me.CBSubjects.Name = "CBSubjects"
        Me.CBSubjects.Size = New System.Drawing.Size(121, 25)
        Me.CBSubjects.TabIndex = 3
        '
        'txtCourseNum
        '
        Me.txtCourseNum.Location = New System.Drawing.Point(290, 6)
        Me.txtCourseNum.Name = "txtCourseNum"
        Me.txtCourseNum.Size = New System.Drawing.Size(100, 26)
        Me.txtCourseNum.TabIndex = 2
        '
        'txtCRN
        '
        Me.txtCRN.Location = New System.Drawing.Point(89, 6)
        Me.txtCRN.Name = "txtCRN"
        Me.txtCRN.Size = New System.Drawing.Size(100, 26)
        Me.txtCRN.TabIndex = 1
        '
        'DGVCourses
        '
        Me.DGVCourses.AllowUserToAddRows = False
        Me.DGVCourses.AllowUserToDeleteRows = False
        Me.DGVCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCourses.Location = New System.Drawing.Point(89, 88)
        Me.DGVCourses.Name = "DGVCourses"
        Me.DGVCourses.ReadOnly = True
        Me.DGVCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCourses.Size = New System.Drawing.Size(482, 213)
        Me.DGVCourses.TabIndex = 0
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'txtDBFilePath
        '
        Me.txtDBFilePath.Location = New System.Drawing.Point(6, 97)
        Me.txtDBFilePath.Name = "txtDBFilePath"
        Me.txtDBFilePath.Size = New System.Drawing.Size(777, 26)
        Me.txtDBFilePath.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 19)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Database File Path:"
        '
        'txtBckUpPath
        '
        Me.txtBckUpPath.Location = New System.Drawing.Point(6, 145)
        Me.txtBckUpPath.Name = "txtBckUpPath"
        Me.txtBckUpPath.Size = New System.Drawing.Size(776, 26)
        Me.txtBckUpPath.TabIndex = 8
        Me.txtBckUpPath.Text = "C:\Users\Ryan\Documents\newBackup"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 19)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Backup Path:"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 505)
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
        Me.Text = "Settings"
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
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.DGVCourses, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents listAccounts As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnDeleteAccount As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents chkAdminType As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkRunWithoutSecurity As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnDeleteSubject As Button
    Friend WithEvents btnUpdateSubject As Button
    Friend WithEvents btnAddSubject As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents txtSubjectNickName As TextBox
    Friend WithEvents dgvSubjects As DataGridView
    Friend WithEvents btnSelectSemester As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CBSubjects As ComboBox
    Friend WithEvents txtCourseNum As TextBox
    Friend WithEvents txtCRN As TextBox
    Friend WithEvents DGVCourses As DataGridView
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents BtnUpdateCourse As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtDBFilePath As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBckUpPath As TextBox
End Class
