using System.Linq;

List<Project> projects = new List<Project>
{
    new Project("Web sitesi", 3500m),
    new Project("Logo tasarımı", 750m),
    new Project("Stok takibi", 5000m),
    new Project("Hata düzeltme", 500m),
    new Project("API geliştirme", 4000m)
};

List<Project> selectedProjects = projects
    .Where(project => project.Price >= 1000m)
    .OrderBy(project => project.Price)
    .ToList();

Console.WriteLine("1000 TL ve üzerindeki projeler:");

foreach (Project project in selectedProjects)
{
    Console.WriteLine($"{project.Name}: {project.Price} TL");
}

decimal totalPrice = selectedProjects.Sum(project => project.Price);

Console.WriteLine($"Seçilen projelerin toplamı: {totalPrice} TL");

Project? foundProject = projects.FirstOrDefault(
    project => project.Name == "Stok takibi"
);

if (foundProject is not null)
{
    Console.WriteLine($"Bulunan proje: {foundProject.Name}");
    Console.WriteLine($"Fiyatı: {foundProject.Price} TL");
}
else
{
    Console.WriteLine("Aranan proje bulunamadı.");
}

Project? missingProject = projects.FirstOrDefault(
    project => project.Name == "Mobil oyun"
);

if (missingProject is not null)
{
    Console.WriteLine($"Bulunan proje: {missingProject.Name}");
}
else
{
    Console.WriteLine("Mobil oyun isimli proje bulunamadı.");
}

class Project
{
    public string Name { get; }
    public decimal Price { get; }

    public Project(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}