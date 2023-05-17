//Implicit Conversion(Bilinçsiz Dönüştürme)
//örnek 1
int tamSayi = 5;
float ondalikliSayi = 61.5f;
float sonuc = tamSayi + ondalikliSayi; //tamSayi değişkeni float olarak ele alındı yani dönüşüm sağlandı.

//örnek 2
byte ilkByte = 5;
string isim = "Onur";
double deger = 61;
object obje = ilkByte + isim + deger; //object veri tipi; byte, string ve double için daha yüksek kapsamlı olduğu için "bilinçsiz dönüşüm" sağlandı.
System.Console.WriteLine(obje);


//Explicit Conversion(Bilinçli Dönüştürme)
string aslindaBirRakam = "5";
int gercekBirRakam = 9;
int toplam = Convert.ToInt16(aslindaBirRakam) + gercekBirRakam; //geliştirici kasıtlı ve bilinçli olarak tip değişimi gerçekleştirdi.