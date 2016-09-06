Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles lbTitulo.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
    ''' <summary>
    ''' Hear My Name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC1_Click(sender As Object, e As EventArgs) Handles btnVerC1.Click
        lbTitulo.Text = "Hear My Name"
        lbArtista.Text = "Armand Helden"
        lbPrecio.Text = "S/. 5.50"
        pbCover.Image = ImageList1.Images.Item(0)


    End Sub
    ''' <summary>
    ''' One More Time
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC2_Click(sender As Object, e As EventArgs) Handles btnVerC2.Click
        lbTitulo.Text = "One More Time"
        lbArtista.Text = "Daft Punk"
        lbPrecio.Text = "S/. 5.00"
        pbCover.Image = ImageList1.Images.Item(1)
    End Sub
    ''' <summary>
    ''' Anciente History
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC3_Click(sender As Object, e As EventArgs) Handles btnVerC3.Click
        lbTitulo.Text = "Ancient History"
        lbArtista.Text = "The Cribs"
        lbPrecio.Text = "S/. 6.00"
        pbCover.Image = ImageList1.Images.Item(2)
    End Sub
    ''' <summary>
    ''' Together
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC4_Click(sender As Object, e As EventArgs) Handles btnVerC4.Click
        lbTitulo.Text = "Together"
        lbArtista.Text = "Chukie"
        lbPrecio.Text = "S/. 4.50"
        pbCover.Image = ImageList1.Images.Item(3)
    End Sub

    Private Sub btnComprarC1_Click(sender As Object, e As EventArgs) Handles btnComprarC1.Click

    End Sub

    Private Sub btnComprarC2_Click(sender As Object, e As EventArgs) Handles btnComprarC2.Click

    End Sub

    Private Sub btnComprarC3_Click(sender As Object, e As EventArgs) Handles btnComprarC3.Click

    End Sub

    Private Sub btnComprarC4_Click(sender As Object, e As EventArgs) Handles btnComprarC4.Click

    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub
End Class