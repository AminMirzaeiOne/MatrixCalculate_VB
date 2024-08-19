Imports System

Module Module1

    Sub Main()
        ' Declare variables for the number of rows and columns.
        Dim rows As Integer, cols As Integer

        ' Get the dimensions of the matrix from the user.
        Console.Write("Enter the number of rows: ")
        rows = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter the number of columns: ")
        cols = Convert.ToInt32(Console.ReadLine())

        ' Create a 2D array to represent the matrix.
        Dim matrix(rows - 1, cols - 1) As Integer

        ' Get the elements of the matrix from the user.
        Console.WriteLine("Enter the elements of the matrix:")
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

End Module