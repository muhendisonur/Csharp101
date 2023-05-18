//günün saatine göre karşılama yapan program

int zaman = DateTime.Now.Hour;
// if(zaman >= 6 && zaman <= 11)
//     Console.WriteLine("Günaydın!");
// else if(zaman <= 18)
//     Console.WriteLine("Tünaydın!");
// else
//     System.Console.WriteLine("İyi akşamlar!");

//yukarıda ki if-else if-else yapısının ternary alternatifi
Console.WriteLine((zaman >= 6 && zaman <= 11) ? "Günaydın!" : (zaman <= 18) ? "Tünaydın!" : "İyi akşamlar!");