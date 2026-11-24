
Imports System.Data.OleDb

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblRole.Text = "LOGIN SEBAGAI  •  KASIR"

        nudJumlah.Minimum = 1
        nudJumlah.Value = 1

        dgvDetail.AllowUserToAddRows = False
        dgvDetail.AllowUserToDeleteRows = False
        dgvDetail.ReadOnly = True
        dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetail.MultiSelect = False
        dgvDetail.Visible = True

        'Memperbaiki urutan tampilan panel dan tabel
        pnlDetail.SendToBack()
        dgvDetail.BringToFront()
        lblDetailTitle.BringToFront()
        lblQty.BringToFront()
        nudJumlah.BringToFront()
        btnHapusItem.BringToFront()
        lblTotal.BringToFront()
        lblTotalValue.BringToFront()

        HitungTotal()
        MuatMenu()

    End Sub

    '========================================
    ' MEMUAT MENU
    '========================================
    Private Sub MuatMenu()

        TampilkanMenu("M01", btnAyam)
        TampilkanMenu("M02", btnLele)
        TampilkanMenu("M03", btnTempe)
        TampilkanMenu("M05", btnEsTeh)

    End Sub

    Private Sub TampilkanMenu(idMenu As String, tombol As Button)

        Try
            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT Nama_Menu, Harga_Menu, Status_Ketersediaan " &
                    "FROM MENU WHERE ID_Menu = ?"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@p1", idMenu)

                    Using rd As OleDbDataReader = cmd.ExecuteReader()

                        If rd.Read() Then

                            Dim nama As String = Convert.ToString(rd("Nama_Menu"))
                            Dim harga As Decimal = Convert.ToDecimal(rd("Harga_Menu"))
                            Dim status As String = Convert.ToString(rd("Status_Ketersediaan"))

                            tombol.Text = nama & vbCrLf & FormatRupiah(harga)

                            tombol.Enabled =
                                status.Equals("Tersedia", StringComparison.OrdinalIgnoreCase)

                            If Not tombol.Enabled Then
                                tombol.Text &= vbCrLf & "(HABIS)"
                            End If

                        Else
                            tombol.Text = "Menu tidak ditemukan"
                            tombol.Enabled = False
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memuat menu: " & ex.Message)
        End Try

    End Sub

    '========================================
    ' MENAMBAHKAN MENU KE TABEL
    '========================================
    Private Sub TambahMenu(idMenu As String)

        Try

            Dim nama As String = ""
            Dim harga As Decimal = 0
            Dim status As String = ""

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT Nama_Menu, Harga_Menu, Status_Ketersediaan " &
                    "FROM MENU WHERE ID_Menu = ?"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@p1", idMenu)

                    Using rd As OleDbDataReader = cmd.ExecuteReader()

                        If Not rd.Read() Then
                            MessageBox.Show("Menu tidak ditemukan.")
                            Return
                        End If

                        nama = Convert.ToString(rd("Nama_Menu"))
                        harga = Convert.ToDecimal(rd("Harga_Menu"))
                        status = Convert.ToString(rd("Status_Ketersediaan"))

                    End Using
                End Using
            End Using

            If Not status.Equals("Tersedia", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show(nama & " sedang habis.")
                MuatMenu()
                Return
            End If

            Dim jumlah As Integer = CInt(nudJumlah.Value)

            'Jika menu sudah ada, tambahkan jumlahnya
            For Each baris As DataGridViewRow In dgvDetail.Rows

                If Convert.ToString(baris.Tag) = idMenu Then

                    Dim qtyBaru As Integer =
                        Convert.ToInt32(baris.Cells("qty").Value) + jumlah

                    baris.Cells("qty").Value = qtyBaru
                    baris.Cells("subtotal").Value = qtyBaru * harga

                    HitungTotal()
                    Return

                End If
            Next

            'Jika menu belum ada, buat baris baru
            Dim index As Integer = dgvDetail.Rows.Add(
                dgvDetail.Rows.Count + 1,
                nama,
                jumlah,
                harga,
                jumlah * harga
            )

            dgvDetail.Rows(index).Tag = idMenu

            HitungTotal()

        Catch ex As Exception
            MessageBox.Show("Gagal menambahkan menu: " & ex.Message)
        End Try

    End Sub

    '========================================
    ' EVENT TOMBOL MENU
    '========================================
    Private Sub btnAyam_Click(sender As Object, e As EventArgs) Handles btnAyam.Click
        TambahMenu("M01")
    End Sub

    Private Sub btnLele_Click(sender As Object, e As EventArgs) Handles btnLele.Click
        TambahMenu("M02")
    End Sub

    Private Sub btnTempe_Click(sender As Object, e As EventArgs) Handles btnTempe.Click
        TambahMenu("M03")
    End Sub

    Private Sub btnEsTeh_Click(sender As Object, e As EventArgs) Handles btnEsTeh.Click
        TambahMenu("M05")
    End Sub

    '========================================
    ' MENGHITUNG TOTAL PESANAN
    '========================================
    Private Sub HitungTotal()

        Dim total As Decimal = 0
        Dim nomor As Integer = 1

        For Each baris As DataGridViewRow In dgvDetail.Rows

            If baris.IsNewRow Then Continue For

            Dim qty As Integer = Convert.ToInt32(baris.Cells("qty").Value)
            Dim harga As Decimal = Convert.ToDecimal(baris.Cells("harga").Value)

            Dim subtotal As Decimal = qty * harga

            baris.Cells("no").Value = nomor
            baris.Cells("subtotal").Value = subtotal

            total += subtotal
            nomor += 1

        Next

        lblTotalValue.Text = FormatRupiah(total)

    End Sub

    '========================================
    ' MENGHAPUS ITEM
    '========================================
    Private Sub btnHapusItem_Click(sender As Object, e As EventArgs) Handles btnHapusItem.Click

        If dgvDetail.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih item yang ingin dihapus.")
            Return
        End If

        If MessageBox.Show(
            "Hapus item yang dipilih?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then

            dgvDetail.Rows.Remove(dgvDetail.SelectedRows(0))
            HitungTotal()

        End If

    End Sub

    '========================================
    ' SIMPAN PESANAN KE DATABASE
    '========================================
    Private Sub btnSimpanPesanan_Click(sender As Object, e As EventArgs) Handles btnSimpanPesanan.Click

        If CurrentKasirId = "" Then
            MessageBox.Show("Akun Kasir belum memiliki No_ID_Kasir.")
            Return
        End If

        If txtNamaPelanggan.Text.Trim() = "" Then
            MessageBox.Show("Nama pelanggan wajib diisi.")
            txtNamaPelanggan.Focus()
            Return
        End If

        If dgvDetail.Rows.Count = 0 Then
            MessageBox.Show("Pilih minimal satu menu.")
            Return
        End If

        Dim nomorTransaksi As String = BuatNoTransaksi()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Using trans As OleDbTransaction = conn.BeginTransaction()

                    Try

                        Dim sqlPesanan As String =
                            "INSERT INTO PESANAN " &
                            "(No_Transaksi, Waktu_Pesanan, Status_Pesanan, " &
                            "Nama_Pelanggan, No_ID_Kasir) VALUES (?, ?, ?, ?, ?)"

                        Using cmd As New OleDbCommand(sqlPesanan, conn, trans)

                            cmd.Parameters.Add("@p1", OleDbType.VarWChar).Value = nomorTransaksi
                            cmd.Parameters.Add("@p2", OleDbType.Date).Value = DateTime.Now
                            cmd.Parameters.Add("@p3", OleDbType.VarWChar).Value = "Menunggu"
                            cmd.Parameters.Add("@p4", OleDbType.VarWChar).Value = txtNamaPelanggan.Text.Trim()
                            cmd.Parameters.Add("@p5", OleDbType.VarWChar).Value = CurrentKasirId

                            cmd.ExecuteNonQuery()

                        End Using

                        For Each baris As DataGridViewRow In dgvDetail.Rows

                            If baris.IsNewRow Then Continue For

                            Dim idMenu As String = Convert.ToString(baris.Tag)
                            Dim qty As Integer = Convert.ToInt32(baris.Cells("qty").Value)
                            Dim harga As Decimal = Convert.ToDecimal(baris.Cells("harga").Value)

                            'Memeriksa ketersediaan menu kembali
                            Using cek As New OleDbCommand(
                                "SELECT Status_Ketersediaan FROM MENU WHERE ID_Menu = ?",
                                conn,
                                trans
                            )

                                cek.Parameters.AddWithValue("@p1", idMenu)

                                Dim status As String = Convert.ToString(cek.ExecuteScalar())

                                If Not status.Equals("Tersedia", StringComparison.OrdinalIgnoreCase) Then
                                    Throw New Exception("Ada menu yang sudah habis. Periksa kembali pesanan.")
                                End If

                            End Using

                            Dim sqlDetail As String =
                                "INSERT INTO DETAIL_PESANAN " &
                                "(No_Transaksi, ID_Menu, Jumlah, Harga_Satuan) " &
                                "VALUES (?, ?, ?, ?)"

                            Using cmd As New OleDbCommand(sqlDetail, conn, trans)

                                cmd.Parameters.Add("@p1", OleDbType.VarWChar).Value = nomorTransaksi
                                cmd.Parameters.Add("@p2", OleDbType.VarWChar).Value = idMenu
                                cmd.Parameters.Add("@p3", OleDbType.Integer).Value = qty
                                cmd.Parameters.Add("@p4", OleDbType.Currency).Value = harga

                                cmd.ExecuteNonQuery()

                            End Using

                        Next

                        trans.Commit()

                    Catch
                        trans.Rollback()
                        Throw
                    End Try

                End Using
            End Using

            CurrentTransactionId = nomorTransaksi

            MessageBox.Show(
                "Pesanan berhasil disimpan." & vbCrLf &
                "Nomor transaksi: " & nomorTransaksi,
                "Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            BukaForm(Me, New Form4(nomorTransaksi))

            dgvDetail.Rows.Clear()
            txtNamaPelanggan.Clear()
            nudJumlah.Value = 1

            HitungTotal()
            MuatMenu()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan pesanan: " & ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' MEMBATALKAN PESANAN
    '========================================
    Private Sub btnBatalPesanan_Click(sender As Object, e As EventArgs) Handles btnBatalPesanan.Click

        dgvDetail.Rows.Clear()
        txtNamaPelanggan.Clear()
        nudJumlah.Value = 1

        HitungTotal()

    End Sub

    '========================================
    ' PENCARIAN MENU
    '========================================
    Private Sub txtCariMenu_TextChanged(sender As Object, e As EventArgs) Handles txtCariMenu.TextChanged

        Dim cari As String = txtCariMenu.Text.Trim().ToLowerInvariant()

        btnAyam.Visible = btnAyam.Text.ToLowerInvariant().Contains(cari)
        btnLele.Visible = btnLele.Text.ToLowerInvariant().Contains(cari)
        btnTempe.Visible = btnTempe.Text.ToLowerInvariant().Contains(cari)
        btnEsTeh.Visible = btnEsTeh.Text.ToLowerInvariant().Contains(cari)

    End Sub

    '========================================
    ' NAVIGASI
    '========================================
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        BukaForm(Me, New Form2())
    End Sub

    Private Sub btnNavPembayaran_Click(sender As Object, e As EventArgs) Handles btnNavPembayaran.Click
        BukaForm(Me, New Form4())
    End Sub

    Private Sub btnNavAntrean_Click(sender As Object, e As EventArgs) Handles btnNavAntrean.Click
        BukaForm(Me, New Form5())
    End Sub

    Private Sub btnNavKoreksi_Click(sender As Object, e As EventArgs) Handles btnNavKoreksi.Click
        BukaForm(Me, New Form8())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MintaLogout(Me)
    End Sub

End Class
