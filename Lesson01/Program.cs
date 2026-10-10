Console.Write("Adın: ");
string name = Console.ReadLine();

Console.Write("İş kaç saat sürecek?  ");
int hours = Convert.ToInt32(Console.ReadLine());

Console.Write("Saatlik ücret kaç TL? ");
int hourlyRate = Convert.ToInt32(Console.ReadLine());

Console.Write("Ek masraf kaç Tl?");
int extraCost = Convert.ToInt32(Console.ReadLine());

int totalPrice = hours * hourlyRate + extraCost ;

Console.WriteLine($"{name}, müşteriye verilecekteklif : {totalPrice} Tl");
 