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
        DataGridView1.Height = Me.Height - 250 ' 200 for the controls, 50 for extra footer room. Leave room for the controls on top. Adjust in future for additional controls OR use a function to read all them controls height and plug into here.

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
        listCoursesInComboBox(Me.ComboBox1) 'does not load on first run
        dtpStart.CustomFormat = "MM/dd/yyyy h:mm tt "
        dtpEnd.CustomFormat = "MM/dd/yyyy h:mm tt "
        ' Do we have to login ?

        ' Check security level of user


        ' Call the refresh sub to update the GUI data. Like the ListBoxes in changing the Selected Database.
        ' reloadSchedulerGUI()

    End Sub

    Private Sub btnPopCampus_Click(sender As Object, e As EventArgs) Handles btnPopCampus.Click
        listCampusesInListBox(Me.lbCampus)
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


        listBuildingsInListBox(Me.lbBuilding, campus)
    End Sub

    Private Sub lbBuilding_Click(sender As Object, e As EventArgs) Handles lbBuilding.Click
        Dim building = lbBuilding.SelectedValue.ToString()

        listRoomsInListBox(Me.lbRooms, building)
    End Sub

    Private Sub lbRooms_Click(sender As Object, e As EventArgs) Handles lbRooms.Click
        Dim room = lbRooms.SelectedValue.ToString()
        displayDateTimeBlocks(Me.DataGridView1, room)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        lblRoom.Text = lbCampus.Text + ": " + lbBuilding.Text + lbRooms.Text
    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click
        If lbRooms.SelectedIndex >= 0 Then
            If ComboBox1.SelectedIndex >= 0 Then
                Dim room = lbRooms.SelectedValue.ToString()
                Dim course = ComboBox1.SelectedValue.ToString()
                Dim startTime = dtpStart.Text.ToString()
                Dim endTime = dtpEnd.Text.ToString()
                addDateTimeBlock(room, course, startTime, endTime)
                displayDateTimeBlocks(Me.DataGridView1, room)
            End If
        End If




    End Sub

    Private Sub btnUpdateTime_Click(sender As Object, e As EventArgs) Handles btnUpdateTime.Click
        If lbRooms.SelectedIndex >= 0 Then
            If ComboBox1.SelectedIndex >= 0 Then
                Dim selected = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                Dim room = lbRooms.SelectedValue.ToString()
                Dim course = ComboBox1.SelectedValue.ToString()
                Dim startTime = dtpStart.Text.ToString()
                Dim endTime = dtpEnd.Text.ToString()
                updateDateTimeBlock(selected, room, course, startTime, endTime)
                displayDateTimeBlocks(Me.DataGridView1, room)
            End If
        End If
    End Sub

    Private Sub btnDeleteTime_Click(sender As Object, e As EventArgs) Handles btnDeleteTime.Click
        If lbRooms.SelectedIndex >= 0 Then
            If ComboBox1.SelectedIndex >= 0 Then
                Dim room = lbRooms.SelectedValue.ToString()
                Dim selected = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                deleteDateTimeBlock(selected)
                displayDateTimeBlocks(Me.DataGridView1, room)
            End If
        End If
    End Sub
End Class

