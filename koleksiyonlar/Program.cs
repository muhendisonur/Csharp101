//GENERIC LIST
//int objeleri barındıran generic list oluşturmak
List<int> sayilar = new List<int>();
sayilar.Add(35);
sayilar.Add(45);
sayilar.Add(100);
sayilar.Add(61);

//eleman silme
sayilar.Remove(100); //removeat ile indeks değerine göre silebiliriz 
//Not: referans değerleri üzerinden işlem yapıyor yani kalıcı olarak sildi.

//eleman aramaa
System.Console.WriteLine(sayilar.Contains(61));

//eleman ile indeks değerine erişme
System.Console.WriteLine(sayilar.BinarySearch(61));

//diziyi list' çevirme
int[] rakamlar = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
List<int> rakamlarListe = new List<int>(rakamlar);

//tüm elemanları silme
rakamlarListe.Clear();
rakamlarListe.ForEach(sayi => Console.WriteLine(sayi)); //herhangi bir sonuç bastırılmaz, liste boş

//liste içerisinde nesne tutmak
List<araba> arabalar = new List<araba>(); //araba listesi oluşturuldu
araba ilkAraba = new araba{ //araba sınıfından instance alındı
    marka = "opel",
    model = 2021
};
arabalar.Add(ilkAraba); //oluşturulan instance listeye eklendi
arabalar.Add(new araba{ //pratik bir eleman ekleme tarzı
    marka = "nissan",
    model = 2012
});
arabalar.ForEach(item => System.Console.WriteLine(item.marka)); //liste elemanlarının markaları yazdırıldı

class araba
{
    public string marka;
    public int model;
}