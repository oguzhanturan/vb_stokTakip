Imports System.Data.OleDb
Imports System.Text


Public Class Form3
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
        With dgvbilesen
            .DataSource = dt
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
        With dgvbilesen
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Ürün Kodu"
            .Columns(1).HeaderCell.Value = "Ürün Adı"
            .Columns(2).HeaderCell.Value = "Ürün Bileşenleri"
        End With
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ad.Enabled = False
        kod.Enabled = False
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & System.Windows.Forms.Application.StartupPath & "\tumurun.xlsx;Extended Properties=Excel 12.0;"
        cn.Open()
        FillDataGridView("select * from [yeni2$]")
        cn.Close()
    End Sub
    Private Sub dgvbilesen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbilesen.CellClick
        Try
            kod.Text = dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(0).Value
            ad.Text = dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(1).Value
            dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(0).Selected = True
            dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(1).Selected = True
            dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(2).Selected = True
            Dim Kelimeler As String = dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(2).Value
            Dim Dizi() As String
            Dizi = Kelimeler.Split("/")
            Dim dizi_sayi As Integer = Dizi.Length - 1
            For index = 0 To dizi_sayi
                ListBox1.Items.Add(Dizi(index))
            Next
        Catch ex As Exception
            MessageBox.Show("Ulaşmaya çalıştığınız ürün bilesenleri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        End Try
    End Sub
End Class