Public Class Form1



    ' Get a handle to an application window.
    <Runtime.InteropServices.DllImport("USER32.DLL")> _
    Public Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    ' Activate an application window.
    <Runtime.InteropServices.DllImport("USER32.DLL")> _
    Public Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Button38.Focus()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tim_1.Start()
        Button38.Focus()
        Dim w = My.Computer.Screen.WorkingArea.Width

        Me.Width = My.Computer.Screen.WorkingArea.Width
        Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - 350)
        Me.Height = 350
        Button38.Focus()
        w = (w - 953) / 2
        pnl_keys.Location = New Point(w, 78)






    



    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button38.Focus()

        If wsx = 1 Then
            tim_2.Start()
        Else
            Me.WindowState = FormWindowState.Minimized
        End If

        Button38.Focus()
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Button38.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If u = 1 Then
            TextBox2.Text += "Q"
        Else
            TextBox2.Text += "q"
        End If
        nex()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Text += Button4.Text
        nex()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If u = 1 Then
            TextBox2.Text += "E"
        Else
            TextBox2.Text += "e"
        End If
        nex()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        TextBox2.Text += "%"
        nex()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If u = 1 Then
            TextBox2.Text += "A"
        Else
            TextBox2.Text += "a"
        End If
        nex()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If u = 1 Then
            TextBox2.Text += "S"
        Else
            TextBox2.Text += "s"
        End If
        nex()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        TextBox2.Text += sender.Text : nex()
    End Sub


    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        TextBox2.Text += sender.Text : nex()
    End Sub


    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        TextBox2.Text += sender.Text : nex()
    End Sub



    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        TextBox2.Text += "_" : nex()
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        TextBox2.Text += sender.Text : nex()
    End Sub

    Public Function gen_ttf(ByVal txt_in As String)

        Dim txt_out As String = txt_in.ToString


        txt_out = txt_out.Replace("`od", "\")
        txt_out = txt_out.Replace("`oq", "÷")
        txt_out = txt_out.Replace("`oQ", "ª")

        txt_out = txt_out.Replace("`Co", "[")

        txt_out = txt_out.Replace("Jod", "ˆ")


        txt_out = txt_out.Replace("`vs", "ç")
        txt_out = txt_out.Replace("`vS", "é")
        txt_out = txt_out.Replace("`va", "å")


        txt_out = txt_out.Replace("`os", "¢")
        txt_out = txt_out.Replace("`oS", "£")

        txt_out = txt_out.Replace("Jo", "‡")

        txt_out = txt_out.Replace("iD", "R")

        txt_out = txt_out.Replace("h_", "©")

        txt_out = txt_out.Replace("`o", "|")
        txt_out = txt_out.Replace("oH", "μ")
        txt_out = txt_out.Replace("`v", "~")
        txt_out = txt_out.Replace("hA", "hS")


        txt_out = txt_out.Replace("ta", "tA")
        txt_out = txt_out.Replace("Ta", "´")
        txt_out = txt_out.Replace("lq", "l=")
        txt_out = txt_out.Replace("lQ", "l+")
        txt_out = txt_out.Replace(".q", ".=")
        txt_out = txt_out.Replace(".Q", ".+")
        txt_out = txt_out.Replace(";q", ";=")
        txt_out = txt_out.Replace(";Q", ";+")
        txt_out = txt_out.Replace("oq", "ÿ")
        txt_out = txt_out.Replace("Nq", "N=")
        txt_out = txt_out.Replace("oQ", "¥")
        txt_out = txt_out.Replace("NQ", "N+")
        txt_out = txt_out.Replace("rQ", "rE")
        txt_out = txt_out.Replace("rs", "ß")
        txt_out = txt_out.Replace("rS", "Í")
        txt_out = txt_out.Replace("rS", "Í")
        txt_out = txt_out.Replace("re", "/")
        txt_out = txt_out.Replace("rE", "?")
        txt_out = txt_out.Replace("ra", "¾")
        txt_out = txt_out.Replace(",q", "¨")
        txt_out = txt_out.Replace(",Q", "Æ")
        txt_out = txt_out.Replace("ns", "ì")
        txt_out = txt_out.Replace("nS", "î")
        txt_out = txt_out.Replace("na", "í")
        txt_out = txt_out.Replace("ps", "Ñ")
        txt_out = txt_out.Replace("pS", "Ö")
        txt_out = txt_out.Replace("pa", "É")
        txt_out = txt_out.Replace("gs", "á")
        txt_out = txt_out.Replace("gS", "à")
        txt_out = txt_out.Replace("ga", "Ü")
        txt_out = txt_out.Replace("vs", "ä")
        txt_out = txt_out.Replace("vS", "ã")
        txt_out = txt_out.Replace("va", "â")
        txt_out = txt_out.Replace("Ls", "Å")
        txt_out = txt_out.Replace("LS", "Ç")
        txt_out = txt_out.Replace("La", "Ä")
        txt_out = txt_out.Replace("us", "ñ")
        txt_out = txt_out.Replace("uS", "ó")
        txt_out = txt_out.Replace("ua", "ï")
        txt_out = txt_out.Replace("Us", "ô")
        txt_out = txt_out.Replace("US", "ö")
        txt_out = txt_out.Replace("Ua", "ò")
        txt_out = txt_out.Replace("js", "ú")
        txt_out = txt_out.Replace("jS", "ù")
        txt_out = txt_out.Replace("ja", "õ")
        txt_out = txt_out.Replace("Os", "ê")
        txt_out = txt_out.Replace("OS", "ë")
        txt_out = txt_out.Replace("Oa", "è")
        txt_out = txt_out.Replace("o%", "ø")
        txt_out = txt_out.Replace(":s", "Ó")
        txt_out = txt_out.Replace(":S", "Ò")
        txt_out = txt_out.Replace("Ps", "ý")
        txt_out = txt_out.Replace("PS", "Â")
        txt_out = txt_out.Replace("Pa", "þ")
        txt_out = txt_out.Replace("cs", "ð")
        txt_out = txt_out.Replace("cS", "Ô")
        txt_out = txt_out.Replace("ca", "Ê")
        txt_out = txt_out.Replace("~s", "ç")
        txt_out = txt_out.Replace("~S", "é")
        txt_out = txt_out.Replace("~a", "å")
        txt_out = txt_out.Replace("Ks", "‚")
        txt_out = txt_out.Replace("KS", "Œ")
        txt_out = txt_out.Replace("<q", "¿")
        txt_out = txt_out.Replace("<Q", "¿Q")
        txt_out = txt_out.Replace("Ms", "Ý")
        txt_out = txt_out.Replace("MS", "Ú")
        txt_out = txt_out.Replace("|q", "÷")
        txt_out = txt_out.Replace("|Q", "ª")
        txt_out = txt_out.Replace("|s", "¢")
        txt_out = txt_out.Replace("|S", "£")
        txt_out = txt_out.Replace("oS", "§")
        txt_out = txt_out.Replace("Xa", "Ù")
        txt_out = txt_out.Replace("Ma", "MA")
        txt_out = txt_out.Replace("Va", "VA")
        txt_out = txt_out.Replace("Vs", "Î")
        txt_out = txt_out.Replace("VS", "Ð")
        txt_out = txt_out.Replace("`.", "Õ")
        txt_out = txt_out.Replace("`.", "|")
        txt_out = txt_out.Replace("Fj", "…")
        txt_out = txt_out.Replace("H_", "œ")
        txt_out = txt_out.Replace("[q", "û")
        txt_out = txt_out.Replace("[Q", "ü")
        txt_out = txt_out.Replace("[d", "Ø")
        txt_out = txt_out.Replace("{d", "×")
        txt_out = txt_out.Replace("Fj", "…")
        txt_out = txt_out.Replace("CI", "Ë")



        txt_out = txt_out.Replace("rq", "re")
        txt_out = txt_out.Replace("F:", "†")

        txt_out = txt_out.Replace("oH", "μ")

        txt_out = txt_out.Replace("`O", "Š")

        Return txt_out
    End Function





    Private Sub Button38_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button38.KeyPress
        If e.KeyChar = "" Then
            delone()
        ElseIf e.KeyChar = "" Then
            TextBox2.Text = ""
        Else

            If u = 0 Then
                TextBox2.Text += e.KeyChar
            Else
                TextBox2.Text += e.KeyChar.ToString.ToUpper
            End If
        End If
        nex()



    End Sub

    Private Sub nex()
        If Button39.BackColor = Color.Gray Then
            Button2.Text = " q"
            Button4.Text = "w"
            Button5.Text = "e"
            Button6.Text = "r"
            Button7.Text = "t"
            Button8.Text = "y"
            Button9.Text = "u"
            Button10.Text = "i"
            Button11.Text = "o"
            Button12.Text = "p"
            Button13.Text = "["

            Button14.Text = "'"
            Button15.Text = ";"
            Button16.Text = "l"
            Button17.Text = "k"
            Button18.Text = "j"
            Button19.Text = "h"
            Button20.Text = "g"
            Button21.Text = "f"
            Button22.Text = "d"
            Button23.Text = " s"
            Button24.Text = " a"

            Button26.Text = "/"
            Button27.Text = "."
            Button28.Text = ","
            Button29.Text = "m"
            Button30.Text = "n"
            Button31.Text = "b"
            Button32.Text = "v"
            Button33.Text = "c"
            Button34.Text = "x"
            Button35.Text = "z"
            Button37.Text = "`"
            u = 0
            Button39.BackColor = Button44.BackColor

        End If




        Dim out = gen_ttf(TextBox2.Text).ToString
        TextBox1.Text = out







        Button38.Focus()
    End Sub


    Private Sub delone()

        Dim x = 1
        Dim p = ""
        For Each c As Char In TextBox2.Text
            If x < TextBox2.Text.Length Then
                p += c
            End If
            x += 1

        Next
        TextBox2.Text = p


        nex()
    End Sub



    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Button38.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_1.Tick
        tim_1.Stop()
        Button38.Focus()
    End Sub


    Dim u = 0
    Dim ct = 0
    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        If u = 0 Then
            Button2.Text = " Q"
            Button4.Text = "W"
            Button5.Text = "E"
            Button6.Text = "R"
            Button7.Text = "T"
            Button8.Text = "Y"
            Button9.Text = "U"
            Button10.Text = "I"
            Button11.Text = "O"
            Button12.Text = "P"
            Button13.Text = "{"

            Button14.Text = Tag
            Button15.Text = ":"
            Button16.Text = "L"
            Button17.Text = "K"
            Button18.Text = "J"
            Button19.Text = "H"
            Button20.Text = "G"
            Button21.Text = "F"
            Button22.Text = "D"
            Button23.Text = " S"
            Button24.Text = " A"

            Button26.Text = "?"
            Button27.Text = ">"
            Button28.Text = "<"
            Button29.Text = "M"
            Button30.Text = "N"
            Button31.Text = "B"
            Button32.Text = "V"
            Button33.Text = "C"
            Button34.Text = "X"
            Button35.Text = "Z"
            Button37.Text = "~"
            Button45.Text = "|"
            u = 1
            Button39.BackColor = Color.Silver
            Button38.Focus()
            Exit Sub
        Else
            Button2.Text = " q"
            Button4.Text = "w"
            Button5.Text = "e"
            Button6.Text = "r"
            Button7.Text = "t"
            Button8.Text = "y"
            Button9.Text = "u"
            Button10.Text = "i"
            Button11.Text = "o"
            Button12.Text = "p"
            Button13.Text = "["

            Button14.Text = "'"
            Button15.Text = ";"
            Button16.Text = "l"
            Button17.Text = "k"
            Button18.Text = "j"
            Button19.Text = "h"
            Button20.Text = "g"
            Button21.Text = "f"
            Button22.Text = "d"
            Button23.Text = " s"
            Button24.Text = " a"

            Button26.Text = "/"
            Button27.Text = "."
            Button28.Text = ","
            Button29.Text = "m"
            Button30.Text = "n"
            Button31.Text = "b"
            Button32.Text = "v"
            Button33.Text = "c"
            Button34.Text = "x"
            Button35.Text = "z"
            Button37.Text = "`"
            Button45.Text = "\"
            u = 0
            Button39.BackColor = Button44.BackColor
            Button38.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        delone()
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        Button38.Focus()
        Try

            My.Computer.Clipboard.SetText(TextBox1.Text)
        Catch ex As Exception

        End Try
        If wsx = 1 Then
            tim_2.Start()
        Else
            Me.WindowState = FormWindowState.Minimized
        End If

        Button38.Focus()

        Try
            My.Computer.Clipboard.SetText(TextBox1.Text)
        
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        TextBox2.Text += " "
        TextBox1.Text += " "
        Button38.Focus()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Button38.Focus()
    End Sub

    Private Sub pnl_keys_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnl_keys.Click
        Button38.Focus()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl_keys.Paint

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://dn-w.blogspot.com/")
    End Sub

    Dim lk As Keys

    Dim b As Button
    Private Sub Button38_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button38.KeyUp



        If lk = Keys.Q Then
            b = Button2 : koff(b)
        ElseIf lk = Keys.W Then
            b = Button4 : koff(b)
        ElseIf lk = Keys.E Then
            b = Button5 : koff(b)
        ElseIf lk = Keys.R Then
            b = Button6 : koff(b)
        ElseIf lk = Keys.T Then
            b = Button7 : koff(b)
        ElseIf lk = Keys.Y Then
            b = Button8 : koff(b)
        ElseIf lk = Keys.U Then
            b = Button9 : koff(b)
        ElseIf lk = Keys.I Then
            b = Button10 : koff(b)
        ElseIf lk = Keys.O Then
            b = Button11 : koff(b)
        ElseIf lk = Keys.P Then
            b = Button12 : koff(b)
        ElseIf lk = Keys.OemOpenBrackets Then
            b = Button13 : koff(b)
        ElseIf lk = Keys.A Then
            b = Button24 : koff(b)
        ElseIf lk = Keys.S Then
            b = Button23 : koff(b)
        ElseIf lk = Keys.D Then
            b = Button22 : koff(b)
        ElseIf lk = Keys.F Then
            b = Button21 : koff(b)
        ElseIf lk = Keys.G Then
            b = Button20 : koff(b)
        ElseIf lk = Keys.H Then
            b = Button19 : koff(b)
        ElseIf lk = Keys.J Then
            b = Button18 : koff(b)
        ElseIf lk = Keys.K Then
            b = Button17 : koff(b)
        ElseIf lk = Keys.L Then
            b = Button16 : koff(b)
        ElseIf lk = Keys.OemSemicolon Then
            b = Button15 : koff(b)
        ElseIf lk = Keys.OemQuotes Then
            b = Button14 : koff(b)
        ElseIf lk = Keys.Z Then
            b = Button35 : koff(b)
        ElseIf lk = Keys.X Then
            b = Button34 : koff(b)
        ElseIf lk = Keys.C Then
            b = Button33 : koff(b)
        ElseIf lk = Keys.V Then
            b = Button32 : koff(b)
        ElseIf lk = Keys.B Then
            b = Button31 : koff(b)
        ElseIf lk = Keys.N Then
            b = Button30 : koff(b)
        ElseIf lk = Keys.M Then
            b = Button29 : koff(b)
        ElseIf lk = Keys.Oemcomma Then
            b = Button28 : koff(b)
        ElseIf lk = Keys.OemPeriod Then
            b = Button27 : koff(b)
        ElseIf lk = Keys.OemQuestion Then
            b = Button26 : koff(b)
        ElseIf lk = Keys.Space Then
            b = Button42 : koff(b)
        ElseIf lk = Keys.Multiply Then
            b = Button36 : koff(b)
        ElseIf lk = Keys.D8 Then
            b = Button36 : koff(b)
        ElseIf lk = Keys.OemPipe Then
            b = Button45 : koff(b)
        ElseIf lk = Keys.Oemtilde Then
            b = Button37 : koff(b)
        ElseIf lk = Keys.D1 Then
            b = Button43 : koff(b)
        ElseIf lk = Keys.D5 Then
            b = Button25 : koff(b)
        ElseIf lk = Keys.Back Then
            b = Button40 : koff(b)
        ElseIf lk = Keys.Escape Then
            b = Button46 : koff(b)

        ElseIf lk = Keys.C Then
            b = Button33 : koff(b)

        ElseIf lk = Keys.OemMinus Then
            b = Button52 : koff(b)

        ElseIf lk = Keys.ShiftKey Then
            b = Button39 : koff(b)
            Button2.Text = " q"
            Button4.Text = "w"
            Button5.Text = "e"
            Button6.Text = "r"
            Button7.Text = "t"
            Button8.Text = "y"
            Button9.Text = "u"
            Button10.Text = "i"
            Button11.Text = "o"
            Button12.Text = "p"
            Button13.Text = "["

            Button14.Text = "'"
            Button15.Text = ";"
            Button16.Text = "l"
            Button17.Text = "k"
            Button18.Text = "j"
            Button19.Text = "h"
            Button20.Text = "g"
            Button21.Text = "f"
            Button22.Text = "d"
            Button23.Text = " s"
            Button24.Text = " a"

            Button26.Text = "/"
            Button27.Text = "."
            Button28.Text = ","
            Button29.Text = "m"
            Button30.Text = "n"
            Button31.Text = "b"
            Button32.Text = "v"
            Button33.Text = "c"
            Button34.Text = "x"
            Button35.Text = "z"
            Button37.Text = "`"
            Button45.Text = "\"
            u = 0
        End If

        If e.KeyCode = Keys.ShiftKey Then
            b = Button39 : koff(b)
            Button2.Text = " q"
            Button4.Text = "w"
            Button5.Text = "e"
            Button6.Text = "r"
            Button7.Text = "t"
            Button8.Text = "y"
            Button9.Text = "u"
            Button10.Text = "i"
            Button11.Text = "o"
            Button12.Text = "p"
            Button13.Text = "["

            Button14.Text = "'"
            Button15.Text = ";"
            Button16.Text = "l"
            Button17.Text = "k"
            Button18.Text = "j"
            Button19.Text = "h"
            Button20.Text = "g"
            Button21.Text = "f"
            Button22.Text = "d"
            Button23.Text = " s"
            Button24.Text = " a"

            Button26.Text = "/"
            Button27.Text = "."
            Button28.Text = ","
            Button29.Text = "m"
            Button30.Text = "n"
            Button31.Text = "b"
            Button32.Text = "v"
            Button33.Text = "c"
            Button34.Text = "x"
            Button35.Text = "z"
            Button37.Text = "`"
            Button45.Text = "\"
            u = 0
        End If

    End Sub

    Private Sub Button38_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button38.KeyDown

        If e.KeyCode = Keys.F11 Then
            wind_pr()
            Button38.Focus()
        End If

        lk = e.KeyCode

        If e.KeyCode = Keys.Control Then
            ct = 1
        Else
            ct = 0
        End If

        If lk = Keys.Q Then
            b = Button2 : kon(b)
        ElseIf lk = Keys.W Then
            b = Button4 : kon(b)
        ElseIf lk = Keys.E Then
            b = Button5 : kon(b)
        ElseIf lk = Keys.R Then
            b = Button6 : kon(b)
        ElseIf lk = Keys.T Then
            b = Button7 : kon(b)
        ElseIf lk = Keys.Y Then
            b = Button8 : kon(b)
        ElseIf lk = Keys.U Then
            b = Button9 : kon(b)
        ElseIf lk = Keys.I Then
            b = Button10 : kon(b)
        ElseIf lk = Keys.O Then
            b = Button11 : kon(b)
        ElseIf lk = Keys.P Then
            b = Button12 : kon(b)
        ElseIf lk = Keys.OemOpenBrackets Then
            b = Button13 : kon(b)
        ElseIf lk = Keys.A Then
            b = Button24 : kon(b)
        ElseIf lk = Keys.S Then
            b = Button23 : kon(b)
        ElseIf lk = Keys.D Then
            b = Button22 : kon(b)
        ElseIf lk = Keys.F Then
            b = Button21 : kon(b)
        ElseIf lk = Keys.G Then
            b = Button20 : kon(b)
        ElseIf lk = Keys.H Then
            b = Button19 : kon(b)
        ElseIf lk = Keys.J Then
            b = Button18 : kon(b)
        ElseIf lk = Keys.K Then
            b = Button17 : kon(b)
        ElseIf lk = Keys.L Then
            b = Button16 : kon(b)
        ElseIf lk = Keys.OemSemicolon Then
            b = Button15 : kon(b)
        ElseIf lk = Keys.OemQuotes Then
            b = Button14 : kon(b)
        ElseIf lk = Keys.Z Then
            b = Button35 : kon(b)
        ElseIf lk = Keys.X Then
            b = Button34 : kon(b)
        ElseIf lk = Keys.C Then

            b = Button33 : kon(b)

        ElseIf lk = Keys.V Then
            b = Button32 : kon(b)
        ElseIf lk = Keys.B Then
            b = Button31 : kon(b)
        ElseIf lk = Keys.N Then
            b = Button30 : kon(b)
        ElseIf lk = Keys.M Then
            b = Button29 : kon(b)
        ElseIf lk = Keys.Oemcomma Then
            b = Button28 : kon(b)
        ElseIf lk = Keys.OemPeriod Then
            b = Button27 : kon(b)
        ElseIf lk = Keys.OemQuestion Then
            b = Button26 : kon(b)
        ElseIf lk = Keys.Space Then
            b = Button42 : kon(b)
        ElseIf lk = Keys.Multiply Then
            b = Button36 : kon(b)
        ElseIf lk = Keys.D8 Then
            If u = 1 Then
                b = Button36 : kon(b)
            End If
        ElseIf lk = Keys.OemPipe Then
            b = Button45 : kon(b)
        ElseIf lk = Keys.Oemtilde Then
            b = Button37 : kon(b)
        ElseIf lk = Keys.D1 Then
            If u = 1 Then
                b = Button43 : kon(b)
            End If
        ElseIf lk = Keys.D5 Then
            If u = 1 Then
                b = Button25 : kon(b)
            End If
        ElseIf lk = Keys.Back Then
            b = Button40 : kon(b)
        ElseIf lk = Keys.Escape Then
            b = Button46 : kon(b)

        ElseIf lk = Keys.C Then
            b = Button33 : kon(b)

        ElseIf lk = Keys.OemMinus Then
            If u = 1 Then
                b = Button52 : kon(b)
            End If


        ElseIf lk = Keys.ShiftKey Then
            b = Button39 : kon(b)
            Button2.Text = " Q"
            Button4.Text = "W"
            Button5.Text = "E"
            Button6.Text = "R"
            Button7.Text = "T"
            Button8.Text = "Y"
            Button9.Text = "U"
            Button10.Text = "I"
            Button11.Text = "O"
            Button12.Text = "P"
            Button13.Text = "{"

            Button14.Text = Tag
            Button15.Text = ":"
            Button16.Text = "L"
            Button17.Text = "K"
            Button18.Text = "J"
            Button19.Text = "H"
            Button20.Text = "G"
            Button21.Text = "F"
            Button22.Text = "D"
            Button23.Text = " S"
            Button24.Text = " A"

            Button26.Text = "?"
            Button27.Text = ">"
            Button28.Text = "<"
            Button29.Text = "M"
            Button30.Text = "N"
            Button31.Text = "B"
            Button32.Text = "V"
            Button33.Text = "C"
            Button34.Text = "X"
            Button35.Text = "Z"
            Button37.Text = "~"
            Button45.Text = "|"
            u = 1
            Button39.BackColor = Color.Silver
        End If


    End Sub

    Private Sub koff(ByVal b)
        alloff()
        b.BackColor = Color.Gray
    End Sub

    Private Sub kon(ByVal b)
        alloff()
        b.BackColor = Color.Silver
    End Sub

    Private Sub alloff()
        Button2.BackColor = Color.Gray
        Button4.BackColor = Color.Gray
        Button5.BackColor = Color.Gray
        Button6.BackColor = Color.Gray
        Button7.BackColor = Color.Gray
        Button8.BackColor = Color.Gray
        Button9.BackColor = Color.Gray
        Button10.BackColor = Color.Gray
        Button11.BackColor = Color.Gray
        Button12.BackColor = Color.Gray
        Button13.BackColor = Color.Gray
        Button14.BackColor = Color.Gray
        Button15.BackColor = Color.Gray
        Button16.BackColor = Color.Gray
        Button17.BackColor = Color.Gray
        Button18.BackColor = Color.Gray
        Button19.BackColor = Color.Gray
        Button20.BackColor = Color.Gray
        Button21.BackColor = Color.Gray
        Button22.BackColor = Color.Gray
        Button23.BackColor = Color.Gray
        Button24.BackColor = Color.Gray
        Button25.BackColor = Color.Gray
        Button26.BackColor = Color.Gray
        Button27.BackColor = Color.Gray
        Button28.BackColor = Color.Gray
        Button29.BackColor = Color.Gray
        Button30.BackColor = Color.Gray
        Button31.BackColor = Color.Gray
        Button32.BackColor = Color.Gray
        Button33.BackColor = Color.Gray
        Button34.BackColor = Color.Gray
        Button35.BackColor = Color.Gray
        Button42.BackColor = Color.Gray
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click

    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Button38.Focus()
    End Sub

    Dim wins = 1

    Private Sub TextBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 70 Then
            TextBox1.Font = Label4.Font
        Else
            TextBox1.Font = Label3.Font
        End If
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        Form2.ShowDialog()
        Button38.Focus()
        nex()
    End Sub

    Private Sub DsfdsafToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DsfdsafToolStripMenuItem.Click
        Try
            My.Computer.Clipboard.SetText(TextBox1.Text)
        Catch ex As Exception

        End Try

        Button38.Focus()

        If wsx = 1 Then
            tim_2.Start()
        Else
            Me.WindowState = FormWindowState.Minimized
        End If
        Button38.Focus()
    End Sub

    Private Sub Panel5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.Click
        Button38.Focus()
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        kbps_pr()
    End Sub

    Dim wsx = 1

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click

        wind_pr()
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        System.Diagnostics.Process.Start("http://dn-w.blogspot.com/")
    End Sub


    Private Sub wind_pr()
        If wsx = 1 Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.Width = 1100
            Me.Location = New Point(150, 300)
            pnl_keys.Location = New Point(0, 78)
            Button38.Focus()
            wsx = 0
            wins = 1
            Label1.Tag = 1
            Button48.Hide()

            Exit Sub
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.Width = My.Computer.Screen.WorkingArea.Width
            Dim w = My.Computer.Screen.WorkingArea.Width

            Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - 350)
            w = (w - 953) / 2
            pnl_keys.Location = New Point(w, 78)
            Button38.Focus()
            Button48.Show()
            Me.Width = My.Computer.Screen.WorkingArea.Width
            wsx = 1
            Exit Sub
        End If
    End Sub



    Private Sub kbps_pr()
        If wins = 1 Then
            wins = 0
            Label1.Tag = wins
            Me.Opacity = 50
            Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - 310)
            Button38.Focus()
            Exit Sub
        Else
            wins = 1
            Label1.Tag = wins
            Me.Location = New Point(0, 378)
            Button38.Focus()
            Exit Sub
        End If
    End Sub



    Private Sub Timer2_Tick2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_2.Tick
        tim_2.Stop()
        If Me.Height <= 5 Then
            Me.WindowState = FormWindowState.Minimized
            If wins = 1 Then
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height)
            Else
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height + 50)
            End If

            Dim w = My.Computer.Screen.WorkingArea.Width
            Me.Width = My.Computer.Screen.WorkingArea.Width
            Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - 350)
            Me.Height = 350
            Button38.Focus()
            w = (w - 953) / 2
            pnl_keys.Location = New Point(w, 78)


            If wins = 1 Then
                Label1.Tag = wins
                Me.Location = New Point(0, 378)
                Button38.Focus()
            End If
            If wins = 0 Then
                Label1.Tag = wins
                Me.Opacity = 50
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - 310)
                Button38.Focus()
            End If




            Exit Sub
        ElseIf Me.Height <= 40 Then
            Me.Height -= 5
            tim_2.Start()
            If wins = 1 Then
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height)
            Else
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height + 50)
            End If
            Exit Sub
        ElseIf Me.Height <= 100 Then
            Me.Height -= 20
            tim_2.Start()
            If wins = 1 Then
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height)
            Else
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height + 50)
            End If
            Exit Sub
        Else
            Me.Height -= 50
            If wins = 1 Then
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height)
            Else
                Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - Me.Height + 50)
            End If
            tim_2.Start()
        End If
    End Sub

    Private Sub Button93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Private makel As String

    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        If Not Caption.ToString() = "TTF Generator 2.0" Then
            Button42.Tag = Caption.ToString()
        End If
        Return Caption.ToString()
    End Function

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim CapTxt As String = GetCaption()
        If makel <> CapTxt Then
            makel = CapTxt
            ' stop timer before showing msgbox so it is not detected!
            Timer2.Stop()
            MsgBox(CapTxt)
            ' resume timer 
            Timer2.Start()
        End If
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        Button38.Focus()
        Me.WindowState = FormWindowState.Minimized
        Try
            ' Get a handle to the Calculator application. The window class
            ' and window name were obtained using the Spy++ tool.
            Dim calculatorHandle As IntPtr = FindWindow(Nothing, Button42.Tag)
            ' Verify that Calculator is a running process.
            If calculatorHandle = IntPtr.Zero Then
                My.Computer.Clipboard.SetText(TextBox1.Text)
                Return
            End If
            ' Make Calculator the foreground application and send it 
            ' a set of calculations.
            SetForegroundWindow(calculatorHandle)
            SendKeys.SendWait(TextBox1.Text)
        Catch ex As Exception
        End Try
        Button38.Focus()
    End Sub

    Private Sub SsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button38.Focus()
        Me.WindowState = FormWindowState.Minimized
        Try
            ' Get a handle to the Calculator application. The window class
            ' and window name were obtained using the Spy++ tool.
            Dim calculatorHandle As IntPtr = FindWindow(Nothing, Button42.Tag)
            ' Verify that Calculator is a running process.
            If calculatorHandle = IntPtr.Zero Then
                My.Computer.Clipboard.SetText(TextBox1.Text)
                Return
            End If
            ' Make Calculator the foreground application and send it 
            ' a set of calculations.
            SetForegroundWindow(calculatorHandle)
            SendKeys.SendWait(TextBox1.Text)
        Catch ex As Exception
        End Try
        Button38.Focus()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        GetCaption()
    End Sub
End Class
