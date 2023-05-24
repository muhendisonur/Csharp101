int[] sayilar = {5, 10, 15, 50, 61, 34, 54, 43, 81};

//Sıralama
System.Console.WriteLine("*************** Dizi Sıralandı ***************");
foreach(var sayi in sayilar)
    System.Console.WriteLine(sayi);

//Silme
System.Console.WriteLine("*************** Diziden Seçilen Eleman(lar)  Silindi ***************");
Array.Clear(sayilar, 6, 3);
foreach(var sayi in sayilar)
    System.Console.WriteLine(sayi);

//Ters Çevirme
System.Console.WriteLine("*************** Dizi Sıralaması Tersine Çevirildi ***************");
Array.Reverse(sayilar);
foreach(var sayi in sayilar)
    System.Console.WriteLine(sayi);

//Elemanın İndeksini Bulmak
System.Console.WriteLine("*************** 61 Sayısının İndeksi Bastırıldı ***************");
System.Console.WriteLine(Array.IndexOf<int>(sayilar, 61));

//Yeniden Boyutlandırma
System.Console.WriteLine("*************** Dizi 15 Elemana Yükseltildi ***************");
Array.Resize<int>(ref sayilar, 15);
foreach(var sayi in sayilar)
    System.Console.WriteLine(sayi);