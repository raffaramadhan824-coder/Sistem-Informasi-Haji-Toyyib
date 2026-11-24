<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.pnlKpi1 = New System.Windows.Forms.Panel()
        Me.lblKpi1Title = New System.Windows.Forms.Label()
        Me.lblKpi1Value = New System.Windows.Forms.Label()
        Me.pnlKpi2 = New System.Windows.Forms.Panel()
        Me.lblKpi2Title = New System.Windows.Forms.Label()
        Me.lblKpi2Value = New System.Windows.Forms.Label()
        Me.pnlKpi3 = New System.Windows.Forms.Panel()
        Me.lblKpi3Title = New System.Windows.Forms.Label()
        Me.lblKpi3Value = New System.Windows.Forms.Label()
        Me.pnlKpi4 = New System.Windows.Forms.Panel()
        Me.lblKpi4Title = New System.Windows.Forms.Label()
        Me.lblKpi4Value = New System.Windows.Forms.Label()
        Me.pnlRecent = New System.Windows.Forms.Panel()
        Me.lblRecentTitle = New System.Windows.Forms.Label()
        Me.trx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBest = New System.Windows.Forms.Panel()
        Me.lblBestTitle = New System.Windows.Forms.Label()
        Me.lblBest1 = New System.Windows.Forms.Label()
        Me.lblBestQty1 = New System.Windows.Forms.Label()
        Me.lblBest2 = New System.Windows.Forms.Label()
        Me.lblBestQty2 = New System.Windows.Forms.Label()
        Me.lblBest3 = New System.Windows.Forms.Label()
        Me.lblBestQty3 = New System.Windows.Forms.Label()
        Me.lblBest4 = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.lblBestQty4 = New System.Windows.Forms.Label()
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
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopbar.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlKpi1
        '
        Me.pnlKpi1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlKpi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKpi1.Location = New System.Drawing.Point(25, 25)
        Me.pnlKpi1.Name = "pnlKpi1"
        Me.pnlKpi1.Size = New System.Drawing.Size(235, 130)
        Me.pnlKpi1.TabIndex = 0
        '
        'lblKpi1Title
        '
        Me.lblKpi1Title.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblKpi1Title.Location = New System.Drawing.Point(41, 43)
        Me.lblKpi1Title.Name = "lblKpi1Title"
        Me.lblKpi1Title.Size = New System.Drawing.Size(205, 25)
        Me.lblKpi1Title.TabIndex = 1
        Me.lblKpi1Title.Text = "TRANSAKSI HARI INI"
        Me.lblKpi1Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKpi1Value
        '
        Me.lblKpi1Value.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi1Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblKpi1Value.Location = New System.Drawing.Point(41, 78)
        Me.lblKpi1Value.Name = "lblKpi1Value"
        Me.lblKpi1Value.Size = New System.Drawing.Size(205, 50)
        Me.lblKpi1Value.TabIndex = 2
        Me.lblKpi1Value.Text = "12"
        Me.lblKpi1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlKpi2
        '
        Me.pnlKpi2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlKpi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKpi2.Location = New System.Drawing.Point(290, 25)
        Me.pnlKpi2.Name = "pnlKpi2"
        Me.pnlKpi2.Size = New System.Drawing.Size(235, 130)
        Me.pnlKpi2.TabIndex = 3
        '
        'lblKpi2Title
        '
        Me.lblKpi2Title.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblKpi2Title.Location = New System.Drawing.Point(306, 43)
        Me.lblKpi2Title.Name = "lblKpi2Title"
        Me.lblKpi2Title.Size = New System.Drawing.Size(205, 25)
        Me.lblKpi2Title.TabIndex = 4
        Me.lblKpi2Title.Text = "MENU TERSEDIA"
        Me.lblKpi2Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKpi2Value
        '
        Me.lblKpi2Value.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi2Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblKpi2Value.Location = New System.Drawing.Point(306, 78)
        Me.lblKpi2Value.Name = "lblKpi2Value"
        Me.lblKpi2Value.Size = New System.Drawing.Size(205, 50)
        Me.lblKpi2Value.TabIndex = 5
        Me.lblKpi2Value.Text = "4"
        Me.lblKpi2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlKpi3
        '
        Me.pnlKpi3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlKpi3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKpi3.Location = New System.Drawing.Point(555, 25)
        Me.pnlKpi3.Name = "pnlKpi3"
        Me.pnlKpi3.Size = New System.Drawing.Size(235, 130)
        Me.pnlKpi3.TabIndex = 6
        '
        'lblKpi3Title
        '
        Me.lblKpi3Title.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblKpi3Title.Location = New System.Drawing.Point(571, 43)
        Me.lblKpi3Title.Name = "lblKpi3Title"
        Me.lblKpi3Title.Size = New System.Drawing.Size(205, 25)
        Me.lblKpi3Title.TabIndex = 7
        Me.lblKpi3Title.Text = "PENDAPATAN HARI INI"
        Me.lblKpi3Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKpi3Value
        '
        Me.lblKpi3Value.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi3Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblKpi3Value.Location = New System.Drawing.Point(571, 78)
        Me.lblKpi3Value.Name = "lblKpi3Value"
        Me.lblKpi3Value.Size = New System.Drawing.Size(205, 50)
        Me.lblKpi3Value.TabIndex = 8
        Me.lblKpi3Value.Text = "Rp160.000"
        Me.lblKpi3Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlKpi4
        '
        Me.pnlKpi4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlKpi4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKpi4.Location = New System.Drawing.Point(820, 25)
        Me.pnlKpi4.Name = "pnlKpi4"
        Me.pnlKpi4.Size = New System.Drawing.Size(235, 130)
        Me.pnlKpi4.TabIndex = 9
        '
        'lblKpi4Title
        '
        Me.lblKpi4Title.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblKpi4Title.Location = New System.Drawing.Point(836, 43)
        Me.lblKpi4Title.Name = "lblKpi4Title"
        Me.lblKpi4Title.Size = New System.Drawing.Size(205, 25)
        Me.lblKpi4Title.TabIndex = 10
        Me.lblKpi4Title.Text = "PESANAN DIPROSES"
        Me.lblKpi4Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKpi4Value
        '
        Me.lblKpi4Value.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpi4Value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblKpi4Value.Location = New System.Drawing.Point(836, 78)
        Me.lblKpi4Value.Name = "lblKpi4Value"
        Me.lblKpi4Value.Size = New System.Drawing.Size(205, 50)
        Me.lblKpi4Value.TabIndex = 11
        Me.lblKpi4Value.Text = "3"
        Me.lblKpi4Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRecent
        '
        Me.pnlRecent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRecent.Location = New System.Drawing.Point(25, 180)
        Me.pnlRecent.Name = "pnlRecent"
        Me.pnlRecent.Size = New System.Drawing.Size(650, 455)
        Me.pnlRecent.TabIndex = 12
        '
        'lblRecentTitle
        '
        Me.lblRecentTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblRecentTitle.Location = New System.Drawing.Point(45, 195)
        Me.lblRecentTitle.Name = "lblRecentTitle"
        Me.lblRecentTitle.Size = New System.Drawing.Size(600, 35)
        Me.lblRecentTitle.TabIndex = 13
        Me.lblRecentTitle.Text = "TRANSAKSI TERBARU"
        Me.lblRecentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'trx
        '
        Me.trx.FillWeight = 22.0!
        Me.trx.HeaderText = "No. Transaksi"
        Me.trx.MinimumWidth = 6
        Me.trx.Name = "trx"
        Me.trx.ReadOnly = True
        Me.trx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer
        '
        Me.customer.FillWeight = 22.0!
        Me.customer.HeaderText = "Pelanggan"
        Me.customer.MinimumWidth = 6
        Me.customer.Name = "customer"
        Me.customer.ReadOnly = True
        Me.customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total
        '
        Me.total.FillWeight = 18.0!
        Me.total.HeaderText = "Total"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'status
        '
        Me.status.FillWeight = 16.0!
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pnlBest
        '
        Me.pnlBest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlBest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBest.Location = New System.Drawing.Point(695, 180)
        Me.pnlBest.Name = "pnlBest"
        Me.pnlBest.Size = New System.Drawing.Size(430, 455)
        Me.pnlBest.TabIndex = 15
        '
        'lblBestTitle
        '
        Me.lblBestTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblBestTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblBestTitle.Location = New System.Drawing.Point(715, 195)
        Me.lblBestTitle.Name = "lblBestTitle"
        Me.lblBestTitle.Size = New System.Drawing.Size(385, 35)
        Me.lblBestTitle.TabIndex = 16
        Me.lblBestTitle.Text = "MENU TERLARIS"
        Me.lblBestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBest1
        '
        Me.lblBest1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBest1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblBest1.Location = New System.Drawing.Point(720, 250)
        Me.lblBest1.Name = "lblBest1"
        Me.lblBest1.Size = New System.Drawing.Size(270, 40)
        Me.lblBest1.TabIndex = 17
        Me.lblBest1.Text = "1.   Penyetan Ayam"
        Me.lblBest1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBestQty1
        '
        Me.lblBestQty1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBestQty1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblBestQty1.Location = New System.Drawing.Point(980, 250)
        Me.lblBestQty1.Name = "lblBestQty1"
        Me.lblBestQty1.Size = New System.Drawing.Size(115, 40)
        Me.lblBestQty1.TabIndex = 18
        Me.lblBestQty1.Text = "8 porsi"
        Me.lblBestQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBest2
        '
        Me.lblBest2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBest2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblBest2.Location = New System.Drawing.Point(720, 328)
        Me.lblBest2.Name = "lblBest2"
        Me.lblBest2.Size = New System.Drawing.Size(270, 40)
        Me.lblBest2.TabIndex = 19
        Me.lblBest2.Text = "2.   Penyetan Lele"
        Me.lblBest2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBestQty2
        '
        Me.lblBestQty2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBestQty2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblBestQty2.Location = New System.Drawing.Point(980, 328)
        Me.lblBestQty2.Name = "lblBestQty2"
        Me.lblBestQty2.Size = New System.Drawing.Size(115, 40)
        Me.lblBestQty2.TabIndex = 20
        Me.lblBestQty2.Text = "5 porsi"
        Me.lblBestQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBest3
        '
        Me.lblBest3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBest3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblBest3.Location = New System.Drawing.Point(720, 406)
        Me.lblBest3.Name = "lblBest3"
        Me.lblBest3.Size = New System.Drawing.Size(270, 40)
        Me.lblBest3.TabIndex = 21
        Me.lblBest3.Text = "3.   Es Teh"
        Me.lblBest3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBestQty3
        '
        Me.lblBestQty3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBestQty3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblBestQty3.Location = New System.Drawing.Point(980, 406)
        Me.lblBestQty3.Name = "lblBestQty3"
        Me.lblBestQty3.Size = New System.Drawing.Size(115, 40)
        Me.lblBestQty3.TabIndex = 22
        Me.lblBestQty3.Text = "4 gelas"
        Me.lblBestQty3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBest4
        '
        Me.lblBest4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblBest4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblBest4.Location = New System.Drawing.Point(720, 484)
        Me.lblBest4.Name = "lblBest4"
        Me.lblBest4.Size = New System.Drawing.Size(270, 40)
        Me.lblBest4.TabIndex = 23
        Me.lblBest4.Text = "4.   Penyetan Tempe"
        Me.lblBest4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'No
        '
        Me.No.FillWeight = 8.0!
        Me.No.HeaderText = "No."
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.AllowUserToResizeRows = False
        Me.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransaksi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransaksi.ColumnHeadersHeight = 38
        Me.dgvTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.trx, Me.customer, Me.total, Me.status})
        Me.dgvTransaksi.EnableHeadersVisualStyles = False
        Me.dgvTransaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dgvTransaksi.Location = New System.Drawing.Point(45, 238)
        Me.dgvTransaksi.MultiSelect = False
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.RowHeadersVisible = False
        Me.dgvTransaksi.RowHeadersWidth = 51
        Me.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaksi.Size = New System.Drawing.Size(610, 370)
        Me.dgvTransaksi.TabIndex = 14
        '
        'lblBestQty4
        '
        Me.lblBestQty4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBestQty4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblBestQty4.Location = New System.Drawing.Point(980, 484)
        Me.lblBestQty4.Name = "lblBestQty4"
        Me.lblBestQty4.Size = New System.Drawing.Size(115, 40)
        Me.lblBestQty4.TabIndex = 24
        Me.lblBestQty4.Text = "3 porsi"
        Me.lblBestQty4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPageTitle
        '
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(30, 17)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(750, 45)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Dashboard Kasir"
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
        Me.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
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
        Me.pnlContent.Controls.Add(Me.pnlKpi1)
        Me.pnlContent.Controls.Add(Me.lblKpi1Title)
        Me.pnlContent.Controls.Add(Me.lblKpi1Value)
        Me.pnlContent.Controls.Add(Me.pnlKpi2)
        Me.pnlContent.Controls.Add(Me.lblKpi2Title)
        Me.pnlContent.Controls.Add(Me.lblKpi2Value)
        Me.pnlContent.Controls.Add(Me.pnlKpi3)
        Me.pnlContent.Controls.Add(Me.lblKpi3Title)
        Me.pnlContent.Controls.Add(Me.lblKpi3Value)
        Me.pnlContent.Controls.Add(Me.pnlKpi4)
        Me.pnlContent.Controls.Add(Me.lblKpi4Title)
        Me.pnlContent.Controls.Add(Me.lblKpi4Value)
        Me.pnlContent.Controls.Add(Me.pnlRecent)
        Me.pnlContent.Controls.Add(Me.lblRecentTitle)
        Me.pnlContent.Controls.Add(Me.dgvTransaksi)
        Me.pnlContent.Controls.Add(Me.pnlBest)
        Me.pnlContent.Controls.Add(Me.lblBestTitle)
        Me.pnlContent.Controls.Add(Me.lblBest1)
        Me.pnlContent.Controls.Add(Me.lblBestQty1)
        Me.pnlContent.Controls.Add(Me.lblBest2)
        Me.pnlContent.Controls.Add(Me.lblBestQty2)
        Me.pnlContent.Controls.Add(Me.lblBest3)
        Me.pnlContent.Controls.Add(Me.lblBestQty3)
        Me.pnlContent.Controls.Add(Me.lblBest4)
        Me.pnlContent.Controls.Add(Me.lblBestQty4)
        Me.pnlContent.Location = New System.Drawing.Point(220, 76)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1146, 692)
        Me.pnlContent.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlContent)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Kasir"
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlKpi1 As Panel
    Friend WithEvents lblKpi1Title As Label
    Friend WithEvents lblKpi1Value As Label
    Friend WithEvents pnlKpi2 As Panel
    Friend WithEvents lblKpi2Title As Label
    Friend WithEvents lblKpi2Value As Label
    Friend WithEvents pnlKpi3 As Panel
    Friend WithEvents lblKpi3Title As Label
    Friend WithEvents lblKpi3Value As Label
    Friend WithEvents pnlKpi4 As Panel
    Friend WithEvents lblKpi4Title As Label
    Friend WithEvents lblKpi4Value As Label
    Friend WithEvents pnlRecent As Panel
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents trx As DataGridViewTextBoxColumn
    Friend WithEvents customer As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents pnlBest As Panel
    Friend WithEvents lblBestTitle As Label
    Friend WithEvents lblBest1 As Label
    Friend WithEvents lblBestQty1 As Label
    Friend WithEvents lblBest2 As Label
    Friend WithEvents lblBestQty2 As Label
    Friend WithEvents lblBest3 As Label
    Friend WithEvents lblBestQty3 As Label
    Friend WithEvents lblBest4 As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents lblBestQty4 As Label
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
