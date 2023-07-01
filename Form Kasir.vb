Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        Call KunciJual()
        Call Kuncibeli()

    End Sub
    Public Sub KunciJual()
        Penjualan.Visible = False
        lblbanyakbarang.Visible = False
        lblharga.Visible = False
        lblKodejual.Visible = False
        LblNamabarang.Visible = False
        Cek.Visible = False
        Hasil.Visible = False
        txtBanyakbrg.Visible = False
        txtHargastn.Visible = False
        txtKodeJual.Visible = False
        txtNama.Visible = False

    End Sub
    Public Sub Kuncibeli()
        Pembelian.Visible = False
        lblbeli.Visible = False
        lblbelibanyak.Visible = False
        lblbelibrg.Visible = False
        lblbelihrga.Visible = False
        cekbeli.Visible = False
        ckbl.Visible = False
        txtbeli1.Visible = False
        txtbeli2.Visible = False
        txtbeli3.Visible = False
        txtbeli4.Visible = False

    End Sub
    Public Sub BukaJual()
        Penjualan.Visible = True
        lblbanyakbarang.Visible = True
        lblharga.Visible = True
        lblKodejual.Visible = True
        LblNamabarang.Visible = True
        Cek.Visible = True
        Hasil.Visible = True
        txtBanyakbrg.Visible = True
        txtHargastn.Visible = True
        txtKodeJual.Visible = True
        txtNama.Visible = True

    End Sub
    Public Sub bukabeli()
        Pembelian.Visible = True
        lblbeli.Visible = True
        lblbelibanyak.Visible = True
        lblbelibrg.Visible = True
        lblbelihrga.Visible = True
        cekbeli.Visible = True
        ckbl.Visible = True
        txtbeli1.Visible = True
        txtbeli2.Visible = True
        txtbeli3.Visible = True
        txtbeli4.Visible = True
    End Sub
    Public Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False

    End Sub
    Public Sub Terbuka()
        LoginToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = True
        TransaksiToolStripMenuItem.Visible = True
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Menu_Login.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
        Call KunciJual()
        Call Kuncibeli()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblKodejual.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblNamabarang.Click

    End Sub

    Private Sub JualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JualToolStripMenuItem.Click
        Call BukaJual()
        Call Kuncibeli()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Hasil_TextChanged(sender As Object, e As EventArgs) Handles Hasil.TextChanged
    End Sub

    Private Sub Cek_Click(sender As Object, e As EventArgs) Handles Cek.Click
        Dim HASILa As String
        HASILa = txtHargastn.Text * txtBanyakbrg.Text
        Hasil.Text = "Kode Penjualan : " + txtKodeJual.Text + Environment.NewLine + "Nama Barang    : " + txtNama.Text +
            Environment.NewLine + "Banyak Barang  : " + txtBanyakbrg.Text + Environment.NewLine + "Harga Satuan     : " + txtHargastn.Text +
        Environment.NewLine + "Total Semuanya  : " + HASILa

    End Sub

    Private Sub txtBanyakbrg_KeyPress(sender As Object, e As EventArgs) Handles txtBanyakbrg.KeyPress
        NumberOnly(e)

    End Sub
    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtHargastn_KeyPress(sender As Object, e As EventArgs) Handles txtHargastn.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub txtHargastn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargastn.KeyPress

    End Sub

    Private Sub txtBanyakbrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBanyakbrg.KeyPress

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Pembelian.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cekbeli.Click
        Dim HASILb As String
        HASILb = txtbeli3.Text * txtbeli4.Text
        ckbl.Text = "Kode Pembelian : " + txtbeli1.Text + Environment.NewLine + "Nama Barang    : " + txtbeli2.Text +
            Environment.NewLine + "Banyak Barang  : " + txtbeli3.Text + Environment.NewLine + "Harga Satuan     : " + txtbeli4.Text +
        Environment.NewLine + "Total Semuanya  : " + HASILb
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As EventArgs) Handles txtbeli4.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As EventArgs) Handles txtbeli3.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtbeli2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtbeli1.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblbelihrga.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lblbelibanyak.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblbelibrg.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblbeli.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ckbl.TextChanged

    End Sub

    Private Sub BeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeliToolStripMenuItem.Click
        Call KunciJual()
        Call bukabeli()
    End Sub
End Class
