//Out Kavramı Örnek
Metotlar ornek = new Metotlar();
ornek.topla(5, 6, out int toplam);
System.Console.WriteLine(toplam);


//Overloading
ornek.kisiYazdir("onur");
ornek.kisiYazdir("oğuzhan", "yıldız");

class Metotlar
{
    public void topla(int sayi1, int sayi2, out int sonuc)
    {
        sonuc = sayi1 + sayi2;
    }

    public void kisiYazdir(string isim)
    {
        System.Console.WriteLine("Hoşgeldiniz {0}", isim);
    }

    public void kisiYazdir(string isim, string soyIsim) //2.parametre girilirse soyad olarak algılanıp tüm karakterler büyük harf yapılacak
    {
        System.Console.WriteLine("Hoşgeldiniz {0} {1}", isim, soyIsim.ToUpper());
    }
}