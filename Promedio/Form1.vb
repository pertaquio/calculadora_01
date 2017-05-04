Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, n3, PT, PROM As Integer
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        n3 = Val(TextBox3.Text)

        PT = n1 + n2 + n3

        TextBox4.Text = PT

        PROM = PT / 3

        Me.TextBox4.Text = PROM
        If PROM >= 0 And PROM < 10 Then
            Label6.Text = "Desaprobado"
        Else
            If PROM >= 11 And PROM < 20 Then
                Label6.Text = "Aprobado"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim AvisoSalida As String
        AvisoSalida = MsgBox("Realmente desea salir", MsgBoxStyle.YesNo, "Salir")
        If AvisoSalida = 6 Then
            End
        End If

    End Sub
End Class
