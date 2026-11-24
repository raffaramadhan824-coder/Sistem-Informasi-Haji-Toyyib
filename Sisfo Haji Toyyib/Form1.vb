
Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        cmbRole.Items.Clear()
        cmbRole.Items.Add("Kasir")
        cmbRole.Items.Add("Dapur")
        cmbRole.SelectedIndex = 0

        txtPassword.UseSystemPasswordChar = True

    End Sub

    '========================================
    ' LOGIN
    '========================================
    Private Sub btnLogin_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim role As String = cmbRole.Text

        If username = "" OrElse password = "" Then

            MessageBox.Show(
                "Username dan password wajib diisi.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        Try

            Using conn As OleDbConnection = BuatKoneksi()

                conn.Open()

                Dim sql As String =
                    "SELECT ID_User, Username, Password_Hash, " &
                    "Role_User, No_ID_Kasir " &
                    "FROM USER_LOGIN " &
                    "WHERE Username = ? AND Status_Aktif = True"

                Using cmd As New OleDbCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@p1", username)

                    Using reader As OleDbDataReader =
                        cmd.ExecuteReader()

                        If Not reader.Read() Then

                            MessageBox.Show(
                                "Username tidak ditemukan atau akun nonaktif.",
                                "Login Gagal"
                            )

                            Return

                        End If

                        Dim passwordDB As String =
                            Convert.ToString(reader("Password_Hash"))

                        Dim roleDB As String =
                            Convert.ToString(reader("Role_User"))

                        Dim hashInput As String =
                            HashPassword(password)

                        If Not String.Equals(
                            passwordDB,
                            hashInput,
                            StringComparison.OrdinalIgnoreCase
                        ) Then

                            MessageBox.Show(
                                "Password yang kamu masukkan salah.",
                                "Login Gagal"
                            )

                            Return

                        End If

                        If Not String.Equals(
                            role,
                            roleDB,
                            StringComparison.OrdinalIgnoreCase
                        ) Then

                            MessageBox.Show(
                                "Role yang dipilih tidak sesuai akun.",
                                "Login Gagal"
                            )

                            Return

                        End If

                        CurrentUserId =
                            Convert.ToInt32(reader("ID_User"))

                        CurrentUsername =
                            Convert.ToString(reader("Username"))

                        CurrentRole = roleDB

                        If IsDBNull(reader("No_ID_Kasir")) Then
                            CurrentKasirId = ""
                        Else
                            CurrentKasirId =
                                Convert.ToString(reader("No_ID_Kasir"))
                        End If

                    End Using

                End Using

            End Using

            MessageBox.Show(
                "Login berhasil. Selamat datang, " &
                CurrentUsername & "!",
                "Berhasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Hide()

            If CurrentRole.Equals(
                "Kasir",
                StringComparison.OrdinalIgnoreCase
            ) Then

                Using frm As New Form2()
                    frm.ShowDialog(Me)
                End Using

            ElseIf CurrentRole.Equals(
                "Dapur",
                StringComparison.OrdinalIgnoreCase
            ) Then

                Using frm As New Form5()
                    frm.ShowDialog(Me)
                End Using

            End If

            LogoutRequested = False

            Me.Show()
            txtPassword.Clear()
            txtUsername.Focus()

        Catch ex As Exception

            MessageBox.Show(
                "Terjadi kesalahan saat login: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' BATAL / BERSIHKAN LOGIN
    '========================================
    Private Sub btnBatal_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBatal.Click

        txtUsername.Clear()
        txtPassword.Clear()

        If cmbRole.Items.Count > 0 Then
            cmbRole.SelectedIndex = 0
        End If

        txtUsername.Focus()

    End Sub

End Class

