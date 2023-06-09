public class Hayvanlar : Canlilar 
{
    protected int elAdeti, ayakAdeti;

    public virtual void avlan()
    {
        System.Console.WriteLine("Hayvan olarak avlanıyorum.");
    }

    protected void uyu()
    {
        System.Console.WriteLine("Hayvan olarak uyuyorum.");
    }
}

public sealed class denizCanlilari : Hayvanlar //sealed class örneği
{
    public denizCanlilari()
    {
        base.nefesAl();
    }

    public void yuz()
    {
        System.Console.WriteLine("Balık olarak yüzüyorum.");
    }

    public override void avlan() //polimorfizm örneği
    {
        System.Console.WriteLine("Deniz canlısı olarak balık tüketiyorum.");
    }
}

public sealed class ucabilenCanlilar : Hayvanlar //sealed class örneği
{
    public ucabilenCanlilar()
    {
        base.nefesAl();
    }

    public void uc()
    {
        System.Console.WriteLine("Kuş olarak uçuyorum.");
    }
}

public sealed class karaCanlilari : Hayvanlar //sealed class örneği
{
    public karaCanlilari()
    {
        base.nefesAl();
        base.uyu();
    }

    public void yuru()
    {
        System.Console.WriteLine("Bir hayvan olarak yürüyorum.");
    }

    public override void avlan()
    {
        System.Console.WriteLine("Kara canlısı olarak kırmızı et tüketiyorum.");
    }
}