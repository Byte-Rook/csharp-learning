Console.WriteLine("Lütfen Projenin ismini griniz :");
string projectName = Console.ReadLine();

Console.WriteLine("Lütfen çalışma süresini tam sayı olarak giriniz ");
int hours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen saatlik çalışma ücretinizi giriniz");
decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Lütfen ek masrafı giriniz ");
decimal extraCost = Convert.ToDecimal(Console.ReadLine());

decimal commissionRate = 0.10m;
 
decimal totalPrice  = hours * hourlyRate + extraCost ;

decimal commissionAmount = totalPrice * commissionRate;

decimal netEarning = totalPrice - commissionAmount;

bool isLargeProject = totalPrice >= 1000m;

Console.WriteLine($"{projectName}, toplam fiyat: {totalPrice} TL");
Console.WriteLine($"{projectName}, komisyon tutarı: {commissionAmount} TL");
Console.WriteLine($"{projectName}, net kazanç: {netEarning} TL");
Console.WriteLine($"büyük proje mi: {isLargeProject}");
