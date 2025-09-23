<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLuong
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
        cbChucVu = New ComboBox()
        txtChucVuID = New TextBox()
        Label5 = New Label()
        txtMucLuong = New TextBox()
        dgvLuong = New DataGridView()
        btnThem = New Button()
        btnCapNhat = New Button()
        btnXoa = New Button()
        btnThoat = New Button()
        CType(dgvLuong, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(82, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 32)
        Label1.TabIndex = 0
        Label1.Text = "BẢNG LƯƠNG CỦA NHÂN VIÊN "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 1
        Label2.Text = "ID chức vụ" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 2
        Label3.Text = "Chức vụ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 3
        ' 
        ' cbChucVu
        ' 
        cbChucVu.FormattingEnabled = True
        cbChucVu.Items.AddRange(New Object() {"Trưởng phòng", "Phó phòng", "Chuyên viên", "Nhân viên", "Thực tập sinh"})
        cbChucVu.Location = New Point(186, 174)
        cbChucVu.Name = "cbChucVu"
        cbChucVu.Size = New Size(251, 28)
        cbChucVu.TabIndex = 4
        ' 
        ' txtChucVuID
        ' 
        txtChucVuID.Location = New Point(186, 99)
        txtChucVuID.Name = "txtChucVuID"
        txtChucVuID.Size = New Size(225, 27)
        txtChucVuID.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 6
        Label5.Text = "Mức lương"
        ' 
        ' txtMucLuong
        ' 
        txtMucLuong.Location = New Point(186, 245)
        txtMucLuong.Name = "txtMucLuong"
        txtMucLuong.Size = New Size(207, 27)
        txtMucLuong.TabIndex = 7
        ' 
        ' dgvLuong
        ' 
        dgvLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLuong.Location = New Point(528, 71)
        dgvLuong.Name = "dgvLuong"
        dgvLuong.RowHeadersWidth = 51
        dgvLuong.Size = New Size(507, 201)
        dgvLuong.TabIndex = 8
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(528, 316)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 9
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(674, 316)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(94, 29)
        btnCapNhat.TabIndex = 10
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(815, 316)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 11
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(958, 316)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(94, 29)
        btnThoat.TabIndex = 12
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' frmLuong
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1144, 454)
        Controls.Add(btnThoat)
        Controls.Add(btnXoa)
        Controls.Add(btnCapNhat)
        Controls.Add(btnThem)
        Controls.Add(dgvLuong)
        Controls.Add(txtMucLuong)
        Controls.Add(Label5)
        Controls.Add(txtChucVuID)
        Controls.Add(cbChucVu)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmLuong"
        Text = "frmLuong"
        CType(dgvLuong, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbChucVu As ComboBox
    Friend WithEvents txtChucVuID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMucLuong As TextBox
    Friend WithEvents dgvLuong As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
End Class
