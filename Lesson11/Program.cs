Console.WriteLine("Proje fiyatını giriniz:");

string priceAnswer = Console.ReadLine() ?? "";

try
{
    decimal price = Convert.ToDecimal(priceAnswer);

    if (price < 0m)
    {
        Console.WriteLine("Fiyat negatif olamaz.");
    }
    else
    {
        Console.WriteLine($"Proje fiyatı: {price} TL");
    }
}
catch (FormatException)
{
    Console.WriteLine("Geçerli bir sayı girmelisiniz.");
}
catch (OverflowException)
{
    Console.WriteLine("Girdiğiniz sayı decimal sınırlarını aşıyor.");
}
finally
{
    Console.WriteLine("Fiyat kontrolü tamamlandı.");
}

int hours;

while (true)
{
    Console.WriteLine("Çalışma saatini tam sayı olarak giriniz:");

    string hoursAnswer = Console.ReadLine() ?? "";

    if (!int.TryParse(hoursAnswer, out hours))
    {
        Console.WriteLine("Geçerli bir tam sayı girmelisiniz.");
        continue;
    }

    if (hours < 0)
    {
        Console.WriteLine("Çalışma saati negatif olamaz.");
        continue;
    }

    break;
}

Console.WriteLine($"Çalışma süresi: {hours} saat");
Console.WriteLine("Program tamamlandı.");