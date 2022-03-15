Imports System.Data.SqlClient

Public Class MasaEklemeFormu
    Private MasaTablosuSqlDA As New SqlDataAdapter
    Private Sub MasaEklemeFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerileriGetir()
    End Sub
    Private Sub VerileriGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        Dim SQLCumle As String = "SELECT * FROM MasaTablosu Order By MasaMekanNo,MasaNo"
        MasaTablosuSqlDA = New SqlDataAdapter(SQLCumle, SQLBaglanti)
        Dim SqlKomutOlusturcu As New SqlCommandBuilder(MasaTablosuSqlDA)

        Dim MekanSorgu As String = "SELECT * FROM MasaMekanTablosu"
        Dim MasaMekanTablosuSqlDA As New SqlDataAdapter(MekanSorgu, SQLBaglanti)
        Try
            SQLBaglanti.Open()
            MasaTablosuSqlDA.DeleteCommand = SqlKomutOlusturcu.GetDeleteCommand
            MasaTablosuSqlDA.InsertCommand = SqlKomutOlusturcu.GetInsertCommand
            MasaTablosuSqlDA.UpdateCommand = SqlKomutOlusturcu.GetUpdateCommand
            MasaTablosuSqlDA.Fill(BilgiKafeDS, "MasaTablosu")
            MasaTablosuBS.DataSource = BilgiKafeDS.Tables("MasaTablosu")
            MasaMekanTablosuSqlDA.Fill(BilgiKafeDS, "MasaMekanTablosu")
            MasaMekanTablosuBS.DataSource = BilgiKafeDS.Tables("MasaMekanTablosu")
            NesneleriBagla()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close()
        End Try
    End Sub
    Private Sub NesneleriBagla()
        MasaNoTBox.DataBindings.Add("Text", MasaTablosuBS, "MasaNo")
        MasaMekanNoLBox.DataBindings.Add("SelectedValue", MasaTablosuBS, "MasaMekanNo")

        MasaMekanNoLBox.DataSource = MasaMekanTablosuBS
        MasaMekanNoLBox.DisplayMember = "MasaMekanAdi"
        MasaMekanNoLBox.ValueMember = "MasaMekanNo"

        'MasaMekanNoC MasaTablosu ile olan bağlantısı dizayn ekranında DataPropertyName alanı ile yapıldı
        MasaMekanNoC.DataSource = MasaMekanTablosuBS
        MasaMekanNoC.DisplayMember = "MasaMekanAdi"
        MasaMekanNoC.ValueMember = "MasaMekanNo"

        MasalarDGV.DataSource = MasaTablosuBS
    End Sub
    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        MasaTablosuBS.AddNew()
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Try
            Me.Validate()
            MasaTablosuBS.EndEdit()
            MasaTablosuSqlDA.Update(BilgiKafeDS, "MasaTablosu")
            MessageBox.Show("Değişiklikler Kaydedildi.", "Kayıt İşlemi")
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
    Private Sub VazgecBtn_Click(sender As Object, e As EventArgs) Handles VazgecBtn.Click
        If Not IsNothing(MasaTablosuBS.Current) Then
            Dim Mesaj As String
            Dim Satir As DataRowView = MasaTablosuBS.Current
            Dim MasaNo As String = Satir("MasaNo")
            Mesaj = MasaNo & " nolu masada yaptığınız değişiklikleri iptal etmek istediğinize emin misiniz?"
            If MessageBox.Show(Mesaj, "İptal Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                MasaTablosuBS.CancelEdit()
            End If
        End If
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If Not IsNothing(MasaTablosuBS.Current) Then
            Dim Mesaj As String
            Dim Satir As DataRowView = MasaTablosuBS.Current
            Dim MasaNo As String = Satir("MasaNo")
            Mesaj = MasaNo & " nolu masayı silmek istediğinize emin misiniz?"
            If MessageBox.Show(Mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                MasaTablosuBS.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub MasaEklemeFormu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class
