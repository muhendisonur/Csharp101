public class Insanlar : Canlilar
{

    public Insanlar()
    {
        base.nefesAl();
    }

    public void yuru()
    {
        System.Console.WriteLine("İnsan olarak yürüyorum.");
        base.siviTuket();
    }

    public void paraKazan()
    {
        System.Console.WriteLine("İnsan olaraktan çalışarak para kazanıyorum.");
    }
}