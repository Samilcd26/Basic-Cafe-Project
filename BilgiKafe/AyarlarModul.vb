Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Module AyarlarModul
    Public Function BaglantiCumlesi() As String
        Dim Cumle As String
        Dim CumleOlusturucu As New SqlConnectionStringBuilder
        CumleOlusturucu.DataSource = "."  '. yerine
        CumleOlusturucu.InitialCatalog = "BilgiKafeVT" '***
        CumleOlusturucu.PersistSecurityInfo = True
        CumleOlusturucu.IntegratedSecurity = True
        CumleOlusturucu.UserID = "sa"
        CumleOlusturucu.Password = "mmyo"
        Cumle = CumleOlusturucu.ConnectionString
        Return Cumle
    End Function
    Public Function HashAlgotirma(Algoritma As HashAlgorithm, Metin As String) As String
        Dim Sonuc As String = Nothing
        Dim ByteDizisi() As Byte = Encoding.UTF8.GetBytes(Metin)
        Dim HashByte() As Byte = Algoritma.ComputeHash(ByteDizisi)
        For Each Karakter As Byte In HashByte
            Sonuc &= Karakter.ToString("x2")
        Next
        Return Sonuc
    End Function
End Module


