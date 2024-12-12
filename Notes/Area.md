## ✨UI katmanında Area nedir?
ASP.NET Core uygulamalarında Area, özellikle `UI (User Interface)` katmanında büyük ve karmaşık projelerde modülerlik ve organizasyon sağlamak için kullanılan bir özelliktir. Area'lar, uygulamanın farklı bölümlerini veya modüllerini mantıksal olarak gruplandırmak için kullanılır.

## ✨Area nedir?
Area, bir ASP.NET Core uygulamasındaki `controller`, `view` ve `model` gibi bileşenlerin belirli bir grup altında organize edilmesini sağlar. Bu sayede uygulamanın farklı bölümleri birbirinden bağımsız bir şekilde yönetebilir ve geliştirme süreci kolaylaşır.

#### 🟠Örnek Adım Senaryoları
1. Amdin ve Kullanıcı Arayüzü Ayrımı
+ Admin panelleri için ayrı bir area oluşturulabilir (`Admin` area).
+ Kullanıcı arayüzü için ise varsayılan alan kullanılabilir.

2. Büyük Modüler Projeler
+ E-ticaret projelerinde `Products`, `Orders`, `Customers` gibi her modül için ayrı bir area kullanılabilir.

#### 🟡 Area Yapılandırması
Bir area oluşturmak için birkaç basit adım aşağıdaki gibidir.

1. Area Dizini Oluşturma
Projedeki bir `Area` klasörü oluşturulur. Daha sonra her area için bir alt klasör oluşturulur.
###### Örnek:
```
Areas/
    Admin/
        Controllers/
        Views/
        Models/
    User/
        Controllers/
        Views/
        Models/
```

2. Controller Tanımlama
Controller'lar ilgil area altında tanımlanır.
###### Örnek:
```
// Areas/Admin/Controllers/HomeController.cs
[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
```

3. View Dosyalarını Düzenleme
Her area'nın kendi `Views` klasörü vardır.
###### Örneğin:
```
Areas/
    Admin/
        Views/
            Home/
                Index.cshtml
```

4. Razor View Çağırımı
```
<a asp-area="Admin" asp-controller="Home" asp-action="Index">Admin Paneli</a>
```

5. Routing Ayarları
ASP.NET Core, area'ları destekleyen bir routing mekanizmasına sahiptir. `Startup.cs` veya `Program.cs` dosyasında area destekleyen rotaların eklenmelidir.
```
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
```

#### 🟢Area'ların Avantajları
1. `Modülerlik:` Kodun farklı bölümlerini mantıksal olarak ayırarak daha düzenli bir yapı sağlar.
2. `Bağımsızlık:` Farklı ekipler veya geliştiriciler aynı projede çalışırken alanlar birbirinden bağımsız yönetebilir.
3. `URL Düzeni:` Alanlar, uygulamada daha anlaşılır URL yapıları sağlar.
###### Örnek:
```
/Admin/Home/Index
/User/Profile/Details
```

#### 🔴Area'ların Dezavantajları
1. `Ekstra Karmaşıklık:` Küçük projelerde area kullanımı gereksiz bir yapı karmaşıklığı oluşturabilir.
2. `Bağımlılık Yönetimi:` Farklı area'lar arasında ortak bir kod paylaşımı gerekiyorsa, bu süreç ek bir çaba gerektirebilir.

##### 📌Sonuç olarak, `Area`, özellikle büyük ve modüler projelerde kod organizasyonu ve bağımsız geliştirme açısından önemli bir kolaylık sağlar. Ancak küçük projelerde gereksiz bir yapı karmaşıklığı yaratabileceğinden dikkatli kullanılmalıdır. Area'ları projede kullanarak hem ekip çalışmasını kolaylaştırabilir hem de daha düzenli bir kod yapısı elde edilebilir.
