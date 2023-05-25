/* SORU: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

//altta ki değişkenler her alanda kullanmak için genel scope üzerinde tanımlandı
byte sayiAdedi = 0;
int girilenSayi = 0;

System.Console.WriteLine("Kaç adet sayı girilecek: ");
try
{
    sayiAdedi = Convert.ToByte(Console.ReadLine()); //kaç adet sayı girileceği tanımlandı
}
catch(Exception)
 {
    System.Console.WriteLine("Hata: Sadece pozitif sayı ifadesi giriniz!");
}

List<int> girilmisSayilar = new List<int>(); //girilen sayıların tutalacağı liste tanımlandı

for(int i = 0; i < sayiAdedi; i++) //sayılar kullanıcıya girdirildi
{
    Console.WriteLine("Sayı giriniz: ");
    try
    {
        girilenSayi = Convert.ToInt16(Console.ReadLine());
        girilmisSayilar.Add(girilenSayi);
    }
    catch(Exception)
    {
        System.Console.WriteLine("Hata: Sadece pozitif sayı ifadesi giriniz!");
    }
}

Console.WriteLine("*********** GİRDİĞİNİZ DEĞERLER ARASINDA Kİ ÇİFT SAYILAR ***********");
for(int j = 0; j < girilmisSayilar.Count(); j++) //listede ki çift sayılar yazdırıldı
{
    if(girilmisSayilar[j] % 2 == 0)
        System.Console.WriteLine(girilmisSayilar[j]);
}
