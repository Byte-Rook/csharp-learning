# 2. Hafta — Ders08–14

Bu bölümde sınıflarla veri modelleme, kontrollü değişiklikler,
liste sorgulama ve kalıcı dosya kaydı üzerinde çalışılmıştır.

## Dersler

| Ders | Odak | Örnek davranış |
| --- | --- | --- |
| Lesson08 | Sınıf ve nesne | Proje bilgilerini nesneler ve listeler içinde tutma |
| Lesson09 | Kapsülleme | Negatif fiyat ve çalışma saati değişikliklerini reddetme |
| Lesson10 | Kalıtım ve interface | Standart ve acil projelerde farklı fiyat hesabı |
| Lesson11 | Hata yönetimi | Geçersiz sayı girişlerini ele alma |
| Lesson12 | LINQ | Projeleri filtreleme, sıralama, arama ve toplama |
| Lesson13 | JSON | Listeyi dosyaya yazma ve yeniden yükleme |
| Lesson14 | Birleşik uygulama | Menü üzerinden proje ekleme, listeleme ve kazanç özeti |

## Birleşik Örnek: Freelance Project Tracker

Lesson14, önceki kavramları tek bir konsol uygulamasında birleştirir:

- Proje adı ve fiyatı alma
- Boş ad ve geçersiz fiyat kontrolü
- Projeleri fiyata göre listeleme
- Toplam fiyat, %15 komisyon ve net kazanç hesabı
- JSON dosyasına kayıt ve yeniden yükleme
- Dosya işlemlerindeki hataları kullanıcıya bildirme

## Çalıştırma

Depo kökünden:

```bash
dotnet run --project Lesson14
```

## Doğrulama Senaryoları

- Boş proje adı reddedilmelidir.
- Sayıya çevrilemeyen ve negatif fiyatlar reddedilmelidir.
- Yalnızca 3500 ve 5000 fiyatlı iki proje varsa toplam 8500,
  komisyon 1275, net kazanç 7225 olmalıdır.
- Program yeniden açıldığında kaydedilen projeler yüklenmelidir.
- Bozuk JSON dosyası okunamadığında boş verilerle üzerine yazılmamalıdır.

Bu maddeler beklenen davranışlardır; otomatik test raporu değildir.
