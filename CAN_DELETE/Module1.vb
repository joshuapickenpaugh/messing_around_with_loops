'Joshua Pickenpaugh

Module Module1

    Sub Main()

        'Declare single-dim array:
        Dim numbers = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}

        'Loop:
        For Each number As Integer In numbers
            If (number Mod 2 = 0) Then
                Console.Write(number & " ")
            End If
        Next

        Console.WriteLine()

        For Each number As Integer In numbers
            If (number Mod 5 = 0) Then
                Console.Write(number & " ")
            End If
        Next

        Console.WriteLine()

        For x As Integer = 1 To 100
            If (x Mod 20 = 0) Then
                Console.WriteLine("FOO")
            ElseIf (x Mod 21 = 0) Then
                Console.WriteLine("FIGHTER")
            End If
        Next

        For y As Integer = 1 To 500
            If (y * y = 4 OrElse y * y = 16) Then
                Console.WriteLine("WOWSERS!!!")
            End If
        Next

        Console.ReadKey()

    End Sub

End Module
