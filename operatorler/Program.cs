//atama ve işlemli atama operatorleri
string isim = "Onur";

int kendisininBesKati = 5;
kendisininBesKati *= 5; // *= ifadesi bu başlığa örnektir.

//mantıksal operatorler
string bosDeger = null;
if(bosDeger == null || bosDeger == "") // || ifadesi bu başlığa örnektir.
    Console.WriteLine("Değişken boş ifade içeriyor!");

//ilişkisel operatorler
int sayiBir = 3;
int sayiIki = 5;
bool birinciBuyuk = sayiBir > sayiIki; // > ifadesi bu başlığa örnektir.

//aritmetik operatorler
int onceArttir = 5;
int sonraArttir = 5;
Console.WriteLine("Bu değer önce artılır sonra yazılır: " + ++onceArttir + "\n" + "Bu değer önce yazılır sonra artırılır: " + sonraArttir++); //++ ifadeleri bu başlığa örnektir.
