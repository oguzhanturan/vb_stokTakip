Imports System.Data.OleDb
Imports System.Text
Imports System.Data.SqlClient


Public Class Form1
    Dim cn As New OleDbConnection
    Dim cn2 As New OleDbConnection
    Dim cn3 As New OleDbConnection
    Dim cm As New OleDbCommand
    Dim da As OleDbDataAdapter
    Dim da2 As OleDbDataAdapter
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Private Property pageready As Boolean = False
    Private Sub WaitForPageLoad()
        AddHandler tarayici.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub
    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If tarayici.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler tarayici.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tarayici.Navigate("http://gonulug sofrasi.blogspot.com.tr/")
        dtext_ad.Enabled = False
        tarih.Value = DateTime.Now()
        combo_firma.DataSource = IO.File.ReadAllLines(Application.StartupPath & "\kaynak\firmaliste.txt", Encoding.UTF8)
        combo_kayitfirma.DataSource = IO.File.ReadAllLines(Application.StartupPath & "\kaynak\firmaliste.txt", Encoding.UTF8)
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\tumparcalar.xlsx;Extended Properties=Excel 12.0;"
        cn.Open()

        FillDataGridView("select * from [tumu$]")

        Dim ks As Integer = dgvbilesen.RowCount
        For index = 0 To ks - 1
            list_add.Items.Add(dgvbilesen.Rows(index).Cells(1).Value)
        Next
        With dgvbilesen
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Parça ID"
            .Columns(1).HeaderCell.Value = "Parça Adı"
            .Columns(2).HeaderCell.Value = "Stok Adedi"
        End With
        cn.Close()
    End Sub

    Private Sub FillDataGridView(ByVal Query As String)
        da = New OleDbDataAdapter(Query, cn)
        dt.Clear()
        da.Fill(dt)
        With dgvbilesen
            .DataSource = dt
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        cn.Close()
        Form2.Close()
        Form3.Close()
    End Sub
    Private Sub combo_firma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_firma.SelectedIndexChanged
        Try
            If combo_firma.SelectedItem.ToString = "IKEA" Then
                combo_urunadi.DataSource = IO.File.ReadAllLines(Application.StartupPath & "\kaynak\ikeaurunlistesi.txt", Encoding.UTF8)
            End If
            If combo_firma.SelectedItem.ToString = "NSK" Then
                combo_urunadi.DataSource = IO.File.ReadAllLines(Application.StartupPath & "\kaynak\nskurunlistesi.txt", Encoding.UTF8)
            End If
            If combo_firma.SelectedItem.ToString = "TWYFORD" Then
                combo_urunadi.DataSource = IO.File.ReadAllLines(Application.StartupPath & "\kaynak\twyfordurunlistesi.txt", Encoding.UTF8)
            End If
            If combo_firma.SelectedItem.ToString = "LGI" Then
                combo_urunadi.DataSource = IO.File.ReadAllLines(Application.StartupPath & "\kaynak\lgiurunlistesi.txt", Encoding.UTF8)
            End If
        Catch ex As Exception
            MsgBox("Seçilen nesneye ulaşılamadı.", "HATA")
        End Try
    End Sub
    Private Sub button_dus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_dus.Click
        Try
            Dim logfirma As String = combo_firma.SelectedItem
            Dim logurun As String = combo_urunadi.SelectedItem
            Dim logadet As String = text_adet.Text
            Dim logtarih As String = Date.Parse(tarih.Text).ToString("dd'.'MM'.'yyyy")
            cn3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\tumurun.xlsx;Extended Properties=Excel 12.0;"
            cn3.Open()
            With cm
                .Connection = cn3
                .CommandText = "insert into [log$](urun,tarih,adet,firma) VALUES ('" & logurun & "','" & logtarih & "','" & logadet & "','" & logfirma & "')"
                .ExecuteNonQuery()
            End With
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\tumparcalar.xlsx;Extended Properties=Excel 12.0;"
            cn.Open()
            da2 = New OleDbDataAdapter("select bilesen_adi from [yeni2$] where urun_adi='" & combo_urunadi.SelectedItem & "'", cn3)
            dt2.Clear()
            da2.Fill(dt2)
            DataGridView2.DataSource = dt2
            Dim grid_okunan As String = DataGridView2.Rows(0).Cells(0).Value
            DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Dim Kelimeler As String = grid_okunan
            Dim Dizi() As String
            Dizi = Kelimeler.Split("/")
            Dim dizi_sayi As Integer = Dizi.Length - 1
            Convert.ToInt32(text_adet.Text)
            For index = 0 To dizi_sayi
                If Dizi(index) <> "" Then
                    FillDataGridView("select stok from [tumu$] where parca_adi='" & Dizi(index) & "'")
                    Dim stok_okunan As String = dgvbilesen.Rows(0).Cells(2).Value
                    stok_okunan -= text_adet.Text
                    With cm
                        .Connection = cn
                        .CommandText = "Update [tumu$] set stok='" & stok_okunan & "' where parca_adi='" & Dizi(index) & "'"
                        .ExecuteNonQuery()
                    End With
                End If
            Next
            FillDataGridView("select * from [tumu$]")
            cn.Close()
            cn3.Close()
            MessageBox.Show("Ürün bileşenleri stokdan düşüldü.", "Stok Düşüldü", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show("Lütfen gerekli yerleri doldurunuz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        Form2.Show()
    End Sub

    Private Sub btn_ekle_Click(sender As Object, e As EventArgs) Handles btn_ekle.Click
        list_select.Items.Add(list_add.SelectedItem)
    End Sub
    Private Sub btn_sil_Click(sender As Object, e As EventArgs) Handles btn_sil.Click
        list_select.Items.Remove(list_select.SelectedItem)
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        If txt_kodu.Text <> "" And txt_yeni.Text <> "" And list_select.Items.Count > 0 Then
            Dim ykytfirma, ykytad As String
            ykytfirma = combo_kayitfirma.SelectedItem
            ykytad = txt_yeni.Text
            Dim ykytbilesen(list_select.Items.Count)
            Dim i As Integer = 0
            For i = 0 To list_select.Items.Count - 1
                ykytbilesen(1) = ykytbilesen(1) + list_select.Items(i) + "/"
            Next
            If ykytfirma = "IKEA" Then
                Dim sw2 As IO.StreamWriter
                sw2 = IO.File.AppendText("kaynak\ikeaurunlistesi.txt")
                sw2.WriteLine(ykytad)
                sw2.Flush()
                sw2.Close()
            End If
            If ykytfirma = "NSK" Then
                Dim sw2 As IO.StreamWriter
                sw2 = IO.File.AppendText("kaynak\nskurunlistesi.txt")
                sw2.WriteLine(ykytad)
                sw2.Flush()
                sw2.Close()
            End If

            If ykytfirma = "TWYFORD" Then
                Dim sw2 As IO.StreamWriter
                sw2 = IO.File.AppendText("kaynak\twyfordurunlistesi.txt")
                sw2.WriteLine(ykytad)
                sw2.Flush()
                sw2.Close()
            End If

            If ykytfirma = "LGI" Then
                Dim sw2 As IO.StreamWriter
                sw2 = IO.File.AppendText("kaynak\lgiurunlistesi.txt")
                sw2.WriteLine(ykytad)
                sw2.Flush()
                sw2.Close()
            End If
            cn2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\tumurun.xlsx;Extended Properties=Excel 12.0;"
            cn2.Open()
            Dim bilesen_adet As Integer

            bilesen_adet = list_select.Items.Count
            With cm
                .Connection = cn2
                .CommandText = "insert into [yeni2$](urun_kodu,urun_adi,bilesen_adi) VALUES ('" & txt_kodu.Text & "','" & ykytad & "','" & ykytbilesen(1) & "')"
                .ExecuteNonQuery()
            End With
            cn2.Close()
            MessageBox.Show(" Ürün başarıyla kaydedildi", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            list_select.Items.Clear()
            txt_kodu.Clear()
            txt_yeni.Clear()
        Else
            MessageBox.Show("Lütfen tüm alanları doldurup tekrar deneyin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1)
        End If

    End Sub
    Private Sub text_adet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_adet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub dgvbilesen_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvbilesen.CellFormatting   
        For i As Integer = 0 To dgvbilesen.Rows.Count - 1
            If dgvbilesen.Rows(i).Cells(2).Value < 5000 Then
                dgvbilesen.Rows(i).Cells(0).Style.ForeColor = Color.Red
                dgvbilesen.Rows(i).Cells(1).Style.ForeColor = Color.Red
                dgvbilesen.Rows(i).Cells(2).Style.ForeColor = Color.Red
            End If
            If dgvbilesen.Rows(i).Cells(2).Value < 0 Then
                dgvbilesen.Rows(i).Cells(2).Value = 0
            End If
        Next
    End Sub
    Private Sub dgvbilesen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbilesen.CellClick
        dtext_kod.Text = dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(0).Value
        dtext_ad.Text = dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(1).Value
        dtext_adet.Text = dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(2).Value
        dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(0).Selected = True
        dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(1).Selected = True
        dgvbilesen.Rows(dgvbilesen.CurrentCell.RowIndex).Cells(2).Selected = True
    End Sub
    Private Sub button_guncelle_Click(sender As Object, e As EventArgs) Handles button_guncelle.Click
        If dtext_adet.Text <> "" And dtext_kod.Text <> "" And dtext_ad.Text <> "" Then
            Dim cn As New OleDbConnection
            Dim cm As New OleDbCommand
            cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\tumparcalar.xlsx;Extended Properties=Excel 12.0;")
            cn.Open()
            With cm
                .Connection = cn
                .CommandText = "update [tumu$] set [stok]=?, [parca_id]=? WHERE [parca_adi]=?"
                cm = New OleDbCommand(.CommandText, cn)
                cm.Parameters.AddWithValue("?", Convert.ToInt32(dtext_adet.Text) + gadet)
                cm.Parameters.AddWithValue("?", dtext_kod.Text)
                cm.Parameters.AddWithValue("?", dtext_ad.Text)

                cm.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("Bilgiler başarıyla güncellendi.", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End With
            FillDataGridView("select * from [tumu$]")
        Else
            MessageBox.Show("Lütfen tüm alanları doldurup tekrar deneyin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub dtext_adet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtext_adet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Dim gadet As Integer
    Private Sub dtext_adet_Click(sender As Object, e As EventArgs) Handles dtext_adet.Click
        If dtext_adet.Text <> "" Then
            gadet = dtext_adet.Text
            dtext_adet.Clear()
        Else
            MessageBox.Show("Lütfen tüm alanları doldurup tekrar deneyin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub tarayici_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles tarayici.DocumentCompleted
        Dim check_Tag As HtmlElementCollection = tarayici.Document.GetElementsByTagName("div")
        For Each Cekilecek_Parametre As HtmlElement In check_Tag
            TextBox1.Text = TextBox1.Text & Cekilecek_Parametre.GetAttribute("innertext") & Environment.NewLine
        Next
        If TextBox1.Text.Contains("kapat") Then
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub dtext_adet_KeyDown(sender As Object, e As KeyEventArgs) Handles dtext_adet.KeyDown
        If e.KeyCode = Keys.Back Then
            e.SuppressKeyPress = True
        End If
    End Sub
    

End Class
