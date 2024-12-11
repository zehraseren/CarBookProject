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
