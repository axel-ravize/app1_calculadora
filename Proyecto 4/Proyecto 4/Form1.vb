Public Class Form1
    Dim Activo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonMas.Click

        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 + Numero2

        Label4.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonMenos.Click

        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 - Numero2
        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BotonPor.Click

        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        Dim Resultado As Double = Numero1 * Numero2
        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BotonEntre.Click

        Dim Resultado

        Dim Numero1 As Double = Double.Parse(TextBox1.Text)
        Dim Numero2 As Double = Double.Parse(TextBox2.Text)

        If Numero2 > 0 Then
            Resultado = Numero1 / Numero2
        Else
            Resultado = "No se puede"
        End If

        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Boton0_Click(sender As Object, e As EventArgs) Handles Boton0.Click
        Activo.Text = Activo.Text & "0"
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Activo.Text = Activo.Text & "1"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        Activo.Text = Activo.Text & "2"
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        Activo.Text = Activo.Text & "3"
    End Sub

    Private Sub Boton4_Click(sender As Object, e As EventArgs) Handles Boton4.Click
        Activo.Text = Activo.Text & "4"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        Activo.Text = Activo.Text & "5"
    End Sub

    Private Sub Boton6_Click(sender As Object, e As EventArgs) Handles Boton6.Click
        Activo.Text = Activo.Text & "6"
    End Sub

    Private Sub Boton7_Click(sender As Object, e As EventArgs) Handles Boton7.Click
        Activo.Text = Activo.Text & "7"
    End Sub

    Private Sub Boton8_Click(sender As Object, e As EventArgs) Handles Boton8.Click
        Activo.Text = Activo.Text & "8"
    End Sub

    Private Sub Boton9_Click(sender As Object, e As EventArgs) Handles Boton9.Click
        Activo.Text = Activo.Text & "9"
    End Sub

    Private Sub BotonBorrar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        Activo.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Activo.Text = Activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Activo = TextBox2
    End Sub
End Class
