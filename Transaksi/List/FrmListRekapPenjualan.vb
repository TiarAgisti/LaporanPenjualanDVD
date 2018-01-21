Imports System.Data
Imports System.Data.SqlClient
Public Class FrmListRekapPenjualan
    Sub HeaderGrid()
        dgv.Columns(0).HeaderText = "No Penjualan"
        dgv.Columns(0).Width = 120
        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(2).HeaderText = "Status"
        dgv.Columns(2).Width = 150
        dgv.Columns(3).HeaderText = "Kode Pegawai"
        dgv.Columns(3).Width = 120
    End Sub

    Sub TampilData()
        Dim query As String
        query = "Select PJ.nopenjualan,PJ.tanggalpenjualan,pgw.namapegawai" & _
        " , CASE WHEN PJ.status = 1 THEN 'Baru' WHEN PJ.status = 3 Then 'Disetujui' ELSE 'Ditolak' End StatusDesc " & _
        " From tbpenjualanheader as PJ INNER JOIN tbpegawai as pgw" & _
        " ON pgw.kodepegawai = PJ.kodepegawai Where PJ.status <> 0"
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

    Private Sub FrmListRekapPenjualan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            TampilData()
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub
End Class