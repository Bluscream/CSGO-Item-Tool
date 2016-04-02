Public Class wmkpad_about

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Process.Start("mailto:admin@timo.de.vc")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.WebBrowser1.Url = New System.Uri("http://r4p3.net", System.UriKind.Absolute)
        Form1.WebBrowser1.Visible() = True
        Form1.WieMaiKaideToolStripMenuItem.Text = "Bro&wser schliessen"
        Form1.ToolStripTextBox1.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class