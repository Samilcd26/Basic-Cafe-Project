Imports System.Data.SqlClient

Public Class MenuSecimFormu
    Private Sub MenuSecimiFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerileriGetir()
    End Sub
    Private Sub VerileriGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim Sorgu As String = "SELECT * FROM MenuTablosu ORDER BY UrunAdi"
        Dim MenuTablosuSqlDA As New SqlDataAdapter(Sorgu, SQLBaglanti)
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
            If Not BilgiKafeDS.Tables("MenuTablosu").Columns.Contains("Adet") Then
                Dim AdetColumn As New DataColumn()
                AdetColumn.ColumnName = "Adet"
                AdetColumn.DataType = GetType(Double)
                AdetColumn.Expression = ""
                BilgiKafeDS.Tables("MenuTablosu").Columns.Add(AdetColumn)
            End If
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
    Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
        Dim Aranan As String = MenuAraTBox.Text.Trim
        Dim Filtre As String = String.Format("UrunAdi Like '%{0}%'", Aranan)
        MenuTablosuBS.Filter = Filtre
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class