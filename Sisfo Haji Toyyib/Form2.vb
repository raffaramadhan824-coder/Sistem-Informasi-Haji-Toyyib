
Imports System.Data.OleDb

Public Class Form2

    Private Sub Form2_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text = "LOGIN SEBAGAI  •  KASIR"

        ' Dapur mengelola pemakaian bahan dan status menu.
        btnNavStatusMenu.Visible = False
        btnNavBahan.Visible = False

        lblKpi1Title.Text = "Transaksi Hari Ini"
        lblKpi2Title.Text = "Menu Tersedia"
        lblKpi3Title.Text = "Pendapatan Hari Ini"
        lblKpi4Title.Text = "Pesanan Belum Selesai"

        MuatDashboard()

    End Sub

    '========================================
    ' MUAT DASHBOARD
    '========================================
    Private Sub MuatDashboard()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim awalHari As DateTime = Date.Today
                Dim akhirHari As DateTime = Date.Today.AddDays(1)

                ' Jumlah transaksi hari ini
                Dim sql1 As String =
                    "SELECT COUNT(*) FROM PESANAN " &
                    "WHERE Waktu_Pesanan >= ? AND Waktu_Pesanan < ?"

                Using cmd As New OleDbCommand(sql1, conn)

                    cmd.Parameters.AddWithValue("@p1", awalHari)
                    cmd.Parameters.AddWithValue("@p2", akhirHari)

                    lblKpi1Value.Text =
                        Convert.ToString(cmd.ExecuteScalar())

                End Using

                ' Menu tersedia
                Dim sql2 As String =
                    "SELECT COUNT(*) FROM MENU " &
                    "WHERE Status_Ketersediaan = 'Tersedia'"

                Using cmd As New OleDbCommand(sql2, conn)

                    lblKpi2Value.Text =
                        Convert.ToString(cmd.ExecuteScalar())

                End Using

                ' Pendapatan hari ini
                Dim sql3 As String =
                    "SELECT SUM(Jumlah_Bayar) FROM PEMBAYARAN " &
                    "WHERE Tanggal_Pembayaran >= ? " &
                    "AND Tanggal_Pembayaran < ?"

                Using cmd As New OleDbCommand(sql3, conn)

                    cmd.Parameters.AddWithValue("@p1", awalHari)
                    cmd.Parameters.AddWithValue("@p2", akhirHari)

                    Dim hasil = cmd.ExecuteScalar()

                    Dim pendapatan As Decimal = 0

                    If hasil IsNot DBNull.Value AndAlso hasil IsNot Nothing Then
                        pendapatan = Convert.ToDecimal(hasil)
                    End If

                    lblKpi3Value.Text = FormatRupiah(pendapatan)

                End Using

                ' Pesanan belum selesai
                Dim sql4 As String =
                    "SELECT COUNT(*) FROM PESANAN " &
                    "WHERE Status_Pesanan <> 'Selesai'"

                Using cmd As New OleDbCommand(sql4, conn)

                    lblKpi4Value.Text =
                        Convert.ToString(cmd.ExecuteScalar())

                End Using

                ' Transaksi terbaru
                dgvTransaksi.Rows.Clear()

                Dim sql5 As String =
                    "SELECT TOP 10 No_Transaksi, Nama_Pelanggan, " &
                    "Status_Pesanan, Waktu_Pesanan " &
                    "FROM PESANAN ORDER BY Waktu_Pesanan DESC"

                Using cmd As New OleDbCommand(sql5, conn)

                    Using reader = cmd.ExecuteReader()

                        Dim nomor As Integer = 1

                        While reader.Read()

                            Dim transaksi As String =
                                Convert.ToString(reader("No_Transaksi"))

                            Dim pelanggan As String =
                                Convert.ToString(reader("Nama_Pelanggan"))

                            Dim status As String =
                                Convert.ToString(reader("Status_Pesanan"))

                            Dim total As Decimal = 0

                            Using cmdTotal As New OleDbCommand(
                                "SELECT SUM(Jumlah * Harga_Satuan) " &
                                "FROM DETAIL_PESANAN WHERE No_Transaksi = ?",
                                conn
                            )

                                cmdTotal.Parameters.AddWithValue("@p1", transaksi)

                                Dim hasil = cmdTotal.ExecuteScalar()

                                If hasil IsNot DBNull.Value AndAlso hasil IsNot Nothing Then
                                    total = Convert.ToDecimal(hasil)
                                End If

                            End Using

                            dgvTransaksi.Rows.Add(
                                nomor,
                                transaksi,
                                pelanggan,
                                FormatRupiah(total),
                                status
                            )

                            nomor += 1

                        End While

                    End Using

                End Using

                ' Menu terlaris
                Dim daftarLabel As Label() = {
                    lblBest1, lblBest2, lblBest3, lblBest4
                }

                Dim daftarQty As Label() = {
                    lblBestQty1, lblBestQty2,
                    lblBestQty3, lblBestQty4
                }

                For i As Integer = 0 To 3

                    daftarLabel(i).Text = "-"
                    daftarQty(i).Text = "0 porsi"

                Next

                Dim sqlBest As String =
                    "SELECT TOP 4 MENU.Nama_Menu, " &
                    "SUM(DETAIL_PESANAN.Jumlah) AS TotalQty " &
                    "FROM MENU INNER JOIN DETAIL_PESANAN " &
                    "ON MENU.ID_Menu = DETAIL_PESANAN.ID_Menu " &
                    "GROUP BY MENU.Nama_Menu " &
                    "ORDER BY SUM(DETAIL_PESANAN.Jumlah) DESC"

                Using cmdBest As New OleDbCommand(sqlBest, conn)

                    Using reader = cmdBest.ExecuteReader()

                        Dim i As Integer = 0

                        While reader.Read() AndAlso i < 4

                            daftarLabel(i).Text =
                                (i + 1).ToString() & ". " &
                                Convert.ToString(reader("Nama_Menu"))

                            daftarQty(i).Text =
                                Convert.ToString(reader("TotalQty")) & " porsi"

                            i += 1

                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat dashboard: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' NAVIGASI
    '========================================
    Private Sub btnNavDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavDashboard.Click

        MuatDashboard()

    End Sub

    Private Sub btnNavPesanan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavPesanan.Click

        BukaForm(Me, New Form3())

    End Sub

    Private Sub btnNavPembayaran_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavPembayaran.Click

        BukaForm(Me, New Form4())

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
