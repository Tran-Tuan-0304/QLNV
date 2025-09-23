Imports System.Data.SqlClient

Public Class frmLuong
    Dim conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-IIR4D865\SQLEXPRESS01;Initial Catalog=QLNhanVien;Integrated Security=True")
    Dim da As SqlDataAdapter
        Dim dt As DataTable
    Private Sub LoadData()
        conn.Open()
        da = New SqlDataAdapter("SELECT * FROM Luong", conn)
        dt = New DataTable()
        da.Fill(dt)
        dgvLuong.DataSource = dt
        conn.Close()
    End Sub

    Private Sub LoadComboBox()
        conn.Open()
        Dim cmd As New SqlCommand("SELECT TenChucVu FROM Luong", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        cbChucVu.Items.Clear()
        While reader.Read()
            cbChucVu.Items.Add(reader("TenChucVu").ToString())
        End While
        conn.Close()
    End Sub
    Private Sub frmLuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadComboBox()
    End Sub


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' Kiểm tra Mức lương có phải số không
        If Not IsNumeric(txtMucLuong.Text) Then
            MessageBox.Show("Mức lương phải là số hợp lệ!", "Lỗi nhập liệu")
            Exit Sub
        End If

        Using conn As New SqlConnection("Data Source=LAPTOP-IIR4D865\SQLEXPRESS01;Initial Catalog=QLNhanVien;Integrated Security=True")
            conn.Open()

            ' Kiểm tra ID đã tồn tại chưa
            Dim checkSql As String = "SELECT COUNT(*) FROM Luong WHERE ChucVuID = @id"
            Using checkCmd As New SqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@id", txtChucVuID.Text)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If exists > 0 Then
                    ' Nếu tồn tại → cập nhật
                    Dim updateSql As String = "UPDATE Luong SET TenChucVu = @ten, MucLuong = @luong WHERE ChucVuID = @id"
                    Using updateCmd As New SqlCommand(updateSql, conn)
                        updateCmd.Parameters.AddWithValue("@id", txtChucVuID.Text)
                        updateCmd.Parameters.AddWithValue("@ten", cbChucVu.Text)
                        updateCmd.Parameters.AddWithValue("@luong", Convert.ToDecimal(txtMucLuong.Text))
                        updateCmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Cập nhật thành công!")
                Else
                    ' Nếu chưa tồn tại → thêm mới
                    Dim insertSql As String = "INSERT INTO Luong VALUES (@id, @ten, @luong)"
                    Using insertCmd As New SqlCommand(insertSql, conn)
                        insertCmd.Parameters.AddWithValue("@id", txtChucVuID.Text)
                        insertCmd.Parameters.AddWithValue("@ten", cbChucVu.Text)
                        insertCmd.Parameters.AddWithValue("@luong", Convert.ToDecimal(txtMucLuong.Text))
                        insertCmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Thêm thành công!")
                End If
            End Using
            conn.Close()
        End Using
    End Sub




    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        conn.Open()
        Dim sql As String = "UPDATE Luong SET TenChucVu=@ten, MucLuong=@luong WHERE ChucVuID=@id"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@id", txtChucVuID.Text)
        cmd.Parameters.AddWithValue("@ten", cbChucVu.Text)
        cmd.Parameters.AddWithValue("@luong", txtMucLuong.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadData()
        LoadComboBox()
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        conn.Open()
        Dim sql As String = "DELETE FROM Luong WHERE ChucVuID=@id"
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@id", txtChucVuID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadData()
        LoadComboBox()
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLuong.CellClick
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            txtChucVuID.Text = dgvLuong.Rows(index).Cells(0).Value.ToString()
            cbChucVu.Text = dgvLuong.Rows(index).Cells(1).Value.ToString()
            txtMucLuong.Text = dgvLuong.Rows(index).Cells(2).Value.ToString()
        End If
    End Sub

End Class