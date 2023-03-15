Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumeros.TextChanged

    End Sub

    Private Sub btnIdentificar_Click_1(sender As Object, e As EventArgs) Handles btnIdentificar.Click
        ' Obtener el arreglo de enteros desde el cuadro de texto
        Dim numeros As Integer() = txtNumeros.Text.Split(","c).Select(Function(str) Integer.Parse(str)).ToArray()

        ' Mostrar la cantidad de elementos en el arreglo
        MessageBox.Show($"El arreglo tiene {numeros.Length} elementos.")

        ' Mostrar el elemento más grande del arreglo
        MessageBox.Show($"El elemento más grande del arreglo es {numeros.Max()}.")

        ' Mostrar el elemento más pequeño del arreglo
        MessageBox.Show($"El elemento más pequeño del arreglo es {numeros.Min()}.")
    End Sub
End Class

