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

        ' Do we have to login ?

        ' Check security level of user


        ' Call the refresh sub to update the GUI data. Like the ListBoxes in changing the Selected Database.
        'reloadSchedulerGUI()

    End Sub

    Private Sub lbCampus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCampus.SelectedIndexChanged

        Dim campusId As Integer
        Dim campusRowViewSTR As String
        ' Work on a copy to avoid an error from popping up that complains about the list being changed while looping it.
        ' Good practice anyways.
        Dim loopCopy As ListBox.SelectedObjectCollection = lbCampus.SelectedItems

        ' Loop through the selected items
        For Each item As DataRowView In loopCopy
            campusRowViewSTR = item.Item("campusName").ToString()
            campusId = Convert.ToInt32(CType(item, DataRowView).Item("campusId"))

            'MessageBox.Show(campusId.ToString)
            'MessageBox.Show(campusRowViewSTR)
        Next

        listBuildingsInListBox(Me.lbBuilding, campusId)

    End Sub

    Private Sub lbBuilding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBuilding.SelectedIndexChanged

        Dim buildingId As Integer
        Dim buildingRowViewSTR As String
        ' Work on a copy to avoid an error from popping up that complains about the list being changed while looping it.
        ' Good practice anyways.
        Dim loopCopy As ListBox.SelectedObjectCollection = lbBuilding.SelectedItems

        ' Loop through the selected items
        For Each item As DataRowView In loopCopy
            buildingRowViewSTR = item.Item("buildingName").ToString()
            buildingId = Convert.ToInt32(CType(item, DataRowView).Item("dbBuildingID"))

            'MessageBox.Show(campusId.ToString)
            'MessageBox.Show(campusRowViewSTR)
        Next

        listRoomsInListBox(Me.lbBuilding, buildingId)

    End Sub

    Private Sub btnPopCampus_Click_1(sender As Object, e As EventArgs) Handles btnPopCampus.Click

        ' Disable events to prevent combobox from freaking out on the loading of the data
        RemoveHandler lbBuilding.ValueMemberChanged, AddressOf lbBuilding_ValueMemberChanged
        RemoveHandler lbCampus.SelectedIndexChanged, AddressOf lbCampus_SelectedIndexChanged
        RemoveHandler lbBuilding.SelectedIndexChanged, AddressOf lbBuilding_SelectedIndexChanged
        RemoveHandler lbRooms.SelectedIndexChanged, AddressOf lbRooms_SelectedIndexChanged

        listCampusesInListBox(Me.lbCampus)

        ' Reenable the events
        AddHandler lbBuilding.ValueMemberChanged, AddressOf lbBuilding_ValueMemberChanged
        AddHandler lbCampus.SelectedIndexChanged, AddressOf lbCampus_SelectedIndexChanged
        AddHandler lbBuilding.SelectedIndexChanged, AddressOf lbBuilding_SelectedIndexChanged
        AddHandler lbRooms.SelectedIndexChanged, AddressOf lbRooms_SelectedIndexChanged


    End Sub

    Private Sub lbCampus_ValueMemberChanged(sender As Object, e As EventArgs) Handles lbCampus.ValueMemberChanged

        Dim campusId As Integer
        Dim campusRowViewSTR As String

        ' Loop through the selected items
        For Each item As DataRowView In lbCampus.SelectedItems
            campusRowViewSTR = item.Item("campusName").ToString()
            campusId = Convert.ToInt32(CType(item, DataRowView).Item("campusId"))

            'MessageBox.Show(campusId.ToString)
            'MessageBox.Show(campusRowViewSTR)
        Next

        listBuildingsInListBox(Me.lbBuilding, campusId)
    End Sub


    Private Sub lbBuilding_ValueMemberChanged(sender As Object, e As EventArgs) Handles lbBuilding.ValueMemberChanged

        Dim buildingsId As Integer
        Dim buildingsRowViewSTR As String

        ' Loop through the selected items
        For Each item As DataRowView In lbBuilding.SelectedItems
            buildingsRowViewSTR = item.Item("buildingName").ToString()
            buildingsId = Convert.ToInt32(CType(item, DataRowView).Item("dbBuildingID"))

            'MessageBox.Show(buildingsId.ToString)
            'MessageBox.Show(buildingsRowViewSTR)
        Next

        listRoomsInListBox(Me.lbBuilding, buildingsId)
    End Sub

    Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRooms.SelectedIndexChanged
        Dim buildingId As Integer
        Dim buildingRowViewSTR As String
        ' Work on a copy to avoid an error from popping up that complains about the list being changed while looping it.
        ' Good practice anyways.
        Dim loopCopy As ListBox.SelectedObjectCollection = lbBuilding.SelectedItems

        ' Loop through the selected items
        For Each item As DataRowView In loopCopy
            buildingRowViewSTR = item.Item("buildingName").ToString()
            buildingId = Convert.ToInt32(CType(item, DataRowView).Item("dbBuildingID"))

            'MessageBox.Show(campusId.ToString)
            'MessageBox.Show(campusRowViewSTR)
        Next


    End Sub
End Class

