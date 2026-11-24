
Imports System.Data.OleDb

Public Class Form8

    Private Sub Form8_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text =
            "LOGIN SEBAGAI  •  " & CurrentRole.ToUpperInvariant()

        cmbFilterJenis.Items.Clear()

        cmbFilterJenis.Items.Add("Semua")
        cmbFilterJenis.Items.Add("PESANAN")
        cmbFilterJenis.Items.Add("MENU")
        cmbFilterJenis.Items.Add("PEMBAYARAN")
        cmbFilterJenis.Items.Add("PEMAKAIAN_BAHAN")

        cmbFilterJenis.SelectedIndex = 0

        dtpDari.Value = Date.Today.AddDays(-30)
        dtpSampai.Value = Date.Today

        dgvRiwayatKoreksi.AllowUserToAddRows = False
        dgvRiwayatKoreksi.ReadOnly = True
        dgvRiwayatKoreksi.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        MuatRiwayat()

    End Sub

    '========================================
    ' MUAT RIWAYAT KOREKSI
    '========================================
    Private Sub MuatRiwayat()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT R.ID_Koreksi, R.Tanggal_Koreksi, " &
                    "U.Username, R.Jenis_Data, R.ID_Referensi, " &
                    "R.Alasan, R.Data_Sebelum, R.Data_Sesudah " &
                    "FROM RIWAYAT_KOREKSI AS R " &
                    "LEFT JOIN USER_LOGIN AS U " &
                    "ON R.ID_User = U.ID_User " &
                    "WHERE 1=1 "

                Dim cmd As New OleDbCommand()
                cmd.Connection = conn

                'Filter jenis data
                If cmbFilterJenis.Text <> "Semua" AndAlso
                    cmbFilterJenis.Text <> "" Then

                    sql &= "AND R.Jenis_Data = ? "
                    cmd.Parameters.AddWithValue(
                        "@pJenis",
                        cmbFilterJenis.Text
                    )

                End If

                'Filter tanggal
                sql &=
                    "AND R.Tanggal_Koreksi >= ? " &
                    "AND R.Tanggal_Koreksi < ? "

                cmd.Parameters.AddWithValue(
                    "@pDari",
                    dtpDari.Value.Date
                )

                cmd.Parameters.AddWithValue(
                    "@pSampai",
                    dtpSampai.Value.Date.AddDays(1)
                )

                'Pencarian
                If txtCariKoreksi.Text.Trim() <> "" Then

                    sql &=
                        "AND (R.ID_Referensi LIKE ? " &
                        "OR R.Alasan LIKE ? " &
                        "OR U.Username LIKE ?) "

                    Dim kata As String =
                        "*" & txtCariKoreksi.Text.Trim() & "*"

                    cmd.Parameters.AddWithValue("@pCari1", kata)
                    cmd.Parameters.AddWithValue("@pCari2", kata)
                    cmd.Parameters.AddWithValue("@pCari3", kata)

                End If

                sql &= "ORDER BY R.Tanggal_Koreksi DESC"

                cmd.CommandText = sql

                Dim tabel As New DataTable()

                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(tabel)
                End Using

                dgvRiwayatKoreksi.Rows.Clear()

                Dim nomor As Integer = 1

                For Each data As DataRow In tabel.Rows

                    Dim tanggal As DateTime =
                        Convert.ToDateTime(data("Tanggal_Koreksi"))

                    dgvRiwayatKoreksi.Rows.Add(
                        nomor,
                        tanggal.ToString("dd/MM/yyyy HH:mm"),
                        Convert.ToString(data("Username")),
                        Convert.ToString(data("Jenis_Data")),
                        Convert.ToString(data("ID_Referensi")),
                        Convert.ToString(data("Alasan")),
                        Convert.ToString(data("Data_Sebelum")),
                        Convert.ToString(data("Data_Sesudah"))
                    )

                    nomor += 1

                Next

                lblKoreksiNote.Text =
                    "Jumlah riwayat: " & tabel.Rows.Count.ToString()

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat riwayat koreksi: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' CARI / FILTER RIWAYAT
    '========================================
    Private Sub btnCariKoreksi_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCariKoreksi.Click

        If dtpDari.Value.Date > dtpSampai.Value.Date Then

            MessageBox.Show(
                "Tanggal awal tidak boleh lebih besar dari tanggal akhir."
            )

            Return

        End If

        MuatRiwayat()

    End Sub

    '========================================
    ' NAVIGASI
    '========================================
    Private Sub btnNavDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavDashboard.Click

        If CurrentRole = "Kasir" Then
            BukaForm(Me, New Form2())
        Else
            BukaForm(Me, New Form5())
        End If

    End Sub

    Private Sub btnNavPesanan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavPesanan.Click

        If CurrentRole = "Kasir" Then
            BukaForm(Me, New Form3())
        End If

    End Sub

    Private Sub btnNavPembayaran_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavPembayaran.Click

        If CurrentRole = "Kasir" Then
            BukaForm(Me, New Form4())
        End If

    End Sub

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

        If CurrentRole = "Dapur" Then
            BukaForm(Me, New Form6())
        End If

    End Sub

    Private Sub btnNavBahan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavBahan.Click

        If CurrentRole = "Dapur" Then
            BukaForm(Me, New Form7())
        End If

    End Sub

    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        MintaLogout(Me)

    End Sub

End Class
