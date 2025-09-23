<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ĐăngNhậpToolStripMenuItem = New ToolStripMenuItem()
        QuảnLýTàiKhoảnToolStripMenuItem = New ToolStripMenuItem()
        ThoátToolStripMenuItem = New ToolStripMenuItem()
        QuảnLýToolStripMenuItem = New ToolStripMenuItem()
        NhânViênToolStripMenuItem = New ToolStripMenuItem()
        LươngToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, QuảnLýToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(613, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ĐăngNhậpToolStripMenuItem, QuảnLýTàiKhoảnToolStripMenuItem, ThoátToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(89, 24)
        ToolStripMenuItem1.Text = "&Hệ thống "
        ' 
        ' ĐăngNhậpToolStripMenuItem
        ' 
        ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem"
        ĐăngNhậpToolStripMenuItem.Size = New Size(211, 26)
        ĐăngNhậpToolStripMenuItem.Text = "&Đăng nhập "
        ' 
        ' QuảnLýTàiKhoảnToolStripMenuItem
        ' 
        QuảnLýTàiKhoảnToolStripMenuItem.Name = "QuảnLýTàiKhoảnToolStripMenuItem"
        QuảnLýTàiKhoảnToolStripMenuItem.Size = New Size(211, 26)
        QuảnLýTàiKhoảnToolStripMenuItem.Text = "&Quản lý tài khoản "
        ' 
        ' ThoátToolStripMenuItem
        ' 
        ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        ThoátToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        ThoátToolStripMenuItem.Size = New Size(211, 26)
        ThoátToolStripMenuItem.Text = "&Thoát "
        ' 
        ' QuảnLýToolStripMenuItem
        ' 
        QuảnLýToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NhânViênToolStripMenuItem, LươngToolStripMenuItem})
        QuảnLýToolStripMenuItem.Enabled = False
        QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        QuảnLýToolStripMenuItem.Size = New Size(73, 24)
        QuảnLýToolStripMenuItem.Text = "&Quản lý"
        ' 
        ' NhânViênToolStripMenuItem
        ' 
        NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        NhânViênToolStripMenuItem.Size = New Size(224, 26)
        NhânViênToolStripMenuItem.Text = "&Nhân viên "
        ' 
        ' LươngToolStripMenuItem
        ' 
        LươngToolStripMenuItem.Name = "LươngToolStripMenuItem"
        LươngToolStripMenuItem.Size = New Size(224, 26)
        LươngToolStripMenuItem.Text = "&Lương "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 371)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ĐăngNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýTàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LươngToolStripMenuItem As ToolStripMenuItem

End Class
