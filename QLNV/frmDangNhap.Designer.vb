<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtTaikhoan = New TextBox()
        txtMatKhau = New TextBox()
        btnDangNhap = New Button()
        btnKetThuc = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(183, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 32)
        Label1.TabIndex = 0
        Label1.Text = "ĐĂNG NHẬP "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Tài khoản "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mật khẩu "
        ' 
        ' txtTaikhoan
        ' 
        txtTaikhoan.Location = New Point(170, 99)
        txtTaikhoan.Name = "txtTaikhoan"
        txtTaikhoan.Size = New Size(271, 27)
        txtTaikhoan.TabIndex = 3
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Location = New Point(170, 173)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.Size = New Size(271, 27)
        txtMatKhau.TabIndex = 4
        ' 
        ' btnDangNhap
        ' 
        btnDangNhap.Location = New Point(142, 257)
        btnDangNhap.Name = "btnDangNhap"
        btnDangNhap.Size = New Size(94, 29)
        btnDangNhap.TabIndex = 5
        btnDangNhap.Text = "Đăng nhập" & vbCrLf
        btnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' btnKetThuc
        ' 
        btnKetThuc.Location = New Point(405, 257)
        btnKetThuc.Name = "btnKetThuc"
        btnKetThuc.Size = New Size(94, 29)
        btnKetThuc.TabIndex = 6
        btnKetThuc.Text = "Kết thúc"
        btnKetThuc.UseVisualStyleBackColor = True
        ' 
        ' frmDangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 317)
        Controls.Add(btnKetThuc)
        Controls.Add(btnDangNhap)
        Controls.Add(txtMatKhau)
        Controls.Add(txtTaikhoan)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmDangNhap"
        Text = "frmDangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTaikhoan As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnKetThuc As Button
End Class
