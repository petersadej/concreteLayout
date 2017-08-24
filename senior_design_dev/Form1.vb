Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Dim blueBrush As New SolidBrush(Color.Blue)
        'e.Graphics.FillRectangle(blueBrush, 20, 30, 100, 100)
    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim blueBrush As New SolidBrush(Color.Blue)
        e.Graphics.FillRectangle(blueBrush, 0, 0, 100, 100)
    End Sub
End Class
