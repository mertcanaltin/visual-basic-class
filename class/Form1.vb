Public Class Form1
    Private Sub HesaplaButton1_Click(sender As Object, e As EventArgs) Handles HesaplaButton1.Click
        'Class'taki fonksiyonu kullanmadan önce o class'ı yeni bir değişken olarak tanımlamalıyız
        Dim SayiUstAlma As New ustalma
        Dim sayimiz, ustdegeri As Decimal
        sayimiz = SayiTextBox1.Text
        ustdegeri = UstTextBox2.Text
        Dim sonuc As Decimal
        sonuc = SayiUstAlma.Kuvvet(sayimiz, ustdegeri)
        SonucTextBox3.Text = sonuc
    End Sub
End Class
