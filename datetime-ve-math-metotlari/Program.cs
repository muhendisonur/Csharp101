//DateTime Metotları
System.Console.WriteLine(DateTime.Now.Hour); //Second, Minute, Hour, Day, Month, Year şeklinde kullanulabilir

//DateTime Zaman Ekleme
System.Console.WriteLine(DateTime.Now.AddDays(5)); //Days yerine üstte ki başlıklar kullanılabilir(çoğul olan s ekiyle beraber).

//DateTime Format
System.Console.WriteLine(DateTime.Now.ToString("ddd")); //yıl yy yyyy olmak üzere gün ve ay 3 şekilde formatlanabilir. Örneğin dd, ddd, dddd

//Math Kütüphanesi
System.Console.WriteLine(Math.Abs(-61)); //mutlak değer
System.Console.WriteLine(Math.Ceiling(61.5)); //yukarı yuvarlama
System.Console.WriteLine(Math.Round(61.4)); //otomatik yuvarlama
System.Console.WriteLine(Math.Floor(61.7)); //aşağı yuvarlama
System.Console.WriteLine(Math.Max(3,7)); //büyük olan değeri yazdırır
System.Console.WriteLine(Math.Min(6,10)); //küçük olan değeri yazdırır
System.Console.WriteLine(Math.Pow(3,5)); //üs alma işlemi
System.Console.WriteLine(Math.Sqrt(81)); //karekök alma işlemi

