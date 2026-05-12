# Stok Kontrol Projesi

C# Windows Forms ile yazılmış, **PostgreSQL** veritabanı destekli çok kullanıcılı bir stok ve müşteri yönetim sistemi. **Yazılım Lab III (Yazlab_3)** dersi kapsamında geliştirilmiştir.

## Özellikler

- **Kullanıcı / Admin girişi**: rol bazlı erişim
- **Ürün yönetimi**: ekleme, listeleme, stok takibi
- **Müşteri yönetimi**: normal/premium müşteri tipleri, bütçe ve harcama takibi
- **Eş zamanlılık kontrolü**: admin işlem yaparken normal kullanıcıların engellenmesi
- **Test verisi üretimi**: rastgele müşteri ekleme (Form1)
- **Özel UI bileşenleri**: gradyan dolgulu `GradientGroupBox` gibi çizilmiş kontroller

## Teknolojiler

- **.NET Framework 4.7.2** + Windows Forms
- **PostgreSQL** (Npgsql sürücüsü ile)
- C#

## Form Yapısı

| Form | İşlev |
|------|-------|
| Form1 | Admin paneli, test verisi üretimi |
| Form2 | Kullanıcı ana paneli (admin durum kilidi ile) |
| Form3 | Ürün/Kullanıcı ekleme |
| Form4 | (yardımcı işlem ekranı) |
| Form5 | Giriş ekranı |
| Form6 | (yardımcı işlem ekranı) |
| Form11 | (ek panel) |

## Veritabanı

Varsayılan bağlantı (`Form1.cs`):

```
Host=localhost;Port=5432;Username=postgres;Password=1234;Database=SistemYonetim
```

### Tablolar (özet)
- `customer` — `customer_name`, `budget`, `customer_type` (normal/premium), `total_spent`
- (ek olarak ürün ve kullanıcı tabloları kod içinde kullanılır)

PostgreSQL'i kuruduktan sonra `SistemYonetim` veritabanını oluşturun ve ilgili tabloları manuel ekleyin; uygulama bağlantı dizisini Form1 üzerinden okur.

## Çalıştırma

1. Visual Studio'da `Yazlab_3_mu.sln` dosyasını açın
2. NuGet üzerinden **Npgsql** paketinin yüklü olduğundan emin olun
3. PostgreSQL'in çalıştığından ve bağlantı bilgilerinin doğru olduğundan emin olun
4. `F5` ile çalıştırın (başlangıç formu: giriş ekranı)

## Proje Yapısı

```
StockControlProject/.../Yazlab_3_mu/
├── Program.cs
├── Form1.cs ... Form11.cs       # Form mantığı
├── Form*.Designer.cs            # Form tasarımları
├── Properties/                  # AssemblyInfo, Resources, Settings
├── StockProject.csproj
└── Yazlab_3_mu.sln
```
