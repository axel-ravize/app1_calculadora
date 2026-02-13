Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonMas.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 + Numero2

        Label4.Text = Resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BotonMenos.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 - Numero2
        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BotonPor.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 * Numero2
        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BotonEntre.Click

        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)

        Dim Resultado As Integer = Numero1 / Numero2
        Label4.Text = Resultado.ToString()

    End Sub

    Private Sub Boton0_Click(sender As Object, e As EventArgs) Handles Boton0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Boton4_Click(sender As Object, e As EventArgs) Handles Boton4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Boton6_Click(sender As Object, e As EventArgs) Handles Boton6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Boton7_Click(sender As Object, e As EventArgs) Handles Boton7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Boton8_Click(sender As Object, e As EventArgs) Handles Boton8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Boton9_Click(sender As Object, e As EventArgs) Handles Boton9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub BotonBorrar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        TextBox1.Text = ""
    End Sub
End Class
