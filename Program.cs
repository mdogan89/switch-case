﻿// See https://aka.ms/new-console-template for more information
using System.Runtime;

Console.WriteLine("Hello, World!");

int month = DateTime.Now.Month;

switch (month)
{
	case 1:
		Console.WriteLine("Ocak ayındasınız");
		break;
    case 2:
        Console.WriteLine("Şubat ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart ayındasınız");
        break;
    case 4:
        Console.WriteLine("Nisan ayındasınız");
        break;
    case 5:
        Console.WriteLine("Mayıs ayındasınız");
        break;
    case 6:
        Console.WriteLine("Haziran ayındasınız");
        break;
    case 7:
        Console.WriteLine("Temmuz ayındasınız");
        break;
    case 8:
        Console.WriteLine("Ağustos ayındasınız");
        break;
    case 9:
        Console.WriteLine("Eylül ayındasınız");
        break;
    case 10:
        Console.WriteLine("Ekim ayındasınız");
        break;
    case 11:
        Console.WriteLine("Kasım ayındasınız");
        break;
    case 12:
        Console.WriteLine("Aralık ayındasınız");
        break;
    default:
        Console.WriteLine("Hata oluştu");
		break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış ayındasınız");
        break;
    default:
        break;
}

