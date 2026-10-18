Client client = new Client("İlker", "Mavi Market");
Console.WriteLine($"Müşteri: {client.Name} | Şirket: {client.CompanyName}");
Project project = new Project("Web sitesi", 3000m);

Project secondProject = new Project("Stok takibi", 5000m);

project.Price += 500m;
List<Project> projects = new List<Project>();

projects.Add(project);
projects.Add(secondProject);
decimal totalPrice = 0m;

foreach (Project currentProject in projects)
{
    Console.WriteLine($"{currentProject.Name}: {currentProject.Price} TL");
    totalPrice += currentProject.Price;
}

Console.WriteLine($"Projelerin toplam fiyatı: {totalPrice} TL");
QuoteItem item = new QuoteItem("Sayfa tasarımı", 3, 1000m);
QuoteItem secondItem = new QuoteItem("Yayına alma", 1, 500m);

List<QuoteItem> quoteItems = new List<QuoteItem>();
quoteItems.Add(item);
quoteItems.Add(secondItem);

Console.WriteLine($"Teklif: {client.CompanyName} | Proje: {project.Name}");

decimal quoteTotal = 0m;

foreach (QuoteItem currentItem in quoteItems)
{
    decimal lineTotal = currentItem.CalculateTotal();
    Console.WriteLine($"{currentItem.Name}: {lineTotal} TL");
    quoteTotal += lineTotal;
}

Console.WriteLine($"Teklif toplamı: {quoteTotal} TL");
class Project
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public Project(string name, decimal price)
{
    Name = name;
    Price = price;
}
}




class Client
{
    public string Name { get; set; }
    public string CompanyName { get; set; }

    public Client(string name, string companyName)
    {
        Name = name;
        CompanyName = companyName;
    }
}
class QuoteItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public QuoteItem(string name, int quantity, decimal unitPrice)
    {
        Name = name;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public decimal CalculateTotal()
    {
        return Quantity * UnitPrice;
    }
}