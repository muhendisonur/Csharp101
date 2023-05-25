/* SORU : Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */

List<string> kelimeler = new List<string>();
int toplamHarf = 0;

System.Console.WriteLine("Cümle giriniz: ");
string girilenCumle = Console.ReadLine();

kelimeler = girilenCumle.Split(" ").ToList(); //kelimelerin boşluk ölçütü ile ayrılarak listeye olarak düzenlenmesi

for(int i = 0; i < kelimeler.Count(); i++) //listede bulunan kelimelerin her birinin uzunluğunu toplamHarf değişkeni üzerinde toplanması
{
    toplamHarf += kelimeler[i].Length;
}

System.Console.WriteLine("Girdiğiniz cümlede toplam; {0} kelime ve {1} harf bulunmaktadır.", kelimeler.Count(), toplamHarf); //sonucun bastırılması