//girilen sayıya kadar tek sayıların toplamını yazan program

int girilenDeger = 0;
int toplam = 0;

Console.WriteLine("Değer giriniz: ");
try
{
    girilenDeger = int.Parse(Console.ReadLine());
}
catch(FormatException)
{
    Console.WriteLine("Sadece sayı ifadesi giriniz!");
}

for(int i = 0; i <= girilenDeger; i++)
{
    toplam += (i%2 != 0) ? i : 0;
}
Console.WriteLine("Toplam: " + toplam);