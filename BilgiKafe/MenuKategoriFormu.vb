Imports System.Data.SqlClient

Public Class MenuKategoriFormu
    Private KategoriTblSqlDA As SqlDataAdapter
    Private Sub MenuKategoriFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        'SQL Cümlemizi Yaz
        Dim SQLCumle As String = "SELECT * FROM KategoriTablosu Order By KategoriAdi"
        'SQLDataAdapter Oluştur Bu Nesne SELECT,DELETE,INSERT ve UPDATE Komutlarını VT Üzerinde Çalıştırır
        KategoriTblSqlDA = New SqlDataAdapter(SQLCumle, SQLBaglanti)
        'DELETE,INSERT ve UPDATE Komutlarını Oluştur
        Dim SqlKomutOlusturcu As New SqlCommandBuilder(KategoriTblSqlDA)
        'Tablo Kayıtlarını Tutacak DataTable Nesnesini Oluşturalım

        Try
            SQLBaglanti.Open()
            KategoriTblSqlDA.DeleteCommand = SqlKomutOlusturcu.GetDeleteCommand
            KategoriTblSqlDA.InsertCommand = SqlKomutOlusturcu.GetInsertCommand
            KategoriTblSqlDA.UpdateCommand = SqlKomutOlusturcu.GetUpdateCommand
            KategoriTblSqlDA.Fill(BilgiKafeDS, "KategoriTablosu")
            KategoriTablosuBS.DataSource = BilgiKafeDS.Tables("KategoriTablosu")
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try

    End Sub

    Private Sub NesneleriBagla()
        KategorilerDGV.DataSource = KategoriTablosuBS
        KategoriAdiTBox.DataBindings.Add("Text", KategoriTablosuBS, "KategoriAdi")
        KategoriResmiPBox.DataBindings.Add("Image", KategoriTablosuBS, "KategoriResmi", True)
    End Sub

    Private Sub VazgecBtn_Click(sender As Object, e As EventArgs) Handles VazgecBtn.Click
        If Not IsNothing(KategoriTablosuBS.Current) Then
            Dim Mesaj As String
            Dim Satir As DataRowView = KategoriTablosuBS.Current
            Dim KategoriAdi As String = Satir("KategoriAdi")
            Mesaj = KategoriAdi & " kategorisinde yaptığınız değişiklikleri iptal etmek istediğinize emin misiniz?"
            If MessageBox.Show(Mesaj, "İptal Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                KategoriTablosuBS.CancelEdit()
            End If
        End If
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If Not IsNothing(KategoriTablosuBS.Current) Then
            Dim Mesaj As String
            Dim Satir As DataRowView = KategoriTablosuBS.Current
            Dim KategoriAdi As String = Satir("KategoriAdi")
            Mesaj = KategoriAdi & " kategorisini silmek istediğinize emin misiniz?"
            If MessageBox.Show(Mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                KategoriTablosuBS.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub MenuKategoriFormu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub ResimEkleBtn_Click(sender As Object, e As EventArgs) Handles ResimEkleBtn.Click
        ResimSecOFD.FileName = Nothing
        ResimSecOFD.Filter = "PNG Dosyası|*.png|JPEG Dosyası|*.jpg;*.jpeg|Tüm Resim Dosyları|*.png;*.jpg;*.jpeg"
        ResimSecOFD.FilterIndex = 3
        ResimSecOFD.Multiselect = False
        If ResimSecOFD.ShowDialog = DialogResult.OK Then
            Dim Resim As Image = Image.FromFile(ResimSecOFD.FileName)
            If Resim.Width <= 64 And Resim.Height <= 64 Then
                KategoriResmiPBox.Image = Resim
            Else
                MessageBox.Show("Seçilen resim istenilen boyuttan büyük. Resimin genişlik ve yükseklik değeri 64 piksel veya küçük olmalı.", "Boyut Uyumsuz")
            End If
        End If
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        KategoriTablosuBS.AddNew()
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Me.Validate()
        KategoriTablosuBS.EndEdit()
        KategoriTblSqlDA.Update(BilgiKafeDS, "KategoriTablosu")
        MessageBox.Show("Değişiklikler Kaydedildi.", "Kayıt İşlemi")
    End Sub
End Class
