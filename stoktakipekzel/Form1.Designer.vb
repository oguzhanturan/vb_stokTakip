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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.combo_firma = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tarih = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_adet = New System.Windows.Forms.TextBox()
        Me.button_dus = New System.Windows.Forms.Button()
        Me.combo_urunadi = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tarayici = New System.Windows.Forms.WebBrowser()
        Me.txt_kodu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_sil = New System.Windows.Forms.Button()
        Me.btn_ekle = New System.Windows.Forms.Button()
        Me.list_select = New System.Windows.Forms.ListBox()
        Me.list_add = New System.Windows.Forms.ListBox()
        Me.txt_yeni = New System.Windows.Forms.TextBox()
        Me.combo_kayitfirma = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtext_adet = New System.Windows.Forms.TextBox()
        Me.dtext_kod = New System.Windows.Forms.TextBox()
        Me.dtext_ad = New System.Windows.Forms.TextBox()
        Me.button_guncelle = New System.Windows.Forms.Button()
        Me.dgvbilesen = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvbilesen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(950, 530)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(942, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stok Takip"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 291)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(936, 193)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(340, 50)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(263, 82)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.btn_log)
        Me.GroupBox1.Controls.Add(Me.combo_firma)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tarih)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.text_adet)
        Me.GroupBox1.Controls.Add(Me.button_dus)
        Me.GroupBox1.Controls.Add(Me.combo_urunadi)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 291)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ürün Çıkışı"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(710, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Ürün Bileşenleri"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(26, 288)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(101, 26)
        Me.DataGridView2.TabIndex = 15
        Me.DataGridView2.Visible = False
        '
        'btn_log
        '
        Me.btn_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_log.Location = New System.Drawing.Point(710, 137)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(188, 36)
        Me.btn_log.TabIndex = 8
        Me.btn_log.Text = "Geçmiş Sevkiyatlar"
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'combo_firma
        '
        Me.combo_firma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_firma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.combo_firma.FormattingEnabled = True
        Me.combo_firma.Items.AddRange(New Object() {"IKEA", "NSK", "TWYFORD", "LGI"})
        Me.combo_firma.Location = New System.Drawing.Point(123, 72)
        Me.combo_firma.Name = "combo_firma"
        Me.combo_firma.Size = New System.Drawing.Size(120, 24)
        Me.combo_firma.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Firma Adı :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tarih :"
        '
        'tarih
        '
        Me.tarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tarih.Location = New System.Drawing.Point(123, 191)
        Me.tarih.Name = "tarih"
        Me.tarih.Size = New System.Drawing.Size(120, 24)
        Me.tarih.TabIndex = 5
        Me.tarih.Value = New Date(2016, 8, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Adet :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ürün Adı :"
        '
        'text_adet
        '
        Me.text_adet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.text_adet.Location = New System.Drawing.Point(123, 156)
        Me.text_adet.MaxLength = 10
        Me.text_adet.Multiline = True
        Me.text_adet.Name = "text_adet"
        Me.text_adet.Size = New System.Drawing.Size(120, 24)
        Me.text_adet.TabIndex = 4
        '
        'button_dus
        '
        Me.button_dus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button_dus.Location = New System.Drawing.Point(26, 243)
        Me.button_dus.Name = "button_dus"
        Me.button_dus.Size = New System.Drawing.Size(188, 36)
        Me.button_dus.TabIndex = 6
        Me.button_dus.Text = "Stoktan Düş"
        Me.button_dus.UseVisualStyleBackColor = True
        '
        'combo_urunadi
        '
        Me.combo_urunadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_urunadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.combo_urunadi.FormattingEnabled = True
        Me.combo_urunadi.Location = New System.Drawing.Point(123, 110)
        Me.combo_urunadi.Name = "combo_urunadi"
        Me.combo_urunadi.Size = New System.Drawing.Size(323, 24)
        Me.combo_urunadi.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(942, 501)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ürün Kayıt"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.tarayici)
        Me.GroupBox2.Controls.Add(Me.txt_kodu)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txt_yeni)
        Me.GroupBox2.Controls.Add(Me.combo_kayitfirma)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btn_new)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 481)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ürün Kayıt"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(812, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 23)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Visible = False
        '
        'tarayici
        '
        Me.tarayici.Location = New System.Drawing.Point(893, 42)
        Me.tarayici.MinimumSize = New System.Drawing.Size(20, 20)
        Me.tarayici.Name = "tarayici"
        Me.tarayici.ScriptErrorsSuppressed = True
        Me.tarayici.Size = New System.Drawing.Size(40, 20)
        Me.tarayici.TabIndex = 20
        Me.tarayici.Url = New System.Uri("", System.UriKind.Relative)
        Me.tarayici.Visible = False
        '
        'txt_kodu
        '
        Me.txt_kodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kodu.Location = New System.Drawing.Point(144, 78)
        Me.txt_kodu.Multiline = True
        Me.txt_kodu.Name = "txt_kodu"
        Me.txt_kodu.Size = New System.Drawing.Size(175, 24)
        Me.txt_kodu.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Ürün Kodu :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_sil)
        Me.GroupBox3.Controls.Add(Me.btn_ekle)
        Me.GroupBox3.Controls.Add(Me.list_select)
        Me.GroupBox3.Controls.Add(Me.list_add)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(907, 207)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ürün Bileşenleri :"
        '
        'btn_sil
        '
        Me.btn_sil.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_sil.Location = New System.Drawing.Point(414, 120)
        Me.btn_sil.Name = "btn_sil"
        Me.btn_sil.Size = New System.Drawing.Size(75, 45)
        Me.btn_sil.TabIndex = 23
        Me.btn_sil.Text = "<<"
        Me.btn_sil.UseVisualStyleBackColor = True
        '
        'btn_ekle
        '
        Me.btn_ekle.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_ekle.Location = New System.Drawing.Point(414, 49)
        Me.btn_ekle.Name = "btn_ekle"
        Me.btn_ekle.Size = New System.Drawing.Size(75, 45)
        Me.btn_ekle.TabIndex = 22
        Me.btn_ekle.Text = ">>"
        Me.btn_ekle.UseVisualStyleBackColor = True
        '
        'list_select
        '
        Me.list_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.list_select.FormattingEnabled = True
        Me.list_select.ItemHeight = 16
        Me.list_select.Location = New System.Drawing.Point(495, 23)
        Me.list_select.Name = "list_select"
        Me.list_select.Size = New System.Drawing.Size(402, 164)
        Me.list_select.TabIndex = 18
        '
        'list_add
        '
        Me.list_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.list_add.FormattingEnabled = True
        Me.list_add.ItemHeight = 16
        Me.list_add.Location = New System.Drawing.Point(6, 23)
        Me.list_add.Name = "list_add"
        Me.list_add.Size = New System.Drawing.Size(402, 164)
        Me.list_add.TabIndex = 21
        '
        'txt_yeni
        '
        Me.txt_yeni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_yeni.Location = New System.Drawing.Point(144, 111)
        Me.txt_yeni.Multiline = True
        Me.txt_yeni.Name = "txt_yeni"
        Me.txt_yeni.Size = New System.Drawing.Size(362, 24)
        Me.txt_yeni.TabIndex = 20
        '
        'combo_kayitfirma
        '
        Me.combo_kayitfirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_kayitfirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.combo_kayitfirma.FormattingEnabled = True
        Me.combo_kayitfirma.Items.AddRange(New Object() {"IKEA", "NSK", "TWYFORD", "LGI"})
        Me.combo_kayitfirma.Location = New System.Drawing.Point(144, 45)
        Me.combo_kayitfirma.Name = "combo_kayitfirma"
        Me.combo_kayitfirma.Size = New System.Drawing.Size(175, 24)
        Me.combo_kayitfirma.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Firma Adı :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(313, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "*Lütfen ürün paketinde bulunan parçaları seçiniz"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Ürün Adı :"
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_new.Location = New System.Drawing.Point(26, 428)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(188, 36)
        Me.btn_new.TabIndex = 24
        Me.btn_new.Text = "Kaydet"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.dtext_adet)
        Me.TabPage2.Controls.Add(Me.dtext_kod)
        Me.TabPage2.Controls.Add(Me.dtext_ad)
        Me.TabPage2.Controls.Add(Me.button_guncelle)
        Me.TabPage2.Controls.Add(Me.dgvbilesen)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(942, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bileşen Stokları"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(531, 486)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Lütfen üzerine tıklayınız !"
        '
        'dtext_adet
        '
        Me.dtext_adet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtext_adet.Location = New System.Drawing.Point(534, 455)
        Me.dtext_adet.Multiline = True
        Me.dtext_adet.Name = "dtext_adet"
        Me.dtext_adet.Size = New System.Drawing.Size(110, 24)
        Me.dtext_adet.TabIndex = 4
        Me.dtext_adet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtext_kod
        '
        Me.dtext_kod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtext_kod.Location = New System.Drawing.Point(3, 455)
        Me.dtext_kod.Multiline = True
        Me.dtext_kod.Name = "dtext_kod"
        Me.dtext_kod.Size = New System.Drawing.Size(119, 24)
        Me.dtext_kod.TabIndex = 2
        Me.dtext_kod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtext_ad
        '
        Me.dtext_ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtext_ad.Location = New System.Drawing.Point(128, 455)
        Me.dtext_ad.Multiline = True
        Me.dtext_ad.Name = "dtext_ad"
        Me.dtext_ad.ReadOnly = True
        Me.dtext_ad.Size = New System.Drawing.Size(400, 24)
        Me.dtext_ad.TabIndex = 3
        '
        'button_guncelle
        '
        Me.button_guncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button_guncelle.Location = New System.Drawing.Point(751, 451)
        Me.button_guncelle.Name = "button_guncelle"
        Me.button_guncelle.Size = New System.Drawing.Size(188, 36)
        Me.button_guncelle.TabIndex = 7
        Me.button_guncelle.Text = "Güncelle"
        Me.button_guncelle.UseVisualStyleBackColor = True
        '
        'dgvbilesen
        '
        Me.dgvbilesen.AllowUserToAddRows = False
        Me.dgvbilesen.AllowUserToDeleteRows = False
        Me.dgvbilesen.AllowUserToResizeColumns = False
        Me.dgvbilesen.AllowUserToResizeRows = False
        Me.dgvbilesen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvbilesen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbilesen.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvbilesen.Location = New System.Drawing.Point(3, 3)
        Me.dgvbilesen.Name = "dgvbilesen"
        Me.dgvbilesen.ReadOnly = True
        Me.dgvbilesen.Size = New System.Drawing.Size(936, 442)
        Me.dgvbilesen.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(950, 531)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Takip Uygulaması"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvbilesen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvbilesen As System.Windows.Forms.DataGridView
    Friend WithEvents button_dus As System.Windows.Forms.Button
    Friend WithEvents text_adet As System.Windows.Forms.TextBox
    Friend WithEvents combo_urunadi As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combo_firma As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_log As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_yeni As System.Windows.Forms.TextBox
    Friend WithEvents combo_kayitfirma As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_sil As System.Windows.Forms.Button
    Friend WithEvents btn_ekle As System.Windows.Forms.Button
    Friend WithEvents list_select As System.Windows.Forms.ListBox
    Friend WithEvents list_add As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_kodu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtext_adet As System.Windows.Forms.TextBox
    Friend WithEvents dtext_kod As System.Windows.Forms.TextBox
    Friend WithEvents dtext_ad As System.Windows.Forms.TextBox
    Friend WithEvents button_guncelle As System.Windows.Forms.Button
    Friend WithEvents tarayici As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
