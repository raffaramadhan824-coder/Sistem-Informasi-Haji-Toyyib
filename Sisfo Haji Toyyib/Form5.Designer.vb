<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.pnlAksiAntrean = New System.Windows.Forms.Panel()
        Me.lblAksiAntrean = New System.Windows.Forms.Label()
        Me.btnTandaiSelesai = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFilterDiproses = New System.Windows.Forms.Button()
        Me.btnFilterSelesai = New System.Windows.Forms.Button()
        Me.btnFilterSemua = New System.Windows.Forms.Button()
        Me.lblAntreanInfo = New System.Windows.Forms.Label()
        Me.dgvAntrean = New System.Windows.Forms.DataGridView()
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
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.pnlTopbar = New System.Windows.Forms.Panel()
        Me.btnMulaiProses = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        CType(Me.dgvAntrean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopbar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAksiAntrean
        '
        Me.pnlAksiAntrean.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAksiAntrean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAksiAntrean.Location = New System.Drawing.Point(25, 550)
        Me.pnlAksiAntrean.Name = "pnlAksiAntrean"
        Me.pnlAksiAntrean.Size = New System.Drawing.Size(1090, 90)
        Me.pnlAksiAntrean.TabIndex = 5
        '
        'lblAksiAntrean
        '
        Me.lblAksiAntrean.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAksiAntrean.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblAksiAntrean.Location = New System.Drawing.Point(45, 562)
        Me.lblAksiAntrean.Name = "lblAksiAntrean"
        Me.lblAksiAntrean.Size = New System.Drawing.Size(300, 28)
        Me.lblAksiAntrean.TabIndex = 6
        Me.lblAksiAntrean.Text = "AKSI PESANAN TERPILIH"
        Me.lblAksiAntrean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTandaiSelesai
        '
        Me.btnTandaiSelesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnTandaiSelesai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTandaiSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTandaiSelesai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTandaiSelesai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnTandaiSelesai.Location = New System.Drawing.Point(615, 575)
        Me.btnTandaiSelesai.Name = "btnTandaiSelesai"
        Me.btnTandaiSelesai.Size = New System.Drawing.Size(235, 45)
        Me.btnTandaiSelesai.TabIndex = 8
        Me.btnTandaiSelesai.Text = "TANDAI SELESAI"
        Me.btnTandaiSelesai.UseVisualStyleBackColor = False
        '
        'status
        '
        Me.status.FillWeight = 17.0!
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pesanan
        '
        Me.pesanan.FillWeight = 27.0!
        Me.pesanan.HeaderText = "Detail Pesanan"
        Me.pesanan.MinimumWidth = 6
        Me.pesanan.Name = "pesanan"
        Me.pesanan.ReadOnly = True
        Me.pesanan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pelanggan
        '
        Me.pelanggan.FillWeight = 18.0!
        Me.pelanggan.HeaderText = "Pelanggan"
        Me.pelanggan.MinimumWidth = 6
        Me.pelanggan.Name = "pelanggan"
        Me.pelanggan.ReadOnly = True
        Me.pelanggan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'waktu
        '
        Me.waktu.FillWeight = 14.0!
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.MinimumWidth = 6
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        Me.waktu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'trx
        '
        Me.trx.FillWeight = 18.0!
        Me.trx.HeaderText = "No. Transaksi"
        Me.trx.MinimumWidth = 6
        Me.trx.Name = "trx"
        Me.trx.ReadOnly = True
        Me.trx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'no
        '
        Me.no.FillWeight = 6.0!
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnFilterDiproses
        '
        Me.btnFilterDiproses.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnFilterDiproses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterDiproses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterDiproses.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFilterDiproses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnFilterDiproses.Location = New System.Drawing.Point(25, 22)
        Me.btnFilterDiproses.Name = "btnFilterDiproses"
        Me.btnFilterDiproses.Size = New System.Drawing.Size(155, 42)
        Me.btnFilterDiproses.TabIndex = 0
        Me.btnFilterDiproses.Text = "DIPROSES"
        Me.btnFilterDiproses.UseVisualStyleBackColor = False
        '
        'btnFilterSelesai
        '
        Me.btnFilterSelesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFilterSelesai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterSelesai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFilterSelesai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSelesai.Location = New System.Drawing.Point(190, 22)
        Me.btnFilterSelesai.Name = "btnFilterSelesai"
        Me.btnFilterSelesai.Size = New System.Drawing.Size(155, 42)
        Me.btnFilterSelesai.TabIndex = 1
        Me.btnFilterSelesai.Text = "SELESAI"
        Me.btnFilterSelesai.UseVisualStyleBackColor = False
        '
        'btnFilterSemua
        '
        Me.btnFilterSemua.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFilterSemua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterSemua.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFilterSemua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSemua.Location = New System.Drawing.Point(355, 22)
        Me.btnFilterSemua.Name = "btnFilterSemua"
        Me.btnFilterSemua.Size = New System.Drawing.Size(155, 42)
        Me.btnFilterSemua.TabIndex = 2
        Me.btnFilterSemua.Text = "SEMUA"
        Me.btnFilterSemua.UseVisualStyleBackColor = False
        '
        'lblAntreanInfo
        '
        Me.lblAntreanInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAntreanInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblAntreanInfo.Location = New System.Drawing.Point(535, 22)
        Me.lblAntreanInfo.Name = "lblAntreanInfo"
        Me.lblAntreanInfo.Size = New System.Drawing.Size(570, 42)
        Me.lblAntreanInfo.TabIndex = 3
        Me.lblAntreanInfo.Text = "Pilih pesanan untuk melihat detail dan memperbarui status pengerjaan."
        Me.lblAntreanInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvAntrean
        '
        Me.dgvAntrean.AllowUserToAddRows = False
        Me.dgvAntrean.AllowUserToDeleteRows = False
        Me.dgvAntrean.AllowUserToResizeRows = False
        Me.dgvAntrean.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAntrean.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAntrean.ColumnHeadersHeight = 38
        Me.dgvAntrean.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.trx, Me.waktu, Me.pelanggan, Me.pesanan, Me.status})
        Me.dgvAntrean.EnableHeadersVisualStyles = False
        Me.dgvAntrean.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvAntrean.Location = New System.Drawing.Point(25, 88)
        Me.dgvAntrean.MultiSelect = False
        Me.dgvAntrean.Name = "dgvAntrean"
        Me.dgvAntrean.ReadOnly = True
        Me.dgvAntrean.RowHeadersVisible = False
        Me.dgvAntrean.RowHeadersWidth = 51
        Me.dgvAntrean.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAntrean.Size = New System.Drawing.Size(1090, 440)
        Me.dgvAntrean.TabIndex = 4
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
        Me.btnNavAntrean.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavAntrean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavAntrean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavAntrean.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavAntrean.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
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
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Antrean Pesanan Dapur"
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
        'btnMulaiProses
        '
        Me.btnMulaiProses.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMulaiProses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMulaiProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulaiProses.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMulaiProses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMulaiProses.Location = New System.Drawing.Point(380, 575)
        Me.btnMulaiProses.Name = "btnMulaiProses"
        Me.btnMulaiProses.Size = New System.Drawing.Size(220, 45)
        Me.btnMulaiProses.TabIndex = 7
        Me.btnMulaiProses.Text = "MULAI DIPROSES"
        Me.btnMulaiProses.UseVisualStyleBackColor = False
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.btnFilterDiproses)
        Me.pnlContent.Controls.Add(Me.btnFilterSelesai)
        Me.pnlContent.Controls.Add(Me.btnFilterSemua)
        Me.pnlContent.Controls.Add(Me.lblAntreanInfo)
        Me.pnlContent.Controls.Add(Me.dgvAntrean)
        Me.pnlContent.Controls.Add(Me.pnlAksiAntrean)
        Me.pnlContent.Controls.Add(Me.lblAksiAntrean)
        Me.pnlContent.Controls.Add(Me.btnMulaiProses)
        Me.pnlContent.Controls.Add(Me.btnTandaiSelesai)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlContent)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antrean Pesanan Dapur"
        CType(Me.dgvAntrean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAksiAntrean As Panel
    Friend WithEvents lblAksiAntrean As Label
    Friend WithEvents btnTandaiSelesai As Button
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents pesanan As DataGridViewTextBoxColumn
    Friend WithEvents pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents waktu As DataGridViewTextBoxColumn
    Friend WithEvents trx As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents btnFilterDiproses As Button
    Friend WithEvents btnFilterSelesai As Button
    Friend WithEvents btnFilterSemua As Button
    Friend WithEvents lblAntreanInfo As Label
    Friend WithEvents dgvAntrean As DataGridView
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
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents pnlTopbar As Panel
    Friend WithEvents btnMulaiProses As Button
    Friend WithEvents pnlContent As Panel
End Class
