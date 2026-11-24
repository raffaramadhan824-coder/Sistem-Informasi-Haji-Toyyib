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
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblBrandTagline = New System.Windows.Forms.Label()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.pnlBrand.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBrand
        '
        Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.pnlBrand.Controls.Add(Me.lblLogo)
        Me.pnlBrand.Controls.Add(Me.lblBrandName)
        Me.pnlBrand.Controls.Add(Me.lblBrandTagline)
        Me.pnlBrand.Location = New System.Drawing.Point(124, 16)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(410, 620)
        Me.pnlBrand.TabIndex = 10
        '
        'lblLogo
        '
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 62.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLogo.Location = New System.Drawing.Point(95, 90)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(220, 110)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "HT"
        Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandName
        '
        Me.lblBrandName.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrandName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBrandName.Location = New System.Drawing.Point(45, 220)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(320, 115)
        Me.lblBrandName.TabIndex = 1
        Me.lblBrandName.Text = "PENYETAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HAJI TOYYIB"
        Me.lblBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandTagline
        '
        Me.lblBrandTagline.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBrandTagline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblBrandTagline.Location = New System.Drawing.Point(32, 365)
        Me.lblBrandTagline.Name = "lblBrandTagline"
        Me.lblBrandTagline.Size = New System.Drawing.Size(350, 48)
        Me.lblBrandTagline.TabIndex = 2
        Me.lblBrandTagline.Text = "Sistem Informasi Penjualan & Persediaan"
        Me.lblBrandTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoginTitle
        '
        Me.lblLoginTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblLoginTitle.Location = New System.Drawing.Point(609, 108)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New System.Drawing.Size(430, 55)
        Me.lblLoginTitle.TabIndex = 11
        Me.lblLoginTitle.Text = "LOGIN PENGGUNA"
        Me.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(609, 196)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(400, 28)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(609, 228)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(425, 30)
        Me.txtUsername.TabIndex = 13
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(609, 298)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(400, 28)
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(609, 330)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(425, 30)
        Me.txtPassword.TabIndex = 15
        '
        'lblRole
        '
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(609, 400)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(400, 28)
        Me.lblRole.TabIndex = 16
        Me.lblRole.Text = "Masuk sebagai"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbRole.Location = New System.Drawing.Point(609, 432)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(425, 31)
        Me.cmbRole.TabIndex = 17
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(609, 516)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(205, 48)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.Text = "MASUK"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBatal.Location = New System.Drawing.Point(829, 516)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(205, 48)
        Me.btnBatal.TabIndex = 19
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1162, 653)
        Me.Controls.Add(Me.pnlBrand)
        Me.Controls.Add(Me.lblLoginTitle)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnBatal)
        Me.MinimumSize = New System.Drawing.Size(1180, 700)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlBrand.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBrand As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblBrandName As Label
    Friend WithEvents lblBrandTagline As Label
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBatal As Button
End Class
