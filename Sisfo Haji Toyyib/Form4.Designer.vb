<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.pnlInfoTransaksi = New System.Windows.Forms.Panel()
        Me.lblInfo0 = New System.Windows.Forms.Label()
        Me.lblInfoVal0 = New System.Windows.Forms.Label()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblInfoVal1 = New System.Windows.Forms.Label()
        Me.lblInfoVal2 = New System.Windows.Forms.Label()
        Me.pnlRincianBayar = New System.Windows.Forms.Panel()
        Me.dgvRincianBayar = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnProsesPembayaran = New System.Windows.Forms.Button()
        Me.lblRincianTitle = New System.Windows.Forms.Label()
        Me.pnlInputBayar = New System.Windows.Forms.Panel()
        Me.lblTagihanTitle = New System.Windows.Forms.Label()
        Me.lblTotalTagihan = New System.Windows.Forms.Label()
        Me.lblUangDiterima = New System.Windows.Forms.Label()
        Me.txtUangDiterima = New System.Windows.Forms.TextBox()
        Me.lblMetode = New System.Windows.Forms.Label()
        Me.cmbMetode = New System.Windows.Forms.ComboBox()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.lblKembalianValue = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.btnCetakStruk = New System.Windows.Forms.Button()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.pnlTopbar = New System.Windows.Forms.Panel()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnNavDashboard = New System.Windows.Forms.Button()
        Me.btnNavPesanan = New System.Windows.Forms.Button()
        Me.btnNavPembayaran = New System.Windows.Forms.Button()
        Me.btnNavAntrean = New System.Windows.Forms.Button()
        Me.btnNavStatusMenu = New System.Windows.Forms.Button()
        Me.btnNavBahan = New System.Windows.Forms.Button()
        Me.btnNavKoreksi = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        CType(Me.dgvRincianBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopbar.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInfoTransaksi
        '
        Me.pnlInfoTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlInfoTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInfoTransaksi.Location = New System.Drawing.Point(25, 22)
        Me.pnlInfoTransaksi.Name = "pnlInfoTransaksi"
        Me.pnlInfoTransaksi.Size = New System.Drawing.Size(430, 135)
        Me.pnlInfoTransaksi.TabIndex = 0
        '
        'lblInfo0
        '
        Me.lblInfo0.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblInfo0.Location = New System.Drawing.Point(45, 35)
        Me.lblInfo0.Name = "lblInfo0"
        Me.lblInfo0.Size = New System.Drawing.Size(135, 26)
        Me.lblInfo0.TabIndex = 1
        Me.lblInfo0.Text = "No. Transaksi"
        Me.lblInfo0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfoVal0
        '
        Me.lblInfoVal0.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoVal0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblInfoVal0.Location = New System.Drawing.Point(185, 35)
        Me.lblInfoVal0.Name = "lblInfoVal0"
        Me.lblInfoVal0.Size = New System.Drawing.Size(250, 26)
        Me.lblInfoVal0.TabIndex = 2
        Me.lblInfoVal0.Text = "TRX-00015"
        Me.lblInfoVal0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfo1
        '
        Me.lblInfo1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblInfo1.Location = New System.Drawing.Point(45, 71)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(135, 26)
        Me.lblInfo1.TabIndex = 3
        Me.lblInfo1.Text = "Tanggal"
        Me.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfoVal1
        '
        Me.lblInfoVal1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoVal1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblInfoVal1.Location = New System.Drawing.Point(185, 71)
        Me.lblInfoVal1.Name = "lblInfoVal1"
        Me.lblInfoVal1.Size = New System.Drawing.Size(250, 26)
        Me.lblInfoVal1.TabIndex = 4
        Me.lblInfoVal1.Text = "23/11/2026 10:22"
        Me.lblInfoVal1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfoVal2
        '
        Me.lblInfoVal2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoVal2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblInfoVal2.Location = New System.Drawing.Point(185, 107)
        Me.lblInfoVal2.Name = "lblInfoVal2"
        Me.lblInfoVal2.Size = New System.Drawing.Size(250, 26)
        Me.lblInfoVal2.TabIndex = 6
        Me.lblInfoVal2.Text = "Sari"
        Me.lblInfoVal2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRincianBayar
        '
        Me.pnlRincianBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRincianBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRincianBayar.Location = New System.Drawing.Point(480, 22)
        Me.pnlRincianBayar.Name = "pnlRincianBayar"
        Me.pnlRincianBayar.Size = New System.Drawing.Size(635, 450)
        Me.pnlRincianBayar.TabIndex = 7
        '
        'dgvRincianBayar
        '
        Me.dgvRincianBayar.AllowUserToAddRows = False
        Me.dgvRincianBayar.AllowUserToDeleteRows = False
        Me.dgvRincianBayar.AllowUserToResizeRows = False
        Me.dgvRincianBayar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRincianBayar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRincianBayar.ColumnHeadersHeight = 38
        Me.dgvRincianBayar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.menu, Me.qty, Me.harga, Me.total})
        Me.dgvRincianBayar.EnableHeadersVisualStyles = False
        Me.dgvRincianBayar.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvRincianBayar.Location = New System.Drawing.Point(500, 85)
        Me.dgvRincianBayar.MultiSelect = False
        Me.dgvRincianBayar.Name = "dgvRincianBayar"
        Me.dgvRincianBayar.ReadOnly = True
        Me.dgvRincianBayar.RowHeadersVisible = False
        Me.dgvRincianBayar.RowHeadersWidth = 51
        Me.dgvRincianBayar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRincianBayar.Size = New System.Drawing.Size(595, 360)
        Me.dgvRincianBayar.TabIndex = 9
        '
        'no
        '
        Me.no.FillWeight = 8.0!
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'menu
        '
        Me.menu.FillWeight = 32.0!
        Me.menu.HeaderText = "Menu"
        Me.menu.MinimumWidth = 6
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        Me.menu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'qty
        '
        Me.qty.FillWeight = 12.0!
        Me.qty.HeaderText = "Qty"
        Me.qty.MinimumWidth = 6
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'harga
        '
        Me.harga.FillWeight = 20.0!
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total
        '
        Me.total.FillWeight = 28.0!
        Me.total.HeaderText = "Subtotal"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnProsesPembayaran
        '
        Me.btnProsesPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnProsesPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProsesPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProsesPembayaran.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProsesPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnProsesPembayaran.Location = New System.Drawing.Point(25, 575)
        Me.btnProsesPembayaran.Name = "btnProsesPembayaran"
        Me.btnProsesPembayaran.Size = New System.Drawing.Size(250, 48)
        Me.btnProsesPembayaran.TabIndex = 19
        Me.btnProsesPembayaran.Text = "PROSES PEMBAYARAN"
        Me.btnProsesPembayaran.UseVisualStyleBackColor = False
        '
        'lblRincianTitle
        '
        Me.lblRincianTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRincianTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblRincianTitle.Location = New System.Drawing.Point(500, 38)
        Me.lblRincianTitle.Name = "lblRincianTitle"
        Me.lblRincianTitle.Size = New System.Drawing.Size(590, 35)
        Me.lblRincianTitle.TabIndex = 8
        Me.lblRincianTitle.Text = "RINCIAN PESANAN"
        Me.lblRincianTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlInputBayar
        '
        Me.pnlInputBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlInputBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInputBayar.Location = New System.Drawing.Point(25, 180)
        Me.pnlInputBayar.Name = "pnlInputBayar"
        Me.pnlInputBayar.Size = New System.Drawing.Size(430, 370)
        Me.pnlInputBayar.TabIndex = 10
        '
        'lblTagihanTitle
        '
        Me.lblTagihanTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagihanTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblTagihanTitle.Location = New System.Drawing.Point(45, 197)
        Me.lblTagihanTitle.Name = "lblTagihanTitle"
        Me.lblTagihanTitle.Size = New System.Drawing.Size(180, 30)
        Me.lblTagihanTitle.TabIndex = 11
        Me.lblTagihanTitle.Text = "TOTAL TAGIHAN"
        Me.lblTagihanTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalTagihan
        '
        Me.lblTotalTagihan.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTagihan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblTotalTagihan.Location = New System.Drawing.Point(45, 230)
        Me.lblTotalTagihan.Name = "lblTotalTagihan"
        Me.lblTotalTagihan.Size = New System.Drawing.Size(370, 55)
        Me.lblTotalTagihan.TabIndex = 12
        Me.lblTotalTagihan.Text = "Rp38.000"
        Me.lblTotalTagihan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUangDiterima
        '
        Me.lblUangDiterima.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUangDiterima.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblUangDiterima.Location = New System.Drawing.Point(45, 310)
        Me.lblUangDiterima.Name = "lblUangDiterima"
        Me.lblUangDiterima.Size = New System.Drawing.Size(160, 28)
        Me.lblUangDiterima.TabIndex = 13
        Me.lblUangDiterima.Text = "Uang Diterima"
        Me.lblUangDiterima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUangDiterima
        '
        Me.txtUangDiterima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUangDiterima.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUangDiterima.Location = New System.Drawing.Point(210, 305)
        Me.txtUangDiterima.Name = "txtUangDiterima"
        Me.txtUangDiterima.Size = New System.Drawing.Size(205, 30)
        Me.txtUangDiterima.TabIndex = 14
        '
        'lblMetode
        '
        Me.lblMetode.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMetode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblMetode.Location = New System.Drawing.Point(45, 372)
        Me.lblMetode.Name = "lblMetode"
        Me.lblMetode.Size = New System.Drawing.Size(160, 28)
        Me.lblMetode.TabIndex = 15
        Me.lblMetode.Text = "Metode Pembayaran"
        Me.lblMetode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMetode
        '
        Me.cmbMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMetode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMetode.Location = New System.Drawing.Point(210, 367)
        Me.cmbMetode.Name = "cmbMetode"
        Me.cmbMetode.Size = New System.Drawing.Size(205, 31)
        Me.cmbMetode.TabIndex = 16
        '
        'lblKembalian
        '
        Me.lblKembalian.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblKembalian.Location = New System.Drawing.Point(45, 434)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(160, 28)
        Me.lblKembalian.TabIndex = 17
        Me.lblKembalian.Text = "Kembalian"
        Me.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKembalianValue
        '
        Me.lblKembalianValue.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblKembalianValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lblKembalianValue.Location = New System.Drawing.Point(210, 429)
        Me.lblKembalianValue.Name = "lblKembalianValue"
        Me.lblKembalianValue.Size = New System.Drawing.Size(205, 40)
        Me.lblKembalianValue.TabIndex = 18
        Me.lblKembalianValue.Text = "Rp0"
        Me.lblKembalianValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfo2
        '
        Me.lblInfo2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblInfo2.Location = New System.Drawing.Point(45, 107)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(135, 26)
        Me.lblInfo2.TabIndex = 5
        Me.lblInfo2.Text = "Kasir"
        Me.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCetakStruk
        '
        Me.btnCetakStruk.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCetakStruk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCetakStruk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetakStruk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCetakStruk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCetakStruk.Location = New System.Drawing.Point(290, 575)
        Me.btnCetakStruk.Name = "btnCetakStruk"
        Me.btnCetakStruk.Size = New System.Drawing.Size(165, 48)
        Me.btnCetakStruk.TabIndex = 20
        Me.btnCetakStruk.Text = "CETAK STRUK"
        Me.btnCetakStruk.UseVisualStyleBackColor = False
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Pembayaran"
        Me.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateTime
        '
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblDateTime.Location = New System.Drawing.Point(780, 22)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(335, 30)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "HT POS  •  PENYETAN HAJI TOYYIB"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTopbar
        '
        Me.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlTopbar.Controls.Add(Me.lblPageTitle)
        Me.pnlTopbar.Controls.Add(Me.lblDateTime)
        Me.pnlTopbar.Location = New System.Drawing.Point(220, 0)
        Me.pnlTopbar.Name = "pnlTopbar"
        Me.pnlTopbar.Size = New System.Drawing.Size(1146, 76)
        Me.pnlTopbar.TabIndex = 4
        '
        'lblBrand
        '
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBrand.Location = New System.Drawing.Point(18, 20)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(190, 65)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "HT  |  PENYETAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      HAJI TOYYIB"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRole
        '
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(18, 94)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(190, 28)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "LOGIN SEBAGAI  •  KASIR"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNavDashboard
        '
        Me.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNavDashboard.Location = New System.Drawing.Point(13, 145)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Size = New System.Drawing.Size(194, 45)
        Me.btnNavDashboard.TabIndex = 2
        Me.btnNavDashboard.Text = "▦   Dashboard"
        Me.btnNavDashboard.UseVisualStyleBackColor = False
        '
        'btnNavPesanan
        '
        Me.btnNavPesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavPesanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNavPesanan.Location = New System.Drawing.Point(13, 198)
        Me.btnNavPesanan.Name = "btnNavPesanan"
        Me.btnNavPesanan.Size = New System.Drawing.Size(194, 45)
        Me.btnNavPesanan.TabIndex = 3
        Me.btnNavPesanan.Text = "▣   Pemesanan"
        Me.btnNavPesanan.UseVisualStyleBackColor = False
        '
        'btnNavPembayaran
        '
        Me.btnNavPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPembayaran.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnNavPembayaran.Location = New System.Drawing.Point(13, 251)
        Me.btnNavPembayaran.Name = "btnNavPembayaran"
        Me.btnNavPembayaran.Size = New System.Drawing.Size(194, 45)
        Me.btnNavPembayaran.TabIndex = 4
        Me.btnNavPembayaran.Text = "◈   Pembayaran"
        Me.btnNavPembayaran.UseVisualStyleBackColor = False
        '
        'btnNavAntrean
        '
        Me.btnNavAntrean.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavAntrean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavAntrean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavAntrean.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavAntrean.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNavAntrean.Location = New System.Drawing.Point(13, 304)
        Me.btnNavAntrean.Name = "btnNavAntrean"
        Me.btnNavAntrean.Size = New System.Drawing.Size(194, 45)
        Me.btnNavAntrean.TabIndex = 5
        Me.btnNavAntrean.Text = "☷   Antrean Dapur"
        Me.btnNavAntrean.UseVisualStyleBackColor = False
        '
        'btnNavStatusMenu
        '
        Me.btnNavStatusMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavStatusMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavStatusMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavStatusMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavStatusMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNavStatusMenu.Location = New System.Drawing.Point(13, 357)
        Me.btnNavStatusMenu.Name = "btnNavStatusMenu"
        Me.btnNavStatusMenu.Size = New System.Drawing.Size(194, 45)
        Me.btnNavStatusMenu.TabIndex = 6
        Me.btnNavStatusMenu.Text = "●   Status Menu"
        Me.btnNavStatusMenu.UseVisualStyleBackColor = False
        '
        'btnNavBahan
        '
        Me.btnNavBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavBahan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavBahan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNavBahan.Location = New System.Drawing.Point(13, 410)
        Me.btnNavBahan.Name = "btnNavBahan"
        Me.btnNavBahan.Size = New System.Drawing.Size(194, 45)
        Me.btnNavBahan.TabIndex = 7
        Me.btnNavBahan.Text = "▤   Pemakaian Bahan"
        Me.btnNavBahan.UseVisualStyleBackColor = False
        '
        'btnNavKoreksi
        '
        Me.btnNavKoreksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavKoreksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavKoreksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavKoreksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavKoreksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNavKoreksi.Location = New System.Drawing.Point(13, 463)
        Me.btnNavKoreksi.Name = "btnNavKoreksi"
        Me.btnNavKoreksi.Size = New System.Drawing.Size(194, 45)
        Me.btnNavKoreksi.TabIndex = 8
        Me.btnNavKoreksi.Text = "◷   Riwayat Koreksi"
        Me.btnNavKoreksi.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(13, 690)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(194, 45)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "↪   Keluar"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.lblRole)
        Me.pnlSidebar.Controls.Add(Me.btnNavDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnNavPesanan)
        Me.pnlSidebar.Controls.Add(Me.btnNavPembayaran)
        Me.pnlSidebar.Controls.Add(Me.btnNavAntrean)
        Me.pnlSidebar.Controls.Add(Me.btnNavStatusMenu)
        Me.pnlSidebar.Controls.Add(Me.btnNavBahan)
        Me.pnlSidebar.Controls.Add(Me.btnNavKoreksi)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 768)
        Me.pnlSidebar.TabIndex = 3
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.pnlInfoTransaksi)
        Me.pnlContent.Controls.Add(Me.lblInfo0)
        Me.pnlContent.Controls.Add(Me.lblInfoVal0)
        Me.pnlContent.Controls.Add(Me.lblInfo1)
        Me.pnlContent.Controls.Add(Me.lblInfoVal1)
        Me.pnlContent.Controls.Add(Me.lblInfo2)
        Me.pnlContent.Controls.Add(Me.lblInfoVal2)
        Me.pnlContent.Controls.Add(Me.pnlRincianBayar)
        Me.pnlContent.Controls.Add(Me.lblRincianTitle)
        Me.pnlContent.Controls.Add(Me.dgvRincianBayar)
        Me.pnlContent.Controls.Add(Me.pnlInputBayar)
        Me.pnlContent.Controls.Add(Me.lblTagihanTitle)
        Me.pnlContent.Controls.Add(Me.lblTotalTagihan)
        Me.pnlContent.Controls.Add(Me.lblUangDiterima)
        Me.pnlContent.Controls.Add(Me.txtUangDiterima)
        Me.pnlContent.Controls.Add(Me.lblMetode)
        Me.pnlContent.Controls.Add(Me.cmbMetode)
        Me.pnlContent.Controls.Add(Me.lblKembalian)
        Me.pnlContent.Controls.Add(Me.lblKembalianValue)
        Me.pnlContent.Controls.Add(Me.btnProsesPembayaran)
        Me.pnlContent.Controls.Add(Me.btnCetakStruk)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlContent)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        CType(Me.dgvRincianBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlInfoTransaksi As Panel
    Friend WithEvents lblInfo0 As Label
    Friend WithEvents lblInfoVal0 As Label
    Friend WithEvents lblInfo1 As Label
    Friend WithEvents lblInfoVal1 As Label
    Friend WithEvents lblInfoVal2 As Label
    Friend WithEvents pnlRincianBayar As Panel
    Friend WithEvents dgvRincianBayar As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents btnProsesPembayaran As Button
    Friend WithEvents lblRincianTitle As Label
    Friend WithEvents pnlInputBayar As Panel
    Friend WithEvents lblTagihanTitle As Label
    Friend WithEvents lblTotalTagihan As Label
    Friend WithEvents lblUangDiterima As Label
    Friend WithEvents txtUangDiterima As TextBox
    Friend WithEvents lblMetode As Label
    Friend WithEvents cmbMetode As ComboBox
    Friend WithEvents lblKembalian As Label
    Friend WithEvents lblKembalianValue As Label
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents btnCetakStruk As Button
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents pnlTopbar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavPesanan As Button
    Friend WithEvents btnNavPembayaran As Button
    Friend WithEvents btnNavAntrean As Button
    Friend WithEvents btnNavStatusMenu As Button
    Friend WithEvents btnNavBahan As Button
    Friend WithEvents btnNavKoreksi As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlContent As Panel
End Class
