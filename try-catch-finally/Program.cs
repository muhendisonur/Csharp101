Console.WriteLine("Sadece sayı ifadesi giriniz: ");
try
{
    int girilenSayi = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Girdiğiniz sayı: " + girilenSayi + "'dır.");
}
catch(FormatException)
{
    Console.WriteLine("Hata: Sadece sayı giriniz!");
}
catch(Exception)
{
    System.Console.WriteLine("Hata, geliştiriciniz ile iletişime geçiniz.");
}
finally
{
    Console.WriteLine("Program sonlandı. İyi günler dileriz.");
}
