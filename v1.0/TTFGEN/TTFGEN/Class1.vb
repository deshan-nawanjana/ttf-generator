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
                l2 = "�"
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
                l2 = "�"
                l1 = ""
            ElseIf l2 = "o" And l1 = "Q" Then
                l2 = "�"
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
                l2 = "�"
                l1 = ""
            ElseIf l2 = "r" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "r" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "r" And l1 = "e" Then
                l2 = "/"
                l1 = ""
            ElseIf l2 = "r" And l1 = "E" Then
                l2 = "?"
                l1 = ""
            ElseIf l2 = "r" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "," And l1 = "q" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "," And l1 = "Q" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "n" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "n" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "n" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "p" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "p" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "p" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "g" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "g" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "g" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "v" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "v" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "v" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "L" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "L" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "L" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "u" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "u" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "u" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "U" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "U" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "U" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "j" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "j" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "j" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "O" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "O" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "O" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "o" And l1 = "%" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = ":" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = ":" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "P" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "P" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "P" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "c" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "c" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "c" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "~" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "~" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "~" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "K" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "K" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "<" And l1 = "q" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "<" And l1 = "Q" Then
                l2 = "�Q"
                l1 = ""
            ElseIf l2 = "M" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "M" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "|" And l1 = "q" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "|" And l1 = "Q" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "|" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "|" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "o" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "X" And l1 = "a" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "M" And l1 = "a" Then
                l2 = "MA"
                l1 = ""
            ElseIf l2 = "V" And l1 = "a" Then
                l2 = "VA"
                l1 = ""
            ElseIf l2 = "V" And l1 = "s" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "V" And l1 = "S" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "`" And l1 = "." Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "`" And l1 = "." Then
                l2 = "|"
                l1 = ""
            ElseIf l2 = "F" And l1 = "j" Then
                l2 = "�"
                l1 = ""
            ElseIf l2 = "o" And l1 = "H" Then
                l2 = "o"
                l1 = "H"
            ElseIf l2 = "H" And l1 = "_" Then
                l2 = "�"
                l1 = ""
            End If
            txt_out = txt_out & l2
        Next
        Return txt_out
    End Function

End Class
