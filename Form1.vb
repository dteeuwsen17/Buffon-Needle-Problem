Imports System.Math

Public Class Form1
    Dim g As Graphics

    Private Sub Simulate_Click(sender As Object, e As EventArgs) Handles Simulate.Click
        Initialize()
        DrawFunction()
        FindProbability()
    End Sub

    Sub Initialize()
        g = Graph.CreateGraphics
        g.Clear(Color.White)
    End Sub

    Sub DrawFunction()
        Dim i As Integer
        Dim x, y As Double
        Dim Horizontal, Vertical As Integer
        Dim SilverFill As SolidBrush = New SolidBrush(Color.Silver)

        For i = 0 To Graph.Width
            x = PI * i / Graph.Width
            y = f(x)
            Horizontal = ConvertX(x)
            Vertical = ConvertY(y)
            g.FillRectangle(SilverFill, Horizontal, Vertical, 2, Graph.Height)
        Next

    End Sub


    Function ConvertX(ByVal x As Double) As Integer

        Return ((x - 0) / (PI - 0)) * Graph.Width

    End Function


    Function ConvertY(ByVal y As Double) As Integer

        Return (1 - (y - 0) / (0.5 - 0)) * Graph.Height

    End Function


    Sub FindProbability()
        Dim Total As Long = 0
        Dim Inside As Long = 0
        Dim x, y As Double
        Dim Horizontal, Vertical As Integer
        Dim blueFill As SolidBrush = New SolidBrush(Color.DarkBlue)
        Dim greenFill As SolidBrush = New SolidBrush(Color.Green)
        Dim Probability As Double
        Dim Bound As Integer
        Bound = NumPoints.Text

        For Total = 1 To Bound
            Application.DoEvents()
            x = Rnd() * PI
            y = Rnd() * 0.5
            Horizontal = ConvertX(x)
            Vertical = ConvertY(y)

            If y < f(x) Then
                g.FillRectangle(greenFill, Horizontal, Vertical, 3, 3)
                Inside = Inside + 1
                Probability = (Inside / Total)
                Prob.Text = Probability
                Prob.Refresh()
            Else
                g.FillRectangle(blueFill, Horizontal, Vertical, 3, 3)
            End If

        Next
    End Sub

    Function f(ByVal x As Double) As Double
        Return Sin(x) / 4
    End Function

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        End
    End Sub
End Class

