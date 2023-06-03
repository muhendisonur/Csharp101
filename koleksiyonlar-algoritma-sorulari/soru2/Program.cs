//SORU: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

List<int> sayilar = new List<int>();
List<int> buyukler = new List<int>();
List<int> kucukler = new List<int>();
int girilenSayi;

for(int i = 0; i < 20; i++) //kullanıcıdan sayıların alınıp listeye eklenmesi
{
    try
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        girilenSayi = int.Parse(Console.ReadLine());
        sayilar.Add(girilenSayi);
    }
    catch(Exception)
    {
        System.Console.WriteLine("Hata, sadece sayı giriniz!");
    }
}

sayilar.Sort(); //listenin küçükten büyüğe sıralanması

for(int i = 0; i < 3; i++)
    kucukler.Add(sayilar[i]); 

sayilar.Reverse(); //listenin büyükten küçüğe sıralanması

for(int i = 0; i < 3; i++)
    buyukler.Add(sayilar[i]);

//sonuçların yazdırılması
System.Console.WriteLine("En küçük 3 sayının ortalaması {0}'dır. Toplamları ise {1}'dir!", (kucukler.Sum() / 3), kucukler.Sum());
System.Console.WriteLine("En büyük 3 sayının ortalaması {0}'dır. Toplamları ise {1}'dir!", (buyukler.Sum() / 3), buyukler.Sum());