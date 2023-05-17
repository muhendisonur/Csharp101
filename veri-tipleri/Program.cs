byte byteDegisken = 1; //1 byte
sbyte sbyteDegisken = 5; //1 byte, negatif değerler dahil.
short shortDegisken = -33; //2 byte
ushort ushortDegisken = 10; //2 byte, sadece pozitif değerler.
Int16 int16Degisken = 5; //2 byte, tam sayı
Int32 int32Degisken = 15; //4 byte, tam sayı, int'in dengidir.
Int64 int64Degisken = 40; //8 byte, tam sayı
uint uintDegisken = 50; //4 byte, tam sayı, sadece pozitif değerler.
long longDegisken = -500; //8 byte tam sayı
ulong ulongDegisken = 400; //8 byte, tam sayı, sadece pozitif değerler.
float floatDegisken = 5.5f; //4 byte, ondalıklı sayılar dahil
double doubleDegisken = 33.5; //8 byte, ondalıklı sayılar dahil
char charDegisken = 'a'; //2 byte, karakter
string stringDegisken = "merhaba"; //sınırsız byte değeri
string dateTimeDegisken = DateTime.Now.ToString("HH:mm"); //DateTime kullanımı

//object tüm tipten değerleri alabilir.
object objectSayi = 5;
object objectKarakter = "a";

