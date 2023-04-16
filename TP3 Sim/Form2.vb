Imports System.Runtime.CompilerServices

Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InitializeComponent()

    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Dim ventana As New Form1
        Form1.ShowDialog()
        Me.Hide()
    End Sub
End Class