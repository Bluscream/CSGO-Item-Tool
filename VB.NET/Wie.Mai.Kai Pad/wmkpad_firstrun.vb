Public Class wmkpad_firstrun



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text IsNot "" Then

            My.Settings.CSGOPATH = TextBox1.Text
            My.Settings.Save()
            Me.Close()
            Form1.Show()
        Else
            MsgBox("Please Enter a valid Path.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub wmkpad_firstrun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.CSGOPATH IsNot "" Then
            Me.Close()
            Form1.Show()
        Else
            Form1.Visible = False
            Form1.WindowState = FormWindowState.Minimized
            Form1.Hide()
            TextBox1.Text = My.Settings.CSGOPATH
        End If
    End Sub

    Shared Sub selected()
        Throw New NotImplementedException
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class