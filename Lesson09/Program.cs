Project project = new Project(3500m, 20);

project.ChangePrice(4000m);
project.ChangeHours(25);

project.ChangePrice(-500m);
project.ChangeHours(-10);

Console.WriteLine($"Proje fiyatı: {project.Price} TL");
Console.WriteLine($"Çalışma süresi: {project.Hours} saat");

class Project
{
    private decimal price;
    private int hours;

    public Project(decimal initialPrice, int initialHours)
    {
        Price = initialPrice;
        Hours = initialHours;
    }

    public decimal Price
    {
        get
        {
            return price;
        }

        private set
        {
            if (value < 0m)
            {
                Console.WriteLine("Fiyat negatif olamaz.");
                return;
            }

            price = value;
        }
    }

    public int Hours
    {
        get
        {
            return hours;
        }

        private set
        {
            if (value < 0)
            {
                Console.WriteLine("Çalışma saati negatif olamaz.");
                return;
            }

            hours = value;
        }
    }

    public void ChangePrice(decimal newPrice)
    {
        Price = newPrice;
    }

    public void ChangeHours(int newHours)
    {
        Hours = newHours;
    }
}