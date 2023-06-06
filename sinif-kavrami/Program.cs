personel yazilimci = new personel("Onur", "YILDIZ", 15000, "Ürün Geliştirme"); //instance

yazilimci.calis();

class personel
{
    //özellikler
    internal string isim;
    internal string soyad;
    internal int maas;
    internal string departman;

    internal personel() //kurucu metot
    {
        System.Console.WriteLine("Personel oluşturuldu!");
    }

    internal personel(string isimPara, string soyadPAra, int maasPara, string departmanPara) //kurucu metot
    {
        isim = isimPara;
        soyad = soyadPAra;
        maas = maasPara;
        departman = departmanPara;
    }

    
    internal void calis() //metot
    {
        System.Console.WriteLine("{0} isimli personel olarak şuanda çalışmaya başladım!", this.isim);
    }
}