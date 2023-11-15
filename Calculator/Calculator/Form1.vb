Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cong.Click
        Dim a = Double.Parse(TextBox1.Text)
        Dim b = Double.Parse(TextBox2.Text)
        Dim c = a + b
        kq.Text = c.ToString()







    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = Double.Parse(TextBox1.Text)
        Dim b = Double.Parse(TextBox2.Text)
        Dim c = a - b
        kq.Text = c.ToString()

    End Sub
End Class
