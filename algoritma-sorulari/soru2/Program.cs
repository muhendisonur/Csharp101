/* SORU: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */

List<byte> girilmisSayilar = new List<byte>();
byte sayiAdedi = 0;
byte bolen = 0;

//kullanıcıdan girilecek sayı adetinin ve kontrolcü sayının alınması
try
{
    System.Console.WriteLine("Kaç adet sayı girilecek: ");
    sayiAdedi = Convert.ToByte(Console.ReadLine());
    Console.WriteLine("Bölüm kontrolü hangi sayı ile yapılacak: ");
    bolen = Convert.ToByte(Console.ReadLine());
}
catch(Exception)
{
    System.Console.WriteLine("Hata: Sadece 255'e kadar olan pozitif sayı giriniz!");
}

for(byte i = 0; i < sayiAdedi; i++) //kullanıcıdan alınan sayıların listeye eklenmesi
{
    try
    {
        System.Console.Write("Sayı giriniz: ");
        girilmisSayilar.Add(Convert.ToByte(Console.ReadLine()));
    }
    catch(Exception)
    {
        System.Console.WriteLine("Hata: Sadece 255'e kadar olan pozitif sayı giriniz!");
    }
}

System.Console.WriteLine("**************** {0} Sayısına Eşit veya Tam Bölünen İfadeler ****************", bolen);
//soruda istenilen "m'e eşit yada tam bölünenleri console'a yazdırın." koşuluna uygun olan listede ki değerlerin yazdırılması
for(byte j = 0; j < girilmisSayilar.Count(); j++)
{
    if(girilmisSayilar[j] % bolen == 0 || girilmisSayilar[j] == bolen)
        System.Console.WriteLine(girilmisSayilar[j]);
}