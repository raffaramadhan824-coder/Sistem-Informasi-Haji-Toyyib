<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFormBahan = New System.Windows.Forms.Panel()
        Me.lblFormBahan = New System.Windows.Forms.Label()
        Me.lbldtpTanggal = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblcmbJenisBahan = New System.Windows.Forms.Label()
        Me.cmbJenisBahan = New System.Windows.Forms.ComboBox()
        Me.lblnudJumlahBahan = New System.Windows.Forms.Label()
        Me.nudJumlahBahan = New System.Windows.Forms.NumericUpDown()
        Me.lblcmbSatuan = New System.Windows.Forms.Label()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.lblCatatanBahan = New System.Windows.Forms.Label()
        Me.txtCatatanBahan = New System.Windows.Forms.TextBox()
        Me.btnSimpanBahan = New System.Windows.Forms.Button()
        Me.btnBersihkanBahan = New System.Windows.Forms.Button()
        Me.pnlRiwayatBahan = New System.Windows.Forms.Panel()
        Me.lblRiwayatBahan = New System.Windows.Forms.Label()
        Me.dgvPemakaianBahan = New System.Windows.Forms.DataGridView()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
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
        Me.pnlTopbar = New System.Windows.Forms.Panel()
        Me.pnlContent.SuspendLayout()
        CType(Me.nudJumlahBahan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPemakaianBahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.FillWeight = 17.0!
        Me.user.HeaderText = "Dicatat Oleh"
        Me.user.MinimumWidth = 6
        Me.user.Name = "user"
        Me.user.ReadOnly = True
        Me.user.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'jumlah
        '
        Me.jumlah.FillWeight = 16.0!
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        Me.jumlah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bahan
        '
        Me.bahan.FillWeight = 25.0!
        Me.bahan.HeaderText = "Jenis Bahan"
        Me.bahan.MinimumWidth = 6
        Me.bahan.Name = "bahan"
        Me.bahan.ReadOnly = True
        Me.bahan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tanggal
        '
        Me.tanggal.FillWeight = 20.0!
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.MinimumWidth = 6
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'satuan
        '
        Me.satuan.FillWeight = 14.0!
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.MinimumWidth = 6
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        Me.satuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pnlFormBahan
        '
        Me.pnlFormBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlFormBahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormBahan.Location = New System.Drawing.Point(25, 22)
        Me.pnlFormBahan.Name = "pnlFormBahan"
        Me.pnlFormBahan.Size = New System.Drawing.Size(430, 630)
        Me.pnlFormBahan.TabIndex = 0
        '
        'lblFormBahan
        '
        Me.lblFormBahan.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblFormBahan.Location = New System.Drawing.Point(45, 38)
        Me.lblFormBahan.Name = "lblFormBahan"
        Me.lblFormBahan.Size = New System.Drawing.Size(390, 32)
        Me.lblFormBahan.TabIndex = 1
        Me.lblFormBahan.Text = "INPUT PEMAKAIAN BAHAN"
        Me.lblFormBahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldtpTanggal
        '
        Me.lbldtpTanggal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbldtpTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbldtpTanggal.Location = New System.Drawing.Point(45, 100)
        Me.lbldtpTanggal.Name = "lbldtpTanggal"
        Me.lbldtpTanggal.Size = New System.Drawing.Size(370, 25)
        Me.lbldtpTanggal.TabIndex = 2
        Me.lbldtpTanggal.Text = "Tanggal"
        Me.lbldtpTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.pnlFormBahan)
        Me.pnlContent.Controls.Add(Me.lblFormBahan)
        Me.pnlContent.Controls.Add(Me.lbldtpTanggal)
        Me.pnlContent.Controls.Add(Me.dtpTanggal)
        Me.pnlContent.Controls.Add(Me.lblcmbJenisBahan)
        Me.pnlContent.Controls.Add(Me.cmbJenisBahan)
        Me.pnlContent.Controls.Add(Me.lblnudJumlahBahan)
        Me.pnlContent.Controls.Add(Me.nudJumlahBahan)
        Me.pnlContent.Controls.Add(Me.lblcmbSatuan)
        Me.pnlContent.Controls.Add(Me.cmbSatuan)
        Me.pnlContent.Controls.Add(Me.lblCatatanBahan)
        Me.pnlContent.Controls.Add(Me.txtCatatanBahan)
        Me.pnlContent.Controls.Add(Me.btnSimpanBahan)
        Me.pnlContent.Controls.Add(Me.btnBersihkanBahan)
        Me.pnlContent.Controls.Add(Me.pnlRiwayatBahan)
        Me.pnlContent.Controls.Add(Me.lblRiwayatBahan)
        Me.pnlContent.Controls.Add(Me.dgvPemakaianBahan)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggal.Location = New System.Drawing.Point(45, 129)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(370, 30)
        Me.dtpTanggal.TabIndex = 3
        '
        'lblcmbJenisBahan
        '
        Me.lblcmbJenisBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblcmbJenisBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblcmbJenisBahan.Location = New System.Drawing.Point(45, 205)
        Me.lblcmbJenisBahan.Name = "lblcmbJenisBahan"
        Me.lblcmbJenisBahan.Size = New System.Drawing.Size(370, 25)
        Me.lblcmbJenisBahan.TabIndex = 4
        Me.lblcmbJenisBahan.Text = "Jenis Bahan"
        Me.lblcmbJenisBahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbJenisBahan
        '
        Me.cmbJenisBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbJenisBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbJenisBahan.Location = New System.Drawing.Point(45, 234)
        Me.cmbJenisBahan.Name = "cmbJenisBahan"
        Me.cmbJenisBahan.Size = New System.Drawing.Size(370, 31)
        Me.cmbJenisBahan.TabIndex = 5
        '
        'lblnudJumlahBahan
        '
        Me.lblnudJumlahBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblnudJumlahBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblnudJumlahBahan.Location = New System.Drawing.Point(45, 310)
        Me.lblnudJumlahBahan.Name = "lblnudJumlahBahan"
        Me.lblnudJumlahBahan.Size = New System.Drawing.Size(370, 25)
        Me.lblnudJumlahBahan.TabIndex = 6
        Me.lblnudJumlahBahan.Text = "Jumlah"
        Me.lblnudJumlahBahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudJumlahBahan
        '
        Me.nudJumlahBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudJumlahBahan.Location = New System.Drawing.Point(45, 339)
        Me.nudJumlahBahan.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudJumlahBahan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudJumlahBahan.Name = "nudJumlahBahan"
        Me.nudJumlahBahan.Size = New System.Drawing.Size(370, 30)
        Me.nudJumlahBahan.TabIndex = 7
        Me.nudJumlahBahan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblcmbSatuan
        '
        Me.lblcmbSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblcmbSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblcmbSatuan.Location = New System.Drawing.Point(45, 415)
        Me.lblcmbSatuan.Name = "lblcmbSatuan"
        Me.lblcmbSatuan.Size = New System.Drawing.Size(370, 25)
        Me.lblcmbSatuan.TabIndex = 8
        Me.lblcmbSatuan.Text = "Satuan"
        Me.lblcmbSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSatuan
        '
        Me.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSatuan.Location = New System.Drawing.Point(45, 444)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(370, 31)
        Me.cmbSatuan.TabIndex = 9
        '
        'lblCatatanBahan
        '
        Me.lblCatatanBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCatatanBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblCatatanBahan.Location = New System.Drawing.Point(45, 520)
        Me.lblCatatanBahan.Name = "lblCatatanBahan"
        Me.lblCatatanBahan.Size = New System.Drawing.Size(370, 24)
        Me.lblCatatanBahan.TabIndex = 10
        Me.lblCatatanBahan.Text = "Catatan"
        Me.lblCatatanBahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCatatanBahan
        '
        Me.txtCatatanBahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatatanBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCatatanBahan.Location = New System.Drawing.Point(45, 548)
        Me.txtCatatanBahan.Multiline = True
        Me.txtCatatanBahan.Name = "txtCatatanBahan"
        Me.txtCatatanBahan.Size = New System.Drawing.Size(370, 48)
        Me.txtCatatanBahan.TabIndex = 11
        '
        'btnSimpanBahan
        '
        Me.btnSimpanBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpanBahan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanBahan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSimpanBahan.Location = New System.Drawing.Point(45, 605)
        Me.btnSimpanBahan.Name = "btnSimpanBahan"
        Me.btnSimpanBahan.Size = New System.Drawing.Size(170, 40)
        Me.btnSimpanBahan.TabIndex = 12
        Me.btnSimpanBahan.Text = "SIMPAN"
        Me.btnSimpanBahan.UseVisualStyleBackColor = False
        '
        'btnBersihkanBahan
        '
        Me.btnBersihkanBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBersihkanBahan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBersihkanBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBersihkanBahan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBersihkanBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBersihkanBahan.Location = New System.Drawing.Point(230, 605)
        Me.btnBersihkanBahan.Name = "btnBersihkanBahan"
        Me.btnBersihkanBahan.Size = New System.Drawing.Size(185, 40)
        Me.btnBersihkanBahan.TabIndex = 13
        Me.btnBersihkanBahan.Text = "BERSIHKAN"
        Me.btnBersihkanBahan.UseVisualStyleBackColor = False
        '
        'pnlRiwayatBahan
        '
        Me.pnlRiwayatBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRiwayatBahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRiwayatBahan.Location = New System.Drawing.Point(480, 22)
        Me.pnlRiwayatBahan.Name = "pnlRiwayatBahan"
        Me.pnlRiwayatBahan.Size = New System.Drawing.Size(635, 630)
        Me.pnlRiwayatBahan.TabIndex = 14
        '
        'lblRiwayatBahan
        '
        Me.lblRiwayatBahan.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRiwayatBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblRiwayatBahan.Location = New System.Drawing.Point(500, 38)
        Me.lblRiwayatBahan.Name = "lblRiwayatBahan"
        Me.lblRiwayatBahan.Size = New System.Drawing.Size(590, 32)
        Me.lblRiwayatBahan.TabIndex = 15
        Me.lblRiwayatBahan.Text = "RIWAYAT PEMAKAIAN"
        Me.lblRiwayatBahan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvPemakaianBahan
        '
        Me.dgvPemakaianBahan.AllowUserToAddRows = False
        Me.dgvPemakaianBahan.AllowUserToDeleteRows = False
        Me.dgvPemakaianBahan.AllowUserToResizeRows = False
        Me.dgvPemakaianBahan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPemakaianBahan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPemakaianBahan.ColumnHeadersHeight = 38
        Me.dgvPemakaianBahan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.tanggal, Me.bahan, Me.jumlah, Me.satuan, Me.user})
        Me.dgvPemakaianBahan.EnableHeadersVisualStyles = False
        Me.dgvPemakaianBahan.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvPemakaianBahan.Location = New System.Drawing.Point(500, 82)
        Me.dgvPemakaianBahan.MultiSelect = False
        Me.dgvPemakaianBahan.Name = "dgvPemakaianBahan"
        Me.dgvPemakaianBahan.ReadOnly = True
        Me.dgvPemakaianBahan.RowHeadersVisible = False
        Me.dgvPemakaianBahan.RowHeadersWidth = 51
        Me.dgvPemakaianBahan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPemakaianBahan.Size = New System.Drawing.Size(595, 545)
        Me.dgvPemakaianBahan.TabIndex = 16
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Pemakaian Bahan Baku"
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
        Me.lblRole.Text = "LOGIN SEBAGAI  •  DAPUR"
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
        Me.btnNavPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnNavPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPembayaran.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.btnNavBahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavBahan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavBahan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavBahan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
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
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlTopbar)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemakaian Bahan"
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.nudJumlahBahan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPemakaianBahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTopbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents user As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents bahan As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents satuan As DataGridViewTextBoxColumn
    Friend WithEvents pnlFormBahan As Panel
    Friend WithEvents lblFormBahan As Label
    Friend WithEvents lbldtpTanggal As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblcmbJenisBahan As Label
    Friend WithEvents cmbJenisBahan As ComboBox
    Friend WithEvents lblnudJumlahBahan As Label
    Friend WithEvents nudJumlahBahan As NumericUpDown
    Friend WithEvents lblcmbSatuan As Label
    Friend WithEvents cmbSatuan As ComboBox
    Friend WithEvents lblCatatanBahan As Label
    Friend WithEvents txtCatatanBahan As TextBox
    Friend WithEvents btnSimpanBahan As Button
    Friend WithEvents btnBersihkanBahan As Button
    Friend WithEvents pnlRiwayatBahan As Panel
    Friend WithEvents lblRiwayatBahan As Label
    Friend WithEvents dgvPemakaianBahan As DataGridView
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents pnlSidebar As Panel
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
    Friend WithEvents pnlTopbar As Panel
End Class
