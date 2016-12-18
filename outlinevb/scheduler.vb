Imports System.IO ' Test﻿


Imports System
Imports Microsoft.VisualBasic.Interaction ' ?
Imports System.ComponentModel

' ObjectDumper.ObjectDumperExtensions.DumpToString(strColumnName, "strColumnName") ' https://objectdumper.codeplex.com/ | https://www.nuget.org/packages/ObjectDumper/

Public Class scheduler

    Private Sub scheduler_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ' On resize, peg some form elements to static positions

        ' DataGridView1
        DataGridView1.Left = 10
        DataGridView1.Width = Me.Width - 40 ' 10 margin on left and 40 on the right, that seems to center it. Margins on left/right are not even ??
        '   Height
        DataGridView1.Height = CInt((Me.Height * 0.5)) ' 200 for the controls, 50 for extra footer room. Leave room for the controls on top. Adjust in future for additional controls OR use a function to read all them controls height and plug into here.
        ' GroupBoxes


    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        closeShop()

    End Sub


    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        frmSettings.ShowDialog(Me)

    End Sub



    Private Sub scheduler_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        closeShop()

    End Sub

    Sub closeShop()

        ' Save settings
        My.Settings.Save()

        ' Exit program
        Application.Exit()

    End Sub

    Private Sub scheduler_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqlString As String = My.Settings.comboCourses.ToString()
        Dim value As String = "courseID"
        Dim display As String = "corn"
        displayItemsInComboBox(Me.ComboBox1, sqlString, value, display) 'does not load on first run
        dtpStart.CustomFormat = "MM/dd/yyyy h:mm tt "
        dtpEnd.CustomFormat = "MM/dd/yyyy h:mm tt "
        endSemester.CustomFormat = "MM/dd/yyyy h:mm tt "

        If My.Settings.CurrentDB.ToString() <> "" Then
            PanelPrinters.Visible = False
            PanelSearch.Visible = False
            PanelScope.Visible = False
            lblSelectADB.Visible = False
        End If
        ' Do we have to login ?

        ' Check security level of user


        ' Call the refresh sub to update the GUI data. Like the ListBoxes in changing the Selected Database.
        ' reloadSchedulerGUI()

    End Sub

    Private Sub btnPopCampus_Click(sender As Object, e As EventArgs) Handles btnPopCampus.Click
        Dim sqlString As String = My.Settings.listCampuses.ToString()
        Dim value As String = "campusID"
        Dim display As String = "campusName"
        displayItemsListBox(Me.lbCampus, sqlString, value, display)

    End Sub
    ' Private Sub lbCampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCampus.SelectedIndexChanged
    '    Dim campus = lbCampus.SelectedValue.ToString()


    '    listBuildingsInListBox(Me.lbBuilding, campus)
    'End Sub

    'Private Sub lbBuilding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBuilding.SelectedIndexChanged
    '    Dim building = lbBuilding.SelectedValue.ToString()

    '    listRoomsInListBox(Me.lbRooms, building)
    'End Sub

    Private Sub lbCampus_Click(sender As Object, e As EventArgs) Handles lbCampus.Click
        If lbCampus.Items.Count() > 0 Then
            Dim campus = lbCampus.SelectedValue.ToString()
            Dim sqlString As String = My.Settings.listBuildings.ToString()
            Dim value As String = "dbBuildingID"
            Dim display As String = "buildingName"
            displayItemsListBox(Me.lbBuilding, sqlString, value, display, campus)
        End If

    End Sub

    Private Sub lbBuilding_Click(sender As Object, e As EventArgs) Handles lbBuilding.Click
        If lbBuilding.Items.Count() > 0 Then
            Dim building = lbBuilding.SelectedValue.ToString()
            Dim sqlString As String = My.Settings.listRooms.ToString()
            Dim value As String = "dbRoomID"
            Dim display As String = "roomNum"
            displayItemsListBox(Me.lbRooms, sqlString, value, display, building)
        End If
    End Sub

    Private Sub lbRooms_Click(sender As Object, e As EventArgs) Handles lbRooms.Click
        If lbRooms.Items.Count() > 0 Then
            Dim room = lbRooms.SelectedValue.ToString()
            Dim sqlString As String = My.Settings.selectDTB.ToString()
            displayDGV(DataGridView1, sqlString, room)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            lblRoom.Text = lbCampus.Text + ": " + lbBuilding.Text + lbRooms.Text
        End If
    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click
        If lbRooms.SelectedIndex >= 0 Then
            If ComboBox1.SelectedIndex >= 0 Then
                Dim sqlStringAdd = My.Settings.addDTB.ToString()
                Dim room = lbRooms.SelectedValue.ToString()
                Dim course = ComboBox1.SelectedValue.ToString()
                Dim startTime = dtpStart.Value
                Dim endTime = dtpEnd.Value
                addToTable(sqlStringAdd, room, course, , , startTime, endTime)

                Dim sqlStringDisplay As String = My.Settings.selectDTB.ToString()
                displayDGV(DataGridView1, sqlStringDisplay, room)
            End If
        End If




    End Sub

    Private Sub btnUpdateTime_Click(sender As Object, e As EventArgs) Handles btnUpdateTime.Click
        If lbRooms.SelectedIndex >= 0 Then
            If ComboBox1.SelectedIndex >= 0 Then
                Dim sqlStringUpdate As String = My.Settings.updateDTB.ToString()
                Dim selected = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                Dim room = lbRooms.SelectedValue.ToString()
                Dim course = ComboBox1.SelectedValue.ToString()
                Dim startTime = dtpStart.Text.ToString()
                Dim endTime = dtpEnd.Text.ToString()
                updateTable(sqlStringUpdate, selected, room, course, startTime, endTime)

                Dim sqlStringDisplay As String = My.Settings.selectDTB.ToString()
                displayDGV(DataGridView1, sqlStringDisplay, room)
            End If
        End If
    End Sub

    Private Sub btnDeleteTime_Click(sender As Object, e As EventArgs) Handles btnDeleteTime.Click
        If lbRooms.SelectedIndex >= 0 Then
            If ComboBox1.SelectedIndex >= 0 Then
                Dim room = lbRooms.SelectedValue.ToString()
                Dim sqlStringDelete As String = My.Settings.deleteDTB.ToString()
                Dim selected = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                deleteFromTable(sqlStringDelete, selected)

                Dim sqlStringDisplay As String = My.Settings.selectDTB.ToString()
                displayDGV(DataGridView1, sqlStringDisplay, room)
            End If
        End If
    End Sub

    Private Sub addRange_Click(sender As Object, e As EventArgs) Handles addRange.Click
        If lbRooms.SelectedIndex >= 0 Then
            If DataGridView1.DataSource IsNot Nothing Then
                If cbMeeting.SelectedIndex >= 0 Then
                    Dim endRange As DateTime = endSemester.Value
                    Dim currentClassStart As DateTime = dtpStart.Value
                    Dim currentClassEnd As DateTime = dtpEnd.Value

                    Dim first As Boolean = True
                    Dim day As Integer = 0
                    While (currentClassEnd <= endRange)

                        'add 2 per week, 2 days and 5 days apart
                        If lbRooms.SelectedIndex >= 0 Then
                            If ComboBox1.SelectedIndex >= 0 Then
                                Dim sqlStringAdd = My.Settings.addDTB.ToString()
                                Dim room = lbRooms.SelectedValue.ToString()
                                Dim course = ComboBox1.SelectedValue.ToString()
                                Dim startTime = currentClassStart
                                Dim endTime = currentClassEnd
                                addToTable(sqlStringAdd, room, course, , , startTime, endTime)

                                Dim sqlStringDisplay As String = My.Settings.selectDTB.ToString()
                                displayDGV(DataGridView1, sqlStringDisplay, room)
                            End If
                        End If

                        If cbMeeting.SelectedIndex = 1 Then
                            If first = True Then
                                currentClassStart = currentClassStart.AddDays(2)
                                currentClassEnd = currentClassEnd.AddDays(2)
                                first = False
                            ElseIf first = False Then
                                currentClassStart = currentClassStart.AddDays(5)
                                currentClassEnd = currentClassEnd.AddDays(5)
                                first = True
                            End If
                        End If

                        If cbMeeting.SelectedIndex = 0 Then
                            currentClassStart = currentClassStart.AddDays(7)
                            currentClassEnd = currentClassEnd.AddDays(7)
                        End If


                        If cbMeeting.SelectedIndex = 2 Then
                            If day < 2 Then
                                currentClassStart = currentClassStart.AddDays(2)
                                currentClassEnd = currentClassEnd.AddDays(2)
                                day += 1
                            ElseIf day = 2 Then
                                currentClassStart = currentClassStart.AddDays(3)
                                currentClassEnd = currentClassEnd.AddDays(3)
                                day = 0
                            End If



                        End If
                    End While
                End If

            End If
        End If





    End Sub

    Function searchEnabled() As Boolean
        If chckActivateCapacity.Checked = True Or chckActivateComputers.Checked = True Or chckActivateMonitors.Checked = True Or chckActivatePrinters.Checked = True Or chckActivateFloor.Checked = True Or chckActivateProjector.Checked = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lbRooms.DataSource = Nothing
        If searchEnabled() Then
            lbRooms.DataSource = Nothing
            lbBuilding.DataSource = Nothing
            lbCampus.DataSource = Nothing
            DataGridView1.DataSource = Nothing
            Dim sqlString As String = My.Settings.searchByFeature.ToString()
            Dim value As String = "dbRoomID"
            Dim display As String = "fullRName"
            Dim capacity As Integer

            If txtCapacity.Enabled = True Then
                If IsNumeric(txtCapacity.Text) Then
                    capacity = CInt(txtCapacity.Text)
                Else
                    capacity = 30
                    MessageBox.Show("Valid capacity was not entered, defaulting to 30. Please enter integer values only")
                End If
            End If

            Dim computers As Boolean
            Dim dualMonitors As Boolean
            Dim projector As Boolean
            Dim raisedFloors As Boolean
            Dim colorPrinter As Boolean
            Dim grayPrinter As Boolean
            Dim sharedPrinter As Boolean

            If chckComputers.Checked And chckComputers.Enabled = True Then
                computers = True
            Else
                computers = False
            End If

            If chckDual.Checked And chckDual.Enabled = True Then
                dualMonitors = True
            Else
                dualMonitors = False
            End If

            If chckProjector.Checked And chckProjector.Enabled = True Then
                projector = True
            Else
                projector = False
            End If

            If chckRaisedFloor.Checked And chckRaisedFloor.Enabled = True Then
                raisedFloors = True
            Else
                raisedFloors = False
            End If

            If rdoColPri.Checked And gbPrinters.Enabled = True Then
                colorPrinter = True
            Else
                colorPrinter = False
            End If

            If rdoGrayPri.Checked And gbPrinters.Enabled = True Then
                grayPrinter = True
            Else
                grayPrinter = False
            End If

            If rdoSharedPri.Checked And gbPrinters.Enabled = True Then
                sharedPrinter = True
            Else
                sharedPrinter = False
            End If

            lblRoom.Text = ""

            sqlString = sqlString.Substring(0, sqlString.Length - 4)

            displayItemsListBox(Me.lbRooms, sqlString, value, display, "", capacity, computers, dualMonitors, projector, raisedFloors, colorPrinter, grayPrinter, sharedPrinter)
            If DataGridView1.DataSource Is Nothing Then
                PanelEditTimes.Visible = True
            End If
        Else
            MessageBox.Show("Search not completed, no fields selected.")
        End If




    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim sqlString As String = My.Settings.comboCourses.ToString()
        Dim value As String = "courseID"
        Dim display As String = "corn"
        displayItemsInComboBox(Me.ComboBox1, sqlString, value, display)
    End Sub

    Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRooms.SelectedIndexChanged
        If lbRooms.SelectedIndex >= 0 Then
            DataGridView1.Visible = True
            If DataGridView1.DataSource IsNot Nothing Then
                PanelEditTimes.Visible = False
            End If
        End If
    End Sub

    Private Sub cbMeeting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMeeting.SelectedIndexChanged
        If cbMeeting.SelectedIndex >= 0 And lbRooms.SelectedIndex >= 0 Then
            addRange.Enabled = True
        Else
            addRange.Enabled = False
        End If

    End Sub

    Private Sub chckActivateCapacity_CheckedChanged(sender As Object, e As EventArgs) Handles chckActivateCapacity.CheckedChanged
        If chckActivateCapacity.Checked = True Then
            txtCapacity.Enabled = True
            My.Settings.searchByFeature += "rf.seatCapacity = @capacity and "
        Else
            txtCapacity.Enabled = False
            My.Settings.searchByFeature = Replace(My.Settings.searchByFeature, "rf.seatCapacity = @capacity and ", "")
        End If
    End Sub

    Private Sub chckActivateComputers_CheckedChanged(sender As Object, e As EventArgs) Handles chckActivateComputers.CheckedChanged
        If chckActivateComputers.Checked = True Then
            chckComputers.Enabled = True
            My.Settings.searchByFeature += "rf.computers = @computers and "
        Else
            chckComputers.Enabled = False
            My.Settings.searchByFeature = Replace(My.Settings.searchByFeature, "rf.computers = @computers and ", "")
        End If
    End Sub

    Private Sub chckActivateMonitors_CheckedChanged(sender As Object, e As EventArgs) Handles chckActivateMonitors.CheckedChanged
        If chckActivateMonitors.Checked = True Then
            chckDual.Enabled = True
            My.Settings.searchByFeature += "rf.computersDualMonitors = @dualMonitors and "
        Else
            chckDual.Enabled = False
            My.Settings.searchByFeature = Replace(My.Settings.searchByFeature, "rf.computersDualMonitors = @dualMonitors and ", "")
        End If
    End Sub

    Private Sub chckActivateProjector_CheckedChanged(sender As Object, e As EventArgs) Handles chckActivateProjector.CheckedChanged
        If chckActivateProjector.Checked = True Then
            chckProjector.Enabled = True
            My.Settings.searchByFeature += "rf.projector = @projector and "
        Else
            chckProjector.Enabled = False
            My.Settings.searchByFeature = Replace(My.Settings.searchByFeature, "rf.projector = @projector and ", "")
        End If
    End Sub

    Private Sub chckActivateFloor_CheckedChanged(sender As Object, e As EventArgs) Handles chckActivateFloor.CheckedChanged
        If chckActivateFloor.Checked = True Then
            chckRaisedFloor.Enabled = True
            My.Settings.searchByFeature += "rf.lectureRaisedFloor = @raisedFloor and "
        Else
            chckRaisedFloor.Enabled = False
            My.Settings.searchByFeature = Replace(My.Settings.searchByFeature, "rf.lectureRaisedFloor = @raisedFloor and ", "")
        End If
    End Sub

    Private Sub chckActivatePrinters_CheckedChanged(sender As Object, e As EventArgs) Handles chckActivatePrinters.CheckedChanged
        If chckActivatePrinters.Checked = True Then
            gbPrinters.Enabled = True
            My.Settings.searchByFeature += "rf.computersDualMonitors = @dualMonitors
                    and rf.inRoomPrinterColor = @colorPri
                    and rf.inRoomPrinterGreyOnly = @grayPri
                    and rf.sharedHallPrinterColor = @sharedPri
                    and "
        Else
            gbPrinters.Enabled = False
            My.Settings.searchByFeature = Replace(My.Settings.searchByFeature, "rf.computersDualMonitors = @dualMonitors
                    and rf.inRoomPrinterColor = @colorPri
                    and rf.inRoomPrinterGreyOnly = @grayPri
                    and rf.sharedHallPrinterColor = @sharedPri
                    and ", "")
        End If
    End Sub
End Class

