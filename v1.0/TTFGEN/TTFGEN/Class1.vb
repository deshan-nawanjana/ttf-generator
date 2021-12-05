Public Class TTFGENRT

    Public Function gen_ttf(ByVal txt_in As String)
        Dim l1 As String = ""
        Dim l2 As String = ""
        Dim txt_out = ""
        Dim s As String = txt_in
        For Each c As Char In s
            l2 = l1
            l1 = c
            If l2 = "t" And l1 = "a" Then
                l2 = "tA"
                l1 = ""
            ElseIf l2 = "T" And l1 = "a" Then
                l2 = "´"
                l1 = ""
            ElseIf l2 = "l" And l1 = "q" Then
                l2 = "l="
                l1 = ""
            ElseIf l2 = "l" And l1 = "Q" Then
                l2 = "l+"
                l1 = ""
            ElseIf l2 = "." And l1 = "q" Then
                l2 = ".="
                l1 = ""
            ElseIf l2 = "." And l1 = "Q" Then
                l2 = ".+"
                l1 = ""
            ElseIf l2 = ";" And l1 = "q" Then
                l2 = ";="
                l1 = ""
            ElseIf l2 = ";" And l1 = "Q" Then
                l2 = ";+"
                l1 = ""
            ElseIf l2 = "o" And l1 = "q" Then
                l2 = "ÿ"
                l1 = ""
            ElseIf l2 = "o" And l1 = "Q" Then
                l2 = "¥"
                l1 = ""
            ElseIf l2 = "N" And l1 = "q" Then
                l2 = "N="
                l1 = ""
            ElseIf l2 = "N" And l1 = "Q" Then
                l2 = "N+"
                l1 = ""
            ElseIf l2 = "r" And l1 = "q" Then
                l2 = "re"
                l1 = ""
            ElseIf l2 = "r" And l1 = "Q" Then
                l2 = "rE"
                l1 = ""
            ElseIf l2 = "r" And l1 = "s" Then
                l2 = "ß"
                l1 = ""
            ElseIf l2 = "r" And l1 = "S" Then
                l2 = "Í"
                l1 = ""
            ElseIf l2 = "r" And l1 = "S" Then
                l2 = "Í"
                l1 = ""
            ElseIf l2 = "r" And l1 = "e" Then
                l2 = "/"
                l1 = ""
            ElseIf l2 = "r" And l1 = "E" Then
                l2 = "?"
                l1 = ""
            ElseIf l2 = "r" And l1 = "a" Then
                l2 = "¾"
                l1 = ""
            ElseIf l2 = "," And l1 = "q" Then
                l2 = "¨"
                l1 = ""
            ElseIf l2 = "," And l1 = "Q" Then
                l2 = "Æ"
                l1 = ""
            ElseIf l2 = "n" And l1 = "s" Then
                l2 = "ì"
                l1 = ""
            ElseIf l2 = "n" And l1 = "S" Then
                l2 = "î"
                l1 = ""
            ElseIf l2 = "n" And l1 = "a" Then
                l2 = "í"
                l1 = ""
            ElseIf l2 = "p" And l1 = "s" Then
                l2 = "Ñ"
                l1 = ""
            ElseIf l2 = "p" And l1 = "S" Then
                l2 = "Ö"
                l1 = ""
            ElseIf l2 = "p" And l1 = "a" Then
                l2 = "É"
                l1 = ""
            ElseIf l2 = "g" And l1 = "s" Then
                l2 = "á"
                l1 = ""
            ElseIf l2 = "g" And l1 = "S" Then
                l2 = "à"
                l1 = ""
            ElseIf l2 = "g" And l1 = "a" Then
                l2 = "Ü"
                l1 = ""
            ElseIf l2 = "v" And l1 = "s" Then
                l2 = "ä"
                l1 = ""
            ElseIf l2 = "v" And l1 = "S" Then
                l2 = "ã"
                l1 = ""
            ElseIf l2 = "v" And l1 = "a" Then
                l2 = "â"
                l1 = ""
            ElseIf l2 = "L" And l1 = "s" Then
                l2 = "Å"
                l1 = ""
            ElseIf l2 = "L" And l1 = "S" Then
                l2 = "Ç"
                l1 = ""
            ElseIf l2 = "L" And l1 = "a" Then
                l2 = "Ä"
                l1 = ""
            ElseIf l2 = "u" And l1 = "s" Then
                l2 = "ñ"
                l1 = ""
            ElseIf l2 = "u" And l1 = "S" Then
                l2 = "ó"
                l1 = ""
            ElseIf l2 = "u" And l1 = "a" Then
                l2 = "ï"
                l1 = ""
            ElseIf l2 = "U" And l1 = "s" Then
                l2 = "ô"
                l1 = ""
            ElseIf l2 = "U" And l1 = "S" Then
                l2 = "ö"
                l1 = ""
            ElseIf l2 = "U" And l1 = "a" Then
                l2 = "ò"
                l1 = ""
            ElseIf l2 = "j" And l1 = "s" Then
                l2 = "ú"
                l1 = ""
            ElseIf l2 = "j" And l1 = "S" Then
                l2 = "ù"
                l1 = ""
            ElseIf l2 = "j" And l1 = "a" Then
                l2 = "õ"
                l1 = ""
            ElseIf l2 = "O" And l1 = "s" Then
                l2 = "ê"
                l1 = ""
            ElseIf l2 = "O" And l1 = "S" Then
                l2 = "ë"
                l1 = ""
            ElseIf l2 = "O" And l1 = "a" Then
                l2 = "è"
                l1 = ""
            ElseIf l2 = "o" And l1 = "%" Then
                l2 = "ø"
                l1 = ""
            ElseIf l2 = ":" And l1 = "s" Then
                l2 = "Ó"
                l1 = ""
            ElseIf l2 = ":" And l1 = "S" Then
                l2 = "Ò"
                l1 = ""
            ElseIf l2 = "P" And l1 = "s" Then
                l2 = "ý"
                l1 = ""
            ElseIf l2 = "P" And l1 = "S" Then
                l2 = "Â"
                l1 = ""
            ElseIf l2 = "P" And l1 = "a" Then
                l2 = "þ"
                l1 = ""
            ElseIf l2 = "c" And l1 = "s" Then
                l2 = "ð"
                l1 = ""
            ElseIf l2 = "c" And l1 = "S" Then
                l2 = "Ô"
                l1 = ""
            ElseIf l2 = "c" And l1 = "a" Then
                l2 = "Ê"
                l1 = ""
            ElseIf l2 = "~" And l1 = "s" Then
                l2 = "ç"
                l1 = ""
            ElseIf l2 = "~" And l1 = "S" Then
                l2 = "é"
                l1 = ""
            ElseIf l2 = "~" And l1 = "a" Then
                l2 = "å"
                l1 = ""
            ElseIf l2 = "K" And l1 = "s" Then
                l2 = "‚"
                l1 = ""
            ElseIf l2 = "K" And l1 = "S" Then
                l2 = "Œ"
                l1 = ""
            ElseIf l2 = "<" And l1 = "q" Then
                l2 = "¿"
                l1 = ""
            ElseIf l2 = "<" And l1 = "Q" Then
                l2 = "¿Q"
                l1 = ""
            ElseIf l2 = "M" And l1 = "s" Then
                l2 = "Ý"
                l1 = ""
            ElseIf l2 = "M" And l1 = "S" Then
                l2 = "Ú"
                l1 = ""
            ElseIf l2 = "|" And l1 = "q" Then
                l2 = "÷"
                l1 = ""
            ElseIf l2 = "|" And l1 = "Q" Then
                l2 = "ª"
                l1 = ""
            ElseIf l2 = "|" And l1 = "s" Then
                l2 = "¢"
                l1 = ""
            ElseIf l2 = "|" And l1 = "S" Then
                l2 = "£"
                l1 = ""
            ElseIf l2 = "o" And l1 = "S" Then
                l2 = "§"
                l1 = ""
            ElseIf l2 = "X" And l1 = "a" Then
                l2 = "Ù"
                l1 = ""
            ElseIf l2 = "M" And l1 = "a" Then
                l2 = "MA"
                l1 = ""
            ElseIf l2 = "V" And l1 = "a" Then
                l2 = "VA"
                l1 = ""
            ElseIf l2 = "V" And l1 = "s" Then
                l2 = "Î"
                l1 = ""
            ElseIf l2 = "V" And l1 = "S" Then
                l2 = "Ð"
                l1 = ""
            ElseIf l2 = "`" And l1 = "." Then
                l2 = "Õ"
                l1 = ""
            ElseIf l2 = "`" And l1 = "." Then
                l2 = "|"
                l1 = ""
            ElseIf l2 = "F" And l1 = "j" Then
                l2 = "…"
                l1 = ""
            ElseIf l2 = "o" And l1 = "H" Then
                l2 = "o"
                l1 = "H"
            ElseIf l2 = "H" And l1 = "_" Then
                l2 = "œ"
                l1 = ""
            End If
            txt_out = txt_out & l2
        Next
        Return txt_out
    End Function

End Class
