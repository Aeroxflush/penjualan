Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Conn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim connString As String
    Dim dv As DataView

    Private Function Koneksi() As Boolean
        Dim ret As Boolean = True
        connString = "Server=127.0.0.1;Database=db_penjualan;Uid=root;"
        Try
            Conn = New MySqlConnection(connString)
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, , "error")
            ret = False
        End Try
        Return ret
    End Function

    Private Function fillDGV() As Boolean
        Dim ret As Boolean = True
        If Koneksi() Then
            Try
                da = New MySqlDataAdapter("SELECT * FROM tb_pelanggan", Conn)
                ds = New DataSet
                ds.Clear()
                da.Fill(ds, "BARANGall")
                dgv.DataSource = (ds.Tables("BARANGall"))
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
                ret = False
            End Try
        Else
            ret = False
        End If
        Return ret
    End Function

    Private Sub SetupDGV()
        Dim i As Integer = 1
        With dgv
            .Columns(0).HeaderText = "ID Pelanggan"
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(2).HeaderText = "Nomor Telepon"
            .Columns(3).HeaderText = "Alamat"
            .Columns(0).Width = 80
            .Columns(1).Width = 200
            .Columns(2).Width = 100
            .Columns(3).Width = 60
        End With
    End Sub

    Private Sub SetupUI()
        txt_idPelangg.Focus()
        txt_namaPelangg.Text = ""
        txt_nomortelp.Text = vbEmpty
        txt_alamat.Text = vbEmpty
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDGV()
        SetupDGV()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        If txt_idPelangg.Text = "" Or txt_namaPelangg.Text = "" Or txt_nomortelp.Text = "" Or txt_alamat.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Dim CMD As MySqlCommand
            If Koneksi() Then
                Try
                    Dim simpan As String = "INSERT INTO tb_pelanggan values ('" & txt_idPelangg.Text & "','" & txt_namaPelangg.Text & "','" & txt_nomortelp.Text & "','" &
                    txt_alamat.Text & "')"
                    CMD = New MySqlCommand(simpan, Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data baru berhasil disimpan")
                    fillDGV()
                Catch ex As Exception
                    MsgBox(ex.Message, , "error")
                End Try
            Else
            End If
        End If
    End Sub

    'Section Edit

    Private Sub txt_kodebrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idPelangg.KeyPress
        If e.KeyChar = Chr(13) Then
            CariKode()
        End If
    End Sub

    Private Sub CariKode()
        Dim CMD As MySqlCommand
        Dim RD As MySqlDataReader
        If Koneksi() Then
            Try
                CMD = New MySqlCommand("SELECT * FROM tb_pelanggan WHERE id_pelanggan='" & txt_idPelangg.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    SetupUI()
                Else
                    txt_namaPelangg.Text = RD.Item("nama_pelanggan")
                    txt_nomortelp.Text = RD.Item("nomor_telepon")
                    txt_alamat.Text = RD.Item("alamat")
                    txt_namaPelangg.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim CMD As MySqlCommand
        If Koneksi() Then
            Try
                Dim edit As String = "UPDATE tb_pelanggan SET nama_pelanggan='" & txt_namaPelangg.Text & "',nomor_telepon='" & txt_nomortelp.Text & "',alamat='" & txt_alamat.Text & "where id_pelanggan='" & txt_idPelangg.Text & "'"
                CMD = New MySqlCommand(edit, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil diUpdate")
                fillDGV()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        Dim CMD As MySqlCommand
        If txt_idPelangg.Text = "" Then
            MsgBox("Silahkan Pilih record yang akan di hapus dengan Masukan KODE barang dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If Koneksi() Then
                    Try
                        Dim hapus As String = "DELETE FROM tb_pelanggan WHERE id_pelanggan='" & txt_idPelangg.Text & "'"
                        CMD = New MySqlCommand(hapus, Conn)
                        CMD.ExecuteNonQuery()
                        fillDGV()
                    Catch ex As Exception
                        MsgBox(ex.Message, , "error")
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub btn_tutup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_tutup.Click
        End
    End Sub
End Class