Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim targetfile As String
        Kill("C:\Users\Oliver\Documents\virus.txt")
        Kill("C:\Users\Oliver\Documents\worm.txt")
        Kill("C:\Users\Oliver\Documents\trojan.txt")
        Kill("C:\Users\Oliver\Documents\spyware.txt")
        targetfile = "c:\WINDOWS\SYSTEM32\cmd.exe"
        Me.Close()
        Form1.Show()
        Form1.Label1.Text = "Deleting selected file(s), please wait."
        Form1.Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class