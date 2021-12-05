Imports TTFGEN
Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        System.Diagnostics.Process.Start("http://www.dn-w.blogspot.com/")
    End Sub

    Private Sub txt_in_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_in.TextChanged
        If txt_in.Text = "" Then
            txt_out.Text = ""
        Else
            Dim fun As New TTFGEN.TTFGENRT
            txt_out.Text = fun.gen_ttf(txt_in.Text & " ").ToString
        End If
    End Sub

    Private Sub CopyTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub XpyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XpyToolStripMenuItem.Click
        If txt_out.Text = "" Then
        Else
            My.Computer.Clipboard.SetText(txt_out.Text)
        End If
    End Sub

    Private Sub SecltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecltToolStripMenuItem.Click
        If txt_out.Text = "" Then
        Else
            txt_in.SelectAll()
        End If
    End Sub
End Class
