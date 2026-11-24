<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.cmbFilterJenis = New System.Windows.Forms.ComboBox()
        Me.sebelum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alasan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referensi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFilterJenis = New System.Windows.Forms.Label()
        Me.lblFilterDari = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblFilterSampai = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.txtCariKoreksi = New System.Windows.Forms.TextBox()
        Me.btnCariKoreksi = New System.Windows.Forms.Button()
        Me.dgvRiwayatKoreksi = New System.Windows.Forms.DataGridView()
        Me.sesudah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblKoreksiNote = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
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
        CType(Me.dgvRiwayatKoreksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.pnlTopbar.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbFilterJenis
        '
        Me.cmbFilterJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFilterJenis.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilterJenis.Location = New System.Drawing.Point(25, 50)
        Me.cmbFilterJenis.Name = "cmbFilterJenis"
        Me.cmbFilterJenis.Size = New System.Drawing.Size(210, 31)
        Me.cmbFilterJenis.TabIndex = 1
        '
        'sebelum
        '
        Me.sebelum.FillWeight = 20.0!
        Me.sebelum.HeaderText = "Data Sebelum"
        Me.sebelum.MinimumWidth = 6
        Me.sebelum.Name = "sebelum"
        Me.sebelum.ReadOnly = True
        Me.sebelum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'alasan
        '
        Me.alasan.FillWeight = 20.0!
        Me.alasan.HeaderText = "Alasan Koreksi"
        Me.alasan.MinimumWidth = 6
        Me.alasan.Name = "alasan"
        Me.alasan.ReadOnly = True
        Me.alasan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'referensi
        '
        Me.referensi.FillWeight = 15.0!
        Me.referensi.HeaderText = "ID Referensi"
        Me.referensi.MinimumWidth = 6
        Me.referensi.Name = "referensi"
        Me.referensi.ReadOnly = True
        Me.referensi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'jenis
        '
        Me.jenis.FillWeight = 14.0!
        Me.jenis.HeaderText = "Jenis Data"
        Me.jenis.MinimumWidth = 6
        Me.jenis.Name = "jenis"
        Me.jenis.ReadOnly = True
        Me.jenis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user
        '
        Me.user.FillWeight = 12.0!
        Me.user.HeaderText = "User"
        Me.user.MinimumWidth = 6
        Me.user.Name = "user"
        Me.user.ReadOnly = True
        Me.user.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tanggal
        '
        Me.tanggal.FillWeight = 15.0!
        Me.tanggal.HeaderText = "Tanggal & Waktu"
        Me.tanggal.MinimumWidth = 6
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'no
        '
        Me.no.FillWeight = 5.0!
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblFilterJenis
        '
        Me.lblFilterJenis.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilterJenis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblFilterJenis.Location = New System.Drawing.Point(25, 22)
        Me.lblFilterJenis.Name = "lblFilterJenis"
        Me.lblFilterJenis.Size = New System.Drawing.Size(130, 25)
        Me.lblFilterJenis.TabIndex = 0
        Me.lblFilterJenis.Text = "Jenis Data"
        Me.lblFilterJenis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFilterDari
        '
        Me.lblFilterDari.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilterDari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblFilterDari.Location = New System.Drawing.Point(260, 22)
        Me.lblFilterDari.Name = "lblFilterDari"
        Me.lblFilterDari.Size = New System.Drawing.Size(150, 25)
        Me.lblFilterDari.TabIndex = 2
        Me.lblFilterDari.Text = "Dari Tanggal"
        Me.lblFilterDari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDari
        '
        Me.dtpDari.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDari.Location = New System.Drawing.Point(260, 50)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(190, 30)
        Me.dtpDari.TabIndex = 3
        '
        'lblFilterSampai
        '
        Me.lblFilterSampai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilterSampai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblFilterSampai.Location = New System.Drawing.Point(470, 22)
        Me.lblFilterSampai.Name = "lblFilterSampai"
        Me.lblFilterSampai.Size = New System.Drawing.Size(150, 25)
        Me.lblFilterSampai.TabIndex = 4
        Me.lblFilterSampai.Text = "Sampai Tanggal"
        Me.lblFilterSampai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpSampai
        '
        Me.dtpSampai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSampai.Location = New System.Drawing.Point(470, 50)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(190, 30)
        Me.dtpSampai.TabIndex = 5
        '
        'txtCariKoreksi
        '
        Me.txtCariKoreksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCariKoreksi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCariKoreksi.Location = New System.Drawing.Point(680, 50)
        Me.txtCariKoreksi.Name = "txtCariKoreksi"
        Me.txtCariKoreksi.Size = New System.Drawing.Size(250, 30)
        Me.txtCariKoreksi.TabIndex = 6
        '
        'btnCariKoreksi
        '
        Me.btnCariKoreksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnCariKoreksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariKoreksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariKoreksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCariKoreksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCariKoreksi.Location = New System.Drawing.Point(940, 50)
        Me.btnCariKoreksi.Name = "btnCariKoreksi"
        Me.btnCariKoreksi.Size = New System.Drawing.Size(175, 38)
        Me.btnCariKoreksi.TabIndex = 7
        Me.btnCariKoreksi.Text = "CARI"
        Me.btnCariKoreksi.UseVisualStyleBackColor = False
        '
        'dgvRiwayatKoreksi
        '
        Me.dgvRiwayatKoreksi.AllowUserToAddRows = False
        Me.dgvRiwayatKoreksi.AllowUserToDeleteRows = False
        Me.dgvRiwayatKoreksi.AllowUserToResizeRows = False
        Me.dgvRiwayatKoreksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRiwayatKoreksi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRiwayatKoreksi.ColumnHeadersHeight = 38
        Me.dgvRiwayatKoreksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.tanggal, Me.user, Me.jenis, Me.referensi, Me.alasan, Me.sebelum, Me.sesudah})
        Me.dgvRiwayatKoreksi.EnableHeadersVisualStyles = False
        Me.dgvRiwayatKoreksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvRiwayatKoreksi.Location = New System.Drawing.Point(25, 115)
        Me.dgvRiwayatKoreksi.MultiSelect = False
        Me.dgvRiwayatKoreksi.Name = "dgvRiwayatKoreksi"
        Me.dgvRiwayatKoreksi.ReadOnly = True
        Me.dgvRiwayatKoreksi.RowHeadersVisible = False
        Me.dgvRiwayatKoreksi.RowHeadersWidth = 51
        Me.dgvRiwayatKoreksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRiwayatKoreksi.Size = New System.Drawing.Size(1090, 500)
        Me.dgvRiwayatKoreksi.TabIndex = 8
        '
        'sesudah
        '
        Me.sesudah.FillWeight = 20.0!
        Me.sesudah.HeaderText = "Data Sesudah"
        Me.sesudah.MinimumWidth = 6
        Me.sesudah.Name = "sesudah"
        Me.sesudah.ReadOnly = True
        Me.sesudah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblKoreksiNote
        '
        Me.lblKoreksiNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKoreksiNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblKoreksiNote.Location = New System.Drawing.Point(25, 630)
        Me.lblKoreksiNote.Name = "lblKoreksiNote"
        Me.lblKoreksiNote.Size = New System.Drawing.Size(1090, 28)
        Me.lblKoreksiNote.TabIndex = 9
        Me.lblKoreksiNote.Text = "Riwayat koreksi disimpan untuk menjaga keterlacakan perubahan data."
        Me.lblKoreksiNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.lblFilterJenis)
        Me.pnlContent.Controls.Add(Me.cmbFilterJenis)
        Me.pnlContent.Controls.Add(Me.lblFilterDari)
        Me.pnlContent.Controls.Add(Me.dtpDari)
        Me.pnlContent.Controls.Add(Me.lblFilterSampai)
        Me.pnlContent.Controls.Add(Me.dtpSampai)
        Me.pnlContent.Controls.Add(Me.txtCariKoreksi)
        Me.pnlContent.Controls.Add(Me.btnCariKoreksi)
        Me.pnlContent.Controls.Add(Me.dgvRiwayatKoreksi)
        Me.pnlContent.Controls.Add(Me.lblKoreksiNote)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Riwayat Koreksi Data"
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
        Me.lblRole.Text = "LOGIN SEBAGAI  •  PEMILIK / ADMIN"
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
        Me.btnNavKoreksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavKoreksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavKoreksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavKoreksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavKoreksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
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
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Riwayat koreksi"
        CType(Me.dgvRiwayatKoreksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbFilterJenis As ComboBox
    Friend WithEvents sebelum As DataGridViewTextBoxColumn
    Friend WithEvents alasan As DataGridViewTextBoxColumn
    Friend WithEvents referensi As DataGridViewTextBoxColumn
    Friend WithEvents jenis As DataGridViewTextBoxColumn
    Friend WithEvents user As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents lblFilterJenis As Label
    Friend WithEvents lblFilterDari As Label
    Friend WithEvents dtpDari As DateTimePicker
    Friend WithEvents lblFilterSampai As Label
    Friend WithEvents dtpSampai As DateTimePicker
    Friend WithEvents txtCariKoreksi As TextBox
    Friend WithEvents btnCariKoreksi As Button
    Friend WithEvents dgvRiwayatKoreksi As DataGridView
    Friend WithEvents sesudah As DataGridViewTextBoxColumn
    Friend WithEvents lblKoreksiNote As Label
    Friend WithEvents pnlContent As Panel
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
End Class
