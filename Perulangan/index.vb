Public Class index

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim pilih = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pilih = Windows.Forms.DialogResult.Yes Then
            Environment.Exit(0)
        Else
            pilih = Windows.Forms.DialogResult.None
        End If
    End Sub

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        bintang.MdiParent = Me
        bintang.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        matriks.MdiParent = Me
        matriks.Show()
    End Sub

    Private Sub AplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiToolStripMenuItem.Click

    End Sub
    '@DesignBy:dDista
End Class
