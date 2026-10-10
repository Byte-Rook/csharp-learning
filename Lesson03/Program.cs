Console.WriteLine("Lütfen proje isminizi giriniz.");
string projectName = Console.ReadLine();

Console.WriteLine("Lütfen projenizin toplam değerini belirleyin ve girin.");
decimal projectPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"{projectName} kaç günde teslim edileceğini giriniz:");
int deliveryDays = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ödeme yapıldı mı? Evet veya hayır şeklinde giriniz.");
string paymentAnswer = Console.ReadLine() ??"";

bool isPaid = paymentAnswer == "evet";

bool hasInvalidInput = projectPrice<=0m || deliveryDays <=0;

bool isPriorityProject = projectPrice >= 1000m && deliveryDays <= 7;

bool isPaymentPending = !isPaid;

decimal finalPrice = projectPrice;

Console.WriteLine($"Hatalı giriş:{hasInvalidInput} ");
Console.WriteLine($"Oncelikli proje: {isPriorityProject}");
Console.WriteLine($"Ödeme bekleniyor: {isPaymentPending}");

if (projectPrice>=5000m)
{
    Console.WriteLine($"{projectName}, büyük bir proje.");
}
else if (projectPrice>=1000m)
{
    Console.WriteLine($"{projectName}, orta büyüklükte bir proje");
}
else 
{
    Console.WriteLine($"{projectName} , küçük bir proje");
}

if (hasInvalidInput)
{
    Console.WriteLine("Hata: Fiyat ve teslim günü sıfırdan büyük olmalıdır.");
}
else if (deliveryDays <= 3)
{
    finalPrice = projectPrice * 1.20m;
    Console.WriteLine("Acil proje: Yüzde 20 ücret uygulandı.");
}
else if (deliveryDays >= 14)
{
    finalPrice = projectPrice * 0.90m;
    Console.WriteLine("Uzun teslim süresi: Yüzde 10 indirim uygulandı.");
}
else 
{
    Console.WriteLine("Standart fiyat uygulandı.");
}

if (isPriorityProject)
{
    Console.WriteLine("Bu proje öncelikli projedir.");
}

if (isPaymentPending)
{
    Console.WriteLine("Uyarı: ödeme bekleniyor.");
}

Console.WriteLine($"Son fiyat: {finalPrice} TL");

