
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization

Public Class Form4

    Private nomorTransaksi As String = ""
    Private totalTagihan As Decimal = 0D
    Private uangDiterima As Decimal = 0D
    Private kembalian As Decimal = 0D
    Private sudahDibayar As Boolean = False

    Private WithEvents dokumenCetak As New PrintDocument

    '========================================
    ' CONSTRUCTOR DEFAULT
    ' DIGUNAKAN OLEH WINDOWS FORMS DESIGNER
    '========================================
    Public Sub New()

        InitializeComponent()

    End Sub

    '========================================
    ' CONSTRUCTOR DENGAN NOMOR TRANSAKSI
    ' DIGUNAKAN DARI FORM PEMESANAN
    '========================================
    Public Sub New(noTransaksi As String)

        Me.New()

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

        txtUangDiterima.Clear()

        lblKembalianValue.Text = FormatRupiah(0)
        lblTotalTagihan.Text = FormatRupiah(0)

        btnProsesPembayaran.Enabled = True
        btnCetakStruk.Enabled = False

        dgvRincianBayar.AllowUserToAddRows = False
        dgvRincianBayar.AllowUserToDeleteRows = False
        dgvRincianBayar.ReadOnly = True
        dgvRincianBayar.MultiSelect = False
        dgvRincianBayar.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        AddHandler txtUangDiterima.TextChanged,
            AddressOf txtUangDiterima_TextChanged

        MuatTransaksi()

    End Sub

    '========================================
    ' EVENT INPUT UANG
    '========================================
    Private Sub txtUangDiterima_TextChanged(
        sender As Object,
        e As EventArgs
    )

        HitungKembalian()

    End Sub

    '========================================
    ' FORMAT ANGKA INPUT
    '========================================
    Private Sub HitungKembalian()

        uangDiterima = ParseRupiah(txtUangDiterima.Text)

        If uangDiterima >= totalTagihan AndAlso
            totalTagihan > 0D Then

            kembalian = uangDiterima - totalTagihan

        Else

            kembalian = 0D

        End If

        lblKembalianValue.Text =
            FormatRupiah(kembalian)

    End Sub

    '========================================
    ' MEMUAT TRANSAKSI
    '========================================
    Private Sub MuatTransaksi()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                'Jika nomor transaksi belum diberikan,
                'ambil pesanan belum dibayar yang paling baru.
                If nomorTransaksi = "" Then

                    Dim sqlCari As String =
                        "SELECT TOP 1 P.No_Transaksi " &
                        "FROM PESANAN AS P " &
                        "LEFT JOIN PEMBAYARAN AS B " &
                        "ON P.No_Transaksi = B.No_Transaksi " &
                        "WHERE B.No_Transaksi IS NULL " &
                        "ORDER BY P.Waktu_Pesanan DESC"

                    Using cmd As New OleDbCommand(sqlCari, conn)

                        Dim hasil As Object = cmd.ExecuteScalar()

                        If hasil Is Nothing OrElse hasil Is DBNull.Value Then

                            MessageBox.Show(
                                "Tidak ada pesanan yang belum dibayar.",
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            )

                            btnProsesPembayaran.Enabled = False
                            Return

                        End If

                        nomorTransaksi =
                            Convert.ToString(hasil)

                    End Using

                End If

                '--------------------------------
                ' CEK APAKAH SUDAH DIBAYAR
                '--------------------------------
                Dim sqlCek As String =
                    "SELECT COUNT(*) FROM PEMBAYARAN " &
                    "WHERE No_Transaksi = ?"

                Using cmd As New OleDbCommand(sqlCek, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    sudahDibayar =
                        Convert.ToInt32(cmd.ExecuteScalar()) > 0

                End Using

                '--------------------------------
                ' INFORMASI UTAMA PESANAN
                '--------------------------------
                Dim sqlHeader As String =
                    "SELECT Waktu_Pesanan, Nama_Pelanggan, No_ID_Kasir " &
                    "FROM PESANAN WHERE No_Transaksi = ?"

                Dim waktuPesanan As DateTime
                Dim idKasir As String = ""
                Dim pelanggan As String = ""
                Dim ditemukan As Boolean = False

                Using cmd As New OleDbCommand(sqlHeader, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    Using reader As OleDbDataReader =
                        cmd.ExecuteReader()

                        If reader.Read() Then

                            waktuPesanan =
                                Convert.ToDateTime(
                                    reader("Waktu_Pesanan")
                                )

                            pelanggan =
                                Convert.ToString(
                                    reader("Nama_Pelanggan")
                                )

                            idKasir =
                                Convert.ToString(
                                    reader("No_ID_Kasir")
                                )

                            ditemukan = True

                        End If

                    End Using

                End Using

                If Not ditemukan Then

                    MessageBox.Show(
                        "Transaksi tidak ditemukan."
                    )

                    btnProsesPembayaran.Enabled = False
                    Return

                End If

                lblInfoVal0.Text = nomorTransaksi

                lblInfoVal1.Text =
                    waktuPesanan.ToString("dd/MM/yyyy HH:mm")

                lblInfoVal2.Text =
                    AmbilNamaKasir(conn, idKasir)

                '--------------------------------
                ' DETAIL PESANAN
                '--------------------------------
                Dim sqlDetail As String =
                    "SELECT MENU.Nama_Menu, " &
                    "DETAIL_PESANAN.Jumlah, " &
                    "DETAIL_PESANAN.Harga_Satuan " &
                    "FROM MENU INNER JOIN DETAIL_PESANAN " &
                    "ON MENU.ID_Menu = DETAIL_PESANAN.ID_Menu " &
                    "WHERE DETAIL_PESANAN.No_Transaksi = ?"

                Dim tabelDetail As New DataTable()

                Using cmd As New OleDbCommand(sqlDetail, conn)

                    cmd.Parameters.AddWithValue(
                        "@p1", nomorTransaksi
                    )

                    Using adapter As New OleDbDataAdapter(cmd)

                        adapter.Fill(tabelDetail)

                    End Using

                End Using

                dgvRincianBayar.Rows.Clear()

                totalTagihan = 0D

                Dim nomor As Integer = 1

                For Each data As DataRow In tabelDetail.Rows

                    Dim namaMenu As String =
                        Convert.ToString(data("Nama_Menu"))

                    Dim jumlah As Integer =
                        Convert.ToInt32(data("Jumlah"))

                    Dim harga As Decimal =
                        Convert.ToDecimal(data("Harga_Satuan"))

                    Dim subtotal As Decimal =
                        jumlah * harga

                    totalTagihan += subtotal

                    dgvRincianBayar.Rows.Add(
                        nomor,
                        namaMenu,
                        jumlah,
                        FormatRupiah(harga),
                        FormatRupiah(subtotal)
                    )

                    nomor += 1

                Next

                lblTotalTagihan.Text =
                    FormatRupiah(totalTagihan)

                txtUangDiterima.Clear()

                If sudahDibayar Then

                    btnProsesPembayaran.Enabled = False
                    btnCetakStruk.Enabled = True

                    AmbilPembayaranTersimpan(conn)

                Else

                    btnProsesPembayaran.Enabled =
                        totalTagihan > 0D

                    btnCetakStruk.Enabled = False

                End If

                HitungKembalian()

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat transaksi: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' MENGAMBIL NAMA KASIR
    '========================================
    Private Function AmbilNamaKasir(
        conn As OleDbConnection,
        idKasir As String
    ) As String

        Dim sql As String =
            "SELECT Nama_Kasir FROM KASIR " &
            "WHERE No_ID_Kasir = ?"

        Using cmd As New OleDbCommand(sql, conn)

            cmd.Parameters.AddWithValue(
                "@p1", idKasir
            )

            Dim hasil As Object =
                cmd.ExecuteScalar()

            If hasil Is Nothing OrElse hasil Is DBNull.Value Then
                Return idKasir
            End If

            Return Convert.ToString(hasil)

        End Using

    End Function

    '========================================
    ' AMBIL DATA PEMBAYARAN YANG SUDAH ADA
    '========================================
    Private Sub AmbilPembayaranTersimpan(
        conn As OleDbConnection
    )

        Dim sql As String =
            "SELECT Jumlah_Bayar, Uang_Diterima, " &
            "Kembalian, Metode_Pembayaran " &
            "FROM PEMBAYARAN WHERE No_Transaksi = ?"

        Using cmd As New OleDbCommand(sql, conn)

            cmd.Parameters.AddWithValue(
                "@p1", nomorTransaksi
            )

            Using reader = cmd.ExecuteReader()

                If reader.Read() Then

                    totalTagihan =
                        Convert.ToDecimal(reader("Jumlah_Bayar"))

                    uangDiterima =
                        Convert.ToDecimal(reader("Uang_Diterima"))

                    kembalian =
                        Convert.ToDecimal(reader("Kembalian"))

                    cmbMetode.Text =
                        Convert.ToString(reader("Metode_Pembayaran"))

                    txtUangDiterima.Text =
                        uangDiterima.ToString("0")

                    lblKembalianValue.Text =
                        FormatRupiah(kembalian)

                End If

            End Using

        End Using

    End Sub

    '========================================
    ' PROSES PEMBAYARAN
    '========================================
    Private Sub btnProsesPembayaran_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnProsesPembayaran.Click

        If sudahDibayar Then

            MessageBox.Show(
                "Transaksi ini sudah dibayar."
            )

            Return

        End If

        If nomorTransaksi = "" Then

            MessageBox.Show(
                "Nomor transaksi belum tersedia."
            )

            Return

        End If

        If totalTagihan <= 0D Then

            MessageBox.Show(
                "Total tagihan tidak valid."
            )

            Return

        End If

        uangDiterima =
            ParseRupiah(txtUangDiterima.Text)

        If uangDiterima < totalTagihan Then

            MessageBox.Show(
                "Uang yang diterima kurang " &
                FormatRupiah(totalTagihan - uangDiterima),
                "Pembayaran Kurang",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUangDiterima.Focus()
            Return

        End If

        If cmbMetode.SelectedIndex < 0 Then

            MessageBox.Show(
                "Pilih metode pembayaran."
            )

            Return

        End If

        kembalian =
            uangDiterima - totalTagihan

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Nomor transaksi: " & nomorTransaksi & vbCrLf &
                "Total tagihan: " & FormatRupiah(totalTagihan) & vbCrLf &
                "Uang diterima: " & FormatRupiah(uangDiterima) & vbCrLf &
                "Kembalian: " & FormatRupiah(kembalian) & vbCrLf &
                "Metode: " & cmbMetode.Text & vbCrLf & vbCrLf &
                "Simpan pembayaran sekarang?",
                "Konfirmasi Pembayaran",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If konfirmasi <> DialogResult.Yes Then Return

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Using trans As OleDbTransaction =
                    conn.BeginTransaction()

                    Try

                        'Periksa ulang pembayaran dalam transaksi.
                        Dim sqlCek As String =
                            "SELECT COUNT(*) FROM PEMBAYARAN " &
                            "WHERE No_Transaksi = ?"

                        Using cmd As New OleDbCommand(
                            sqlCek, conn, trans
                        )

                            cmd.Parameters.AddWithValue(
                                "@p1", nomorTransaksi
                            )

                            If Convert.ToInt32(
                                cmd.ExecuteScalar()
                            ) > 0 Then

                                Throw New Exception(
                                    "Pesanan sudah memiliki pembayaran."
                                )

                            End If

                        End Using

                        'Simpan pembayaran.
                        Dim sqlSimpan As String =
                            "INSERT INTO PEMBAYARAN " &
                            "(No_Transaksi, Tanggal_Pembayaran, " &
                            "Jumlah_Bayar, Uang_Diterima, Kembalian, " &
                            "Metode_Pembayaran) " &
                            "VALUES (?, ?, ?, ?, ?, ?)"

                        Using cmd As New OleDbCommand(
                            sqlSimpan, conn, trans
                        )

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

                        trans.Commit()

                    Catch

                        trans.Rollback()
                        Throw

                    End Try

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
                "Gagal menyimpan pembayaran: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
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
                "Pembayaran belum disimpan."
            )

            Return

        End If

        Using dialog As New PrintDialog()

            dialog.Document = dokumenCetak

            If dialog.ShowDialog() = DialogResult.OK Then

                Try

                    dokumenCetak.Print()

                Catch ex As Exception

                    MessageBox.Show(
                        "Gagal mencetak struk: " & ex.Message
                    )

                End Try

            End If

        End Using

    End Sub

    '========================================
    ' ISI CETAK STRUK
    '========================================
    Private Sub dokumenCetak_PrintPage(
        sender As Object,
        e As PrintPageEventArgs
    ) Handles dokumenCetak.PrintPage

        Using fontJudul As New Font(
            "Arial",
            14,
            FontStyle.Bold
        )

            Using fontIsi As New Font(
                "Arial",
                9,
                FontStyle.Regular
            )

                Dim grafik As Graphics = e.Graphics
                Dim y As Integer = 30
                Dim x As Integer = 30
                Dim lebar As Integer = 350

                grafik.DrawString(
                    "PENYETAN HAJI TOYYIB",
                    fontJudul,
                    Brushes.Black,
                    x,
                    y
                )

                y += 35

                grafik.DrawString(
                    "BUKTI PEMBAYARAN",
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 25

                grafik.DrawString(
                    "No. Transaksi : " & nomorTransaksi,
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 20

                grafik.DrawString(
                    "Waktu         : " & DateTime.Now.ToString(
                        "dd/MM/yyyy HH:mm"
                    ),
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 25

                grafik.DrawString(
                    "------------------------------------------",
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 25

                For Each baris As DataGridViewRow In
                    dgvRincianBayar.Rows

                    If baris.IsNewRow Then Continue For

                    Dim nama As String =
                        Convert.ToString(
                            baris.Cells("menu").Value
                        )

                    Dim qty As String =
                        Convert.ToString(
                            baris.Cells("qty").Value
                        )

                    Dim harga As String =
                        Convert.ToString(
                            baris.Cells("harga").Value
                        )

                    Dim subtotal As String =
                        Convert.ToString(
                            baris.Cells("total").Value
                        )

                    grafik.DrawString(
                        nama,
                        fontIsi,
                        Brushes.Black,
                        x,
                        y
                    )

                    y += 18

                    grafik.DrawString(
                        qty & " x " & harga & " = " & subtotal,
                        fontIsi,
                        Brushes.Black,
                        x,
                        y
                    )

                    y += 25

                Next

                grafik.DrawString(
                    "------------------------------------------",
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 25

                grafik.DrawString(
                    "TOTAL       : " & FormatRupiah(totalTagihan),
                    fontJudul,
                    Brushes.Black,
                    x,
                    y
                )

                y += 30

                grafik.DrawString(
                    "UANG DITERIMA: " & FormatRupiah(uangDiterima),
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 20

                grafik.DrawString(
                    "KEMBALIAN    : " & FormatRupiah(kembalian),
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 25

                grafik.DrawString(
                    "METODE       : " & cmbMetode.Text,
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

                y += 35

                grafik.DrawString(
                    "Terima kasih atas kunjungan Anda.",
                    fontIsi,
                    Brushes.Black,
                    x,
                    y
                )

            End Using

        End Using

        e.HasMorePages = False

    End Sub

    '========================================
    ' NAVIGASI DASHBOARD
    '========================================
    Private Sub btnNavDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavDashboard.Click

        BukaForm(Me, New Form2())

    End Sub

    '========================================
    ' NAVIGASI PEMESANAN
    '========================================
    Private Sub btnNavPesanan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavPesanan.Click

        BukaForm(Me, New Form3())

    End Sub

    '========================================
    ' NAVIGASI ANTREAN DAPUR
    '========================================
    Private Sub btnNavAntrean_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavAntrean.Click

        BukaForm(Me, New Form5())

    End Sub

    '========================================
    ' NAVIGASI RIWAYAT KOREKSI
    '========================================
    Private Sub btnNavKoreksi_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavKoreksi.Click

        BukaForm(Me, New Form8())

    End Sub

    '========================================
    ' LOGOUT
    '========================================
    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        MintaLogout(Me)

    End Sub

End Class
