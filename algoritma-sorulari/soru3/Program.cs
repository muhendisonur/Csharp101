/* SORU: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */

List<string> kelimeler = new List<string>();
byte kelimeAdedi = 0;

//kullanıcıdan girilecek kelime sayısının alınması
try
{
    System.Console.WriteLine("Kaç adet kelime girilecek: ");
    kelimeAdedi = Convert.ToByte(Console.ReadLine());
}
catch(Exception)
{
    System.Console.WriteLine("Hata: 255'den daha fazla kelime girmeyiniz!");
}

for(int i = 0; i < kelimeAdedi; i++) //kullanıcıdan alınan kelimelerin listeye eklenmesi
{
    try
    {
        System.Console.WriteLine("Kelime giriniz: ");
        string girilenKelime = Console.ReadLine();
        kelimeler.Add(girilenKelime);
    }
    catch(Exception)
    {
        System.Console.WriteLine("Hata! Tekrar Deneyiniz.");
    }
}

kelimeler.elemanlariTerstenYazdir();

public static class listeYardimcilari //extension class 
{
    public static void elemanlariTerstenYazdir(this List<string> param) //listeyi tersine çevirip elemanlarını yazdıran extension metot
    {
        param.Reverse();
        System.Console.WriteLine("****************** Elemanlarının Tersten Yazılışı ******************");
        foreach(var item in param)
        {
            System.Console.WriteLine(item);
        }
    }
}