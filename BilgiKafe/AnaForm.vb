Imports System.Data.SqlClient
Public Class AnaForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Dim KullaniciFormu As New KullaniciGirisFormu
        KullaniciGirisFormu.ShowDialog(Me)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub MenüKategorileriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenüKategorileriToolStripMenuItem.Click
        MenuKategoriFormu.ShowDialog(Me)
    End Sub

    Private Sub MenüEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenüEkleToolStripMenuItem.Click
        MenuyeEklemeFormu.MenuNo = Nothing
        MenuyeEklemeFormu.ShowDialog(Me)
    End Sub

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click, MenüToolStripMenuItem.Click
        MenuFormu.MdiParent = Me
        MenuFormu.Show()
        MenuFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MasaMekanBilgileriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasaMekanBilgileriToolStripMenuItem.Click
        MasaMekanFormu.ShowDialog(Me)
        MasaMekanFormu.Dispose()
    End Sub

    Private Sub MasaEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasaEkleToolStripMenuItem.Click
        MasaEklemeFormu.ShowDialog(Me)
    End Sub

    Private Sub MasalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasalarToolStripMenuItem.Click, MasalarBtn.Click
        MasalarFormu.MdiParent = Me
        MasalarFormu.Show()
        MasalarFormu.WindowState = FormWindowState.Maximized
    End Sub
End Class
