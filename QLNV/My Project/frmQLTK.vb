Imports System.Data.SqlClient

Public Class frmQLTK
    Dim sql As String
    Dim index As Integer = -1
    Private Sub frmQLTK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM TaiKhoan"
        dgvTK.DataSource = LayDL(sql)

        ' Gắn sự kiện chọn dòng
        AddHandler dgvTK.CellClick, AddressOf dgvTK_CellClick
    End Sub
    Private Sub dgvTK_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        index = e.RowIndex
        If index >= 0 AndAlso index < dgvTK.Rows.Count Then
            txtTenDN.Text = dgvTK.Rows(index).Cells(0).Value.ToString()
            txtMatKhau.Text = dgvTK.Rows(index).Cells(1).Value.ToString()
            txtHoten.Text = dgvTK.Rows(index).Cells(2).Value.ToString()
        End If
    End Sub


    Private Sub XoaTextBox()
        txtTenDN.Clear()
        txtMatKhau.Clear()
        txtHoten.Clear()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' Kiểm tra trùng tên đăng nhập
        Dim sqlCheck As String = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDN = @TenDN"
        Using cnn As SqlConnection = ketnoi()
            Using cmdCheck As New SqlCommand(sqlCheck, cnn)
                cmdCheck.Parameters.AddWithValue("@TenDN", txtTenDN.Text)
                cnn.Open()
                Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                cnn.Close()

                If exists > 0 Then
                    MessageBox.Show("Tên đăng nhập đã tồn tại!")
                    Exit Sub
                End If
            End Using

            ' Thêm tài khoản
            Dim sql As String = "INSERT INTO TaiKhoan VALUES (@TenDN, @MatKhau, @HoTen)"
            Using cmd As New SqlCommand(sql, cnn)
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text)
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text)
                cmd.Parameters.AddWithValue("@HoTen", txtHoten.Text)
                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()
            End Using
        End Using

        dgvTK.DataSource = LayDL("SELECT * FROM TaiKhoan")
        MessageBox.Show("Thêm thành công!")
        XoaTextBox()
    End Sub



    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If txtTenDN.Text = "" Then
            MessageBox.Show("Chọn tài khoản cần cập nhật!")
            Exit Sub
        End If

        Dim sql As String = "UPDATE TaiKhoan SET MatKhau = @MatKhau, HoTen = @HoTen WHERE TenDN = @TenDN"
        Using cnn As SqlConnection = ketnoi()
            Using cmd As New SqlCommand(sql, cnn)
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text)
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text)
                cmd.Parameters.AddWithValue("@HoTen", txtHoten.Text)

                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()
            End Using
        End Using

        dgvTK.DataSource = LayDL("SELECT * FROM TaiKhoan")
        MessageBox.Show("Cập nhật thành công!")
        XoaTextBox()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtTenDN.Text = "" Then
            MessageBox.Show("Chọn tài khoản cần xóa!")
            Exit Sub
        End If

        If MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Dim sql As String = "DELETE FROM TaiKhoan WHERE TenDN = @TenDN"

        Using cnn As SqlConnection = ketnoi()
            Using cmd As New SqlCommand(sql, cnn)
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text)
                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()
            End Using
        End Using

        dgvTK.DataSource = LayDL("SELECT * FROM TaiKhoan")
        MessageBox.Show("Xóa tài khoản thành công!")
        XoaTextBox()
    End Sub

    Private Sub btnGhi_Click(sender As Object, e As EventArgs) Handles btnGhi.Click
        MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu!")
    End Sub
    Private Sub btnKhongGhi_Click(sender As Object, e As EventArgs) Handles btnKhongGhi.Click
        XoaTextBox()
    End Sub

    Private Sub btnKetThuc_Click(sender As Object, e As EventArgs) Handles btnKetThuc.Click
        Me.Close()
    End Sub


End Class