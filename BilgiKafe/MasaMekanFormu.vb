Imports System.Data.SqlClient

Public Class MasaMekanFormu
    Private MasaMekanTablosuSqlDA As SqlDataAdapter
    Private Sub MasaMekanFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerileriGetir
    End Sub
    Private Sub VerileriGetir()
        Dim SQLBaglanti As New SqlConnection(BaglantiCumlesi)
        'SQL Cümlemizi Yaz
        Dim SQLCumle As String = "SELECT * FROM MasaMekanTablosu Order By MasaMekanAdi"
        'SQLDataAdapter Oluştur Bu Nesne SELECT,DELETE,INSERT ve UPDATE Komutlarını VT Üzerinde Çalıştırır
        MasaMekanTablosuSqlDA = New SqlDataAdapter(SQLCumle, SQLBaglanti)
        'DELETE,INSERT ve UPDATE Komutlarını Oluştur
        Dim SqlKomutOlusturcu As New SqlCommandBuilder(MasaMekanTablosuSqlDA)
        'Tablo Kayıtlarını Tutacak DataTable Nesnesini Oluşturalım

        Try
            SQLBaglanti.Open()
            MasaMekanTablosuSqlDA.DeleteCommand = SqlKomutOlusturcu.GetDeleteCommand
            MasaMekanTablosuSqlDA.InsertCommand = SqlKomutOlusturcu.GetInsertCommand
            MasaMekanTablosuSqlDA.UpdateCommand = SqlKomutOlusturcu.GetUpdateCommand
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
        MekanlarDGV.DataSource = MasaMekanTablosuBS
        MasaMekanAdiTBox.DataBindings.Add("Text", MasaMekanTablosuBS, "MasaMekanAdi")
    End Sub
    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        MasaMekanTablosuBS.AddNew()
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Try
            Me.Validate()
            MasaMekanTablosuBS.EndEdit()
            MasaMekanTablosuSqlDA.Update(BilgiKafeDS, "MasaMekanTablosu")
            MessageBox.Show("Değişiklikler Kaydedildi.", "Kayıt İşlemi")
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu. Hata: " & ex.Message, "Hata")
        End Try
    End Sub
    Private Sub VazgecBtn_Click(sender As Object, e As EventArgs) Handles VazgecBtn.Click
        If Not IsNothing(MasaMekanTablosuBS.Current) Then
            Dim Mesaj As String
            Dim Satir As DataRowView = MasaMekanTablosuBS.Current
            Dim MasaMekanAdi As String = Satir("MasaMekanAdi")
            Mesaj = MasaMekanAdi & " mekanında yaptığınız değişiklikleri iptal etmek istediğinize emin misiniz?"
            If MessageBox.Show(Mesaj, "İptal Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                MasaMekanTablosuBS.CancelEdit()
            End If
        End If
    End Sub

    Private Sub SilBtn_Click(sender As Object, e As EventArgs) Handles SilBtn.Click
        If Not IsNothing(MasaMekanTablosuBS.Current) Then
            Dim Mesaj As String
            Dim Satir As DataRowView = MasaMekanTablosuBS.Current
            Dim MasaMekanAdi As String = Satir("MasaMekanAdi")
            Mesaj = MasaMekanAdi & " mekanını silmek istediğinize emin misiniz?"
            If MessageBox.Show(Mesaj, "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                MasaMekanTablosuBS.RemoveCurrent()
            End If
        End If
    End Sub
End Class
