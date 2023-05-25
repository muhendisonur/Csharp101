//erisim_belirteci donus_tipi metot_ismi(porametreler){}

Metotlar ornek = new Metotlar();

//Call by Value Örnek
int a = 5;
int b = 10;
System.Console.WriteLine("{0} ile {1}'in toplamı: {2}", a, b, ornek.topla(a, b));

//Call by Reference Örnek
System.Console.WriteLine("İsim giriniz: ");
string kisiİsmi = Console.ReadLine();
ornek.muhendisTanimla(ref kisiİsmi);
System.Console.WriteLine("{0} olarak sisteme kaydedildi.", kisiİsmi);

class Metotlar
{
    //Call by Value
    public int topla(int sayi1, int sayi2) //iki sayının toplamını döndürür
    {
        return sayi1 + sayi2;
    }

    //Call by Reference
    public void muhendisTanimla(ref string isim) //parametreye muhendis ekini ekler
    {
        isim += " Mühendis";
    }
}


