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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip1.SuspendLayout()
        Me.GroupScope.SuspendLayout()
        Me.GroupFeatures.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Help File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthorsToolStripMenuItem1})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
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
        Me.GroupFeatures.Controls.Add(Me.TextBox1)
        Me.GroupFeatures.Controls.Add(Me.Label4)
        Me.GroupFeatures.Controls.Add(Me.txtCapacity)
        Me.GroupFeatures.Controls.Add(Me.Label1)
        Me.GroupFeatures.Location = New System.Drawing.Point(711, 29)
        Me.GroupFeatures.Name = "GroupFeatures"
        Me.GroupFeatures.Size = New System.Drawing.Size(193, 141)
        Me.GroupFeatures.TabIndex = 28
        Me.GroupFeatures.TabStop = False
        Me.GroupFeatures.Text = "Room Features:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 59)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(44, 26)
        Me.TextBox1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "# of Computers"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(141, 22)
        Me.txtCapacity.MaxLength = 3
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(43, 26)
        Me.txtCapacity.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
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
        Me.DataGridView1.Location = New System.Drawing.Point(29, 343)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(859, 185)
        Me.DataGridView1.TabIndex = 29
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
        Me.dtpStart.Value = New Date(2017, 8, 29, 8, 0, 0, 0)
        '
        'dtpEnd
        '
        Me.dtpEnd.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(102, 243)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(202, 23)
        Me.dtpEnd.TabIndex = 49
        Me.dtpEnd.Value = New Date(2017, 8, 29, 9, 55, 0, 0)
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
        Me.addRange.Location = New System.Drawing.Point(660, 282)
        Me.addRange.Name = "addRange"
        Me.addRange.Size = New System.Drawing.Size(106, 23)
        Me.addRange.TabIndex = 54
        Me.addRange.Text = "Add Range"
        Me.addRange.UseVisualStyleBackColor = True
        '
        'endSemester
        '
        Me.endSemester.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endSemester.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endSemester.Location = New System.Drawing.Point(564, 222)
        Me.endSemester.Name = "endSemester"
        Me.endSemester.Size = New System.Drawing.Size(202, 23)
        Me.endSemester.TabIndex = 49
        Me.endSemester.Value = New Date(2017, 12, 18, 9, 55, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(444, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Semester End"
        '
        'cbMeeting
        '
        Me.cbMeeting.FormattingEnabled = True
        Me.cbMeeting.Items.AddRange(New Object() {"Ounce Per Week", "MW/TH", "MWF"})
        Me.cbMeeting.Location = New System.Drawing.Point(608, 251)
        Me.cbMeeting.Name = "cbMeeting"
        Me.cbMeeting.Size = New System.Drawing.Size(158, 25)
        Me.cbMeeting.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(487, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 19)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Meeting Days"
        '
        'scheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 762)
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
        Me.Controls.Add(Me.GroupFeatures)
        Me.Controls.Add(Me.GroupScope)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 800)
        Me.Name = "scheduler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Educational Resource Scheduler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupScope.ResumeLayout(False)
        Me.GroupScope.PerformLayout()
        Me.GroupFeatures.ResumeLayout(False)
        Me.GroupFeatures.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
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
End Class
