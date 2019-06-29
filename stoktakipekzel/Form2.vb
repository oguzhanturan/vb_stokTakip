Imports System.Data.OleDb
Imports System.Text


Public Class Form2
    Dim cn As New System.Data.OleDb.OleDbConnection
    Dim cm As New OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As New System.Data.DataTable
    Dim w As IO.StreamWriter
    Dim r As IO.StreamReader
    Private Sub FillDataGridView(ByVal Query As String)
        da = New OleDbDataAdapter(Query, cn)
        dt.Clear()
        da.Fill(dt)
        With dgv
            .DataSource = dt
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
        With dgv
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Ürün Adı"
            .Columns(1).HeaderCell.Value = "Gönderilme Tarihi"
            .Columns(2).HeaderCell.Value = "Gönderilen Adet"
            .Columns(3).HeaderCell.Value = "Gönderilen Firma"
        End With
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & System.Windows.Forms.Application.StartupPath & "\tumurun.xlsx;Extended Properties=Excel 12.0;"
        cn.Open()
        log_tarihlist.Value = DateTime.Now()
        FillDataGridView("select * from [log$]")
        cn.Close()
    End Sub

    Private Sub btn_filtre_Click(sender As Object, e As EventArgs) Handles btn_filtre.Click
        Try
            Dim fil_tarih As String = Date.Parse(log_tarihlist.Text).ToString("dd'.'MM'.'yyyy")
            FillDataGridView("select * from [log$] where tarih='" & fil_tarih & "'")
            If dgv.RowCount = 0 Then
                MessageBox.Show("Bu tarihde sevkiyat gerçekleşmemiştir.", "Sevkiyat", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                FillDataGridView("select * from [log$]")
            End If
        Catch ex As Exception
            MessageBox.Show("Lütfen gerekli yerleri doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FillDataGridView("select * from [log$]")

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Selected = True
        dgv.Rows(dgv.CurrentCell.RowIndex).Cells(1).Selected = True
        dgv.Rows(dgv.CurrentCell.RowIndex).Cells(2).Selected = True
        dgv.Rows(dgv.CurrentCell.RowIndex).Cells(3).Selected = True
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.dgv.Width, Me.dgv.Height)
        dgv.DrawToBitmap(bm, New Rectangle(0, 0, Me.dgv.Width, Me.dgv.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class