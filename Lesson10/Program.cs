List<IPricedProject> projects = new List<IPricedProject>
{
    new StandardProject("Web sitesi", 3500m),
    new UrgentProject("Stok takibi", 5000m)
};

decimal totalPrice = 0m;

foreach (IPricedProject project in projects)
{
    decimal finalPrice = project.CalculatePrice();

    Console.WriteLine($"{project.Name}: {finalPrice} TL");

    totalPrice += finalPrice;
}

Console.WriteLine($"Genel toplam: {totalPrice} TL");

interface IPricedProject
{
    string Name { get; }
    decimal CalculatePrice();
}

abstract class Project : IPricedProject
{
    private decimal basePrice;

    public string Name { get; private set; }

    public decimal BasePrice
    {
        get
        {
            return basePrice;
        }

        private set
        {
            if (value < 0m)
            {
                Console.WriteLine("Fiyat negatif olamaz.");
                return;
            }

            basePrice = value;
        }
    }

    public Project(string name, decimal basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }

    public abstract decimal CalculatePrice();
}

class StandardProject : Project
{
    public StandardProject(string name, decimal basePrice)
        : base(name, basePrice)
    {
    }

    public override decimal CalculatePrice()
    {
        return BasePrice;
    }
}

class UrgentProject : Project
{
    public UrgentProject(string name, decimal basePrice)
        : base(name, basePrice)
    {
    }

    public override decimal CalculatePrice()
    {
        return BasePrice * 1.20m;
    }
}