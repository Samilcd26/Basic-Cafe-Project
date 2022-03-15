Imports System.Data.SqlClient
Public Class MasalarFormu
    Private AdisyonTablosuSqlDA As SqlDataAdapter
    Private AdisyonDetayTablosuSqlDA As SqlDataAdapter
    Private MasaTablosuSqlDA As SqlDataAdapter
    Private Sub MasalarFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MasaMekanGetir()
        MasaGetir()
        AdisyonGetir()
        AdisyonDetayGetir()
        PersonelGetir()
        MenuGetir()
        NesneleriBagla()
        AdisyonFiltrele(0, False)
    End Sub
    Private Sub MasaMekanGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT * FROM MasaMekanTablosu Order By MasaMekanAdi"
        Dim MasaMekanTablosuSqlDA As New SqlDataAdapter(SQLCumle, SQLBaglanti)
        Try
            SQLBaglanti.Open()
            MasaMekanTablosuSqlDA.Fill(BilgiKafeDS, "MasaMekanTablosu")
            MasaMekanTablosuBS.DataSource = BilgiKafeDS.Tables("MasaMekanTablosu")
            Mekanlar()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub MasaGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT * FROM MasaTablosu Order By MasaMekanNo,MasaNo"
        MasaTablosuSqlDA = New SqlDataAdapter(SQLCumle, SQLBaglanti)

        Dim KomutOlusturucu As New SqlCommandBuilder(MasaTablosuSqlDA)
        Try
            SQLBaglanti.Open()
            MasaTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            MasaTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            MasaTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand

            MasaTablosuSqlDA.Fill(BilgiKafeDS, "MasaTablosu")
            MasaTablosuBS.DataSource = BilgiKafeDS.Tables("MasaTablosu")
            Masalar()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub Masalar()
        For Each Tab As TabPage In MekanlarTabControl.TabPages
            Dim Liste As ListView = Tab.Controls.Cast(Of Control)().FirstOrDefault(Function(x) TypeOf x Is ListView)
            Liste.Items.Clear()
        Next
        For Each MasaSatir As DataRow In BilgiKafeDS.Tables("MasaTablosu").Rows
            Dim MekanNo As Integer = MekanlarTabControl.TabPages.IndexOfKey(MasaSatir("MasaMekanNo"))
            Dim Tab As TabPage = MekanlarTabControl.TabPages(MekanNo)
            Dim Liste As ListView = Tab.Controls.Cast(Of Control)().FirstOrDefault(Function(x) TypeOf x Is ListView)
            Dim Masa As New ListViewItem
            Masa.Text = MasaSatir("MasaNo")
            Masa.ImageIndex = MasaSatir("Durum")
            Select Case Masa.ImageIndex
                Case 0
                    Masa.ToolTipText = "Masa Boş"
                Case 1
                    Masa.ToolTipText = "Masa Dolu"
                Case 2
                    Masa.ToolTipText = "Masa Rezerve"
                Case Else
                    Masa.ToolTipText = ""
            End Select
            Masa.Tag = MasaSatir("MasaKayitNo")
            Liste.Items.Add(Masa)
        Next
    End Sub
    Private Sub Mekanlar()
        MekanlarTabControl.TabPages.Clear()
        For Each MekanSatir As DataRow In BilgiKafeDS.Tables("MasaMekanTablosu").Rows
            Dim YeniTab As New TabPage
            YeniTab.Name = MekanSatir("MasaMekanNo")
            YeniTab.Text = MekanSatir("MasaMekanAdi")
            Dim YeniListe As New ListView
            YeniListe.Name = MekanSatir("MasaMekanNo")
            YeniListe.Dock = DockStyle.Fill
            YeniListe.Padding = New Padding(10)
            YeniListe.View = View.LargeIcon
            YeniListe.LargeImageList = MasaImageList
            YeniListe.ShowItemToolTips = True
            YeniListe.MultiSelect = False
            AddHandler YeniListe.ItemSelectionChanged, AddressOf MasaListView_ItemSelectionChanged
            YeniTab.Controls.Add(YeniListe)
            MekanlarTabControl.TabPages.Add(YeniTab)
        Next
    End Sub

    Private Sub MekanlarTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MekanlarTabControl.SelectedIndexChanged
        If MekanlarTabControl.SelectedIndex > -1 Then
            'MessageBox.Show(MekanlarTabControl.SelectedTab.Name)
        End If
    End Sub

    Private Sub MasaListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        Dim Liste As ListView = sender
        Dim MasaKayitNo As Integer = 0
        If e.IsSelected Then
            MasaKayitNo = e.Item.Tag
            Dim MasaNo As Short = e.Item.Text
            Dim Mekan As String = MekanlarTabControl.SelectedTab.Text
            Dim MekanNo As Integer = MekanlarTabControl.SelectedTab.Tag
            MekanLbl.Text = Mekan
            MasaNoLbl.Text = MasaNo
        Else
            MekanLbl.Text = "Yok"
            MasaNoLbl.Text = 0
        End If
        AdisyonFiltrele(MasaKayitNo, False)
        'If e.IsSelected Then
        'MessageBox.Show(e.Item.Tag)
        'End If
    End Sub
    Private Sub AdisyonGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT * FROM AdisyonTablosu"
        AdisyonTablosuSqlDA = New SqlDataAdapter(SQLCumle, SQLBaglanti)
        Dim KomutOlusturucu As New SqlCommandBuilder(AdisyonTablosuSqlDA)
        Try
            SQLBaglanti.Open()

            AdisyonTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            AdisyonTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            AdisyonTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand
            If BilgiKafeDS.Tables.Contains("AdisyonTablosu") Then
                BilgiKafeDS.Tables("AdisyonTablosu").Clear()
            End If
            AdisyonTablosuSqlDA.Fill(BilgiKafeDS, "AdisyonTablosu")
            AdisyonTablosuBS.DataSource = BilgiKafeDS.Tables("AdisyonTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub PersonelGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT *,Adi+' '+Soyadi AS AdSoyad FROM PersonelTablosu ORDER BY Adi,Soyadi"
        Dim PersonelTablosuSqlDA As New SqlDataAdapter(SQLCumle, SQLBaglanti)
        Dim KomutOlusturucu As New SqlCommandBuilder(PersonelTablosuSqlDA)
        Try
            SQLBaglanti.Open()

            PersonelTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            PersonelTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            PersonelTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand

            PersonelTablosuSqlDA.Fill(BilgiKafeDS, "PersonelTablosu")
            PersonelTablosuBS.DataSource = BilgiKafeDS.Tables("PersonelTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub MenuGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT * FROM MenuTablosu"
        Dim MenuTablosuSqlDA As New SqlDataAdapter(SQLCumle, SQLBaglanti)
        Dim KomutOlusturucu As New SqlCommandBuilder(MenuTablosuSqlDA)
        Try
            SQLBaglanti.Open()

            MenuTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            MenuTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            MenuTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand

            MenuTablosuSqlDA.Fill(BilgiKafeDS, "MenuTablosu")
            MenuTablosuBS.DataSource = BilgiKafeDS.Tables("MenuTablosu")
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub AdisyonDetayGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT * FROM AdisyonDetayTablosu"
        AdisyonDetayTablosuSqlDA = New SqlDataAdapter(SQLCumle, SQLBaglanti)
        Dim KomutOlusturucu As New SqlCommandBuilder(AdisyonDetayTablosuSqlDA)
        Try
            SQLBaglanti.Open()
            AdisyonDetayTablosuSqlDA.InsertCommand = KomutOlusturucu.GetInsertCommand
            AdisyonDetayTablosuSqlDA.UpdateCommand = KomutOlusturucu.GetUpdateCommand
            AdisyonDetayTablosuSqlDA.DeleteCommand = KomutOlusturucu.GetDeleteCommand
            If BilgiKafeDS.Tables.Contains("AdisyonDetayTablosu") Then
                BilgiKafeDS.Tables("AdisyonDetayTablosu").Clear()
            End If
            AdisyonDetayTablosuSqlDA.Fill(BilgiKafeDS, "AdisyonDetayTablosu")
            'Hesaplanan Alan Ekle
            If Not BilgiKafeDS.Tables("AdisyonDetayTablosu").Columns.Contains("Toplam") Then
                Dim Toplam As New DataColumn()
                Toplam.ColumnName = "Toplam"
                Toplam.DataType = GetType(Double)
                Toplam.Expression = "Adet * Fiyat"
                BilgiKafeDS.Tables("AdisyonDetayTablosu").Columns.Add(Toplam)
            End If
            '*****************
            'İlişki ekleme
            If Not BilgiKafeDS.Relations.Contains("AdisyonAdisyonDetay") Then
                Dim AdisyonAdisyonDetayRelation As New DataRelation("AdisyonAdisyonDetay",
                    BilgiKafeDS.Tables("AdisyonTablosu").Columns("AdisyonNo"),
                   BilgiKafeDS.Tables("AdisyonDetayTablosu").Columns("AdisyonNo"), False)
                AdisyonAdisyonDetayRelation.Nested = True

                BilgiKafeDS.Relations.Add(AdisyonAdisyonDetayRelation)
            End If
            '**********
            'AdisyonDetayTablosuBS.DataSource = BilgiKafeDS.Tables("AdisyonDetayTablosu")
            AdisyonDetayTablosuBS.DataSource = AdisyonTablosuBS 'Üst Tablonun BS ü ile bağla
            AdisyonDetayTablosuBS.DataMember = "AdisyonAdisyonDetay" 'İlişkşinin adını ver
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        For Each Kontrol As Control In SplitContainer1.Panel1.Controls
            Kontrol.DataBindings.Clear()
        Next
        TarihSaatTBox.DataBindings.Add("Text", AdisyonTablosuBS, "TarihSaat", True)

        PersonelNoCBox.DataBindings.Add("SelectedValue", AdisyonTablosuBS, "PersonelNo")
        PersonelNoCBox.DataSource = PersonelTablosuBS
        PersonelNoCBox.DisplayMember = "AdSoyad"
        PersonelNoCBox.ValueMember = "PersonelNo"

        MenuNoC.DataSource = MenuTablosuBS
        MenuNoC.DisplayMember = "UrunAdi"
        MenuNoC.ValueMember = "MenuNo"

        AciklamaTBox.DataBindings.Add("Text", AdisyonTablosuBS, "Aciklama")
        AdisyonDetayDGV.DataSource = AdisyonDetayTablosuBS
    End Sub
    Private Sub AdisyonFiltrele(MasaKayitNo As Integer, Kapat As Boolean)
        AdisyonTablosuBS.Filter = Nothing
        AdisyonTablosuBS.Filter = String.Format("MasaKayitNo={0} AND Kapat={1}", MasaKayitNo, Kapat)
        If MasaKayitNo > 0 And AdisyonTablosuBS.Count = 0 Then
            Dim Mesaj As String = String.Format("{0} mekanında {1} nolu masa için açılmış bir adisyon yok açmak istrmisiniz?", MekanLbl.Text, MasaNoLbl.Text)
            If MessageBox.Show(Mesaj, "Adisyon", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Dim Durum As Integer = 1
                MasaDurumu(MasaKayitNo, Durum)
                AdisyonAc(MasaKayitNo)
            End If
        Else

        End If
    End Sub
    Private Sub MasaDurumu(MasaKayitNo As Integer, Durum As Integer)
        Dim SiraNo As Integer = MasaTablosuBS.Find("MasaKayitNo", MasaKayitNo)
        If SiraNo > -1 Then
            Dim Satir As DataRowView = MasaTablosuBS.Item(SiraNo)
            Satir.BeginEdit()
            Satir("Durum") = Durum
            Satir.EndEdit()
            MasaTablosuBS.EndEdit()
            MasaTablosuSqlDA.Update(BilgiKafeDS, "MasaTablosu")
            Masalar()
        End If
    End Sub
    Private Sub AdisyonAc(MasaKayitNo)
        Dim Satir As DataRow = BilgiKafeDS.Tables("AdisyonTablosu").NewRow
        Satir("MasaKayitNo") = MasaKayitNo
        Satir("TarihSaat") = Now '.ToString("MM/dd/yyyy H:m")
        Satir("PersonelNo") = 1
        Satir("Kapat") = False
        BilgiKafeDS.Tables("AdisyonTablosu").Rows.Add(Satir)
        AdisyonTablosuSqlDA.Update(BilgiKafeDS, "AdisyonTablosu")
        AdisyonGetir()
        Me.Update()
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        If AdisyonTablosuBS.Count = 1 Then
            Dim AdisyonNo As Integer = AdisyonTablosuBS.Item(0)("AdisyonNo")
            If MenuSecimFormu.ShowDialog(Me) = DialogResult.OK Then
                For Each Satir As DataRow In MenuSecimFormu.BilgiKafeDS.Tables("MenuTablosu").Rows
                    If IsNumeric(Satir("Adet")) AndAlso Satir("Adet") > 0 Then
                        Dim Menuno As Guid = Satir("MenuNo")
                        Dim Adet As Integer = Satir("Adet")
                        Dim Fiyat As Decimal = Satir("Fiyat")
                        Dim Bulundu As Boolean = False
                        'Birinci Yöntem DataGridView Üzerinde Dönerek
                        'For Each DetaySatir As DataGridViewRow In AdisyonDetayDGV.Rows
                        'If DetaySatir.Cells("MenuNoC").Value = Menuno Then
                        'DetaySatir.Cells("AdetC").Value += Adet
                        'Bulundu = True
                        'AdisyonDetayTablosuSqlDA.Update(BilgiKafeDS, "AdisyonDetayTablosu")
                        'End If
                        'Next
                        'İkinci Yöntem BindingSource Üzerinde Dönerek
                        For Each DetaySatir As DataRowView In AdisyonDetayTablosuBS.List
                            If DetaySatir("MenuNo") = Menuno Then
                                DetaySatir.BeginEdit()
                                DetaySatir("Adet") += Adet
                                DetaySatir.EndEdit()
                                Bulundu = True
                                AdisyonDetayTablosuSqlDA.Update(BilgiKafeDS, "AdisyonDetayTablosu")
                            End If
                        Next
                        If Not Bulundu Then
                            AdisyonDetayEkle(AdisyonNo, Menuno, Adet, Fiyat)
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub AdisyonDetayEkle(AdisyonNo As Integer, MenuNo As Guid, Adet As Integer, Fiyat As Decimal)
        Dim Satir As DataRow = BilgiKafeDS.Tables("AdisyonDetayTablosu").NewRow
        Satir("AdisyonNo") = AdisyonNo
        Satir("MenuNo") = MenuNo
        Satir("Adet") = Adet
        Satir("Fiyat") = Fiyat
        BilgiKafeDS.Tables("AdisyonDetayTablosu").Rows.Add(Satir)
        AdisyonDetayTablosuSqlDA.Update(BilgiKafeDS, "AdisyonDetayTablosu")
        AdisyonDetayGetir()
    End Sub

    Private Sub AdisyonDetayDGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles AdisyonDetayDGV.CellEndEdit
        Dim Satir As DataGridViewRow = AdisyonDetayDGV.Rows(e.RowIndex)
        If IsNumeric(Satir.Cells("AdetC").Value) AndAlso Satir.Cells("AdetC").Value > 0 Then
            AdisyonDetayTablosuBS.EndEdit()
            AdisyonDetayTablosuSqlDA.Update(BilgiKafeDS, "AdisyonDetayTablosu")
            AdisyonDetayGetir()
        Else
            AdisyonDetayTablosuBS.CancelEdit()
        End If
    End Sub

    Private Sub FisYazdirBtn_Click(sender As Object, e As EventArgs) Handles FisYazdirBtn.Click
        If AdisyonTablosuBS.Count = 1 Then
            Dim AdisyonNo As Integer = AdisyonTablosuBS.Item(0)("AdisyonNo")
            AdisyonRaporFormu.AdisyonNo = AdisyonNo
            AdisyonRaporFormu.ShowDialog(Me)
            AdisyonRaporFormu.Dispose()
        End If
    End Sub

    Private Sub AdisyonDetayTablosuBS_CurrentChanged(sender As Object, e As EventArgs) Handles AdisyonDetayTablosuBS.CurrentChanged
        Try
            Dim Toplam As Decimal = 0
            For Each Satir As DataRowView In AdisyonDetayTablosuBS.List
                Toplam += Satir("Toplam")
            Next
            ToplamTBox.Text = Toplam
        Catch ex As Exception

        End Try
    End Sub
End Class