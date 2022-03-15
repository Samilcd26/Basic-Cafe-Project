Imports System.Security.Cryptography
Imports System.Text
Public Class Form1
    Private Function Hash(Algoritma As HashAlgorithm, Metin As String) As String
        Dim Sonuc As String = Nothing
        Dim ByteDizi() As Byte = Encoding.UTF8.GetBytes(Metin)
        Dim SonucByte() As Byte = Algoritma.ComputeHash(ByteDizi)
        For Each Karakter As Byte In SonucByte
            Sonuc &= Karakter.ToString("x2")
        Next
        Return Sonuc
    End Function

    Private Sub KodlaBtn_Click(sender As Object, e As EventArgs) Handles KodlaBtn.Click
        Select Case HashCBox.SelectedIndex
            Case 0
                Dim Algoritma As MD5 = MD5.Create
                KodTBox.Text = Hash(Algoritma, MetinTBox.Text)
            Case 1
                Dim Algoritma As SHA1 = SHA1.Create
                KodTBox.Text = Hash(Algoritma, MetinTBox.Text)
            Case 2
                Dim Algoritma As SHA256 = SHA256.Create
                KodTBox.Text = Hash(Algoritma, MetinTBox.Text)
            Case 3
                Dim Algoritma As SHA384 = SHA384.Create
                KodTBox.Text = Hash(Algoritma, MetinTBox.Text)
            Case 4
                Dim Algoritma As SHA512 = SHA512.Create
                KodTBox.Text = Hash(Algoritma, MetinTBox.Text)
        End Select
        UzunlukLbl.Text = KodTBox.TextLength
    End Sub
End Class
