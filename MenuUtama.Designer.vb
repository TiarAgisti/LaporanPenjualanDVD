﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stKodePegawai = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stNamaPegawai = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stHakAkses = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPenjualanHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPenjualanDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBarangMasukHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaeangMasukDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLapPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLapBrgMsk = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLapReturPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLapStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPengaturan = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGantiPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(15, 20)
        Me.ToolStripStatusLabel1.Text = "||"
        '
        'stKodePegawai
        '
        Me.stKodePegawai.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stKodePegawai.ForeColor = System.Drawing.SystemColors.Window
        Me.stKodePegawai.Name = "stKodePegawai"
        Me.stKodePegawai.Size = New System.Drawing.Size(76, 20)
        Me.stKodePegawai.Text = "KODE PEGAWAI"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stKodePegawai, Me.ToolStripStatusLabel1, Me.stNamaPegawai, Me.ToolStripStatusLabel2, Me.stHakAkses, Me.ToolStripStatusLabel3, Me.stTanggal, Me.ToolStripStatusLabel4, Me.stJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 396)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1080, 25)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stNamaPegawai
        '
        Me.stNamaPegawai.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stNamaPegawai.ForeColor = System.Drawing.SystemColors.Window
        Me.stNamaPegawai.Name = "stNamaPegawai"
        Me.stNamaPegawai.Size = New System.Drawing.Size(79, 20)
        Me.stNamaPegawai.Text = "NAMA PEGAWAI"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(15, 20)
        Me.ToolStripStatusLabel2.Text = "||"
        '
        'stHakAkses
        '
        Me.stHakAkses.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stHakAkses.ForeColor = System.Drawing.SystemColors.Window
        Me.stHakAkses.Name = "stHakAkses"
        Me.stHakAkses.Size = New System.Drawing.Size(59, 20)
        Me.stHakAkses.Text = "HAK AKSES"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(15, 20)
        Me.ToolStripStatusLabel3.Text = "||"
        '
        'stTanggal
        '
        Me.stTanggal.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stTanggal.ForeColor = System.Drawing.SystemColors.Window
        Me.stTanggal.Name = "stTanggal"
        Me.stTanggal.Size = New System.Drawing.Size(49, 20)
        Me.stTanggal.Text = "TANGGAL"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(15, 20)
        Me.ToolStripStatusLabel4.Text = "||"
        '
        'stJam
        '
        Me.stJam.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stJam.ForeColor = System.Drawing.SystemColors.Window
        Me.stJam.Name = "stJam"
        Me.stJam.Size = New System.Drawing.Size(29, 20)
        Me.stJam.Text = "JAM"
        '
        'menuKeluar
        '
        Me.menuKeluar.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuKeluar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.Size = New System.Drawing.Size(54, 22)
        Me.menuKeluar.Text = "KELUAR"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMaster, Me.menuTransaksi, Me.menuLaporan, Me.menuPengaturan, Me.menuKeluar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1080, 26)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMaster
        '
        Me.menuMaster.BackColor = System.Drawing.Color.SteelBlue
        Me.menuMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.menuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUser, Me.menuBarang})
        Me.menuMaster.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuMaster.ForeColor = System.Drawing.SystemColors.Desktop
        Me.menuMaster.ImageTransparentColor = System.Drawing.Color.White
        Me.menuMaster.Name = "menuMaster"
        Me.menuMaster.Size = New System.Drawing.Size(55, 22)
        Me.menuMaster.Text = "MASTER"
        '
        'menuUser
        '
        Me.menuUser.Name = "menuUser"
        Me.menuUser.Size = New System.Drawing.Size(152, 22)
        Me.menuUser.Text = "PEGAWAI"
        '
        'menuBarang
        '
        Me.menuBarang.Name = "menuBarang"
        Me.menuBarang.Size = New System.Drawing.Size(152, 22)
        Me.menuBarang.Text = "ITEM"
        '
        'menuTransaksi
        '
        Me.menuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuPenjualanHeader, Me.menuPenjualanDetail, Me.menuBarangMasukHeader, Me.BaeangMasukDetailToolStripMenuItem})
        Me.menuTransaksi.Font = New System.Drawing.Font("Agency", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuTransaksi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.menuTransaksi.Name = "menuTransaksi"
        Me.menuTransaksi.Size = New System.Drawing.Size(69, 22)
        Me.menuTransaksi.Text = "TRANSAKSI"
        '
        'menuPenjualanHeader
        '
        Me.menuPenjualanHeader.Name = "menuPenjualanHeader"
        Me.menuPenjualanHeader.Size = New System.Drawing.Size(182, 22)
        Me.menuPenjualanHeader.Text = "LIST BARANG MASUK"
        '
        'menuPenjualanDetail
        '
        Me.menuPenjualanDetail.Name = "menuPenjualanDetail"
        Me.menuPenjualanDetail.Size = New System.Drawing.Size(182, 22)
        Me.menuPenjualanDetail.Text = "LIST REKAP PENJUALAN"
        '
        'menuBarangMasukHeader
        '
        Me.menuBarangMasukHeader.Name = "menuBarangMasukHeader"
        Me.menuBarangMasukHeader.Size = New System.Drawing.Size(182, 22)
        Me.menuBarangMasukHeader.Text = "LIST PENGELUARAN KAS"
        '
        'BaeangMasukDetailToolStripMenuItem
        '
        Me.BaeangMasukDetailToolStripMenuItem.Name = "BaeangMasukDetailToolStripMenuItem"
        Me.BaeangMasukDetailToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BaeangMasukDetailToolStripMenuItem.Text = "LIST RETUR PEMBELIAN"
        '
        'menuLaporan
        '
        Me.menuLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLapPembelian, Me.menuLapBrgMsk, Me.menuLapReturPembelian, Me.menuLapStock})
        Me.menuLaporan.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuLaporan.ForeColor = System.Drawing.SystemColors.Desktop
        Me.menuLaporan.Name = "menuLaporan"
        Me.menuLaporan.Size = New System.Drawing.Size(61, 22)
        Me.menuLaporan.Text = "LAPORAN"
        '
        'menuLapPembelian
        '
        Me.menuLapPembelian.Name = "menuLapPembelian"
        Me.menuLapPembelian.Size = New System.Drawing.Size(199, 22)
        Me.menuLapPembelian.Text = "LAPORAN PEMBELIAN"
        '
        'menuLapBrgMsk
        '
        Me.menuLapBrgMsk.Name = "menuLapBrgMsk"
        Me.menuLapBrgMsk.Size = New System.Drawing.Size(199, 22)
        Me.menuLapBrgMsk.Text = "LAPORAN BARANG MASUK"
        '
        'menuLapReturPembelian
        '
        Me.menuLapReturPembelian.Name = "menuLapReturPembelian"
        Me.menuLapReturPembelian.Size = New System.Drawing.Size(199, 22)
        Me.menuLapReturPembelian.Text = "LAPORAN RETUR PEMBELIAN"
        '
        'menuLapStock
        '
        Me.menuLapStock.Name = "menuLapStock"
        Me.menuLapStock.Size = New System.Drawing.Size(199, 22)
        Me.menuLapStock.Text = "LAPORAN STOK"
        '
        'menuPengaturan
        '
        Me.menuPengaturan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGantiPassword})
        Me.menuPengaturan.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuPengaturan.ForeColor = System.Drawing.SystemColors.Desktop
        Me.menuPengaturan.Name = "menuPengaturan"
        Me.menuPengaturan.Size = New System.Drawing.Size(79, 22)
        Me.menuPengaturan.Text = "PENGATURAN"
        '
        'menuGantiPassword
        '
        Me.menuGantiPassword.Name = "menuGantiPassword"
        Me.menuGantiPassword.Size = New System.Drawing.Size(157, 22)
        Me.menuGantiPassword.Text = "GANTI PASSWORD"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Global.PROGRAMPENJUALANDVD.My.Resources.Resources.TOKO
        Me.PictureBox1.Image = Global.PROGRAMPENJUALANDVD.My.Resources.Resources.TOKO1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1080, 370)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 421)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuUtama"
        Me.Text = "FrmMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stKodePegawai As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stNamaPegawai As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stHakAkses As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stTanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPenjualanHeader As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPenjualanDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBarangMasukHeader As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLapPembelian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLapBrgMsk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLapReturPembelian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLapStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPengaturan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGantiPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BaeangMasukDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
