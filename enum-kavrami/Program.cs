long yillikCiro = 0;

System.Console.WriteLine("Şirketinizin yıllık cirosunu giriniz: ");

try
{
    yillikCiro = long.Parse(Console.ReadLine());
}
catch(FormatException)
{
    throw new FormatException("Sadece sayı giriniz!");
}



if(yillikCiro <= (int)sirketOlcegi.kucuk)
    System.Console.WriteLine("Şirketiniz küçük ölçeklidir!");
else if(yillikCiro <= (int)sirketOlcegi.orta)
    System.Console.WriteLine("Şirketiniz orta ölçeklidir!");
else
    System.Console.WriteLine("Şirketiniz büyük ölçeklidir!");


enum sirketOlcegi
{
    kucuk = 100000,
    orta = 1000000,
    buyuk = 1000000
}