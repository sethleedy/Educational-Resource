Imports System.IO ' Test﻿


Imports System
Imports Microsoft.VisualBasic.Interaction ' ?
Imports System.ComponentModel

' ObjectDumper.ObjectDumperExtensions.DumpToString(strColumnName, "strColumnName") ' https://objectdumper.codeplex.com/ | https://www.nuget.org/packages/ObjectDumper/

Public Class scheduler

    Private Sub scheduler_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ' On resize, peg some form elements to static positions

        ' DataGridView1
        '   Left/Right
        DataGridView1.Left = 10
        DataGridView1.Width = Me.Width - 40 ' 10 margin on left and 40 on the right, that seems to center it. Margins on left/right are not even ??
        '   Height
        DataGridView1.Height = Me.Height - 250 ' 200 for the controls, 50 for extra footer room. Leave room for the controls on top. Adjust in future for additional controls OR use a function to read all them controls height and plug into here.

        ' DataGridViewTest1
        '   Left/Right
        DataGridViewTest1.Left = 10
        DataGridViewTest1.Width = Me.Width - 40 ' 10 margin on left and 40 on the right, that seems to center it. Margins on left/right are not even ??
        '   Height
        DataGridViewTest1.Height = Me.Height - 250 ' 200 for the controls, 50 for extra footer room. Leave room for the controls on top. Adjust in future for additional controls OR use a function to read all them controls height and plug into here.



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

    Private Sub DataGridViewTest1_DateClick(sender As Object, e As MindFusion.Scheduling.WinForms.ResourceDateEventArgs) Handles DataGridViewTest1.DateClick

    End Sub


End Class

