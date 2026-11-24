<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.lblTabelStatus = New System.Windows.Forms.Label()
        Me.dgvStatusMenu = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTabelStatus = New System.Windows.Forms.Panel()
        Me.pnlEditStatus = New System.Windows.Forms.Panel()
        Me.lblEditStatusTitle = New System.Windows.Forms.Label()
        Me.lbltxtIdMenu = New System.Windows.Forms.Label()
        Me.txtIdMenu = New System.Windows.Forms.TextBox()
        Me.lbltxtNamaMenu = New System.Windows.Forms.Label()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatusMenu = New System.Windows.Forms.ComboBox()
        Me.lblStatusHint = New System.Windows.Forms.Label()
        Me.btnSimpanStatus = New System.Windows.Forms.Button()
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
        CType(Me.dgvStatusMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopbar.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTabelStatus
        '
        Me.lblTabelStatus.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTabelStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblTabelStatus.Location = New System.Drawing.Point(45, 38)
        Me.lblTabelStatus.Name = "lblTabelStatus"
        Me.lblTabelStatus.Size = New System.Drawing.Size(650, 32)
        Me.lblTabelStatus.TabIndex = 1
        Me.lblTabelStatus.Text = "DAFTAR MENU"
        Me.lblTabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvStatusMenu
        '
        Me.dgvStatusMenu.AllowUserToAddRows = False
        Me.dgvStatusMenu.AllowUserToDeleteRows = False
        Me.dgvStatusMenu.AllowUserToResizeRows = False
        Me.dgvStatusMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStatusMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStatusMenu.ColumnHeadersHeight = 38
        Me.dgvStatusMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.id, Me.nama, Me.harga, Me.status})
        Me.dgvStatusMenu.EnableHeadersVisualStyles = False
        Me.dgvStatusMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvStatusMenu.Location = New System.Drawing.Point(45, 82)
        Me.dgvStatusMenu.MultiSelect = False
        Me.dgvStatusMenu.Name = "dgvStatusMenu"
        Me.dgvStatusMenu.ReadOnly = True
        Me.dgvStatusMenu.RowHeadersVisible = False
        Me.dgvStatusMenu.RowHeadersWidth = 51
        Me.dgvStatusMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStatusMenu.Size = New System.Drawing.Size(660, 520)
        Me.dgvStatusMenu.TabIndex = 2
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
        'id
        '
        Me.id.FillWeight = 14.0!
        Me.id.HeaderText = "ID Menu"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'nama
        '
        Me.nama.FillWeight = 34.0!
        Me.nama.HeaderText = "Nama Menu"
        Me.nama.MinimumWidth = 6
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'status
        '
        Me.status.FillWeight = 24.0!
        Me.status.HeaderText = "Status Ketersediaan"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pnlTabelStatus
        '
        Me.pnlTabelStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlTabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTabelStatus.Location = New System.Drawing.Point(25, 22)
        Me.pnlTabelStatus.Name = "pnlTabelStatus"
        Me.pnlTabelStatus.Size = New System.Drawing.Size(700, 610)
        Me.pnlTabelStatus.TabIndex = 0
        '
        'pnlEditStatus
        '
        Me.pnlEditStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlEditStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEditStatus.Location = New System.Drawing.Point(750, 22)
        Me.pnlEditStatus.Name = "pnlEditStatus"
        Me.pnlEditStatus.Size = New System.Drawing.Size(365, 610)
        Me.pnlEditStatus.TabIndex = 3
        '
        'lblEditStatusTitle
        '
        Me.lblEditStatusTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblEditStatusTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblEditStatusTitle.Location = New System.Drawing.Point(770, 38)
        Me.lblEditStatusTitle.Name = "lblEditStatusTitle"
        Me.lblEditStatusTitle.Size = New System.Drawing.Size(325, 32)
        Me.lblEditStatusTitle.TabIndex = 4
        Me.lblEditStatusTitle.Text = "UBAH STATUS MENU"
        Me.lblEditStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltxtIdMenu
        '
        Me.lbltxtIdMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltxtIdMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbltxtIdMenu.Location = New System.Drawing.Point(770, 100)
        Me.lbltxtIdMenu.Name = "lbltxtIdMenu"
        Me.lbltxtIdMenu.Size = New System.Drawing.Size(315, 26)
        Me.lbltxtIdMenu.TabIndex = 5
        Me.lbltxtIdMenu.Text = "ID Menu"
        Me.lbltxtIdMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdMenu
        '
        Me.txtIdMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIdMenu.Location = New System.Drawing.Point(770, 130)
        Me.txtIdMenu.Name = "txtIdMenu"
        Me.txtIdMenu.Size = New System.Drawing.Size(315, 30)
        Me.txtIdMenu.TabIndex = 6
        '
        'lbltxtNamaMenu
        '
        Me.lbltxtNamaMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltxtNamaMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbltxtNamaMenu.Location = New System.Drawing.Point(770, 192)
        Me.lbltxtNamaMenu.Name = "lbltxtNamaMenu"
        Me.lbltxtNamaMenu.Size = New System.Drawing.Size(315, 26)
        Me.lbltxtNamaMenu.TabIndex = 7
        Me.lbltxtNamaMenu.Text = "Nama Menu"
        Me.lbltxtNamaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNamaMenu.Location = New System.Drawing.Point(770, 222)
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(315, 30)
        Me.txtNamaMenu.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(770, 284)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(315, 26)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status Ketersediaan"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbStatusMenu
        '
        Me.cmbStatusMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatusMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatusMenu.Location = New System.Drawing.Point(770, 314)
        Me.cmbStatusMenu.Name = "cmbStatusMenu"
        Me.cmbStatusMenu.Size = New System.Drawing.Size(315, 31)
        Me.cmbStatusMenu.TabIndex = 10
        '
        'lblStatusHint
        '
        Me.lblStatusHint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblStatusHint.Location = New System.Drawing.Point(770, 380)
        Me.lblStatusHint.Name = "lblStatusHint"
        Me.lblStatusHint.Size = New System.Drawing.Size(315, 70)
        Me.lblStatusHint.TabIndex = 11
        Me.lblStatusHint.Text = "Pilih Tersedia atau Habis. Perubahan akan terlihat oleh Kasir."
        Me.lblStatusHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSimpanStatus
        '
        Me.btnSimpanStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpanStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSimpanStatus.Location = New System.Drawing.Point(770, 500)
        Me.btnSimpanStatus.Name = "btnSimpanStatus"
        Me.btnSimpanStatus.Size = New System.Drawing.Size(315, 48)
        Me.btnSimpanStatus.TabIndex = 12
        Me.btnSimpanStatus.Text = "SIMPAN STATUS"
        Me.btnSimpanStatus.UseVisualStyleBackColor = False
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Status Ketersediaan Menu"
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
        Me.btnNavStatusMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavStatusMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavStatusMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavStatusMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavStatusMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
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
        Me.pnlContent.Controls.Add(Me.pnlTabelStatus)
        Me.pnlContent.Controls.Add(Me.lblTabelStatus)
        Me.pnlContent.Controls.Add(Me.dgvStatusMenu)
        Me.pnlContent.Controls.Add(Me.pnlEditStatus)
        Me.pnlContent.Controls.Add(Me.lblEditStatusTitle)
        Me.pnlContent.Controls.Add(Me.lbltxtIdMenu)
        Me.pnlContent.Controls.Add(Me.txtIdMenu)
        Me.pnlContent.Controls.Add(Me.lbltxtNamaMenu)
        Me.pnlContent.Controls.Add(Me.txtNamaMenu)
        Me.pnlContent.Controls.Add(Me.lblStatus)
        Me.pnlContent.Controls.Add(Me.cmbStatusMenu)
        Me.pnlContent.Controls.Add(Me.lblStatusHint)
        Me.pnlContent.Controls.Add(Me.btnSimpanStatus)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlContent)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Menu"
        CType(Me.dgvStatusMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTabelStatus As Label
    Friend WithEvents dgvStatusMenu As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents pnlTabelStatus As Panel
    Friend WithEvents pnlEditStatus As Panel
    Friend WithEvents lblEditStatusTitle As Label
    Friend WithEvents lbltxtIdMenu As Label
    Friend WithEvents txtIdMenu As TextBox
    Friend WithEvents lbltxtNamaMenu As Label
    Friend WithEvents txtNamaMenu As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatusMenu As ComboBox
    Friend WithEvents lblStatusHint As Label
    Friend WithEvents btnSimpanStatus As Button
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
