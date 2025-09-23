<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLTK
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
        btnThem = New Button()
        btnCapNhat = New Button()
        btnXoa = New Button()
        btnGhi = New Button()
        btnKhongGhi = New Button()
        btnKetThuc = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTenDN = New TextBox()
        txtMatKhau = New TextBox()
        txtHoten = New TextBox()
        dgvTK = New DataGridView()
        CType(dgvTK, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(180, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 32)
        Label1.TabIndex = 0
        Label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN "
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(12, 272)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 2
        btnThem.Text = "Thêm "
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(144, 272)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(94, 29)
        btnCapNhat.TabIndex = 3
        btnCapNhat.Text = "Cập nhật "
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(275, 272)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 4
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnGhi
        ' 
        btnGhi.Location = New Point(414, 272)
        btnGhi.Name = "btnGhi"
        btnGhi.Size = New Size(94, 29)
        btnGhi.TabIndex = 5
        btnGhi.Text = "Ghi"
        btnGhi.UseVisualStyleBackColor = True
        ' 
        ' btnKhongGhi
        ' 
        btnKhongGhi.Location = New Point(552, 272)
        btnKhongGhi.Name = "btnKhongGhi"
        btnKhongGhi.Size = New Size(94, 29)
        btnKhongGhi.TabIndex = 6
        btnKhongGhi.Text = "Không ghi"
        btnKhongGhi.UseVisualStyleBackColor = True
        ' 
        ' btnKetThuc
        ' 
        btnKetThuc.Location = New Point(694, 272)
        btnKetThuc.Name = "btnKetThuc"
        btnKetThuc.Size = New Size(94, 29)
        btnKetThuc.TabIndex = 7
        btnKetThuc.Text = "Kết thúc" & vbCrLf
        btnKetThuc.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 333)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 20)
        Label2.TabIndex = 8
        Label2.Text = "Tên đăng nhập"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(81, 387)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 9
        Label3.Text = "Mật khẩu "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(81, 448)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 20)
        Label4.TabIndex = 10
        Label4.Text = "Họ tên "
        ' 
        ' txtTenDN
        ' 
        txtTenDN.Location = New Point(216, 326)
        txtTenDN.Name = "txtTenDN"
        txtTenDN.Size = New Size(370, 27)
        txtTenDN.TabIndex = 11
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Location = New Point(216, 384)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.Size = New Size(370, 27)
        txtMatKhau.TabIndex = 12
        ' 
        ' txtHoten
        ' 
        txtHoten.Location = New Point(216, 441)
        txtHoten.Name = "txtHoten"
        txtHoten.Size = New Size(370, 27)
        txtHoten.TabIndex = 13
        ' 
        ' dgvTK
        ' 
        dgvTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTK.Location = New Point(7, 59)
        dgvTK.Name = "dgvTK"
        dgvTK.RowHeadersWidth = 51
        dgvTK.Size = New Size(787, 197)
        dgvTK.TabIndex = 14
        ' 
        ' frmQLTK
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 487)
        Controls.Add(dgvTK)
        Controls.Add(txtHoten)
        Controls.Add(txtMatKhau)
        Controls.Add(txtTenDN)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnKetThuc)
        Controls.Add(btnKhongGhi)
        Controls.Add(btnGhi)
        Controls.Add(btnXoa)
        Controls.Add(btnCapNhat)
        Controls.Add(btnThem)
        Controls.Add(Label1)
        Name = "frmQLTK"
        Text = "frmQLTK"
        CType(dgvTK, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnGhi As Button
    Friend WithEvents btnKhongGhi As Button
    Friend WithEvents btnKetThuc As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenDN As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents txtHoten As TextBox
    Friend WithEvents dgvTK As DataGridView
End Class
