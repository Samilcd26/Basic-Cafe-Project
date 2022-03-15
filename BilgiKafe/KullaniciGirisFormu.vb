Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class KullaniciGirisFormu
    Private Hak As Integer = 3
    Private Tamam As Boolean = False
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Hak -= 1
        Dim KAdi As String = UsernameTextBox.Text.Trim
        Dim KSifre As String = PasswordTextBox.Text.Trim
        Dim MD5Algoritma As MD5 = MD5.Create
        KSifre = HashAlgotirma(MD5Algoritma, KSifre)
        Dim SqlBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM KullaniciTablosu WHERE KullaniciAdi=@Adi and KullaniciSifresi=@Sifresi"
        Dim KullaniciSqlDA As New SqlDataAdapter(Sorgu, SqlBaglanti)
        'SELECT cümlesinde kullandýðýmýz parametre deðiþkenlerini tanýmla ve deðer ata
        KullaniciSqlDA.SelectCommand.Parameters.Add("@Adi", SqlDbType.NVarChar, 15).Value = KAdi
        KullaniciSqlDA.SelectCommand.Parameters.Add("@Sifresi", SqlDbType.NVarChar, 128).Value = KSifre
        Dim Tablo As New DataTable
        Try
            SqlBaglanti.Open()
            KullaniciSqlDA.Fill(Tablo)
            If Tablo.Rows.Count = 1 And Hak >= 0 Then
                Dim Satir As DataRow = Tablo.Rows(0)
                If Satir("KullaniciAdi") = KAdi And Satir("KullaniciSifresi") = KSifre Then
                    Tamam = True
                    Me.Close()
                Else
                    MessageBox.Show("Kullanýcý Adý ve Þifresi hatalý.", "Hata")
                End If
            ElseIf Hak > 0 Then
                MessageBox.Show("Kullanýcý Adý ve Þifresi hatalý.", "Hata")
            Else
                MessageBox.Show("Kullanýcý Adý ve Þifresi hatalý. Program Kapatýlacak.", "Hata")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata Oluþtu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub SifremiUnuttumLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SifremiUnuttumLbl.LinkClicked
        Dim KAdi As String = UsernameTextBox.Text.Trim
        Dim SqlBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM KullaniciTablosu WHERE KullaniciAdi=@Adi"
        Dim KullaniciSqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        'SELECT cümlesinde kullandýðýmýz parametre deðiþkenlerini tanýmla ve deðer ata
        KullaniciSqlKomut.Parameters.Add("@Adi", SqlDbType.NVarChar, 15).Value = KAdi
        Dim Tablo As New DataTable
        Try
            SqlBaglanti.Open()
            Tablo.Load(KullaniciSqlKomut.ExecuteReader)
            If Tablo.Rows.Count = 1 Then
                Dim Satir As DataRow = Tablo.Rows(0)
                If Satir("KullaniciAdi") = KAdi Then
                    SifremiUnuttumFormu.KNo = Satir("KullaniciNo")
                    SifremiUnuttumFormu.KAdi = Satir("KullaniciAdi")
                    SifremiUnuttumFormu.KSoru = Satir("KullaniciSoru")
                    SifremiUnuttumFormu.KCevap = Satir("KullaniciCevap")
                    SifremiUnuttumFormu.ShowDialog(Me)
                Else
                    MessageBox.Show("Kullanýcý Adý hatalý.", "Hata")
                End If
            Else
                MessageBox.Show("Kullanýcý Adý hatalý.", "Hata")
            End If
        Catch ex As Exception
            MessageBox.Show("Hata Oluþtu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub KullaniciGirisFormu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not Tamam Then
            Application.Exit()
        End If
    End Sub
End Class
