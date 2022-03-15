Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class SifremiUnuttumFormu
    Public KAdi, KSoru, KCevap As String
    Public KNo As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim MD5Algoritma As MD5 = MD5.Create
        Dim Cevap As String = HashAlgotirma(MD5Algoritma, CevapTBox.Text.Trim)
        Dim YeniSifre As String = YeniSifreTBox.Text.Trim
        Dim SifreTekrar As String = SifreTekrariTBox.Text.Trim
        If KCevap = Cevap Then
            If YeniSifre.Length > 3 Then
                If YeniSifre = SifreTekrar Then
                    SifreYenile(KNo, HashAlgotirma(MD5Algoritma, YeniSifre))
                Else
                    MessageBox.Show("Şifre takrarı hatalı.", "Hata")
                End If
            Else
                MessageBox.Show("Yeni Şifreniz en az 4 karakter olmalıdır.", "Hata")
            End If
        Else
                MessageBox.Show("Cevabınız hatalı.", "Hata")
        End If
    End Sub
    Private Sub SifreYenile(KullaniciNo As Integer, Sifre As String)
        Dim SqlBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim Sorgu As String = "UPDATE KullaniciTablosu SET KullaniciSifresi=@Sifre WHERE KullaniciNo=@No"
        Dim KullaniciSqlKomut As New SqlCommand(Sorgu, SqlBaglanti)
        'SELECT cümlesinde kullandığımız parametre değişkenlerini tanımla ve değer ata
        KullaniciSqlKomut.Parameters.Add("@No", SqlDbType.Int).Value = KullaniciNo
        KullaniciSqlKomut.Parameters.Add("@Sifre", SqlDbType.NVarChar, 128).Value = Sifre
        Try
            SqlBaglanti.Open()
            If KullaniciSqlKomut.ExecuteNonQuery() Then
                MessageBox.Show("Şifreniz başarı ile değiştirilmiştir.", "Şifre Değişimi")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SqlBaglanti.Close()
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.Close()
    End Sub

    Private Sub SifremiUnuttumFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoruTBox.Text = KSoru
    End Sub
End Class
