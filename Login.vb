Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Admin" Then
            Main.Show()
            Me.Hide()
        Else
            MsgBox("User Name and Password not Match")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class