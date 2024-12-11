## ✨Dependency Injection (DI) nedir?
Dependency Injection, bir sınıfın ihtiyaç duyduğu bağımlılıkları dışarıdan sağlama yöntemidir. Bu tasarım deseni, kodun daha esnek, modüler ve test edilebilir olmasını sağlar.

#### ⚜️Prensipler ve Amaçlar
1. `Bağımlılıkların Merkezi Yönetimi:` Bir sınıfın ihtiyaç duyduğu bağımlılıkları manuel olarak oluşturmak yerine dışarıdan sağlayarak daha temiz ve kolay yönetilebilir kod yazılır.
2. `Bağımlılıklar Arasındaki Gevşek Bağlılık:` Sınıflar birbiriyle sıkı sıkıya bağlı olmadığı için kod daha kolay genişletilebilir.
3. `Test Edilebilirlik:` Mock veya stub bağımlılık kullanarak birim test yazmaya kolaylaştırır.

#### 🟡ASP.NET Core’da Kullanımı
1. Bağımlılığın Tanımlanması (Program.cs)
```
builder.Services.AddScoped<IMyService, MyService>();
```
+ `AddScoped:` Her istek için bir örnek oluşturur.
+ `AddTransient:` Her kullanımda yeni bir örnek oluşturur.
+ `AddSignleton:` Uygulama boyunca tek bir örnek olışturur.

2. Bağımlılığın Enjekte Edilmesi (Constructor Injection)
```
public class HomeController
{
    private readonly IMyService _myService;

    public HomeController(IMyService myService)
    {
        _myService = myService;
    }

    public IActionResult Index()
    {
        var data = _myService.GetData();
        return View(data);
    }
}
```

#### 🟠Avantajları
1. `Kolay Genişletilebilirlik:` Yeni bağımlılıklar eklendiğinde kod minimum değişiklikler çalışır.
2. `Test Edilebilirlik:` Kodun bağımlılıkları kolayca mock'lanabilir.
3. `Yüksek Modülerlik:` Farklı katmanlardaki bileşenlerin bağımsız çalışmasını sağlar.

#### 🟣Dezavantajları
1. `Başlangıç Karmaşıklığı:` DI kavramını anlamak ve yapılandırmak başlangıçta zor olabilir.
2. `Performans Maliyeti:` Bazı durumlarda bağımlılıkları sürekli oluşturmak sistem üzerinde yük oluşturabilir.

##### 📌Dependency Injection, yazılım geliştirme sürecinde modülerlik ve test edilebilirlik sağlarken, ASP.NET Core gibi modern frameworklerde yaygın bir standart haline gelmiştir.
