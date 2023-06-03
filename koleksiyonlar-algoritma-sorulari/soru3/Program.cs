//SORU: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

string harfler = "aeıioöuü";
List<char> sesliHarfler = new List<char>();

System.Console.WriteLine("Bir cümle giriniz: ");
string girilenCumle = Console.ReadLine();

for(int i = 0; i < girilenCumle.Length; i++) //girilen cümlenin her bir harfinin tüm sesli harflerle karşılaştırılması
{
    for(int j = 0; j < harfler.Length; j++)
    {
        if(girilenCumle[i] == harfler[j] && !sesliHarfler.Contains(girilenCumle[i])) //sesliHarfler'de var olan harfin tekrar eklenmemesi ekstra için koşul eklenmiştir
        {
            sesliHarfler.Add(girilenCumle[i]);
            break;
        }
    }
}

//sonucun yazdırılması
System.Console.WriteLine("********* GİRDİĞİNİZ CÜMLE DE Kİ SESLİ HARFLER *********"); 
foreach(var item in sesliHarfler)
{
    System.Console.WriteLine(item);
}
