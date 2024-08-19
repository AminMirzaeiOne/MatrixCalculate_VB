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

    ' This method allows the user to customize the theme of the application.

    Private Sub QuestionTheme()
themeQ:
        ' Get user input for the application theme (Light or Dark).
        Console.Write("Select The App Theme (Light or Dark) : ")
        Dim theme As String = Console.ReadLine().Trim().ToLower()
        ' Use a Select Case statement to handle different theme choices.
        Select Case theme
            Case "light"
                ' Set console background color to white and text color to black for light theme.
                Console.BackgroundColor = ConsoleColor.White
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Black
            Case "dark"
                ' Set console background color to black and text color to white for dark theme.
                Console.BackgroundColor = ConsoleColor.Black
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.White
            Case Else
                ' Display error message for invalid theme selection.
                Console.BackgroundColor = ConsoleColor.Red
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("The entered theme is invalid and not supported")
                Console.ResetColor()
                Console.ReadKey()
                ' Use a GoTo statement to loop back to the theme selection prompt (not recommended practice).
                GoTo themeQ
        End Select
themeColor:
        ' Get user input for the application theme color (Blue, Green, Yellow, or Red).
        Console.Write("Select The App Theme Color (Blue or Green or Yellow or Red) : ")
        Dim color As String = Console.ReadLine().Trim().ToLower()

        ' Use another Select Case statement to handle different theme color choices.
        Select Case color
            Case "blue"
                Console.ForegroundColor = ConsoleColor.DarkCyan  ' Set text color to dark cyan.
            Case "green"
                Console.ForegroundColor = ConsoleColor.Green   ' Set text color to green.
            Case "red"
                Console.ForegroundColor = ConsoleColor.Red     ' Set text color to red.
            Case "yellow"
                Console.ForegroundColor = ConsoleColor.Yellow   ' Set text color to yellow.
            Case Else
                ' Display error message for invalid theme color selection.
                Console.BackgroundColor = ConsoleColor.Red
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("The entered theme color is invalid and not supported")
                Console.ResetColor()
                Console.ReadKey()
                ' Use a GoTo statement to loop back to the theme color selection prompt (not recommended practice).
                GoTo themeColor
        End Select

    End Sub

End Module