<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Penjualan = New System.Windows.Forms.Label()
        Me.lblKodejual = New System.Windows.Forms.Label()
        Me.LblNamabarang = New System.Windows.Forms.Label()
        Me.lblbanyakbarang = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.txtKodeJual = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtBanyakbrg = New System.Windows.Forms.TextBox()
        Me.txtHargastn = New System.Windows.Forms.TextBox()
        Me.Cek = New System.Windows.Forms.Button()
        Me.Hasil = New System.Windows.Forms.TextBox()
        Me.ckbl = New System.Windows.Forms.TextBox()
        Me.cekbeli = New System.Windows.Forms.Button()
        Me.txtbeli4 = New System.Windows.Forms.TextBox()
        Me.txtbeli3 = New System.Windows.Forms.TextBox()
        Me.txtbeli2 = New System.Windows.Forms.TextBox()
        Me.txtbeli1 = New System.Windows.Forms.TextBox()
        Me.lblbelihrga = New System.Windows.Forms.Label()
        Me.lblbelibanyak = New System.Windows.Forms.Label()
        Me.lblbelibrg = New System.Windows.Forms.Label()
        Me.lblbeli = New System.Windows.Forms.Label()
        Me.Pembelian = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JualToolStripMenuItem, Me.BeliToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'JualToolStripMenuItem
        '
        Me.JualToolStripMenuItem.Name = "JualToolStripMenuItem"
        Me.JualToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.JualToolStripMenuItem.Text = "Jual"
        '
        'BeliToolStripMenuItem
        '
        Me.BeliToolStripMenuItem.Name = "BeliToolStripMenuItem"
        Me.BeliToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.BeliToolStripMenuItem.Text = "Beli"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(883, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Penjualan
        '
        Me.Penjualan.AutoSize = True
        Me.Penjualan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Penjualan.Location = New System.Drawing.Point(368, 37)
        Me.Penjualan.Name = "Penjualan"
        Me.Penjualan.Padding = New System.Windows.Forms.Padding(10)
        Me.Penjualan.Size = New System.Drawing.Size(130, 47)
        Me.Penjualan.TabIndex = 1
        Me.Penjualan.Text = "Penjualan"
        '
        'lblKodejual
        '
        Me.lblKodejual.AutoSize = True
        Me.lblKodejual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblKodejual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodejual.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblKodejual.Location = New System.Drawing.Point(71, 109)
        Me.lblKodejual.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblKodejual.Name = "lblKodejual"
        Me.lblKodejual.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblKodejual.Size = New System.Drawing.Size(150, 20)
        Me.lblKodejual.TabIndex = 2
        Me.lblKodejual.Text = "Kode Penjualan"
        '
        'LblNamabarang
        '
        Me.LblNamabarang.AutoSize = True
        Me.LblNamabarang.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LblNamabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamabarang.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LblNamabarang.Location = New System.Drawing.Point(71, 140)
        Me.LblNamabarang.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblNamabarang.Name = "LblNamabarang"
        Me.LblNamabarang.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.LblNamabarang.Size = New System.Drawing.Size(137, 20)
        Me.LblNamabarang.TabIndex = 3
        Me.LblNamabarang.Text = "Nama Barang"
        '
        'lblbanyakbarang
        '
        Me.lblbanyakbarang.AutoSize = True
        Me.lblbanyakbarang.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbanyakbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbanyakbarang.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblbanyakbarang.Location = New System.Drawing.Point(71, 171)
        Me.lblbanyakbarang.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblbanyakbarang.Name = "lblbanyakbarang"
        Me.lblbanyakbarang.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblbanyakbarang.Size = New System.Drawing.Size(148, 20)
        Me.lblbanyakbarang.TabIndex = 4
        Me.lblbanyakbarang.Text = "Banyak Barang"
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblharga.Location = New System.Drawing.Point(71, 203)
        Me.lblharga.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblharga.Size = New System.Drawing.Size(139, 20)
        Me.lblharga.TabIndex = 5
        Me.lblharga.Text = "Harga Satuan"
        '
        'txtKodeJual
        '
        Me.txtKodeJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeJual.Location = New System.Drawing.Point(241, 106)
        Me.txtKodeJual.Name = "txtKodeJual"
        Me.txtKodeJual.Size = New System.Drawing.Size(325, 26)
        Me.txtKodeJual.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(241, 137)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(325, 26)
        Me.txtNama.TabIndex = 7
        '
        'txtBanyakbrg
        '
        Me.txtBanyakbrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanyakbrg.Location = New System.Drawing.Point(241, 168)
        Me.txtBanyakbrg.Name = "txtBanyakbrg"
        Me.txtBanyakbrg.Size = New System.Drawing.Size(325, 26)
        Me.txtBanyakbrg.TabIndex = 8
        '
        'txtHargastn
        '
        Me.txtHargastn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargastn.Location = New System.Drawing.Point(241, 200)
        Me.txtHargastn.Name = "txtHargastn"
        Me.txtHargastn.Size = New System.Drawing.Size(325, 26)
        Me.txtHargastn.TabIndex = 9
        '
        'Cek
        '
        Me.Cek.Location = New System.Drawing.Point(241, 233)
        Me.Cek.Name = "Cek"
        Me.Cek.Size = New System.Drawing.Size(325, 32)
        Me.Cek.TabIndex = 10
        Me.Cek.Text = "Cek >>"
        Me.Cek.UseVisualStyleBackColor = True
        '
        'Hasil
        '
        Me.Hasil.Location = New System.Drawing.Point(606, 106)
        Me.Hasil.Multiline = True
        Me.Hasil.Name = "Hasil"
        Me.Hasil.ReadOnly = True
        Me.Hasil.Size = New System.Drawing.Size(241, 120)
        Me.Hasil.TabIndex = 11
        '
        'ckbl
        '
        Me.ckbl.Location = New System.Drawing.Point(606, 106)
        Me.ckbl.Multiline = True
        Me.ckbl.Name = "ckbl"
        Me.ckbl.ReadOnly = True
        Me.ckbl.Size = New System.Drawing.Size(241, 120)
        Me.ckbl.TabIndex = 22
        '
        'cekbeli
        '
        Me.cekbeli.Location = New System.Drawing.Point(241, 233)
        Me.cekbeli.Name = "cekbeli"
        Me.cekbeli.Size = New System.Drawing.Size(325, 32)
        Me.cekbeli.TabIndex = 21
        Me.cekbeli.Text = "Cek >>"
        Me.cekbeli.UseVisualStyleBackColor = True
        '
        'txtbeli4
        '
        Me.txtbeli4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeli4.Location = New System.Drawing.Point(241, 200)
        Me.txtbeli4.Name = "txtbeli4"
        Me.txtbeli4.Size = New System.Drawing.Size(325, 26)
        Me.txtbeli4.TabIndex = 20
        '
        'txtbeli3
        '
        Me.txtbeli3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeli3.Location = New System.Drawing.Point(241, 168)
        Me.txtbeli3.Name = "txtbeli3"
        Me.txtbeli3.Size = New System.Drawing.Size(325, 26)
        Me.txtbeli3.TabIndex = 19
        '
        'txtbeli2
        '
        Me.txtbeli2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeli2.Location = New System.Drawing.Point(241, 137)
        Me.txtbeli2.Name = "txtbeli2"
        Me.txtbeli2.Size = New System.Drawing.Size(325, 26)
        Me.txtbeli2.TabIndex = 18
        '
        'txtbeli1
        '
        Me.txtbeli1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbeli1.Location = New System.Drawing.Point(241, 106)
        Me.txtbeli1.Name = "txtbeli1"
        Me.txtbeli1.Size = New System.Drawing.Size(325, 26)
        Me.txtbeli1.TabIndex = 17
        '
        'lblbelihrga
        '
        Me.lblbelihrga.AutoSize = True
        Me.lblbelihrga.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbelihrga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbelihrga.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblbelihrga.Location = New System.Drawing.Point(71, 203)
        Me.lblbelihrga.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblbelihrga.Name = "lblbelihrga"
        Me.lblbelihrga.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblbelihrga.Size = New System.Drawing.Size(139, 20)
        Me.lblbelihrga.TabIndex = 16
        Me.lblbelihrga.Text = "Harga Satuan"
        '
        'lblbelibanyak
        '
        Me.lblbelibanyak.AutoSize = True
        Me.lblbelibanyak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbelibanyak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbelibanyak.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblbelibanyak.Location = New System.Drawing.Point(71, 171)
        Me.lblbelibanyak.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblbelibanyak.Name = "lblbelibanyak"
        Me.lblbelibanyak.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblbelibanyak.Size = New System.Drawing.Size(148, 20)
        Me.lblbelibanyak.TabIndex = 15
        Me.lblbelibanyak.Text = "Banyak Barang"
        '
        'lblbelibrg
        '
        Me.lblbelibrg.AutoSize = True
        Me.lblbelibrg.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbelibrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbelibrg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblbelibrg.Location = New System.Drawing.Point(71, 140)
        Me.lblbelibrg.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblbelibrg.Name = "lblbelibrg"
        Me.lblbelibrg.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblbelibrg.Size = New System.Drawing.Size(137, 20)
        Me.lblbelibrg.TabIndex = 14
        Me.lblbelibrg.Text = "Nama Barang"
        '
        'lblbeli
        '
        Me.lblbeli.AutoSize = True
        Me.lblbeli.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbeli.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblbeli.Location = New System.Drawing.Point(71, 109)
        Me.lblbeli.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblbeli.Name = "lblbeli"
        Me.lblbeli.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblbeli.Size = New System.Drawing.Size(154, 20)
        Me.lblbeli.TabIndex = 13
        Me.lblbeli.Text = "Kode Pembelian"
        '
        'Pembelian
        '
        Me.Pembelian.AutoSize = True
        Me.Pembelian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pembelian.Location = New System.Drawing.Point(368, 37)
        Me.Pembelian.Name = "Pembelian"
        Me.Pembelian.Padding = New System.Windows.Forms.Padding(10)
        Me.Pembelian.Size = New System.Drawing.Size(135, 47)
        Me.Pembelian.TabIndex = 12
        Me.Pembelian.Text = "Pembelian"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 292)
        Me.Controls.Add(Me.ckbl)
        Me.Controls.Add(Me.cekbeli)
        Me.Controls.Add(Me.txtbeli4)
        Me.Controls.Add(Me.txtbeli3)
        Me.Controls.Add(Me.txtbeli2)
        Me.Controls.Add(Me.txtbeli1)
        Me.Controls.Add(Me.lblbelihrga)
        Me.Controls.Add(Me.lblbelibanyak)
        Me.Controls.Add(Me.lblbelibrg)
        Me.Controls.Add(Me.lblbeli)
        Me.Controls.Add(Me.Pembelian)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.Cek)
        Me.Controls.Add(Me.txtHargastn)
        Me.Controls.Add(Me.txtBanyakbrg)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKodeJual)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.lblbanyakbarang)
        Me.Controls.Add(Me.LblNamabarang)
        Me.Controls.Add(Me.lblKodejual)
        Me.Controls.Add(Me.Penjualan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Aplikasi Kasir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Penjualan As Label
    Friend WithEvents lblKodejual As Label
    Friend WithEvents LblNamabarang As Label
    Friend WithEvents lblbanyakbarang As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents txtKodeJual As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtBanyakbrg As TextBox
    Friend WithEvents txtHargastn As TextBox
    Friend WithEvents Cek As Button
    Friend WithEvents Hasil As TextBox
    Friend WithEvents ckbl As TextBox
    Friend WithEvents cekbeli As Button
    Friend WithEvents txtbeli4 As TextBox
    Friend WithEvents txtbeli3 As TextBox
    Friend WithEvents txtbeli2 As TextBox
    Friend WithEvents txtbeli1 As TextBox
    Friend WithEvents lblbelihrga As Label
    Friend WithEvents lblbelibanyak As Label
    Friend WithEvents lblbelibrg As Label
    Friend WithEvents lblbeli As Label
    Friend WithEvents Pembelian As Label
End Class
