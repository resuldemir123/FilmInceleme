# Film İnceleme Uygulaması

Bu proje, kullanıcıların filmler hakkında inceleme yapmasını sağlayan bir ASP.NET Core MVC uygulamasıdır.

## Özellikler
- Kullanıcılar film ekleyebilir, silebilir ve güncelleyebilir.
- Film incelemeleri eklenebilir ve görüntülenebilir.
- Kullanıcı kimlik doğrulama ve yetkilendirme sistemi.
- Responsive tasarım ile mobil uyumluluk.

## Kullanılan Teknolojiler
- **Backend**: ASP.NET Core MVC, Entity Framework Core
- **Frontend**: Razor Pages, Bootstrap, jQuery
- **Veritabanı**: SQL Server

## Kurulum ve Çalıştırma
1. **Depoyu Klonlayın:**
   ```sh
   git clone <repository-url>
   cd FilmInceleme
   ```
2. **Bağımlılıkları Yükleyin:**
   ```sh
   dotnet restore
   ```
3. **Veritabanını Güncelleyin:**
   ```sh
   dotnet ef database update
   ```
4. **Uygulamayı Çalıştırın:**
   ```sh
   dotnet run
   ```

## Klasör Yapısı
- `Controllers/` - MVC controller dosyaları.
- `Models/` - Veritabanı modelleri.
- `Views/` - Razor View dosyaları.
- `wwwroot/` - Statik dosyalar (CSS, JS, img).
- `Data/` - Veritabanı bağlamı ve göç dosyaları.

## Katkıda Bulunma
Projeye katkıda bulunmak için lütfen bir **pull request** oluşturun veya bir **issue** açın.

---
Bu proje eğitim amaçlı geliştirilmiştir.

