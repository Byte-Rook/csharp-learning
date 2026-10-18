# Freelance Project Tracker

C# ve .NET ile hazırlanmış, yerel dosyada veri saklayan konsol uygulaması.

## Özellikler

- Proje ekleme ve giriş doğrulama
- Projeleri fiyata göre azalan sırada listeleme
- Toplam fiyat, %15 komisyon ve net kazanç hesabı
- JSON dosyasına kayıt ve dosyadan yükleme
- Dosya erişim hatalarını ele alma

## Çalıştırma

Proje hedefiyle uyumlu .NET SDK kurulmalıdır.

Depo kökünden:

```bash
dotnet run --project Lesson14
```

## Menü

| Seçenek | İşlem |
| --- | --- |
| 1 | Proje ekle |
| 2 | Projeleri listele |
| 3 | Kazanç özetini göster |
| 0 | Çıkış |

Ondalıklı fiyat girişleri bilgisayarın sayı biçimine göre yorumlanır.

## Veri Kaydı

Kayıt dosyası, kullanıcının `LocalApplicationData` konumu altında
`FreelanceCourse/Lesson14/projects.json` yolunda tutulur.
Bu dosya kaynak kod klasöründen ayrıdır.

## Sınırlar

Tek kullanıcılı bir eğitim uygulamasıdır. Proje düzenleme, silme,
kullanıcı hesabı ve eş zamanlı erişim desteği içermez.
Dosyaya yazma işlemi kesintiye karşı atomik kayıt garantisi sunmaz.
