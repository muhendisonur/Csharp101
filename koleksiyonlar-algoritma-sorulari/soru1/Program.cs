//SORU : Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
using System.Collections;

ArrayList asalSayilar = new ArrayList();
ArrayList asalOlmayanSayilar = new ArrayList();

int girilenDeger = 0;
bool asalKontrol = false;

for(int i = 0; i < 20; i++)
{
    try //sayısal değer giriş kontrolü
    {
        System.Console.WriteLine("Bir değer giriniz: ");
        girilenDeger = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        System.Console.WriteLine("Sadace sayı giriniz!");
        continue;
    }
    catch(Exception)
    {
        System.Console.WriteLine("Hata, geliştiriciniz ile iletişime geçiniz!");
        continue;
    }

    if(girilenDeger <= 0) //girilen değerin pozitif sayı kontrolü
    {
        System.Console.WriteLine("0'dan büyük bir değer giriniz!");
        continue;
    }
    else if(girilenDeger == 1) //girilen sayı 1 ise direkt asalOlmayanSayilar listesine eklenecek
    {
        if(!asalOlmayanSayilar.Contains(girilenDeger)) //arrayde var olan değerin eklenmemesi için kontrol
            {
                asalOlmayanSayilar.Add(girilenDeger);
                continue;
            }
        else
            continue;     
    }
    else if(girilenDeger == 2)
    {
        if(!asalSayilar.Contains(girilenDeger))//var olan değerin eklenmemesi için kontrol
        {
            asalSayilar.Add(girilenDeger);
            continue;
        }
        else
            continue;
            
    }

    for(int j = 2; j < girilenDeger; j++)
    {
        if(girilenDeger % j == 0)
        {
            asalKontrol = false;
            break;
        }
        else
            asalKontrol = true;
    }

    if(asalKontrol)
    {
        if(!asalSayilar.Contains(girilenDeger)) //var olan değerin tekrar eklenmesini engellemek
            asalSayilar.Add(girilenDeger);
    }   
    else
    {
        if(!asalOlmayanSayilar.Contains(girilenDeger)) //var olan değerin tekrar eklenmesini engellemek
            asalOlmayanSayilar.Add(girilenDeger);
    }
}

//yazdırma işlemleri
System.Console.WriteLine("**************** ASAL SAYILAR ****************");
foreach(var item in asalSayilar)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("**************** ASAL OLMAYAN SAYILAR ****************");
foreach(var item in asalOlmayanSayilar)
{
    System.Console.WriteLine(item);
}