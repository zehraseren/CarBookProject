## ✨ViewComponent / ComponentPartial Nedir?
ASP.NET Core'da kullanılan `ViewComponent` ve `ComponentPartial`, uygulamalarda yeniden kullanılabilir ve modüler arayüz bileşenleri oluşturmak için geliştirilmiştir.

#### ⚜️ViewComponent nedir?
+ Razor tabanlı dinamik bileşenler oluşturmak için kullanılır.
+ Veri işleme ve iş mantığını içerebilir. 
##### Örnek: Kullanıcı paneli, sepet özeti, son haberler bileşeni.

###### 1. ViewComponent Class
```
public class LatestNewsViewComponent : ViewComponent
{
    private readonly INewsService _newsService;

    public LatestNewsViewComponent(INewsService newsService)
    {
        _newsService = newsService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var news = await _newsService.GetLatestNews();
        return View(news);
    }
}
```

###### 2. Razor View Çağrım
```
@await Component.InvokeAsync("LatestNews")
```

#### ⚜️ComponentPartial nedir?
+ Daha basit, statik veya minimal dinamik gereksinimleri olan içeriklerde kullanılır.
+ Veri işleme gerektirmez veya çok az gerektirir.
##### Örnek: Sabit menü, footer ya da banner alanları.

###### 1. Partial View
```
<!-- _MenuPartial.cshtml -->
<ul>
    <li><a href="/home">Anasayfa</a></li>
    <li><a href="/about">Hakkımızda</a></li>
</ul>
```

###### 2. Razor View Çağrımı
```
@Html.Partial("_MenuPartial")
```

#### 🟠 Farkları
|Özellik|ViewComponent|ComponentPartial|
|-------|-------------|----------------|
|Kullanım Amacı|Dinamik veri ve iş mantığı içerir.|Statik veya az veri işleme gerektirir.|
|Controller Mantığı|Sahiptir (ViewComponent sınıfı içinde).|Yoktur.|
|Performans|Daha ağır ve güçlüdür.|Daha hafif ve basittir.|

#### ⚜️Razor tabanlı dinamik bileşenler nedir?
Razor tabanlı dinamik bileşenler, ASP.NET Core'da `ViewComponent` ve `ComponentPartial` gibi yapıların kullanılarak tekrar kullanılabilir, modüler ve dinamik içerikler oluşturulmasını sağlar.

##### Kısaca
+ `ViewComponent:` Controller'dan bağımsız çalışan ve bir görüünümün belirli bir kısmını işlemek için kullanılan küçük, dinamik bir bileşendir. Örneğin, `Son Blog Yazıları` ve `Kullanıcı Bildirimleri`.
+ `ComponentPartial:` Razor sayfalarında veya View'da kullanılan, HTML ve C# kodlarının bir arada bulunduğu tekrar kullanılabilir parçalardır.

#### 🟢Kullanım Alanları
1. `Tekrar Kullanılabilirlik:` Aynı bileşen farklı sayfalardan tekrar tekrar kullanılabilir.
2. `Dinamik Veri Çekme:` Belirli bir veriyi çekerek dinamik olarak görsel oluşturur.
3. `Kod Organizasyonu:` Sayfa içeriği daha güvenli ve modüler hale gelir.

##### 📌Özetle bu bileşenler, sayfa içeriğini bölmek ve dinamik olarka yönetmek için kullanılır.
