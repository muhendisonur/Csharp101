//dizi büyüklüğü kullanıcıdan alınan girdiye göre tanımlanan ve sonrasında dizinin her bir elemanı için atama yapan, son olarak dizinin tüm elemanlarını yazdıran program.

string[] ogrenciler;
string girilenOgrenci = "";
int ogrenciSayisi = 0;

Console.WriteLine("Kaç adet öğrenci olacak: ");
try
{
    ogrenciSayisi = int.Parse(Console.ReadLine());
}
catch(Exception)
{
    Console.WriteLine("Hata, tekrar deneyiniz!");
}

ogrenciler = new string[ogrenciSayisi];

for(int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine("{0}.öğrenciyi giriniz: ", i+1);
    try
    {
        girilenOgrenci = Console.ReadLine();
    }
    catch(Exception)
    {
        Console.WriteLine("Hata, tekrar deneyiniz!");
    }

    ogrenciler[i] = girilenOgrenci;
}

Console.Write("Öğrenci Listesi: ");
for(int j = 0; j < ogrenciSayisi; j++)
    Console.Write(ogrenciler[j] + "; ");