public class Insanlar : Canlilar
{

    public Insanlar()
    {
        base.nefesAl();
        base.besinTuket();
    }

    public void yuru()
    {
        System.Console.WriteLine("İnsan olarak yürüyorum.");
        base.siviTuket();
    }

    public virtual void besinTuket() //polimorfizm örneği
    {
        base.besinTuket();
        System.Console.WriteLine("İnsan olarak et tüketiyorum.");
    }

    public void paraKazan()
    {
        System.Console.WriteLine("İnsan olaraktan çalışarak para kazanıyorum.");
    }
}