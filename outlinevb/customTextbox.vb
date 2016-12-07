Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Public Class customTextbox2
    Inherits TextBox 'must be after declaration, only inherit 1 thing
    Private oldFont As Font = Nothing
    Private watermarkTextEndabled As Boolean = False
    Private _watermarkColor As Color = Color.Gray
    Private _watermarkText As String = "Watermark"
    Private lblHighlight As Label = New Label

#Region "Properties"
    Public Property watermarkColor() As Color
        Get
            Return _watermarkColor
        End Get
        Set(value As Color)
            _watermarkColor = value
        End Set
    End Property

    Public Property watermarkText() As String
        Get
            Return _watermarkText
        End Get
        Set(value As String)
            _watermarkText = value
        End Set
    End Property

    Private m_selectedBackColor As Color
    <Category("Custom"), Description("Sets or gets the background color when control is active")>
    Public Property SelectedBackColor() As Color
        Get
            Return m_selectedBackColor
        End Get
        Set(value As Color)
            m_selectedBackColor = value
        End Set
    End Property
    Private m_HighLightColor As Color
    <Category("Custom"), Description("Set or get color for highlight")>
    Public Property HighLightColor() As Color
        Get
            Return m_HighLightColor
        End Get
        Set(value As Color)
            m_HighLightColor = value
        End Set
    End Property

    Private m_DefaultText As String = String.Empty
    <Category("Custom"), Description("Set or get Default Text")>
    Public Property DefaultText() As String
        Get
            Return m_DefaultText
        End Get
        Set(value As String)
            m_DefaultText = value
        End Set
    End Property

    Private m_DefaultTextColor As Color
    <Category("Custom"), Description("Set or get default text color")>
    Public Property DefaultTextCOlor() As Color
        Get
            Return m_DefaultTextColor
        End Get
        Set(value As Color)
            m_DefaultTextColor = value
        End Set
    End Property

    Private m_highlight As Boolean
    <Category("Custom"), Description("Turn highlights on or off")>
    Public Property HighLight As Boolean
        Get
            Return m_highlight
        End Get
        Set(value As Boolean)
            m_highlight = value
        End Set
    End Property

#End Region

#Region "Event Handlers"
    Private Sub watermark_Toggle(sender As Object, args As EventArgs)
        If Me.Text.Length <= 0 Then
            enableWatermark()
        Else
            disableWatermark()
        End If
    End Sub
    Private Sub enableWatermark()
        oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.watermarkTextEndabled = True
        Refresh()
    End Sub
    Private Sub disableWatermark()
        Me.watermarkTextEndabled = False
        Me.SetStyle(ControlStyles.UserPaint, False)
        If Not oldFont Is Nothing Then
            Me.Font = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        End If
    End Sub
    Private Sub watermark_FontChanged(sender As Object, args As EventArgs)
        If watermarkTextEndabled Then
            oldFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        End If
    End Sub
#End Region
    Private Sub JoinEvents(join As Boolean)
        If join Then
            AddHandler(TextChanged), AddressOf watermark_Toggle
            AddHandler(LostFocus), AddressOf watermark_Toggle
            AddHandler(FontChanged), AddressOf watermark_FontChanged
            AddHandler(Leave), AddressOf textbox_Leave
            AddHandler(Enter), AddressOf textbox_Enter
            AddHandler(TextChanged), AddressOf textbox_TextChanged
            AddHandler(Validated), AddressOf textbox_Validated
            AddHandler(KeyPress), AddressOf textbox_KeyPress
        End If
    End Sub

    Private Sub textbox_Enter(sender As Object, e As EventArgs)
        If Me.m_highlight Then
            Dim rc = New Rectangle(Me.Left - 2, Me.Top - 2, Me.Width + 4, Me.Bottom - Me.Top + 4)
            Me.Parent.Controls.Add(Me.lblHighlight)
            lblHighlight.Bounds = rc
            lblHighlight.BackColor = Me.m_HighLightColor
        End If
        If Me.Text.Trim() = Me.DefaultText Then
            Me.Text = ""
        End If
        If SelectedBackColor <> SystemColors.Window Then
            Me.BackColor = SelectedBackColor
        End If
    End Sub

    Private Sub textbox_Leave(sender As Object, e As EventArgs)
        Me.Parent.Controls.Remove(lblHighlight)
        Me.BackColor = SystemColors.Window
        If Trim(Me.Text) <> "" Then
            Select Case textBoxType
                Case textBoxTypes.LowerCase
                    Me.Text = Me.Text.ToLower
                Case textBoxTypes.UpperCase
                    Me.Text = Me.Text.ToUpper
            End Select
        End If
    End Sub

    Private Sub textbox_TextChanged(sender As Object, e As EventArgs)
        If Me.Text.Trim() <> Me.DefaultText.Trim() Then
            Me.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub textbox_Validated(sender As Object, e As EventArgs)
        If Me.Text.Trim() <> Me.DefaultText And Me.Text.Trim <> "" Then
            Me.ForeColor = DefaultForeColor
        End If
        If Me.Text.Trim() = "" Then
            Me.Text = Me.DefaultText
            Me.ForeColor = Me.DefaultTextCOlor
        End If
    End Sub

    Private Sub textbox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case textBoxType
            Case textBoxTypes.Normal
                Return
            Case textBoxTypes.NumbersOnly
                If e.KeyChar < "0" Or e.KeyChar > "9" Then
                    e.Handled = True
                End If
            Case textBoxTypes.AlphaOnly
                If (e.KeyChar < "a" Or e.KeyChar > "z") And (e.KeyChar < "A" Or e.KeyChar > "Z") Then
                    e.Handled = True
                End If
            Case textBoxTypes.AlphaNumeric
                If (e.KeyChar < "a" Or e.KeyChar > "z") And (e.KeyChar < "A" Or e.KeyChar > "Z") And (e.KeyChar < "0" Or e.KeyChar > "9") Then
                    e.Handled = True
                End If
            Case textBoxTypes.NoSpaces 'Also check on textbox_TextChanged to stop pasting 
                If e.KeyChar = ChrW(Keys.Space) Then
                    e.Handled = True
                End If
        End Select
    End Sub

    Public Sub New()
        JoinEvents(True)
        Me.ForeColor = Color.Silver
        Me.HighLightColor = Color.Red
        HighLight = True
        DefaultTextCOlor = Color.Silver
        SelectedBackColor = Color.FromArgb(255, 255, 255, 192)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim drawFont As Font = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        Dim drawBrush As SolidBrush = New SolidBrush(Me.watermarkColor)
        e.Graphics.DrawString(IIf(watermarkTextEndabled, watermarkText, Text).ToString(), drawFont, drawBrush, New Point(0, 0))
        MyBase.OnPaint(e)
    End Sub
    Enum textBoxTypes
        Normal = 0
        NumbersOnly = 1
        UpperCase = 2
        LowerCase = 3
        AlphaOnly = 4
        AlphaNumeric = 5
        NoSpaces = 6
    End Enum
    Private _textBoxType As textBoxTypes
    <Category("Custom"), Description("Set or get default textbox type")>
    <DefaultValue(textBoxTypes.Normal)>
    Public Property textBoxType() As textBoxTypes
        Get
            Return _textBoxType
        End Get
        Set(value As textBoxTypes)
            _textBoxType = value
        End Set
    End Property
End Class
