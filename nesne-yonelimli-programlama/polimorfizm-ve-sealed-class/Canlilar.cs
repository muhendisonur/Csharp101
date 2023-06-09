public class Canlilar
{
    protected void nefesAl()
    {
        System.Console.WriteLine("Canlı olarak nefes alıyorum.");
    }

    protected void bosalt()
    {
        System.Console.WriteLine("Canlı olarak boşaltım yapıyorum.");
    }

    protected void ol()
    {
        System.Console.WriteLine("Vefat ettim.");
    }

    protected virtual void besinTuket() //polimorfizm örneği
    {
        System.Console.WriteLine("Canlı olarak besin tüketiyorum.");
    }

    protected void siviTuket()
    {
        System.Console.WriteLine("Canlı olarak sıvı tüketiyorum.");
    }
}