
Imports System.Data.OleDb

Public Class Form7

    Private Sub Form7_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text = "LOGIN SEBAGAI  •  DAPUR"

        btnNavDashboard.Visible = False
        btnNavPesanan.Visible = False
        btnNavPembayaran.Visible = False

        dtpTanggal.Value = Date.Today

        cmbJenisBahan.Items.Clear()
        cmbJenisBahan.DropDownStyle =
            ComboBoxStyle.DropDown

        cmbJenisBahan.Items.AddRange(
            New Object() {
                "Ayam",
                "Lele",
                "Tempe",
                "Beras",
                "Minyak Goreng",
                "Cabai",
                "Sayuran",
                "Lainnya"
            }
        )

        cmbSatuan.Items.Clear()

        cmbSatuan.Items.AddRange(
            New Object() {
                "kg",
                "gram",
                "liter",
                "ml",
                "pcs",
                "bungkus"
            }
        )

        cmbSatuan.SelectedIndex = 0

        nudJumlahBahan.Minimum = CDec(0.01)
        nudJumlahBahan.Maximum = CDec(100000)
        nudJumlahBahan.DecimalPlaces = 2
        nudJumlahBahan.Value = 1

        dgvPemakaianBahan.AllowUserToAddRows = False
        dgvPemakaianBahan.ReadOnly = True

        MuatPemakaianBahan()

    End Sub

    '========================================
    ' SIMPAN PEMAKAIAN BAHAN
    '========================================
    Private Sub btnSimpanBahan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimpanBahan.Click

        Dim jenis As String =
            cmbJenisBahan.Text.Trim()

        Dim satuan As String =
            cmbSatuan.Text.Trim()

        Dim jumlah As Decimal =
            nudJumlahBahan.Value

        If jenis = "" Then

            MessageBox.Show(
                "Jenis bahan wajib diisi."
            )

            Return

        End If

        If satuan = "" Then

            MessageBox.Show(
                "Pilih satuan bahan."
            )

            Return

        End If

        If jumlah <= 0 Then

            MessageBox.Show(
                "Jumlah pemakaian harus lebih dari nol."
            )

            Return

        End If

        If CurrentUserId <= 0 Then

            MessageBox.Show(
                "Session pengguna tidak ditemukan."
            )

            Return

        End If

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "INSERT INTO PEMAKAIAN_BAHAN " &
                    "(No_ID_Pemilik, Tanggal_Pemakaian, " &
                    "Jenis_Bahan, Jumlah_Pemakaian, Satuan, " &
                    "Catatan_Koreksi, ID_User) " &
                    "VALUES (?, ?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", OWNER_ID
                    )

                    cmd.Parameters.AddWithValue(
                        "@p2", dtpTanggal.Value.Date
                    )

                    cmd.Parameters.AddWithValue(
                        "@p3", jenis
                    )

                    cmd.Parameters.AddWithValue(
                        "@p4", Convert.ToDouble(jumlah)
                    )

                    cmd.Parameters.AddWithValue(
                        "@p5", satuan
                    )

                    cmd.Parameters.AddWithValue(
                        "@p6", txtCatatanBahan.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@p7", CurrentUserId
                    )

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Pemakaian bahan berhasil disimpan.",
                "Berhasil"
            )

            BersihkanInput()
            MuatPemakaianBahan()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan pemakaian bahan: " &
                ex.Message
            )

        End Try

    End Sub

    '========================================
    ' MEMUAT RIWAYAT PEMAKAIAN
    '========================================
    Private Sub MuatPemakaianBahan()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT B.ID_Pemakaian, " &
                    "B.Tanggal_Pemakaian, " &
                    "B.Jenis_Bahan, " &
                    "B.Jumlah_Pemakaian, " &
                    "B.Satuan, U.Username " &
                    "FROM PEMAKAIAN_BAHAN AS B " &
                    "LEFT JOIN USER_LOGIN AS U " &
                    "ON B.ID_User = U.ID_User " &
                    "ORDER BY B.Tanggal_Pemakaian DESC"

                Dim tabel As New DataTable()

                Using adapter As New OleDbDataAdapter(sql, conn)
                    adapter.Fill(tabel)
                End Using

                dgvPemakaianBahan.Rows.Clear()

                Dim nomor As Integer = 1

                For Each data As DataRow In tabel.Rows

                    Dim tanggal As DateTime =
                        Convert.ToDateTime(data("Tanggal_Pemakaian"))

                    Dim jumlah As Decimal =
                        Convert.ToDecimal(data("Jumlah_Pemakaian"))

                    dgvPemakaianBahan.Rows.Add(
                        nomor,
                        tanggal.ToString("dd/MM/yyyy"),
                        Convert.ToString(data("Jenis_Bahan")),
                        jumlah,
                        Convert.ToString(data("Satuan")),
                        Convert.ToString(data("Username"))
                    )

                    nomor += 1

                Next

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat riwayat bahan: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' BERSIHKAN INPUT
    '========================================
    Private Sub BersihkanInput()

        dtpTanggal.Value = Date.Today
        cmbJenisBahan.Text = ""
        cmbSatuan.SelectedIndex = 0
        nudJumlahBahan.Value = 1
        txtCatatanBahan.Clear()

    End Sub

    Private Sub btnBersihkanBahan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBersihkanBahan.Click

        BersihkanInput()

    End Sub

    '========================================
    ' NAVIGASI
    '========================================
    Private Sub btnNavAntrean_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavAntrean.Click

        BukaForm(Me, New Form5())

    End Sub

    Private Sub btnNavStatusMenu_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStatusMenu.Click

        BukaForm(Me, New Form6())

    End Sub

    Private Sub btnNavKoreksi_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavKoreksi.Click

        BukaForm(Me, New Form8())

    End Sub

    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        MintaLogout(Me)

    End Sub

End Class
