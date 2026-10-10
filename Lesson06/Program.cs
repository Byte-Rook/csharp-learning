List<string> projects = new List<string>();
projects.Add("Miras");
projects.Add("Freelance API");
projects.Add("Mobil Oyun");
Console.WriteLine("Yeni proje ismini giriniz:");
string newProject = Console.ReadLine() ??"";
projects.Add(newProject);
bool wasRemoved = projects.Remove("Freelance API");

Console.WriteLine($"Silme işlemi başarılı mı: {wasRemoved}");
bool hasMiras = projects.Contains("Miras");
bool hasWebSite = projects.Contains("Web Sitesi");

Console.WriteLine($"Miras listede var mı: {hasMiras}");
Console.WriteLine($"Web Sitesi listede var mı: {hasWebSite}");
foreach (string project in projects)
{
    Console.WriteLine(project);
}
Console.WriteLine($"Toplam proje sayısı:{projects.Count}");
 
Console.WriteLine();
Console.WriteLine("---Proje Fiyatları---");

List<decimal> prices = new List<decimal>();

prices.Add(750m);
prices.Add(1200m);
prices.Add(500m);

decimal totalPrice = 0m;

foreach (decimal price in prices)
{
    Console.WriteLine($"Proje fiyatı: {price} TL");
    totalPrice += price;
}

Console.WriteLine($"Toplam proje değeri: {totalPrice} TL");
decimal averagePrice = totalPrice / prices.Count;
decimal lowestPrice = prices.Min();
decimal highestPrice = prices.Max();
Console.WriteLine($"Ortalama proje fiyatı: {averagePrice:0.00} TL");
Console.WriteLine($"En düşük proje fiyatı: {lowestPrice} TL");
Console.WriteLine($"En yüksek proje fiyatı: {highestPrice} TL");
Console.WriteLine();
Console.WriteLine("--- FREELANCE GELİR TAKİBİ ---");

List<decimal> userPrices = new List<decimal>();

Console.Write("Kaç proje gireceksiniz: ");
int userProjectCount = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= userProjectCount; i++)
{
    Console.Write($"{i}. projenin fiyatını giriniz: ");
    decimal userPrice = Convert.ToDecimal(Console.ReadLine());

    userPrices.Add(userPrice);
}
Console.WriteLine($"Girilen proje sayısı: {userPrices.Count}");

foreach (decimal userPrice in userPrices)
{
    Console.WriteLine($"Kaydedilen fiyat: {userPrice} TL");
}
if (userPrices.Count > 0)
{
    decimal userTotal = 0m;
    int highValueProjectCount = 0;

    foreach (decimal currentPrice in userPrices)
    {
        userTotal += currentPrice;

        if (currentPrice >= 1000m)
        {
            highValueProjectCount++;
        }
    }

    decimal userAverage = userTotal / userPrices.Count;
    decimal userLowest = userPrices.Min();
    decimal userHighest = userPrices.Max();

    Console.WriteLine("--- ÖZET ---");
    Console.WriteLine($"Toplam gelir: {userTotal} TL");
    Console.WriteLine($"Ortalama proje fiyatı: {userAverage:0.00} TL");
    Console.WriteLine($"En düşük fiyat: {userLowest} TL");
    Console.WriteLine($"En yüksek fiyat: {userHighest} TL");
    Console.WriteLine($"1000 TL ve üzerindeki proje sayısı: {highValueProjectCount}");
}
else
{
    Console.WriteLine("Hesaplanacak proje bulunamadı.");
}