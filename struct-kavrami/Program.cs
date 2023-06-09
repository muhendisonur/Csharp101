kare ilkKare;
ilkKare.kenarUzunlugu = 5;
System.Console.WriteLine("{0} kenar uzunluğuna sahip karenin alanı {1}'dir!", ilkKare.kenarUzunlugu, ilkKare.alanHesapla());

struct kare
{
    internal int kenarUzunlugu;

    public kare()
    {
        kenarUzunlugu = 0;
    }

    public kare(int kenarUzunluguPara)
    {
        kenarUzunlugu = kenarUzunluguPara;
    }

    public int alanHesapla()
    {
        return kenarUzunlugu*kenarUzunlugu;
    }
}