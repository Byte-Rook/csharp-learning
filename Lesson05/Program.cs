Console.WriteLine("Lütfen proje ismini giriniz:");
string projectName = Console.ReadLine() ?? "";

Console.WriteLine("Lütfen çalışma saatini giriniz:");
decimal hours = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Lütfen saatlik ücreti giriniz:");
decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());

decimal totalPrice = CalculateTotal(hours, hourlyRate);

bool isLargeProject = IsLargeProject(totalPrice);

ShowSummary(projectName, totalPrice, isLargeProject);


decimal CalculateTotal(decimal workHours, decimal rate)
{
    decimal calculatedPrice = workHours * rate;

    return calculatedPrice;
}


bool IsLargeProject(decimal price)
{
    bool result = price >= 1000m;

    return result;
}


void ShowSummary(string name, decimal price, bool isLarge)
{
    Console.WriteLine();
    Console.WriteLine("----- PROJE ÖZETİ -----");
    Console.WriteLine($"Proje adı: {name}");
    Console.WriteLine($"Toplam fiyat: {price} TL");

    if (isLarge)
    {
        Console.WriteLine("Bu büyük bir projedir.");
    }
    else
    {
        Console.WriteLine("Bu küçük bir projedir.");
    }
}