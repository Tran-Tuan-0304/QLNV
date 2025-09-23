Public Class Form1
    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        frmDangNhap.Show()
    End Sub

    Private Sub QuảnLýTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTàiKhoảnToolStripMenuItem.Click
        frmQLTK.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        Dim frm As New frmNhanVien()
        frm.Show()
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
    End Sub

    Private Sub LươngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LươngToolStripMenuItem.Click
        frmLuong.Show()
    End Sub
End Class
