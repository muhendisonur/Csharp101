string ilkCumle = "Ben .Net Core Öğreniyorum!";
string ikinciCumle = ".NET CORE";

//Length: değişkenin uzunluğunu verir
System.Console.WriteLine(ilkCumle.Length);

//ToUpper, ToLower: değişkeni komple büyük ya da küçük harfe çevirir
System.Console.WriteLine(ikinciCumle.ToLower());

//Concat: değişkenin sonuna belirtilen string ifadeyi ekler
System.Console.WriteLine(String.Concat(ilkCumle, " Core"));

//Compare: verilen ifadeleri karşılaştırır ve duruma göre 1, -1 ifadelerini döner
//CompareTo: verilen ifadelerin uzunluklarını karşılaştırır ve duruma göre 1, 0, -1 ifadelirini döner.
System.Console.WriteLine(string.Compare(ikinciCumle, ilkCumle));
System.Console.WriteLine(ikinciCumle.CompareTo(ilkCumle));

//Contains: değişkenin verilen string ifadeyi içerip içermediğini kontrol eder
System.Console.WriteLine(ilkCumle.ToLower().Contains(ikinciCumle.ToLower()));

//IndexOf: verilen string ifadenin kaçıncı indeksten başladığını döner
//LastIndexOf: belirtilen ifadenin en son nereden başladığını döner
System.Console.WriteLine(ilkCumle.IndexOf(".Net"));
System.Console.WriteLine(ikinciCumle.LastIndexOf("E"));

//Insert: belirtilen indeksten itibaren belirtilen ifadeyi ekler
System.Console.WriteLine(ilkCumle.Insert(ilkCumle.Length, " Hoşcakal!"));

//Padleft - PadRight: ifadenin karakter uzunluğu da dahil olmak üzere belirtilen karaktere uzunluğuna tamamlar
System.Console.WriteLine(ilkCumle.PadRight(50, '*') + ikinciCumle);

//Remove: belirtilen indeksten sonra belirtilen adetçe karakter siler
System.Console.WriteLine(ilkCumle.Remove(8,5));

//Replace: belirtilen ifadeyi, sonrasında belirtilen ifade ile değiştirir
System.Console.WriteLine(ilkCumle.Replace(".Net", "C#"));

//Split: kelime dizisini belirtilen ölçüye göre diziye ayırır
System.Console.WriteLine(ilkCumle.Split(" ")[1]);