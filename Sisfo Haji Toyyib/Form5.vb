
Imports System.Data.OleDb

Public Class Form5

    Private filterAktif As String = "Diproses"

    Private Sub Form5_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text = "LOGIN SEBAGAI  •  DAPUR"

        'Dapur tidak menggunakan menu kasir.
        btnNavDashboard.Visible = False
        btnNavPesanan.Visible = False
        btnNavPembayaran.Visible = False

        dgvAntrean.AllowUserToAddRows = False
        dgvAntrean.ReadOnly = True
        dgvAntrean.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        MuatAntrean("Diproses")

    End Sub

    '========================================
    ' MEMUAT ANTREAN
    '========================================
    Private Sub MuatAntrean(statusFilter As String)

        filterAktif = statusFilter

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT No_Transaksi, Waktu_Pesanan, " &
                    "Nama_Pelanggan, Status_Pesanan " &
                    "FROM PESANAN "

                If statusFilter = "Diproses" Then

                    sql &=
                        "WHERE Status_Pesanan IN ('Menunggu','Diproses') "

                ElseIf statusFilter = "Selesai" Then

                    sql &=
                        "WHERE Status_Pesanan = 'Selesai' "

                End If

                sql &= "ORDER BY Waktu_Pesanan ASC"

                Dim tabel As New DataTable()

                Using adapter As New OleDbDataAdapter(sql, conn)
                    adapter.Fill(tabel)
                End Using

                dgvAntrean.Rows.Clear()

                Dim nomor As Integer = 1

                For Each data As DataRow In tabel.Rows

                    Dim transaksi As String =
                        Convert.ToString(data("No_Transaksi"))

                    Dim waktu As DateTime =
                        Convert.ToDateTime(data("Waktu_Pesanan"))

                    Dim pelanggan As String =
                        Convert.ToString(data("Nama_Pelanggan"))

                    Dim status As String =
                        Convert.ToString(data("Status_Pesanan"))

                    Dim detail As String =
                        AmbilDetailPesanan(conn, transaksi)

                    dgvAntrean.Rows.Add(
                        nomor,
                        transaksi,
                        waktu.ToString("HH:mm"),
                        pelanggan,
                        detail,
                        status
                    )

                    nomor += 1

                Next

                lblAntreanInfo.Text =
                    "Jumlah pesanan: " & tabel.Rows.Count.ToString()

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat antrean: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' DETAIL MENU DALAM SATU TRANSAKSI
    '========================================
    Private Function AmbilDetailPesanan(
        conn As OleDbConnection,
        transaksi As String
    ) As String

        Dim hasil As New List(Of String)

        Dim sql As String =
            "SELECT MENU.Nama_Menu, DETAIL_PESANAN.Jumlah " &
            "FROM MENU INNER JOIN DETAIL_PESANAN " &
            "ON MENU.ID_Menu = DETAIL_PESANAN.ID_Menu " &
            "WHERE DETAIL_PESANAN.No_Transaksi = ?"

        Using cmd As New OleDbCommand(sql, conn)

            cmd.Parameters.AddWithValue("@p1", transaksi)

            Using reader = cmd.ExecuteReader()

                While reader.Read()

                    hasil.Add(
                        Convert.ToString(reader("Nama_Menu")) &
                        " (" &
                        Convert.ToString(reader("Jumlah")) &
                        ")"
                    )

                End While

            End Using

        End Using

        Return String.Join(", ", hasil)

    End Function

    '========================================
    ' AMBIL NOMOR TRANSAKSI TERPILIH
    '========================================
    Private Function TransaksiTerpilih() As String

        If dgvAntrean.SelectedRows.Count = 0 Then
            Return ""
        End If

        Return Convert.ToString(
            dgvAntrean.SelectedRows(0).Cells("trx").Value
        )

    End Function

    '========================================
    ' UBAH STATUS PESANAN
    '========================================
    Private Sub UbahStatusPesanan(statusBaru As String)

        Dim transaksi As String = TransaksiTerpilih()

        If transaksi = "" Then

            MessageBox.Show(
                "Pilih pesanan terlebih dahulu."
            )

            Return

        End If

        Try

            Dim statusLama As String = ""

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                'Ambil status lama
                Using cmd As New OleDbCommand(
                    "SELECT Status_Pesanan FROM PESANAN " &
                    "WHERE No_Transaksi = ?",
                    conn
                )

                    cmd.Parameters.AddWithValue("@p1", transaksi)

                    statusLama =
                        Convert.ToString(cmd.ExecuteScalar())

                End Using

                If statusLama = statusBaru Then

                    MessageBox.Show(
                        "Status pesanan sudah " & statusBaru & "."
                    )

                    Return

                End If

                Dim sql As String =
                    "UPDATE PESANAN SET Status_Pesanan = ? " &
                    "WHERE No_Transaksi = ?"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@p1", statusBaru)
                    cmd.Parameters.AddWithValue("@p2", transaksi)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            CatatRiwayat(
                "PESANAN",
                transaksi,
                "Perubahan status pesanan oleh Dapur",
                statusLama,
                statusBaru
            )

            MessageBox.Show(
                "Status pesanan berhasil diubah menjadi " &
                statusBaru & "."
            )

            MuatAntrean(filterAktif)

        Catch ex As Exception

            MessageBox.Show(
                "Gagal mengubah status: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' TOMBOL MULAI DIPROSES
    '========================================
    Private Sub btnMulaiProses_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMulaiProses.Click

        UbahStatusPesanan("Diproses")

    End Sub

    '========================================
    ' TOMBOL SELESAI
    '========================================
    Private Sub btnTandaiSelesai_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnTandaiSelesai.Click

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Tandai pesanan ini sudah selesai?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If konfirmasi = DialogResult.Yes Then
            UbahStatusPesanan("Selesai")
        End If

    End Sub

    '========================================
    ' FILTER ANTREAN
    '========================================
    Private Sub btnFilterDiproses_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFilterDiproses.Click

        MuatAntrean("Diproses")

    End Sub

    Private Sub btnFilterSelesai_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFilterSelesai.Click

        MuatAntrean("Selesai")

    End Sub

    Private Sub btnFilterSemua_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFilterSemua.Click

        MuatAntrean("Semua")

    End Sub

    '========================================
    ' NAVIGASI
    '========================================
    Private Sub btnNavStatusMenu_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStatusMenu.Click

        BukaForm(Me, New Form6())

    End Sub

    Private Sub btnNavBahan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavBahan.Click

        BukaForm(Me, New Form7())

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
