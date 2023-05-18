//kullanıcının bulunduğu aya göre mevsimi söyleyen program

int ay = DateTime.Now.Month;

switch(ay)
{
    case 1:
    case 2: 
    case 3:
        Console.WriteLine("Kıştasınız!");
        break;
    case 4:
    case 5: 
    case 6:
        Console.WriteLine("İlkbahardasınız!");
        break;
    case 7:
    case 8: 
    case 9:
        Console.WriteLine("Yazdasınız!");
        break;
    case 10:
    case 11: 
    case 12:
        Console.WriteLine("Sonbahardasınız!");
        break;
}