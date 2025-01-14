# 👩🏼‍💻 CARBOOK PROJESİ (.NET CORE 8.0 ONION ARCHITECTURE)

Bu repository, Murat Yücedağ'ın [.Net Core 8.0 Onion Architecture ile BookCar Projesi](https://www.udemy.com/course/aspnet-core-api-8-onion-architecture-ile-bookcar-projesi/) udemy kursundaki eğitim sürecimde geliştirdiğim CarBook Projesini içermektedir. Bu proje, kurs sırasında öğrendiğim konseptlerin pratik bir uygulaması olarak hazırlanmıştır.

***

## 🎯 Proje Hakkında
CarBook, araç kiralama ve yönetim sürecini aşağıdaki özelliklerle kolaylaştırır:
+ `Araç ve kullanıcı yönetimi:` Kullanıcılar araçları kiralayabilir, iade edebilir.
+ `Gerçek zamanlı bildirimler:` SignalR ile araç durumu güncellemeleri.
+ `Modern tasarım ve kolay kullanım:` Kullanıcı dostu bir arayüz.

***
### Ana Sayfa
![Ekran görüntüsü 2025-01-14 204316](https://github.com/user-attachments/assets/b5e8a439-7d11-42ae-9cfa-8a7b507246b1)

### Araç Kiralama Paneli
![Ekran görüntüsü 2025-01-14 215422](https://github.com/user-attachments/assets/cc3366df-6bdf-4f84-b371-501a92213250)

### Admin Paneli
![Ekran görüntüsü 2025-01-14 213657](https://github.com/user-attachments/assets/c138b00f-930d-4193-8839-fcfde1ed1436)
![Ekran görüntüsü 2025-01-14 213710](https://github.com/user-attachments/assets/5c00d65f-7595-48cd-b81f-0a62eb6bc032)

### Veritabanı Diyagramı
![Ekran görüntüsü 2025-01-14 214435](https://github.com/user-attachments/assets/e7ab8368-664f-43f2-802d-e6343e044f37)

## 🛠️ Kullanılan Teknolojiler

- **ASP.NET Core 8**
- **Entity Framework Core**
- **MS SQL Server**
- **SignalR**
- **JWT (Json Web Token)**
- **CQRS Pattern**
- **Mediator Pattern**
- **Repository**
- **FluentValidation**

## 📂 Proje Yapısı
```
CarBook
├── Core
│   ├── Application
│   │   ├── Container        | # DI (Dependency Injection) container, uygulama bağımlılıklarının yönetimi
│   │   ├── Dtos             | # Veri Transfer Objeleri (DTO), veri iletimini kolaylaştırır
│   │   ├── Enums            | #  Enum'lar, projede kullanılan sabit değerler (örneğin: PricingType)
│   │   ├── Features         | # CQRS, Mediator ve Repository gibi özellikler
│   │   ├── Interfaces       | # Uygulamanın servis ve repository arayüzleri
│   │   ├── Services         | # İş mantığı servisleri, örneğin araç kiralama hizmetleri
│   │   ├── Tools            | # Yardımcı araçlar ve yardımcı sınıflar
│   │   ├── Validator        | # Veritabanı ve DTO doğrulama işlemleri
│   │   ├── ViewModels       | # ViewModel sınıfları
│   ├── Domain
│   │   ├── Entities         | # # Entity sınıfları (Car, Brand, CarPricing vb.)
├── FrontEnds
│   ├── Dto                  | # Frontend için kullanılan DTO'lar, verinin frontend'e aktarımı
│   ├── WebUI                | # Web UI katmanı: Areas, Controller, Models, ViewComponents, Views
├── Infrastructure
│   ├── Persistance          | # Veritabanı işlemleri: DbContext, Migrations, Repositories
├── Prensentation
│   ├── WebApi               | # API Katmanı, API Controller, SignalR Hub
```

## 🌟 Özellikler
+ JWT tabanlı güvenli kimlik doğrulama.
+ SignalR ile gerçek zamanlı araç güncellemeleri.
+ DTO ve FluentValidation ile sadeleştirilmiş veri doğrulama.
+ SQL Pivot Table ile detaylı veri raporlamaları.
