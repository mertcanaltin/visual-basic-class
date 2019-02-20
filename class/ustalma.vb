Public Class ustalma
    Public Function Kuvvet(ByVal Sayi As Decimal, ByVal ust As Decimal) As Decimal
        Dim Sonuc As Decimal
        Sonuc = Sayi ^ ust
        Return Sonuc
    End Function
End Class
