<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dgvNhanVien = New DataGridView()
        txtMaNV = New TextBox()
        txtHoTen = New TextBox()
        dtpNgaySinh = New DateTimePicker()
        cboGioiTinh = New ComboBox()
        txtDiaChi = New TextBox()
        txtSDT = New TextBox()
        txtEmail = New TextBox()
        btnThem = New Button()
        btnCapNhat = New Button()
        btnXoa = New Button()
        btnThoat = New Button()
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 0
        Label1.Text = "Mã NV"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 1
        Label2.Text = "Họ tên "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 2
        Label3.Text = "Ngày sinh "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 3
        Label4.Text = "Giới tính"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(548, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 4
        Label5.Text = "Địa chỉ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(548, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 5
        Label6.Text = "SDT"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(548, 184)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 6
        Label7.Text = "Email"
        ' 
        ' dgvNhanVien
        ' 
        dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNhanVien.Location = New Point(20, 229)
        dgvNhanVien.Name = "dgvNhanVien"
        dgvNhanVien.RowHeadersWidth = 51
        dgvNhanVien.Size = New Size(966, 188)
        dgvNhanVien.TabIndex = 7
        ' 
        ' txtMaNV
        ' 
        txtMaNV.Location = New Point(97, 28)
        txtMaNV.Name = "txtMaNV"
        txtMaNV.Size = New Size(223, 27)
        txtMaNV.TabIndex = 8
        ' 
        ' txtHoTen
        ' 
        txtHoTen.Location = New Point(97, 83)
        txtHoTen.Name = "txtHoTen"
        txtHoTen.Size = New Size(223, 27)
        txtHoTen.TabIndex = 9
        ' 
        ' dtpNgaySinh
        ' 
        dtpNgaySinh.Location = New Point(97, 135)
        dtpNgaySinh.Name = "dtpNgaySinh"
        dtpNgaySinh.Size = New Size(244, 27)
        dtpNgaySinh.TabIndex = 10
        ' 
        ' cboGioiTinh
        ' 
        cboGioiTinh.FormattingEnabled = True
        cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        cboGioiTinh.Location = New Point(97, 184)
        cboGioiTinh.Name = "cboGioiTinh"
        cboGioiTinh.Size = New Size(151, 28)
        cboGioiTinh.TabIndex = 11
        ' 
        ' txtDiaChi
        ' 
        txtDiaChi.Location = New Point(637, 56)
        txtDiaChi.Name = "txtDiaChi"
        txtDiaChi.Size = New Size(199, 27)
        txtDiaChi.TabIndex = 12
        ' 
        ' txtSDT
        ' 
        txtSDT.Location = New Point(637, 109)
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(199, 27)
        txtSDT.TabIndex = 13
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(637, 177)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(199, 27)
        txtEmail.TabIndex = 14
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(112, 442)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 15
        btnThem.Text = "Thêm "
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(327, 442)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(94, 29)
        btnCapNhat.TabIndex = 16
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(578, 442)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 17
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(807, 442)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(94, 29)
        btnThoat.TabIndex = 19
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' frmNhanVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(998, 534)
        Controls.Add(btnThoat)
        Controls.Add(btnXoa)
        Controls.Add(btnCapNhat)
        Controls.Add(btnThem)
        Controls.Add(txtEmail)
        Controls.Add(txtSDT)
        Controls.Add(txtDiaChi)
        Controls.Add(cboGioiTinh)
        Controls.Add(dtpNgaySinh)
        Controls.Add(txtHoTen)
        Controls.Add(txtMaNV)
        Controls.Add(dgvNhanVien)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNhanVien"
        Text = "frmNhanVien"
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvNhanVien As DataGridView
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
End Class
