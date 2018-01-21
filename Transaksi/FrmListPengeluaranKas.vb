Imports System.Data
Imports System.Data.SqlClient
Public Class FrmListPengeluaranKas
    Sub TampilData()
        Dim query As String
        query = "Select * from "
        Try
            OpenConnection()
            cmd = New SqlCommand(query, conn)
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds)
            dt = ds.Tables(0)
            dgv.DataSource = dt
            dgv.ReadOnly = True
            HeaderGrid()
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            'ds.Dispose()
            'dt.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub HeaderGrid()
        dgv.Columns(0).HeaderText = "No Barang Masuk"
        dgv.Columns(0).Width = 120
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "No Nota Pembelian"
        dgv.Columns(2).Width = 150
        dgv.Columns(3).HeaderText = "Nama Pegawai"
        dgv.Columns(3).Width = 120
        dgv.Columns(4).HeaderText = "Status"
        dgv.Columns(4).Width = 100
    End Sub


   

    Private Sub FrmListPengeluaranKas_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim frm As FrmPengeluaranKas = New FrmPengeluaranKas
        FrmPengeluaranKas.kondisi = "Create"
        frm.ShowDialog()
    End Sub
End Class