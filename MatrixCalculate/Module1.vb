Imports System

Module Module1

    Sub Main()
        ' Declare variables for the number of rows and columns.
        Dim rows As Integer, cols As Integer

        QuestionTheme()

        ' Get the dimensions of the matrix from the user.
        Console.Write("Enter the number of rows: ")
        rows = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter the number of columns: ")
        cols = Convert.ToInt32(Console.ReadLine())

        ' Create a 2D array to represent the matrix.
        Dim matrix(rows - 1, cols - 1) As Integer

        ' Get the elements of the matrix from the user.
        Console.Write("Enter the elements of the matrix:")
        For i As Integer = 0 To rows - 1
            For j As Integer = 0 To cols - 1
                matrix(i, j) = Convert.ToInt32(Console.ReadLine())
            Next
        Next

        ' Calculate the sum of all elements.
        Dim sumTotal As Integer = 0
        For i As Integer = 0 To rows - 1
            For j As Integer = 0 To cols - 1
                sumTotal += matrix(i, j)
            Next
        Next
        Console.WriteLine("Sum of all elements: " & sumTotal)

        ' Calculate the sum of the main diagonal elements.
        Dim sumDiagonal As Integer = 0
        For i As Integer = 0 To Math.Min(rows, cols) - 1
            sumDiagonal += matrix(i, i)
        Next
        Console.WriteLine("Sum of main diagonal elements: " & sumDiagonal)

        ' Calculate the sum of elements above the main diagonal.
        Dim sumAboveDiagonal As Integer = 0
        For i As Integer = 0 To rows - 1
            For j As Integer = i + 1 To cols - 1
                sumAboveDiagonal += matrix(i, j)
            Next
        Next
        Console.WriteLine("Sum of elements above the main diagonal: " & sumAboveDiagonal)

        ' Calculate the sum of elements below the main diagonal.
        Dim sumBelowDiagonal As Integer = 0
        For i As Integer = 1 To rows - 1  ' Start from 1 to avoid accessing (0,0)
            For j As Integer = 0 To i - 1
                sumBelowDiagonal += matrix(i, j)
            Next
        Next
        Console.WriteLine("Sum of elements below the main diagonal: " & sumBelowDiagonal)

        Console.ReadLine()
    End Sub

    Private Sub QuestionTheme()
theme:
        System.Console.Write("Select The App Theme (Light or Dark) : ")
        Dim theme As String = System.Console.ReadLine().Trim().ToLower()
        Select Case theme
            Case "light"
                System.Console.BackgroundColor = ConsoleColor.White
                System.Console.Clear()
                System.Console.ForegroundColor = ConsoleColor.Black
            Case "dark"
                System.Console.BackgroundColor = ConsoleColor.Black
                System.Console.Clear()
                System.Console.ForegroundColor = ConsoleColor.White
            Case Else
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.WriteLine("The entered theme is invalid and not supported")
                System.Console.ReadKey()
                GoTo theme
        End Select
theColor:
        System.Console.Write("Select The App Theme Color (Blue or Green or Yellow or Red) : ")
        Dim color As String = System.Console.ReadLine().Trim().ToLower()
        Select Case color
            Case "blue"
                System.Console.ForegroundColor = ConsoleColor.DarkCyan
            Case "green"
                System.Console.ForegroundColor = ConsoleColor.Green
            Case "red"
                System.Console.ForegroundColor = ConsoleColor.Red
            Case "yellow"
                System.Console.ForegroundColor = ConsoleColor.Yellow
            Case Else
                System.Console.BackgroundColor = ConsoleColor.Red
                System.Console.ForegroundColor = ConsoleColor.White
                System.Console.WriteLine("The entered theme color is invalid and not supported")
                System.Console.ReadKey()
                GoTo theColor
        End Select

    End Sub

End Module