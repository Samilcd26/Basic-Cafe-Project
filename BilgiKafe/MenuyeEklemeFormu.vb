Imports System.Data.SqlClient

Public Class MenuyeEklemeFormu
    Private MenuTablosuSqlDA As SqlDataAdapter
    Public MenuNo As Guid = Nothing
    Private Sub MenuyeEklemeFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerileriGetir()
        If MenuNo <> Nothing Then
            MenuTablosuBS.Filter = String.Format("MenuNo='{0}'", MenuNo.ToString)
        Else
            MenuTablosuBS.Filter = Nothing
        End If
    End Sub
    Private Sub VerileriGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM MenuTablosu ORDER BY UrunAdi"
        MenuTablosuSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Dim KomutOlusturucu As New SqlCommandBuilder(MenuTablosuSqlDA)
        '*************LookUp ComboBox ile Kategori Bilgilerini Tablodan Getirmek İçin Kodlar**********
        Sorgu = "SELECT * FROM KategoriTablosu"
        Dim SQLKomut As New SqlCommand(Sorgu, SQLBaglanti)
        '**************************************************
        Try
            SQLBaglanti.Open()
            MenuTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            MenuTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            MenuTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand
            If BilgiKafeDS.Tables.Contains("MenuTablosu") Then
                BilgiKafeDS.Tables("MenuTablosu").Clear()
            End If
            MenuTablosuSqlDA.Fill(BilgiKafeDS, "MenuTablosu")
            MenuTablosuBS.DataSource = BilgiKafeDS
            MenuTablosuBS.DataMember = "MenuTablosu"
            '*************LookUp ComboBox ile Kategori Bilgilerini Tablodan Getirmek İçin Kodlar**********
            If Not BilgiKafeDS.Tables.Contains("KategoriTablosu") Then
                BilgiKafeDS.Tables.Add("KategoriTablosu")
            End If
            BilgiKafeDS.Tables("KategoriTablosu").Clear()
            BilgiKafeDS.Tables("KategoriTablosu").Load(SQLKomut.ExecuteReader)
            KategoriTablosuBS.DataSource = BilgiKafeDS.Tables("KategoriTablosu")
            '**********************************************************
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        For Each Kontrol As Control In Me.Controls
            Kontrol.DataBindings.Clear()
        Next
        UrunAdiTBox.DataBindings.Add("Text", MenuTablosuBS, "UrunAdi")
        icindekilerTBox.DataBindings.Add("Text", MenuTablosuBS, "icindekiler")
        FiyatTBox.DataBindings.Add("Text", MenuTablosuBS, "Fiyat")
        '*************LookUp ComboBox ile Kategori Bilgilerini Tablodan Getirmek İçin Kodlar**********
        KategoriNoCBox.DataBindings.Add("SelectedValue", MenuTablosuBS, "KategoriNo")
        KategoriNoCBox.DataSource = KategoriTablosuBS
        KategoriNoCBox.DisplayMember = "KategoriAdi"
        KategoriNoCBox.ValueMember = "KategoriNo" 'Kategori ile MenuTablosu arasındaki ilişkili alanın adı yazılacak
        '************************************************************
        GuncellemeTarihDTP.DataBindings.Add("Value", MenuTablosuBS, "GuncellemeTarihi", True)
        ResimPBox.DataBindings.Add("Image", MenuTablosuBS, "Resim", True)
    End Sub

    Private Sub ilkBtn_Click(sender As Object, e As EventArgs) Handles ilkBtn.Click
        MenuTablosuBS.MoveFirst()
    End Sub

    Private Sub OncekiBtn_Click(sender As Object, e As EventArgs) Handles OncekiBtn.Click
        MenuTablosuBS.MovePrevious()
    End Sub

    Private Sub SonrakiBtn_Click(sender As Object, e As EventArgs) Handles SonrakiBtn.Click
        MenuTablosuBS.MoveNext()
    End Sub

    Private Sub SonBtn_Click(sender As Object, e As EventArgs) Handles SonBtn.Click
        MenuTablosuBS.MoveLast()
    End Sub

    Private Sub MenuTablosuBS_CurrentChanged(sender As Object, e As EventArgs) Handles MenuTablosuBS.CurrentChanged
        ilkBtn.Enabled = True
        OncekiBtn.Enabled = True
        SonrakiBtn.Enabled = True
        SonBtn.Enabled = True
        If MenuTablosuBS.Position = 0 Then
            ilkBtn.Enabled = False
            OncekiBtn.Enabled = False
        End If
        If MenuTablosuBS.Position = MenuTablosuBS.Count - 1 Then
            SonrakiBtn.Enabled = False
            SonBtn.Enabled = False
        End If
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        MenuTablosuBS.AddNew()
    End Sub

    Private Sub VazgecBtn_Click(sender As Object, e As EventArgs) Handles VazgecBtn.Click
        'BindingSource üzerindeki mevcut kayıt bilgilerini okumak
        If Not IsNothing(MenuTablosuBS.Current) Then 'If MenuTablosuBS.Count > 0 Then
            Dim Satir As DataRowView = MenuTablosuBS.Current
            Dim MenuAdi As String = Satir("UrunAdi").ToString
            Dim Mesaj As String = MenuAdi & " menüsünde yapmış olduğunuz değişiklikleri iptal etmek istiyormusunuz?"
            If MsgBox(Mesaj, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "İptal Uyarısı") = MsgBoxResult.Yes Then
                MenuTablosuBS.CancelEdit()
            End If
        End If
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        'BindingSource üzerindeki mevcut kayıt bilgilerini okumak
        If Not IsNothing(MenuTablosuBS.Current) Then
            Dim Satir As DataRowView = MenuTablosuBS.Current
            Dim MenuAdi As String = Satir("UrunAdi").ToString
            Dim Mesaj As String = MenuAdi & " menüsünü silmek istediğinize emin misiniz?"
            If MsgBox(Mesaj, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Silme Uyarısı") = MsgBoxResult.Yes Then
                MenuTablosuBS.RemoveCurrent()

            End If
        End If
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Try
            Me.Validate()
            MenuTablosuBS.EndEdit()
            Dim Sayi As Integer = MenuTablosuSqlDA.Update(BilgiKafeDS, "MenuTablosu")
            If Sayi > 0 Then
                MessageBox.Show("Yapılan tüm işlemler başarı ile kaydedildi.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResimEkleBtn_Click(sender As Object, e As EventArgs) Handles ResimEkleBtn.Click
        ResimSecOFD.Filter = "JPEG Resimler|*.jpg;*.jpeg|PNG Resimler|*.png|Tüm Resim Dosyaları|*.jpeg;*.jpg;*.png"
        ResimSecOFD.FilterIndex = 3
        ResimSecOFD.FileName = Nothing
        If ResimSecOFD.ShowDialog = DialogResult.OK Then
            Dim Resim As Image = Image.FromFile(ResimSecOFD.FileName)
            Dim Boyut As Size = Resim.Size
            Dim Oran As Decimal = 1
            If Boyut.Width > Boyut.Height Then
                Oran = 200 / Boyut.Width
            Else
                Oran = 200 / Boyut.Height
            End If

            Dim GeriDonus As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            Dim YeniResim As Image = Resim.GetThumbnailImage(Boyut.Width * Oran, Boyut.Height * Oran, GeriDonus, IntPtr.Zero)
            ResimPBox.Image = YeniResim
        End If
    End Sub

    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function
End Class
