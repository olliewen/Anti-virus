Public Class Form1

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
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "Virus" Then
            ListBox1.ClearSelected()
        ElseIf ListBox1.SelectedItem = "Trojan" Then
            ListBox1.ClearSelected()
        ElseIf ListBox1.SelectedItem = "Worm" Then
            ListBox1.ClearSelected()
        ElseIf ListBox1.SelectedItem = "Spyware" Then
            ListBox1.ClearSelected()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim targetfile As String
        Kill("C:\Users\Oliver\Documents\virus.txt")
        Kill("C:\Users\Oliver\Documents\worm.txt")
        Kill("C:\Users\Oliver\Documents\trojan.txt")
        Kill("C:\Users\Oliver\Documents\spyware.txt")
        targetfile = "c:\WINDOWS\SYSTEM32\cmd.exe"
        Label1.Text = "Deleting selected file(s), please wait."
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim therandom As New Random
        Timer1.Interval = therandom.Next(100, 1000)
        On Error Resume Next
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Label2.Text = "Deleted selected file(s)"
        Else
            ProgressBar1.Value += therandom.Next(1, 3)

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub
End Class
