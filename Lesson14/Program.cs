using System.Linq;
using System.Text.Json;

string dataDirectory = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
    "FreelanceCourse",
    "Lesson14"
);

string filePath = Path.Combine(dataDirectory, "projects.json");

List<Project> projects;

try
{
    Directory.CreateDirectory(dataDirectory);

    projects = File.Exists(filePath)
        ? JsonSerializer.Deserialize<List<Project>>(
            File.ReadAllText(filePath)
        ) ?? new List<Project>()
        : new List<Project>();

    if (projects.Any(project =>
        project is null ||
        string.IsNullOrWhiteSpace(project.Name) ||
        project.Price < 0m))
    {
        Console.WriteLine("Dosyada geçersiz proje bilgileri var.");
        return;
    }
}
catch (JsonException)
{
    Console.WriteLine("Kayıt dosyasının JSON biçimi bozuk.");
    return;
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Kayıt klasörüne erişim izni yok.");
    return;
}
catch (IOException)
{
    Console.WriteLine("Kayıt dosyası açılamadı.");
    return;
}

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Proje ekle");
    Console.WriteLine("2 - Projeleri listele");
    Console.WriteLine("3 - Kazanç özetini göster");
    Console.WriteLine("0 - Çıkış");

    string choice = Console.ReadLine() ?? "";

    if (choice == "0")
    {
        break;
    }

    switch (choice)
    {
        case "1":
        {
            Console.WriteLine("Proje adını giriniz:");

            string name = (Console.ReadLine() ?? "").Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Proje adı boş olamaz.");
                break;
            }

            Console.WriteLine("Proje fiyatını giriniz:");

            if (!decimal.TryParse(Console.ReadLine(), out decimal price)
                || price < 0m)
            {
                Console.WriteLine("Geçerli ve negatif olmayan bir fiyat giriniz.");
                break;
            }

            Project newProject = new Project
            {
                Name = name,
                Price = price
            };

            List<Project> updatedProjects = projects.ToList();
            updatedProjects.Add(newProject);

            if (SaveProjects(updatedProjects, filePath))
            {
                projects = updatedProjects;
                Console.WriteLine("Proje eklendi ve kaydedildi.");
            }

            break;
        }

        case "2":
        {
            if (projects.Count == 0)
            {
                Console.WriteLine("Henüz proje bulunmuyor.");
                break;
            }

            foreach (Project project in projects.OrderByDescending(
                project => project.Price))
            {
                Console.WriteLine($"{project.Name}: {project.Price:F2} TL");
            }

            break;
        }

        case "3":
        {
            decimal totalPrice = projects.Sum(project => project.Price);
            decimal commission = CalculateCommission(totalPrice, 0.15m);
            decimal netEarning = totalPrice - commission;

            Console.WriteLine($"Proje sayısı: {projects.Count}");
            Console.WriteLine($"Toplam fiyat: {totalPrice:F2} TL");
            Console.WriteLine($"Komisyon: {commission:F2} TL");
            Console.WriteLine($"Net kazanç: {netEarning:F2} TL");

            break;
        }

        default:
        {
            Console.WriteLine("Menüdeki seçeneklerden birini giriniz.");
            break;
        }
    }
}

Console.WriteLine("Program kapatıldı.");

decimal CalculateCommission(decimal totalPrice, decimal rate)
{
    return totalPrice * rate;
}

bool SaveProjects(List<Project> projects, string filePath)
{
    try
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(projects, options);

        File.WriteAllText(filePath, json);

        return true;
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("Dosyaya yazma izni yok. Proje eklenmedi.");
        return false;
    }
    catch (IOException)
    {
        Console.WriteLine("Dosya kaydedilemedi. Proje eklenmedi.");
        return false;
    }
}

class Project
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}