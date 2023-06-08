personel.personelSayi(); //Sınıfı ilk çağırdığımız yer, static kurucu çalışır ve _personelSayısı 0 olarak atanır.

personel yazilimci1 = new personel("Onur", "YILDIZ", 25000, "Ürün Geliştirme"); //instance
personel yazilimci2 = new personel("Ahmet", "Pınar", 8000, "İnsan Kaynakları");  //asgari ücretten düşük olduğu için personelsayisi değişkeni artırılmaz

personel.personelSayi();

class personel
{

    private static int _personelSayisi; //sınıfın çağırıldığı tüm noktalarda ortak değer sunar.
    public static int personelSayisi { get => _personelSayisi; }
    private string isim; //field örneği
    private string soyad;
    private int _maas; 
    private string departman;

    public int maas //property ile enkapsülasyon gerçekleştirildi
    {get => _maas; 
    set
    {
        if(value < 10927)
        {
            System.Console.WriteLine("Asgari ücretten düşük maaş veremezsin!");
            _maas = 0;
        }
            
        else
        {
            _maas = value;
            _personelSayisi++;
        }
            
    }
    }

    static personel() //statik yapıcı metot çalışan sınıfına erişildiğinde bir kereye mahsus çalışır
    {
        _personelSayisi = 0;
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

    public static void personelSayi()
    {
        System.Console.WriteLine(_personelSayisi);
    }
}