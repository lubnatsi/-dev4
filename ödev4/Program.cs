/*
  1.soru
  public double HesaplaUcgenAlani(double taban, double yukseklik)
{
    return (taban * yukseklik) / 2;
}
*/

/*
 2soru 
public int EnBuyukDegeriBul(int[] dizi)
{
    int enBuyuk = dizi[0];
    foreach (int deger in dizi)
    {
        if (deger > enBuyuk)
        {
            enBuyuk = deger;
        }
    }
    return enBuyuk;
}
*/

/*
 soru 3 
public int CalculateSum(int a, int b)
{
    return a + b;
}

public double CalculateSum(double a, double b)
{
    return a + b;
}

public int CalculateSum(int a, int b, int c)
{
    return a + b + c;
}
*/

/*
 soru4
public int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
*/

/*
 soru5 Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama
public double OrtalamaHesapla(params double[] sayilar)
{
    double toplam = 0;
    foreach (double sayi in sayilar)
    {
        toplam += sayi;
    }
    return toplam / sayilar.Length;
}
*/

/*
 soru6 dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot
public int ToplaVeFiltrele(int[] dizi, int filtreDegeri)
{
    int toplam = 0;
    foreach (int deger in dizi)
    {
        if (deger > filtreDegeri)
        {
            toplam += deger;
        }
    }
    return toplam;
}
*/
/*
 soru7Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma
public int YasFark(int yas = 18)
{
    if (yas <= 18)
    {
        return 0;
    }
    return yas - 18;
}
*/

/*
 soru8 Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot
public List<string> Uzunluk5tenBuyukOlanlariFiltrele(string[] dizi)
{
    List<string> sonuc = new List<string>();
    foreach (string deger in dizi)
    {
        if (deger.Length > 5)
        {
            sonuc.Add(deger);
        }
    }
    return sonuc;
}
*/

