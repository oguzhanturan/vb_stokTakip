<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dgvbilesen = New System.Windows.Forms.DataGridView()
        Me.kod = New System.Windows.Forms.TextBox()
        Me.ad = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.dgvbilesen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvbilesen
        '
        Me.dgvbilesen.AllowUserToAddRows = False
        Me.dgvbilesen.AllowUserToDeleteRows = False
        Me.dgvbilesen.AllowUserToResizeColumns = False
        Me.dgvbilesen.AllowUserToResizeRows = False
        Me.dgvbilesen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvbilesen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbilesen.Location = New System.Drawing.Point(0, 0)
        Me.dgvbilesen.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvbilesen.MultiSelect = False
        Me.dgvbilesen.Name = "dgvbilesen"
        Me.dgvbilesen.ReadOnly = True
        Me.dgvbilesen.Size = New System.Drawing.Size(884, 340)
        Me.dgvbilesen.TabIndex = 0
        '
        'kod
        '
        Me.kod.Location = New System.Drawing.Point(12, 387)
        Me.kod.Name = "kod"
        Me.kod.ReadOnly = True
        Me.kod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.kod.Size = New System.Drawing.Size(366, 24)
        Me.kod.TabIndex = 1
        Me.kod.WordWrap = False
        '
        'ad
        '
        Me.ad.Location = New System.Drawing.Point(12, 351)
        Me.ad.Name = "ad"
        Me.ad.ReadOnly = True
        Me.ad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ad.Size = New System.Drawing.Size(366, 24)
        Me.ad.TabIndex = 2
        Me.ad.WordWrap = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(393, 351)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(479, 94)
        Me.ListBox1.TabIndex = 3
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.kod)
        Me.Controls.Add(Me.dgvbilesen)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Bileşenleri"
        CType(Me.dgvbilesen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvbilesen As System.Windows.Forms.DataGridView
    Friend WithEvents kod As System.Windows.Forms.TextBox
    Friend WithEvents ad As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
