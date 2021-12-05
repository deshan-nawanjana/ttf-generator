Public Class Form3

    Dim ex = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ex = 1
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ex = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = My.Computer.Clock.LocalTime.Millisecond & My.Computer.Clock.LocalTime.Minute & My.Computer.Clock.LocalTime.DayOfWeek
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vx = 0
        For Each c As Char In Label3.Text
            If c = "1" Then
                vx += 6756657
            End If
            If c = "2" Then
                vx += 5635235
            End If
            If c = "3" Then
                vx += 6875634
            End If
            If c = "4" Then
                vx += 4325236
            End If
            If c = "5" Then
                vx += 3762433
            End If
            If c = "6" Then
                vx += 6545452
            End If
            If c = "7" Then
                vx += 6518888
            End If
            If c = "8" Then
                vx += 4375474
            End If
            If c = "9" Then
                vx += 8464254
            End If
            If c = "0" Then
                vx += 3453453
            End If
        Next

        If vx.ToString = TextBox1.Text Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData & "\kx.reg", "", False)
            ex = 1
            Me.Close()
        End If

    End Sub
End Class