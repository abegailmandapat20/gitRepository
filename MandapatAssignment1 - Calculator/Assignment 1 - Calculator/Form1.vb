﻿Public Class Calculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click

    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked

    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked

    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBoxDisplay.Text = "0" Then
            TextBoxDisplay.Text = "0"

        Else TextBoxDisplay.Text = TextBoxDisplay.Text & "0"

        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBoxDisplay.Text = "0" Then
            TextBoxDisplay.Text = "1"

        Else TextBoxDisplay.Text = TextBoxDisplay.Text & "1"
        End If
    End Sub
End Class
