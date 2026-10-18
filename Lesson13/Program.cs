using System.Text.Json;

string filePath = Path.Combine(AppContext.BaseDirectory, "projects.json");

List<Project> projects;

try
{
    if (File.Exists(filePath))
    {
        string json = File.ReadAllText(filePath);

        projects = JsonSerializer.Deserialize<List<Project>>(json)
            ?? new List<Project>();

        Console.WriteLine("Projeler dosyadan yüklendi.");
    }
    else
    {
        projects = new List<Project>
        {
            new Project { Name = "Web sitesi", Price = 3500m },
            new Project { Name = "Stok takibi", Price = 5000m }
        };

        Console.WriteLine("İlk kullanım için örnek projeler oluşturuldu.");
    }

    Console.WriteLine("Kayıtlı projeler:");

    foreach (Project project in projects)
    {
        Console.WriteLine($"{project.Name}: {project.Price} TL");
    }

    Console.WriteLine("Yeni proje adı giriniz. Eklememek için Enter'a basınız:");

    string projectName = (Console.ReadLine() ?? "").Trim();

    if (projectName != "")
    {
        decimal price;

        while (true)
        {
            Console.WriteLine("Proje fiyatını giriniz:");

            string priceAnswer = Console.ReadLine() ?? "";

            if (!decimal.TryParse(priceAnswer, out price))
            {
                Console.WriteLine("Geçerli bir sayı girmelisiniz.");
                continue;
            }

            if (price < 0m)
            {
                Console.WriteLine("Fiyat negatif olamaz.");
                continue;
            }

            break;
        }

        projects.Add(new Project
        {
            Name = projectName,
            Price = price
        });

        Console.WriteLine("Yeni proje listeye eklendi.");
    }

    JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    string updatedJson = JsonSerializer.Serialize(projects, options);

    File.WriteAllText(filePath, updatedJson);

    Console.WriteLine("Projeler dosyaya kaydedildi.");
    Console.WriteLine($"Toplam proje sayısı: {projects.Count}");
    Console.WriteLine($"Dosya konumu: {filePath}");
}
catch (JsonException)
{
    Console.WriteLine("JSON dosyası okunamadı. Dosyanın biçimini kontrol edin.");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Dosyaya erişim izni bulunmuyor.");
}
catch (IOException)
{
    Console.WriteLine("Dosya okunurken veya yazılırken bir sorun oluştu.");
}

class Project
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}