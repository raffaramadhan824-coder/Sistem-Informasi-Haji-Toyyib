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
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.lblCariMenu = New System.Windows.Forms.Label()
        Me.txtCariMenu = New System.Windows.Forms.TextBox()
        Me.lblMenuTitle = New System.Windows.Forms.Label()
        Me.btnAyam = New System.Windows.Forms.Button()
        Me.btnLele = New System.Windows.Forms.Button()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTempe = New System.Windows.Forms.Button()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEsTeh = New System.Windows.Forms.Button()
        Me.pnlDetail = New System.Windows.Forms.Panel()
        Me.lblDetailTitle = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.nudJumlah = New System.Windows.Forms.NumericUpDown()
        Me.btnHapusItem = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.btnSimpanPesanan = New System.Windows.Forms.Button()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.btnBatalPesanan = New System.Windows.Forms.Button()
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
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopbar.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(25, 18)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(230, 28)
        Me.lblNamaPelanggan.TabIndex = 0
        Me.lblNamaPelanggan.Text = "Nama Pelanggan"
        Me.lblNamaPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPelanggan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(25, 48)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(360, 30)
        Me.txtNamaPelanggan.TabIndex = 1
        '
        'lblCariMenu
        '
        Me.lblCariMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCariMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblCariMenu.Location = New System.Drawing.Point(410, 18)
        Me.lblCariMenu.Name = "lblCariMenu"
        Me.lblCariMenu.Size = New System.Drawing.Size(220, 28)
        Me.lblCariMenu.TabIndex = 2
        Me.lblCariMenu.Text = "Cari Menu"
        Me.lblCariMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCariMenu
        '
        Me.txtCariMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCariMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCariMenu.Location = New System.Drawing.Point(410, 48)
        Me.txtCariMenu.Name = "txtCariMenu"
        Me.txtCariMenu.Size = New System.Drawing.Size(330, 30)
        Me.txtCariMenu.TabIndex = 3
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblMenuTitle.Location = New System.Drawing.Point(25, 108)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(680, 32)
        Me.lblMenuTitle.TabIndex = 4
        Me.lblMenuTitle.Text = "PILIH MENU"
        Me.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAyam
        '
        Me.btnAyam.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAyam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAyam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyam.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAyam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnAyam.Location = New System.Drawing.Point(25, 150)
        Me.btnAyam.Name = "btnAyam"
        Me.btnAyam.Size = New System.Drawing.Size(200, 95)
        Me.btnAyam.TabIndex = 5
        Me.btnAyam.Text = "PENYETAN AYAM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rp15.000"
        Me.btnAyam.UseVisualStyleBackColor = False
        '
        'btnLele
        '
        Me.btnLele.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLele.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLele.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLele.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLele.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLele.Location = New System.Drawing.Point(245, 150)
        Me.btnLele.Name = "btnLele"
        Me.btnLele.Size = New System.Drawing.Size(200, 95)
        Me.btnLele.TabIndex = 6
        Me.btnLele.Text = "PENYETAN LELE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rp13.000"
        Me.btnLele.UseVisualStyleBackColor = False
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
        Me.menu.FillWeight = 28.0!
        Me.menu.HeaderText = "Menu"
        Me.menu.MinimumWidth = 6
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        Me.menu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnTempe
        '
        Me.btnTempe.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnTempe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTempe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTempe.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTempe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTempe.Location = New System.Drawing.Point(465, 150)
        Me.btnTempe.Name = "btnTempe"
        Me.btnTempe.Size = New System.Drawing.Size(200, 95)
        Me.btnTempe.TabIndex = 7
        Me.btnTempe.Text = "PENYETAN TEMPE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rp8.000"
        Me.btnTempe.UseVisualStyleBackColor = False
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
        'subtotal
        '
        Me.subtotal.FillWeight = 24.0!
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.MinimumWidth = 6
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnEsTeh
        '
        Me.btnEsTeh.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnEsTeh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEsTeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEsTeh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEsTeh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEsTeh.Location = New System.Drawing.Point(25, 270)
        Me.btnEsTeh.Name = "btnEsTeh"
        Me.btnEsTeh.Size = New System.Drawing.Size(200, 95)
        Me.btnEsTeh.TabIndex = 8
        Me.btnEsTeh.Text = "ES TEH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rp4.000"
        Me.btnEsTeh.UseVisualStyleBackColor = False
        '
        'pnlDetail
        '
        Me.pnlDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetail.Location = New System.Drawing.Point(705, 108)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(410, 510)
        Me.pnlDetail.TabIndex = 9
        '
        'lblDetailTitle
        '
        Me.lblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblDetailTitle.Location = New System.Drawing.Point(725, 125)
        Me.lblDetailTitle.Name = "lblDetailTitle"
        Me.lblDetailTitle.Size = New System.Drawing.Size(370, 32)
        Me.lblDetailTitle.TabIndex = 10
        Me.lblDetailTitle.Text = "DETAIL PESANAN"
        Me.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQty
        '
        Me.lblQty.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblQty.Location = New System.Drawing.Point(725, 490)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(85, 28)
        Me.lblQty.TabIndex = 12
        Me.lblQty.Text = "Jumlah"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudJumlah
        '
        Me.nudJumlah.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudJumlah.Location = New System.Drawing.Point(805, 486)
        Me.nudJumlah.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudJumlah.Name = "nudJumlah"
        Me.nudJumlah.Size = New System.Drawing.Size(85, 30)
        Me.nudJumlah.TabIndex = 13
        Me.nudJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnHapusItem
        '
        Me.btnHapusItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnHapusItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapusItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapusItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHapusItem.Location = New System.Drawing.Point(900, 486)
        Me.btnHapusItem.Name = "btnHapusItem"
        Me.btnHapusItem.Size = New System.Drawing.Size(195, 36)
        Me.btnHapusItem.TabIndex = 14
        Me.btnHapusItem.Text = "Hapus Item"
        Me.btnHapusItem.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(725, 540)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 32)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "TOTAL"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalValue
        '
        Me.lblTotalValue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblTotalValue.Location = New System.Drawing.Point(915, 535)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(180, 40)
        Me.lblTotalValue.TabIndex = 16
        Me.lblTotalValue.Text = "Rp0"
        Me.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSimpanPesanan
        '
        Me.btnSimpanPesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSimpanPesanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanPesanan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpanPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSimpanPesanan.Location = New System.Drawing.Point(725, 570)
        Me.btnSimpanPesanan.Name = "btnSimpanPesanan"
        Me.btnSimpanPesanan.Size = New System.Drawing.Size(190, 42)
        Me.btnSimpanPesanan.TabIndex = 17
        Me.btnSimpanPesanan.Text = "SIMPAN PESANAN"
        Me.btnSimpanPesanan.UseVisualStyleBackColor = False
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
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.AllowUserToResizeRows = False
        Me.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetail.ColumnHeadersHeight = 38
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.menu, Me.qty, Me.harga, Me.subtotal})
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(725, 170)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.ReadOnly = True
        Me.dgvDetail.RowHeadersVisible = False
        Me.dgvDetail.RowHeadersWidth = 51
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(370, 300)
        Me.dgvDetail.TabIndex = 11
        '
        'btnBatalPesanan
        '
        Me.btnBatalPesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatalPesanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatalPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatalPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatalPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBatalPesanan.Location = New System.Drawing.Point(925, 570)
        Me.btnBatalPesanan.Name = "btnBatalPesanan"
        Me.btnBatalPesanan.Size = New System.Drawing.Size(170, 42)
        Me.btnBatalPesanan.TabIndex = 18
        Me.btnBatalPesanan.Text = "BATAL"
        Me.btnBatalPesanan.UseVisualStyleBackColor = False
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Pemesanan Kasir"
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
        Me.btnNavPesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavPesanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavPesanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
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
        Me.pnlContent.Controls.Add(Me.lblNamaPelanggan)
        Me.pnlContent.Controls.Add(Me.txtNamaPelanggan)
        Me.pnlContent.Controls.Add(Me.lblCariMenu)
        Me.pnlContent.Controls.Add(Me.txtCariMenu)
        Me.pnlContent.Controls.Add(Me.lblMenuTitle)
        Me.pnlContent.Controls.Add(Me.btnAyam)
        Me.pnlContent.Controls.Add(Me.btnLele)
        Me.pnlContent.Controls.Add(Me.btnTempe)
        Me.pnlContent.Controls.Add(Me.btnEsTeh)
        Me.pnlContent.Controls.Add(Me.pnlDetail)
        Me.pnlContent.Controls.Add(Me.lblDetailTitle)
        Me.pnlContent.Controls.Add(Me.dgvDetail)
        Me.pnlContent.Controls.Add(Me.lblQty)
        Me.pnlContent.Controls.Add(Me.nudJumlah)
        Me.pnlContent.Controls.Add(Me.btnHapusItem)
        Me.pnlContent.Controls.Add(Me.lblTotal)
        Me.pnlContent.Controls.Add(Me.lblTotalValue)
        Me.pnlContent.Controls.Add(Me.btnSimpanPesanan)
        Me.pnlContent.Controls.Add(Me.btnBatalPesanan)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlContent)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemesanan"
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents lblCariMenu As Label
    Friend WithEvents txtCariMenu As TextBox
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnAyam As Button
    Friend WithEvents btnLele As Button
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents btnTempe As Button
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btnEsTeh As Button
    Friend WithEvents pnlDetail As Panel
    Friend WithEvents lblDetailTitle As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents nudJumlah As NumericUpDown
    Friend WithEvents btnHapusItem As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents btnSimpanPesanan As Button
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents btnBatalPesanan As Button
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
