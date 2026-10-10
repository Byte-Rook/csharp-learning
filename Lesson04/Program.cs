// ---------------------------------
// 1. FOR
// Tekrar sayısı önceden belliyse
// ---------------------------------

Console.WriteLine("FOR ÖRNEĞİ");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"İş kalemi numarası: {i}");
}


// ---------------------------------
// 2. WHILE
// Koşul doğru kaldığı sürece
// ---------------------------------

Console.WriteLine("\nWHILE ÖRNEĞİ");

decimal whileTotalPrice = 0m;
string continueAnswer = "evet";

while (continueAnswer == "evet")
{
    Console.WriteLine("İş kalemi fiyatını giriniz:");
    decimal workPrice = Convert.ToDecimal(Console.ReadLine());

    whileTotalPrice += workPrice;

    Console.WriteLine("Başka iş kalemi eklensin mi? (evet/hayır)");
    continueAnswer = Console.ReadLine() ?? "";
}

Console.WriteLine($"While toplamı: {whileTotalPrice} TL");


// ---------------------------------
// 3. FOREACH
// Hazır koleksiyondaki her eleman için
// ---------------------------------

Console.WriteLine("\nFOREACH ÖRNEĞİ");

decimal[] prices = { 120m, 850m, 75m, 1400m, 300m };

decimal foreachTotalPrice = 0m;
int expensiveCount = 0;

foreach (decimal price in prices)
{
    Console.WriteLine($"Fiyat: {price} TL");

    foreachTotalPrice += price;

    if (price >= 500m)
    {
        expensiveCount++;
    }
}

Console.WriteLine($"Foreach toplamı: {foreachTotalPrice} TL");
Console.WriteLine($"500 TL ve üzerindeki iş sayısı: {expensiveCount}");