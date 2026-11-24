
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Form4

    Private nomorTransaksi As String = ""
    Private totalTagihan As Decimal = 0
    Private sudahDibayar As Boolean = False

    Private WithEvents dokumenCetak As New PrintDocument

    '========================================
    ' CONSTRUCTOR
    '========================================
    Public Sub New(Optional noTransaksi As String = "")

        InitializeComponent()

        nomorTransaksi = noTransaksi

    End Sub

    '========================================
    ' FORM LOAD
    '========================================
    Private Sub Form4_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text = "LOGIN SEBAGAI  •  KASIR"

        cmbMetode.Items.Clear()
        cmbMetode.Items.Add("Tunai")
        cmbMetode.Items.Add("QRIS")
        cmbMetode.SelectedIndex = 0

        btnCetakStruk.Enabled = False
        btnProsesPembayaran.Enabled = True

        AddHandler txtUangDiterima.TextChanged,
            AddressOf HitungKembalian

        dgvRincianBayar.AllowUserToAddRows = False
        dgvRincianBayar.ReadOnly = True

        MuatTransaksi()

    End Sub

    '========================================
    ' CARI PESANAN BELUM DIBAYAR
    '========================================
    Private Sub MuatTransaksi()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                If nomorTransaksi = "" Then

                    Dim sqlCari As String =
                        "SELECT TOP 1 No_Transaksi " &
                        "FROM PESANAN " &
                        "WHERE No_Transaksi NOT IN " &
                        "(SELECT No_Transaksi FROM PEMBAYARAN) " &
                        "ORDER BY Waktu_Pesanan DESC"

                    Using cmd As New OleDbCommand(sqlCari, conn)

                        Dim hasil = cmd.ExecuteScalar()

                        If hasil Is Nothing OrElse hasil Is DBNull.Value Then

                            MessageBox.Show(
                                "Tidak ada pesanan yang belum dibayar."
                            )

                            Me.Close()
                            Return

                        End If

                        nomorTransaksi = Convert.ToString(hasil)

                    End Using

                End If

                'Ambil informasi pesanan
                Dim sqlHeader As String =
                    "SELECT Waktu_Pesanan, Nama_Pelanggan, No_ID_Kasir " &
                    "FROM PESANAN WHERE No_Transaksi = ?"

                Using cmd As New OleDbCommand(sqlHeader, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    Using reader = cmd.ExecuteReader()

                        If Not reader.Read() Then

                            MessageBox.Show(
                                "Data pesanan tidak ditemukan."
                            )

                            Me.Close()
                            Return

                        End If

                        lblInfoVal0.Text = nomorTransaksi

                        lblInfoVal1.Text =
                            Convert.ToDateTime(
                                reader("Waktu_Pesanan")
                            ).ToString("dd/MM/yyyy HH:mm")

                        Dim idKasir As String =
                            Convert.ToString(reader("No_ID_Kasir"))

                        lblInfoVal2.Text =
                            AmbilNamaKasir(conn, idKasir)

                    End Using

                End Using

                'Ambil detail pesanan
                dgvRincianBayar.Rows.Clear()

                Dim sqlDetail As String =
                    "SELECT MENU.Nama_Menu, " &
                    "DETAIL_PESANAN.Jumlah, " &
                    "DETAIL_PESANAN.Harga_Satuan " &
                    "FROM MENU INNER JOIN DETAIL_PESANAN " &
                    "ON MENU.ID_Menu = DETAIL_PESANAN.ID_Menu " &
                    "WHERE DETAIL_PESANAN.No_Transaksi = ?"

                Using cmd As New OleDbCommand(sqlDetail, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    Using reader = cmd.ExecuteReader()

                        Dim no As Integer = 1
                        totalTagihan = 0

                        While reader.Read()

                            Dim nama As String =
                                Convert.ToString(reader("Nama_Menu"))

                            Dim qty As Integer =
                                Convert.ToInt32(reader("Jumlah"))

                            Dim harga As Decimal =
                                Convert.ToDecimal(reader("Harga_Satuan"))

                            Dim subtotal As Decimal = qty * harga

                            totalTagihan += subtotal

                            dgvRincianBayar.Rows.Add(
                                no,
                                nama,
                                qty,
                                FormatRupiah(harga),
                                FormatRupiah(subtotal)
                            )

                            no += 1

                        End While

                    End Using

                End Using

                lblTotalTagihan.Text =
                    FormatRupiah(totalTagihan)

                HitungKembalian(Nothing, EventArgs.Empty)

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat transaksi: " & ex.Message
            )

        End Try

    End Sub

    Private Function AmbilNamaKasir(
        conn As OleDbConnection,
        idKasir As String
    ) As String

        Dim sql As String =
            "SELECT Nama_Kasir FROM KASIR WHERE No_ID_Kasir = ?"

        Using cmd As New OleDbCommand(sql, conn)

            cmd.Parameters.AddWithValue("@p1", idKasir)

            Dim hasil = cmd.ExecuteScalar()

            If hasil Is Nothing OrElse hasil Is DBNull.Value Then
                Return idKasir
            End If

            Return Convert.ToString(hasil)

        End Using

    End Function

    '========================================
    ' HITUNG KEMBALIAN
    '========================================
    Private Sub HitungKembalian(
        sender As Object,
        e As EventArgs
    )

        Dim uang As Decimal =
            ParseRupiah(txtUangDiterima.Text)

        If uang >= totalTagihan AndAlso totalTagihan > 0 Then

            lblKembalianValue.Text =
                FormatRupiah(uang - totalTagihan)

        Else

            lblKembalianValue.Text = FormatRupiah(0)

        End If

    End Sub

    '========================================
    ' PROSES PEMBAYARAN
    '========================================
    Private Sub btnProsesPembayaran_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnProsesPembayaran.Click

        If nomorTransaksi = "" Then
            MessageBox.Show("Nomor transaksi belum tersedia.")
            Return
        End If

        If totalTagihan <= 0 Then
            MessageBox.Show("Total tagihan tidak valid.")
            Return
        End If

        Dim uangDiterima As Decimal =
            ParseRupiah(txtUangDiterima.Text)

        If uangDiterima < totalTagihan Then

            MessageBox.Show(
                "Uang kurang " &
                FormatRupiah(totalTagihan - uangDiterima),
                "Pembayaran Kurang",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUangDiterima.Focus()
            Return

        End If

        Dim kembalian As Decimal =
            uangDiterima - totalTagihan

        If cmbMetode.SelectedIndex < 0 Then
            MessageBox.Show("Pilih metode pembayaran.")
            Return
        End If

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                'Cegah pembayaran ganda
                Dim sqlCek As String =
                    "SELECT COUNT(*) FROM PEMBAYARAN " &
                    "WHERE No_Transaksi = ?"

                Using cmd As New OleDbCommand(sqlCek, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then

                        MessageBox.Show(
                            "Pesanan ini sudah dibayar."
                        )

                        Return

                    End If

                End Using

                Dim sql As String =
                    "INSERT INTO PEMBAYARAN " &
                    "(No_Transaksi, Tanggal_Pembayaran, " &
                    "Jumlah_Bayar, Uang_Diterima, Kembalian, " &
                    "Metode_Pembayaran) " &
                    "VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    cmd.Parameters.AddWithValue(
                        "@p2", DateTime.Now
                    )

                    cmd.Parameters.AddWithValue(
                        "@p3", totalTagihan
                    )

                    cmd.Parameters.AddWithValue(
                        "@p4", uangDiterima
                    )

                    cmd.Parameters.AddWithValue(
                        "@p5", kembalian
                    )

                    cmd.Parameters.AddWithValue(
                        "@p6", cmbMetode.Text
                    )

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            sudahDibayar = True

            btnProsesPembayaran.Enabled = False
            btnCetakStruk.Enabled = True

            MessageBox.Show(
                "Pembayaran berhasil disimpan." & vbCrLf &
                "Kembalian: " & FormatRupiah(kembalian),
                "Pembayaran Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan pembayaran: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' CETAK STRUK
    '========================================
    Private Sub btnCetakStruk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCetakStruk.Click

        If Not sudahDibayar Then
            MessageBox.Show(
                "Simpan pembayaran terlebih dahulu."
            )
            Return
        End If

        Using dialog As New PrintDialog()

            dialog.Document = dokumenCetak

            If dialog.ShowDialog() = DialogResult.OK Then
                dokumenCetak.Print()
            End If

        End Using

    End Sub

    Private Sub dokumenCetak_PrintPage(
        sender As Object,
        e As PrintPageEventArgs
    ) Handles dokumenCetak.PrintPage

        Dim fontJudul As New Font("Arial", 14, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 9)
        Dim y As Integer = 30

        e.Graphics.DrawString(
            "PENYETAN HAJI TOYYIB",
            fontJudul,
            Brushes.Black,
            30,
            y
        )

        y += 35

        e.Graphics.DrawString(
            "HT POS - BUKTI PEMBAYARAN",
            fontIsi,
            Brushes.Black,
            30,
            y
        )

        y += 30

        e.Graphics.DrawString(
            "No. Transaksi: " & nomorTransaksi,
            fontIsi,
            Brushes.Black,
            30,
            y
        )

        y += 20

        e.Graphics.DrawString(
            "--------------------------------------------",
            fontIsi,
            Brushes.Black,
            30,
            y
        )

        y += 25

        For Each baris As DataGridViewRow In dgvRincianBayar.Rows

            e.Graphics.DrawString(
                Convert.ToString(baris.Cells("menu").Value),
                fontIsi,
                Brushes.Black,
                30,
                y
            )

            y += 20

            e.Graphics.DrawString(
                Convert.ToString(baris.Cells("qty").Value) &
                " x " &
                Convert.ToString(baris.Cells("harga").Value) &
                " = " &
                Convert.ToString(baris.Cells("total").Value),
                fontIsi,
                Brushes.Black,
                30,
                y
            )

            y += 25

        Next

        e.Graphics.DrawString(
            "TOTAL: " & FormatRupiah(totalTagihan),
            fontJudul,
            Brushes.Black,
            30,
            y
        )

        y += 30

        e.Graphics.DrawString(
            "Terima kasih.",
            fontIsi,
            Brushes.Black,
            30,
            y
        )

        fontJudul.Dispose()
        fontIsi.Dispose()

    End Sub

    '========================================
    ' NAVIGASI
    '========================================
    Private Sub btnNavDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavDashboard.Click

        BukaForm(Me, New Form2())

    End Sub

    Private Sub btnNavPesanan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavPesanan.Click

        BukaForm(Me, New Form3())

    End Sub

    Private Sub btnNavAntrean_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavAntrean.Click

        BukaForm(Me, New Form5())

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
