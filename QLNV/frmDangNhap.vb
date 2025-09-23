Imports System.ComponentModel.Design

Public Class frmDangNhap
    Dim daTK As DataTable
    Dim TenDN, MatKhau, HoTen As String
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim user, pass As String
        user = txtTaikhoan.Text.Trim()
        pass = txtMatKhau.Text.Trim()
        If user = "" Or pass = "" Then
            MessageBox.Show("Chưa nhập Tên đăng nhâp/Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sql = "select * from TaiKhoan where TenDN='" + user + "' and MatKhau='" + pass + "'"
            daTK = LayDL(sql)
            If daTK.Rows.Count > 0 Then
                TenDN = daTK.Rows(0).Item("TenDN")
                MatKhau = daTK.Rows(0).Item("MatKhau")
                HoTen = daTK.Rows(0).Item("HoTen")
                Form1.Show()
                Me.Hide()
                Form1.QuảnLýToolStripMenuItem.Enabled = True
            Else
                MessageBox.Show("Lỗi đăng nhập", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTaikhoan.Text = "" : txtMatKhau.Text = ""
                txtTaikhoan.Focus()
            End If
        End If
    End Sub

    Private Sub btnKetThuc_Click(sender As Object, e As EventArgs) Handles btnKetThuc.Click
        Me.Close()
    End Sub
End Class