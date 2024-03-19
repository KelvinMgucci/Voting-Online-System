Imports System.IO.Pipes

Public Class Form1

    Function Verify(Marks As Double) As String
        Dim results As String
        If Marks >= 0 And Marks <= 100 Then
            Dim ans As Double
            If ans >= 40 Then
                MsgBox("Pass")
            ElseIf ans <= 40 Then
                MsgBox("Fail")
            End If
        Else
            MessageBox.Show("Enter the correct marks")
        End If

    End Function

    Function Quotient(x As Integer, y As Integer) As Double
        Dim rls As Double
        rls = x / y
        Return rls
    End Function

    Public Sub Power(ByVal a As Integer, B As Integer)
        MsgBox(a ^ B)

    End Sub

    Public Sub Kevoo(a As Integer, b As Integer)
        MsgBox(a + b)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(CByte(134))


    End Sub
End Class
