public class Hayvanlar : Canlilar 
{
    protected int elAdeti, ayakAdeti;

    protected void avlan()
    {
        System.Console.WriteLine("Hayvan olarak avlanıyorum.");
    }

    protected void uyu()
    {
        System.Console.WriteLine("Hayvan olarak uyuyorum.");
    }
}

public class denizCanlilari : Hayvanlar
{
    public void yuz()
    {
        System.Console.WriteLine("Balık olarak yüzüyorum.");
    }
}

class ucabilenCanlilar : Hayvanlar
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

class karaCanlilari : Hayvanlar
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
}