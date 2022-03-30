Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollLabel.Text = ""
        Dim randomNumbers(12) As Integer
        Dim temp As String
        Dim seperator As String = " |"
        Dim padLength As Integer = 5
        Dim lineSeperator As String = "-"
        Dim lineLength As Integer = padLength * (UBound(randomNumbers) + 1)

        'count random numbers
        For i = 1 To 1000
            randomNumbers(GetRandomInteger()) += 1
        Next

        'display random number count(s)
        'headers
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(i) & seperator
            temp = temp.PadLeft(padLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        'display contents of randomNumbers() array
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(randomNumbers(i)) & seperator
            temp = temp.PadLeft(padLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        Console.Read()
    End Sub

    Function GetRandomInteger() As Integer
        Dim value As Integer
        Dim temp As Single
        ' Initialize the random-number generator.
        Randomize()
        temp = (Rnd() * 11) + 2
        value = CInt(System.Math.Floor(CDbl(temp)))

        'Console.WriteLine(temp)
        'Console.WriteLine(value)
        ' Generate random value between 1 and 6.
        ' Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value
    End Function

    Private Sub RollLabel_Click(sender As Object, e As EventArgs) Handles RollLabel.Click

    End Sub
End Class
