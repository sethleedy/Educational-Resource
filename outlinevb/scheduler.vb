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
        Dim campus = lbCampus.SelectedValue.ToString()
        Dim sqlString As String = My.Settings.listBuildings.ToString()
        Dim value As String = "dbBuildingID"
        Dim display As String = "buildingName"
        displayItemsListBox(Me.lbBuilding, sqlString, value, display, campus)

    End Sub

    Private Sub lbBuilding_Click(sender As Object, e As EventArgs) Handles lbBuilding.Click
        Dim building = lbBuilding.SelectedValue.ToString()
        Dim sqlString As String = My.Settings.listRooms.ToString()
        Dim value As String = "dbRoomID"
        Dim display As String = "roomNum"
        displayItemsListBox(Me.lbRooms, sqlString, value, display, building)
    End Sub

    Private Sub lbRooms_Click(sender As Object, e As EventArgs) Handles lbRooms.Click
        Dim room = lbRooms.SelectedValue.ToString()
        Dim sqlString As String = My.Settings.selectDTB.ToString()
        displayDGV(DataGridView1, sqlString, room)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        lblRoom.Text = lbCampus.Text + ": " + lbBuilding.Text + lbRooms.Text
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




    End Sub

End Class

