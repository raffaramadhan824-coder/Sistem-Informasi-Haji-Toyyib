
Imports System.Data.OleDb

Public Class Form6

    Private Sub Form6_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text = "LOGIN SEBAGAI  •  DAPUR"

        btnNavDashboard.Visible = False
        btnNavPesanan.Visible = False
        btnNavPembayaran.Visible = False

        txtIdMenu.ReadOnly = True
        txtNamaMenu.ReadOnly = True

        cmbStatusMenu.Items.Clear()
        cmbStatusMenu.Items.Add("Tersedia")
        cmbStatusMenu.Items.Add("Habis")

        dgvStatusMenu.AllowUserToAddRows = False
        dgvStatusMenu.ReadOnly = True
        dgvStatusMenu.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        MuatStatusMenu()

    End Sub

    '========================================
    ' MEMUAT DATA MENU
    '========================================
    Private Sub MuatStatusMenu()

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT ID_Menu, Nama_Menu, Harga_Menu, " &
                    "Status_Ketersediaan FROM MENU " &
                    "ORDER BY ID_Menu"

                Dim tabel As New DataTable()

                Using adapter As New OleDbDataAdapter(sql, conn)
                    adapter.Fill(tabel)
                End Using

                dgvStatusMenu.Rows.Clear()

                Dim nomor As Integer = 1

                For Each data As DataRow In tabel.Rows

                    dgvStatusMenu.Rows.Add(
                        nomor,
                        Convert.ToString(data("ID_Menu")),
                        Convert.ToString(data("Nama_Menu")),
                        FormatRupiah(
                            Convert.ToDecimal(data("Harga_Menu"))
                        ),
                        Convert.ToString(data("Status_Ketersediaan"))
                    )

                    nomor += 1

                Next

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat status menu: " & ex.Message
            )

        End Try

    End Sub

    '========================================
    ' PILIH BARIS MENU
    '========================================
    Private Sub dgvStatusMenu_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvStatusMenu.CellClick

        If e.RowIndex < 0 Then Return

        Dim baris As DataGridViewRow =
            dgvStatusMenu.Rows(e.RowIndex)

        txtIdMenu.Text =
            Convert.ToString(baris.Cells("id").Value)

        txtNamaMenu.Text =
            Convert.ToString(baris.Cells("nama").Value)

        Dim status As String =
            Convert.ToString(baris.Cells("status").Value)

        cmbStatusMenu.SelectedItem = status

    End Sub

    '========================================
    ' SIMPAN STATUS MENU
    '========================================
    Private Sub btnSimpanStatus_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimpanStatus.Click

        Dim idMenu As String = txtIdMenu.Text.Trim()
        Dim statusBaru As String = cmbStatusMenu.Text

        If idMenu = "" Then

            MessageBox.Show(
                "Pilih menu yang akan diubah."
            )

            Return

        End If

        If statusBaru = "" Then

            MessageBox.Show(
                "Pilih status ketersediaan."
            )

            Return

        End If

        Try

            Dim statusLama As String = ""

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Using cmd As New OleDbCommand(
                    "SELECT Status_Ketersediaan FROM MENU " &
                    "WHERE ID_Menu = ?",
                    conn
                )

                    cmd.Parameters.AddWithValue("@p1", idMenu)

                    statusLama =
                        Convert.ToString(cmd.ExecuteScalar())

                End Using

                If statusLama = statusBaru Then

                    MessageBox.Show(
                        "Status menu tidak mengalami perubahan."
                    )

                    Return

                End If

                Dim sql As String =
                    "UPDATE MENU SET Status_Ketersediaan = ? " &
                    "WHERE ID_Menu = ?"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@p1", statusBaru)
                    cmd.Parameters.AddWithValue("@p2", idMenu)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            CatatRiwayat(
                "MENU",
                idMenu,
                "Perubahan status ketersediaan menu",
                statusLama,
                statusBaru
            )

            MessageBox.Show(
                "Status menu berhasil diperbarui.",
                "Berhasil"
            )

            MuatStatusMenu()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memperbarui status menu: " & ex.Message
            )

        End Try

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
