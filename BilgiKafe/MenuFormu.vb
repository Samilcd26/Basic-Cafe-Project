
Imports System.Data.SqlClient

Public Class MenuFormu
    Private MenuTablosuSqlDA As SqlDataAdapter
    Private Sub MenuFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerileriGetir()
    End Sub
    Private Sub VerileriGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM MenuTablosu ORDER BY UrunAdi"
        MenuTablosuSqlDA = New SqlDataAdapter(Sorgu, SQLBaglanti)
        '*************LookUp ComboBox ile Kategori Bilgilerini Tablodan Getirmek İçin Kodlar**********
        Sorgu = "SELECT * FROM KategoriTablosu"
        Dim SQLKomut As New SqlCommand(Sorgu, SQLBaglanti)
        '**************************************************
        Try
            SQLBaglanti.Open()
            If BilgiKafeDS.Tables.Contains("MenuTablosu") Then
                BilgiKafeDS.Tables("MenuTablosu").Clear()
            End If
            MenuTablosuSqlDA.Fill(BilgiKafeDS, "MenuTablosu")
            MenuTablosuBS.DataSource = BilgiKafeDS
            MenuTablosuBS.DataMember = "MenuTablosu"
            MenuTablosuBS.MoveLast()
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
        KategoriNoC.DataSource = KategoriTablosuBS
        KategoriNoC.DisplayMember = "KategoriAdi"
        KategoriNoC.ValueMember = "KategoriNo"
        MenuDGV.DataSource = MenuTablosuBS
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        MenuyeEklemeFormu.MenuNo = Guid.NewGuid
        MenuyeEklemeFormu.SilBtn.Visible = False
        MenuyeEklemeFormu.VazgecBtn.Visible = False
        MenuyeEklemeFormu.ShowDialog(Me)
        MenuyeEklemeFormu.Dispose()
    End Sub

    Private Sub DuzenleBtn_Click(sender As Object, e As EventArgs) Handles DuzenleBtn.Click
        If Not IsNothing(MenuTablosuBS.Current) Then
            Dim Satir As DataRowView = MenuTablosuBS.Current
            MenuyeEklemeFormu.MenuNo = Satir("MenuNo")
            MenuyeEklemeFormu.EkleBtn.Visible = False
            MenuyeEklemeFormu.ShowDialog(Me)
            MenuyeEklemeFormu.Dispose()
        End If
    End Sub

    Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
        Dim Aranan As String = MenuAraTBox.Text.Trim
        'Dim Yer As Integer = MenuTablosuBS.Find("UrunAdi", Aranan)
        'If Yer > -1 Then
        'MenuTablosuBS.Position = Yer
        'Else
        'MessageBox.Show("Aradığınız Ürün Menüde Bulunamadı.", "Arama")
        'End If
        Dim Filtre As String = String.Format("UrunAdi Like '%{0}%'", Aranan)
        MenuTablosuBS.Filter = Filtre
    End Sub
End Class