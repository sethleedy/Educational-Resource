<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scheduler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scheduler))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbRooms = New System.Windows.Forms.ListBox()
        Me.lbBuilding = New System.Windows.Forms.ListBox()
        Me.lbCampus = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupScope = New System.Windows.Forms.GroupBox()
        Me.btnPopCampus = New System.Windows.Forms.Button()
        Me.GroupFeatures = New System.Windows.Forms.GroupBox()
        Me.chckActivatePrinters = New System.Windows.Forms.CheckBox()
        Me.chckActivateFloor = New System.Windows.Forms.CheckBox()
        Me.chckActivateProjector = New System.Windows.Forms.CheckBox()
        Me.chckActivateMonitors = New System.Windows.Forms.CheckBox()
        Me.chckActivateComputers = New System.Windows.Forms.CheckBox()
        Me.chckActivateCapacity = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chckRaisedFloor = New System.Windows.Forms.CheckBox()
        Me.chckProjector = New System.Windows.Forms.CheckBox()
        Me.chckDual = New System.Windows.Forms.CheckBox()
        Me.chckComputers = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.btnAddTime = New System.Windows.Forms.Button()
        Me.btnUpdateTime = New System.Windows.Forms.Button()
        Me.btnDeleteTime = New System.Windows.Forms.Button()
        Me.addRange = New System.Windows.Forms.Button()
        Me.endSemester = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMeeting = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdoColPri = New System.Windows.Forms.RadioButton()
        Me.rdoGrayPri = New System.Windows.Forms.RadioButton()
        Me.rdoSharedPri = New System.Windows.Forms.RadioButton()
        Me.gbPrinters = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rdoNoPri = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelPrinters = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PanelEditTimes = New System.Windows.Forms.Panel()
        Me.TTSched = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelScope = New System.Windows.Forms.Panel()
        Me.lblSelectADB = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupScope.SuspendLayout()
        Me.GroupFeatures.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPrinters.SuspendLayout()
        Me.PanelScope.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Calligraphy", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SearchToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 26)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.ToolStripMenuItem1.Text = "&Program"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem2.Text = "Help File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthorsToolStripMenuItem1})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'AuthorsToolStripMenuItem1
        '
        Me.AuthorsToolStripMenuItem1.Name = "AuthorsToolStripMenuItem1"
        Me.AuthorsToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.AuthorsToolStripMenuItem1.Text = "Authors"
        '
        'lbRooms
        '
        Me.lbRooms.FormattingEnabled = True
        Me.lbRooms.ItemHeight = 17
        Me.lbRooms.Location = New System.Drawing.Point(538, 22)
        Me.lbRooms.Name = "lbRooms"
        Me.lbRooms.Size = New System.Drawing.Size(145, 72)
        Me.lbRooms.TabIndex = 23
        '
        'lbBuilding
        '
        Me.lbBuilding.FormattingEnabled = True
        Me.lbBuilding.ItemHeight = 17
        Me.lbBuilding.Location = New System.Drawing.Point(314, 24)
        Me.lbBuilding.Name = "lbBuilding"
        Me.lbBuilding.Size = New System.Drawing.Size(145, 72)
        Me.lbBuilding.TabIndex = 24
        '
        'lbCampus
        '
        Me.lbCampus.FormattingEnabled = True
        Me.lbCampus.ItemHeight = 17
        Me.lbCampus.Location = New System.Drawing.Point(88, 24)
        Me.lbCampus.Name = "lbCampus"
        Me.lbCampus.Size = New System.Drawing.Size(141, 72)
        Me.lbCampus.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(475, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Rooms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Building"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Campus"
        '
        'GroupScope
        '
        Me.GroupScope.Controls.Add(Me.btnPopCampus)
        Me.GroupScope.Controls.Add(Me.lbRooms)
        Me.GroupScope.Controls.Add(Me.Label2)
        Me.GroupScope.Controls.Add(Me.Label3)
        Me.GroupScope.Controls.Add(Me.lbBuilding)
        Me.GroupScope.Controls.Add(Me.Label5)
        Me.GroupScope.Controls.Add(Me.lbCampus)
        Me.GroupScope.Location = New System.Drawing.Point(12, 29)
        Me.GroupScope.Name = "GroupScope"
        Me.GroupScope.Size = New System.Drawing.Size(693, 141)
        Me.GroupScope.TabIndex = 27
        Me.GroupScope.TabStop = False
        Me.GroupScope.Text = "Scope:"
        '
        'btnPopCampus
        '
        Me.btnPopCampus.Location = New System.Drawing.Point(88, 102)
        Me.btnPopCampus.Name = "btnPopCampus"
        Me.btnPopCampus.Size = New System.Drawing.Size(141, 23)
        Me.btnPopCampus.TabIndex = 26
        Me.btnPopCampus.Text = "Load Campuses"
        Me.btnPopCampus.UseVisualStyleBackColor = True
        '
        'GroupFeatures
        '
        Me.GroupFeatures.Controls.Add(Me.chckActivatePrinters)
        Me.GroupFeatures.Controls.Add(Me.PanelSearch)
        Me.GroupFeatures.Controls.Add(Me.chckActivateFloor)
        Me.GroupFeatures.Controls.Add(Me.chckActivateProjector)
        Me.GroupFeatures.Controls.Add(Me.chckActivateMonitors)
        Me.GroupFeatures.Controls.Add(Me.chckActivateComputers)
        Me.GroupFeatures.Controls.Add(Me.chckActivateCapacity)
        Me.GroupFeatures.Controls.Add(Me.Label16)
        Me.GroupFeatures.Controls.Add(Me.Label15)
        Me.GroupFeatures.Controls.Add(Me.Label14)
        Me.GroupFeatures.Controls.Add(Me.chckRaisedFloor)
        Me.GroupFeatures.Controls.Add(Me.chckProjector)
        Me.GroupFeatures.Controls.Add(Me.chckDual)
        Me.GroupFeatures.Controls.Add(Me.chckComputers)
        Me.GroupFeatures.Controls.Add(Me.btnSearch)
        Me.GroupFeatures.Controls.Add(Me.Label4)
        Me.GroupFeatures.Controls.Add(Me.txtCapacity)
        Me.GroupFeatures.Controls.Add(Me.Label1)
        Me.GroupFeatures.Location = New System.Drawing.Point(711, 33)
        Me.GroupFeatures.Name = "GroupFeatures"
        Me.GroupFeatures.Size = New System.Drawing.Size(238, 332)
        Me.GroupFeatures.TabIndex = 28
        Me.GroupFeatures.TabStop = False
        Me.GroupFeatures.Text = "Room Features:"
        '
        'chckActivatePrinters
        '
        Me.chckActivatePrinters.AutoSize = True
        Me.chckActivatePrinters.Location = New System.Drawing.Point(24, 171)
        Me.chckActivatePrinters.Name = "chckActivatePrinters"
        Me.chckActivatePrinters.Size = New System.Drawing.Size(15, 14)
        Me.chckActivatePrinters.TabIndex = 40
        Me.chckActivatePrinters.UseVisualStyleBackColor = True
        '
        'chckActivateFloor
        '
        Me.chckActivateFloor.AutoSize = True
        Me.chckActivateFloor.Location = New System.Drawing.Point(24, 146)
        Me.chckActivateFloor.Name = "chckActivateFloor"
        Me.chckActivateFloor.Size = New System.Drawing.Size(15, 14)
        Me.chckActivateFloor.TabIndex = 39
        Me.chckActivateFloor.UseVisualStyleBackColor = True
        '
        'chckActivateProjector
        '
        Me.chckActivateProjector.AutoSize = True
        Me.chckActivateProjector.Location = New System.Drawing.Point(24, 120)
        Me.chckActivateProjector.Name = "chckActivateProjector"
        Me.chckActivateProjector.Size = New System.Drawing.Size(15, 14)
        Me.chckActivateProjector.TabIndex = 38
        Me.chckActivateProjector.UseVisualStyleBackColor = True
        '
        'chckActivateMonitors
        '
        Me.chckActivateMonitors.AutoSize = True
        Me.chckActivateMonitors.Location = New System.Drawing.Point(24, 90)
        Me.chckActivateMonitors.Name = "chckActivateMonitors"
        Me.chckActivateMonitors.Size = New System.Drawing.Size(15, 14)
        Me.chckActivateMonitors.TabIndex = 37
        Me.chckActivateMonitors.UseVisualStyleBackColor = True
        '
        'chckActivateComputers
        '
        Me.chckActivateComputers.AutoSize = True
        Me.chckActivateComputers.Location = New System.Drawing.Point(24, 60)
        Me.chckActivateComputers.Name = "chckActivateComputers"
        Me.chckActivateComputers.Size = New System.Drawing.Size(15, 14)
        Me.chckActivateComputers.TabIndex = 36
        Me.chckActivateComputers.UseVisualStyleBackColor = True
        '
        'chckActivateCapacity
        '
        Me.chckActivateCapacity.AutoSize = True
        Me.chckActivateCapacity.Location = New System.Drawing.Point(24, 25)
        Me.chckActivateCapacity.Name = "chckActivateCapacity"
        Me.chckActivateCapacity.Size = New System.Drawing.Size(15, 14)
        Me.chckActivateCapacity.TabIndex = 35
        Me.chckActivateCapacity.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 19)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Raised Floor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(88, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 19)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Projector"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(48, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 19)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Dual Monitors"
        '
        'chckRaisedFloor
        '
        Me.chckRaisedFloor.AutoSize = True
        Me.chckRaisedFloor.Enabled = False
        Me.chckRaisedFloor.Location = New System.Drawing.Point(201, 151)
        Me.chckRaisedFloor.Name = "chckRaisedFloor"
        Me.chckRaisedFloor.Size = New System.Drawing.Size(15, 14)
        Me.chckRaisedFloor.TabIndex = 31
        Me.chckRaisedFloor.UseVisualStyleBackColor = True
        '
        'chckProjector
        '
        Me.chckProjector.AutoSize = True
        Me.chckProjector.Enabled = False
        Me.chckProjector.Location = New System.Drawing.Point(201, 120)
        Me.chckProjector.Name = "chckProjector"
        Me.chckProjector.Size = New System.Drawing.Size(15, 14)
        Me.chckProjector.TabIndex = 30
        Me.chckProjector.UseVisualStyleBackColor = True
        '
        'chckDual
        '
        Me.chckDual.AutoSize = True
        Me.chckDual.Enabled = False
        Me.chckDual.Location = New System.Drawing.Point(201, 90)
        Me.chckDual.Name = "chckDual"
        Me.chckDual.Size = New System.Drawing.Size(15, 14)
        Me.chckDual.TabIndex = 29
        Me.chckDual.UseVisualStyleBackColor = True
        '
        'chckComputers
        '
        Me.chckComputers.AutoSize = True
        Me.chckComputers.Enabled = False
        Me.chckComputers.Location = New System.Drawing.Point(201, 60)
        Me.chckComputers.Name = "chckComputers"
        Me.chckComputers.Size = New System.Drawing.Size(15, 14)
        Me.chckComputers.TabIndex = 28
        Me.chckComputers.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(157, 303)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Has Computers"
        '
        'txtCapacity
        '
        Me.txtCapacity.Enabled = False
        Me.txtCapacity.Location = New System.Drawing.Point(180, 22)
        Me.txtCapacity.MaxLength = 3
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(43, 26)
        Me.txtCapacity.TabIndex = 24
        Me.txtCapacity.Text = "30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Seat Capacity"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 367)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(859, 185)
        Me.DataGridView1.TabIndex = 29
        Me.DataGridView1.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(31, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Course"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Start Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "End Time"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(100, 180)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 23)
        Me.ComboBox1.TabIndex = 46
        '
        'dtpStart
        '
        Me.dtpStart.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(102, 211)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(202, 23)
        Me.dtpStart.TabIndex = 48
        Me.dtpStart.Value = New Date(2019, 8, 29, 8, 0, 0, 0)
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(102, 243)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(202, 23)
        Me.dtpEnd.TabIndex = 49
        Me.dtpEnd.Value = New Date(2019, 8, 29, 9, 55, 0, 0)
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(25, 306)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(0, 24)
        Me.lblRoom.TabIndex = 50
        '
        'btnAddTime
        '
        Me.btnAddTime.Location = New System.Drawing.Point(12, 272)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.Size = New System.Drawing.Size(106, 23)
        Me.btnAddTime.TabIndex = 51
        Me.btnAddTime.Text = "Add Time"
        Me.btnAddTime.UseVisualStyleBackColor = True
        '
        'btnUpdateTime
        '
        Me.btnUpdateTime.Location = New System.Drawing.Point(124, 272)
        Me.btnUpdateTime.Name = "btnUpdateTime"
        Me.btnUpdateTime.Size = New System.Drawing.Size(124, 23)
        Me.btnUpdateTime.TabIndex = 52
        Me.btnUpdateTime.Text = "Update Time"
        Me.btnUpdateTime.UseVisualStyleBackColor = True
        '
        'btnDeleteTime
        '
        Me.btnDeleteTime.Location = New System.Drawing.Point(254, 272)
        Me.btnDeleteTime.Name = "btnDeleteTime"
        Me.btnDeleteTime.Size = New System.Drawing.Size(113, 23)
        Me.btnDeleteTime.TabIndex = 53
        Me.btnDeleteTime.Text = "Delete Time"
        Me.btnDeleteTime.UseVisualStyleBackColor = True
        '
        'addRange
        '
        Me.addRange.Enabled = False
        Me.addRange.Location = New System.Drawing.Point(538, 271)
        Me.addRange.Name = "addRange"
        Me.addRange.Size = New System.Drawing.Size(106, 23)
        Me.addRange.TabIndex = 54
        Me.addRange.Text = "Add Range"
        Me.TTSched.SetToolTip(Me.addRange, "Creates entries between the dates entered in Start Time and Semester End." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uses t" &
        "he Meeting Days field to determine how many entries to make.")
        Me.addRange.UseVisualStyleBackColor = True
        '
        'endSemester
        '
        Me.endSemester.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endSemester.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endSemester.Location = New System.Drawing.Point(442, 211)
        Me.endSemester.Name = "endSemester"
        Me.endSemester.Size = New System.Drawing.Size(202, 23)
        Me.endSemester.TabIndex = 49
        Me.endSemester.Value = New Date(2019, 12, 18, 9, 55, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(322, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Semester End"
        '
        'cbMeeting
        '
        Me.cbMeeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeeting.FormattingEnabled = True
        Me.cbMeeting.Items.AddRange(New Object() {"Ounce Per Week", "MW/TH", "MWF"})
        Me.cbMeeting.Location = New System.Drawing.Point(486, 240)
        Me.cbMeeting.Name = "cbMeeting"
        Me.cbMeeting.Size = New System.Drawing.Size(158, 25)
        Me.cbMeeting.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(365, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 19)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Meeting Days"
        '
        'rdoColPri
        '
        Me.rdoColPri.AutoSize = True
        Me.rdoColPri.Checked = True
        Me.rdoColPri.Location = New System.Drawing.Point(162, 21)
        Me.rdoColPri.Name = "rdoColPri"
        Me.rdoColPri.Size = New System.Drawing.Size(14, 13)
        Me.rdoColPri.TabIndex = 32
        Me.rdoColPri.TabStop = True
        Me.rdoColPri.UseVisualStyleBackColor = True
        '
        'rdoGrayPri
        '
        Me.rdoGrayPri.AutoSize = True
        Me.rdoGrayPri.Location = New System.Drawing.Point(162, 50)
        Me.rdoGrayPri.Name = "rdoGrayPri"
        Me.rdoGrayPri.Size = New System.Drawing.Size(14, 13)
        Me.rdoGrayPri.TabIndex = 33
        Me.rdoGrayPri.UseVisualStyleBackColor = True
        '
        'rdoSharedPri
        '
        Me.rdoSharedPri.AutoSize = True
        Me.rdoSharedPri.Location = New System.Drawing.Point(162, 77)
        Me.rdoSharedPri.Name = "rdoSharedPri"
        Me.rdoSharedPri.Size = New System.Drawing.Size(14, 13)
        Me.rdoSharedPri.TabIndex = 34
        Me.rdoSharedPri.UseVisualStyleBackColor = True
        '
        'gbPrinters
        '
        Me.gbPrinters.Controls.Add(Me.Label17)
        Me.gbPrinters.Controls.Add(Me.rdoNoPri)
        Me.gbPrinters.Controls.Add(Me.Label13)
        Me.gbPrinters.Controls.Add(Me.Label12)
        Me.gbPrinters.Controls.Add(Me.Label9)
        Me.gbPrinters.Controls.Add(Me.rdoSharedPri)
        Me.gbPrinters.Controls.Add(Me.rdoColPri)
        Me.gbPrinters.Controls.Add(Me.rdoGrayPri)
        Me.gbPrinters.Enabled = False
        Me.gbPrinters.Location = New System.Drawing.Point(763, 200)
        Me.gbPrinters.Name = "gbPrinters"
        Me.gbPrinters.Size = New System.Drawing.Size(186, 126)
        Me.gbPrinters.TabIndex = 35
        Me.gbPrinters.TabStop = False
        Me.gbPrinters.Text = "Printer:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(107, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 19)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "None"
        '
        'rdoNoPri
        '
        Me.rdoNoPri.AutoSize = True
        Me.rdoNoPri.Location = New System.Drawing.Point(162, 106)
        Me.rdoNoPri.Name = "rdoNoPri"
        Me.rdoNoPri.Size = New System.Drawing.Size(14, 13)
        Me.rdoNoPri.TabIndex = 61
        Me.rdoNoPri.TabStop = True
        Me.rdoNoPri.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 19)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Shared Hallway"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 19)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Black and White"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Color"
        '
        'PanelPrinters
        '
        Me.PanelPrinters.Location = New System.Drawing.Point(717, 204)
        Me.PanelPrinters.Name = "PanelPrinters"
        Me.PanelPrinters.Size = New System.Drawing.Size(232, 157)
        Me.PanelPrinters.TabIndex = 61
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(342, 183)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(76, 23)
        Me.btnRefresh.TabIndex = 58
        Me.btnRefresh.Text = "Refresh"
        Me.TTSched.SetToolTip(Me.btnRefresh, "Click this if you added new courses.")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PanelEditTimes
        '
        Me.PanelEditTimes.Location = New System.Drawing.Point(12, 175)
        Me.PanelEditTimes.Name = "PanelEditTimes"
        Me.PanelEditTimes.Size = New System.Drawing.Size(683, 180)
        Me.PanelEditTimes.TabIndex = 59
        '
        'PanelScope
        '
        Me.PanelScope.Controls.Add(Me.lblSelectADB)
        Me.PanelScope.Location = New System.Drawing.Point(12, 33)
        Me.PanelScope.Name = "PanelScope"
        Me.PanelScope.Size = New System.Drawing.Size(693, 137)
        Me.PanelScope.TabIndex = 60
        '
        'lblSelectADB
        '
        Me.lblSelectADB.AutoSize = True
        Me.lblSelectADB.Location = New System.Drawing.Point(32, 18)
        Me.lblSelectADB.Name = "lblSelectADB"
        Me.lblSelectADB.Size = New System.Drawing.Size(372, 38)
        Me.lblSelectADB.TabIndex = 0
        Me.lblSelectADB.Text = "Welcome to the Educational Resource Scheduler!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please Select a Database in 'Prog" &
    "ram -> Settings'"
        '
        'PanelSearch
        '
        Me.PanelSearch.Location = New System.Drawing.Point(0, 0)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(238, 332)
        Me.PanelSearch.TabIndex = 61
        '
        'scheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 762)
        Me.Controls.Add(Me.PanelPrinters)
        Me.Controls.Add(Me.PanelScope)
        Me.Controls.Add(Me.PanelEditTimes)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbMeeting)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.addRange)
        Me.Controls.Add(Me.btnDeleteTime)
        Me.Controls.Add(Me.btnUpdateTime)
        Me.Controls.Add(Me.btnAddTime)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.endSemester)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupScope)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbPrinters)
        Me.Controls.Add(Me.GroupFeatures)
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 800)
        Me.Name = "scheduler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Educational Resource Scheduler"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupScope.ResumeLayout(False)
        Me.GroupScope.PerformLayout()
        Me.GroupFeatures.ResumeLayout(False)
        Me.GroupFeatures.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPrinters.ResumeLayout(False)
        Me.gbPrinters.PerformLayout()
        Me.PanelScope.ResumeLayout(False)
        Me.PanelScope.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Public WithEvents lbRooms As ListBox
    Friend WithEvents lbBuilding As ListBox
    Friend WithEvents lbCampus As ListBox
    Public WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupScope As GroupBox
    Friend WithEvents GroupFeatures As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AuthorsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnPopCampus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblRoom As Label
    Friend WithEvents btnAddTime As Button
    Friend WithEvents btnUpdateTime As Button
    Friend WithEvents btnDeleteTime As Button
    Friend WithEvents addRange As Button
    Friend WithEvents endSemester As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbMeeting As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents chckComputers As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents chckRaisedFloor As CheckBox
    Friend WithEvents chckProjector As CheckBox
    Friend WithEvents chckDual As CheckBox
    Friend WithEvents rdoColPri As RadioButton
    Friend WithEvents rdoGrayPri As RadioButton
    Friend WithEvents rdoSharedPri As RadioButton
    Friend WithEvents gbPrinters As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rdoNoPri As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PanelEditTimes As Panel
    Friend WithEvents TTSched As ToolTip
    Friend WithEvents PanelScope As Panel
    Friend WithEvents lblSelectADB As Label
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents PanelPrinters As Panel
    Friend WithEvents chckActivatePrinters As CheckBox
    Friend WithEvents chckActivateFloor As CheckBox
    Friend WithEvents chckActivateProjector As CheckBox
    Friend WithEvents chckActivateMonitors As CheckBox
    Friend WithEvents chckActivateComputers As CheckBox
    Friend WithEvents chckActivateCapacity As CheckBox
End Class
