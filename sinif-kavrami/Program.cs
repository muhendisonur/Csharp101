personel yazilimci = new personel("Onur", "YILDIZ", 8000, "Ürün Geliştirme"); //instance

yazilimci.calis();

class personel
{
    //özellikler
    internal string isim;
    internal string soyad;
    private int _maas; 
    internal string departman;

    public int maas //property ile enkapsülasyon gerçekleştirildi
    {get => _maas; 
    set
    {
        if(maas < 10927)
            System.Console.WriteLine("Asgari ücretten düşük maaş veremezsin!");
        else
            _maas = value;
    }
    }

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