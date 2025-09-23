Imports System.Data.SqlClient

Public Class frmNhanVien
    Dim sql As String
    Dim cnn As New SqlConnection("Data Source=LAPTOP-IIR4D865\SQLEXPRESS01;Initial Catalog=QLNhanVien ;Integrated Security=True")
    Dim index As Integer = -1

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        sql = "SELECT * FROM NhanVien"
        Dim da As New SqlDataAdapter(sql, cnn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvNhanVien.DataSource = dt
    End Sub

    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        index = e.RowIndex
        If index >= 0 Then
            txtMaNV.Text = dgvNhanVien.Rows(index).Cells(0).Value.ToString()
            txtHoTen.Text = dgvNhanVien.Rows(index).Cells(1).Value.ToString()

            If Not IsDBNull(dgvNhanVien.Rows(index).Cells(2).Value) Then
                dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows(index).Cells(2).Value)
            Else
                dtpNgaySinh.Value = DateTime.Now
            End If

            cboGioiTinh.Text = dgvNhanVien.Rows(index).Cells(3).Value.ToString()
            txtDiaChi.Text = dgvNhanVien.Rows(index).Cells(4).Value.ToString()
            txtSDT.Text = dgvNhanVien.Rows(index).Cells(5).Value.ToString()
            txtEmail.Text = dgvNhanVien.Rows(index).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtMaNV.Clear()
        txtHoTen.Clear()
        txtDiaChi.Clear()
        txtSDT.Clear()
        txtEmail.Clear()
        cboGioiTinh.SelectedIndex = -1
        dtpNgaySinh.Value = DateTime.Today
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' Kiểm tra trùng mã nhân viên
        Dim checkSql As String = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV"
        Dim checkCmd As New SqlCommand(checkSql, cnn)
        checkCmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text)

        cnn.Open()
        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
        cnn.Close()

        If count > 0 Then
            MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Thêm nhân viên mới
        sql = "INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email) VALUES (@MaNV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email)"
        Dim cmd As New SqlCommand(sql, cnn)

        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value)
        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()

            LoadData()
            ClearFields()
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cnn.Close()
        End Try
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        sql = "UPDATE NhanVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDienThoai=@SDT, Email=@Email WHERE MaNV=@MaNV"
        Dim cmd As New SqlCommand(sql, cnn)

        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value)
        cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text)
        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

        Try
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()

            LoadData()
            ClearFields()
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi cập nhật: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cnn.Close()
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV"
            Dim cmd As New SqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text)

            Try
                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()

                LoadData()
                ClearFields()
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cnn.Close()
            End Try
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
