﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists("C:\Users\Oliver\Documents\virus.txt") Then
            ListBox1.Items.Add("Virus")
        End If
        If My.Computer.FileSystem.FileExists("C:\Users\Oliver\Documents\trojan.txt") Then
            ListBox1.Items.Add("Trojan")
        End If
        If My.Computer.FileSystem.FileExists("C:\Users\Oliver\Documents\worm.txt") Then
            ListBox1.Items.Add("Worm")
        End If
        If My.Computer.FileSystem.FileExists("C:\Users\Oliver\Documents\spyware.txt") Then
            ListBox1.Items.Add("Spyware")
        End If
        If My.Computer.FileSystem.FileExists("C:\Users\Oliver\Desktop\Internet Explorer.exe") Then
            ListBox1.Items.Add("Virus")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

End Class
