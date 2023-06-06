personel yazilimci = new personel(){
    isim = "Onur",
    soyad = "YILDIZ",
    maas = 15000,
    departman = "Ürün Geliştirme"
};

yazilimci.calis();


class personel
{
    internal string isim;
    internal string soyad;
    internal int maas;
    internal string departman;

    internal void calis()
    {
        System.Console.WriteLine("{0} isimli personel olarak şuanda çalışmaya başladım!", this.isim);
    }
}