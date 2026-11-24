
Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Linq
Imports System.Globalization

Module Module1

    Public CurrentUserId As Integer = 0
    Public CurrentUsername As String = ""
    Public CurrentRole As String = ""
    Public CurrentKasirId As String = ""
    Public CurrentTransactionId As String = ""

    Public LogoutRequested As Boolean = False

    Public Const DB_FILE As String = "Database Haji toyyib.accdb"
    Public Const OWNER_ID As String = "PM01"

    '========================================
    ' KONEKSI DATABASE
    '========================================
    Public Function BuatKoneksi() As OleDbConnection

        Dim lokasiDB As String =
            Path.Combine(Application.StartupPath, DB_FILE)

        If Not File.Exists(lokasiDB) Then
            Throw New FileNotFoundException(
                "Database tidak ditemukan: " & lokasiDB
            )
        End If

        Dim connectionString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;" &
            "Data Source=" & lokasiDB & ";" &
            "Persist Security Info=False;"

        Return New OleDbConnection(connectionString)

    End Function

    '========================================
    ' HASH PASSWORD SHA256
    '========================================
    Public Function HashPassword(password As String) As String

        Using sha As SHA256 = SHA256.Create()

            Dim bytes As Byte() =
                Encoding.UTF8.GetBytes(password)

            Dim hash As Byte() = sha.ComputeHash(bytes)

            Return BitConverter.ToString(hash).
                Replace("-", "").ToLowerInvariant()

        End Using

    End Function

    '========================================
    ' FORMAT RUPIAH
    '========================================
    Public Function FormatRupiah(nilai As Decimal) As String

        Return "Rp" & nilai.ToString(
            "#,##0",
            CultureInfo.GetCultureInfo("id-ID")
        )

    End Function

    '========================================
    ' MEMBACA INPUT UANG
    '========================================
    Public Function ParseRupiah(teks As String) As Decimal

        Dim angka As String =
            New String(teks.Where(
                Function(c) Char.IsDigit(c)
            ).ToArray())

        Dim hasil As Decimal = 0

        Decimal.TryParse(angka, hasil)

        Return hasil

    End Function

    '========================================
    ' MEMBUAT NOMOR TRANSAKSI
    '========================================
    Public Function BuatNoTransaksi() As String

        Return "TR" & DateTime.Now.ToString(
            "yyyyMMddHHmmssfff"
        )

    End Function

    '========================================
    ' RIWAYAT KOREKSI
    '========================================
    Public Sub CatatRiwayat(
        jenisData As String,
        idReferensi As String,
        alasan As String,
        dataSebelum As String,
        dataSesudah As String
    )

        If CurrentUserId <= 0 Then
            Throw New Exception(
                "Session pengguna belum tersedia."
            )
        End If

        Using conn As OleDbConnection = BuatKoneksi()

            conn.Open()

            Dim sql As String =
                "INSERT INTO RIWAYAT_KOREKSI " &
                "(ID_User, Tanggal_Koreksi, Jenis_Data, " &
                "ID_Referensi, Alasan, Data_Sebelum, Data_Sesudah) " &
                "VALUES (?, ?, ?, ?, ?, ?, ?)"

            Using cmd As New OleDbCommand(sql, conn)

                cmd.Parameters.AddWithValue("@p1", CurrentUserId)
                cmd.Parameters.AddWithValue("@p2", DateTime.Now)
                cmd.Parameters.AddWithValue("@p3", jenisData)
                cmd.Parameters.AddWithValue("@p4", idReferensi)
                cmd.Parameters.AddWithValue("@p5", alasan)
                cmd.Parameters.AddWithValue("@p6", dataSebelum)
                cmd.Parameters.AddWithValue("@p7", dataSesudah)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    '========================================
    ' NAVIGASI ANTAR FORM
    '========================================
    Public Sub BukaForm(
        parentForm As Form,
        childForm As Form
    )

        parentForm.Hide()

        childForm.ShowDialog(parentForm)
        childForm.Dispose()

        If LogoutRequested Then
            parentForm.Close()
        Else
            parentForm.Show()
        End If

    End Sub

    '========================================
    ' LOGOUT
    '========================================
    Public Sub MintaLogout(formAktif As Form)

        LogoutRequested = True
        formAktif.Close()

    End Sub

    '========================================
    ' MENGATUR LAPISAN KOMPONEN FORM
    '========================================
    Public Sub AturLayerKonten(konten As Panel)

        'Letakkan semua panel latar di belakang
        For Each kontrol As Control In konten.Controls
            If TypeOf kontrol Is Panel Then
                kontrol.SendToBack()
            End If
        Next

        'Letakkan komponen isi di depan panel latar
        For Each kontrol As Control In konten.Controls
            If Not TypeOf kontrol Is Panel Then
                kontrol.BringToFront()
            End If
        Next

    End Sub

End Module
