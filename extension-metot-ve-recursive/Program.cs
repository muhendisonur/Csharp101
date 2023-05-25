//faktoriyel hesabı üzerinde rekürsif metot kullanımı
matematiksel ornek = new matematiksel();
System.Console.WriteLine(ornek.faktoriyel(5)); //rekürsif metotun kullanılması



//girilen sayının tek durumunun kontorlünün extension(genişletilmiş) metot ile sağlanması
int girilenSayi = 0;

try //yanlış girdi için hata kontrolü
{
    System.Console.WriteLine("Bir sayı giriniz: ");
    girilenSayi = int.Parse(Console.ReadLine());
}
catch(Exception)
{
    System.Console.WriteLine("Hata, tekrar deneyiniz!");
}

bool tek = girilenSayi.tekMi(); //extension metotun kullanılması

if(tek)
    System.Console.WriteLine("Girdiğiniz sayı tektir!");
else
    System.Console.WriteLine("Girdiğiniz sayı tek DEĞİLDİR!");


static class genisletilmisMetot
{
    public static bool tekMi(this int deger) //extension metotun tanımlanması
    {
        return (deger % 2 == 0) ? false : true;
    }
}

class matematiksel 
{
    public int faktoriyel(int fakParam) //rekürsif metotun tanımlanması
    {
        if(fakParam == 1)
            return fakParam;
        return faktoriyel(fakParam - 1) * fakParam;
    }
}