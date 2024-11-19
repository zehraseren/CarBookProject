## ✨Onion Architecture nedir?
Onion Architecture, uygulamaların katmanlı ve bağımsız bir yapıda geliştirilmesini sağlayan bir yazılım mimarisidir. `Bu mimari, uygulama kodlarını birbirinden izole ederek bağımlılıkları en aza indirmeyi hedefler.` .NET Core ile sıkça kullanılan Onion Architecture, özellikle büyük ve karmaşık projelerde esneklik ve sürdürülebilirlik sağlar.

#### ⚜️Temel olarak, Onion Architecture şu katmanlardan oluşur:
1. Core Layer | Domain Katmanı: Uygulamanın temel mantığını ve temek varlıkları (entity) içerir. Bu katmanda yalnızca domain sınıfları, arayüzler ve servisler yer alır. Dış katmanlara bağımlı değildir, bu da uygulamanın çekirdeğini korumaya yardımcı olur.
> Entities (varlıklar), Value Objects, Interfaces yer alır.

2. Application Layer | Uygulama Katmanı: İş mantığının gerçekleştirildiği, servislerin ve arayüzlerin uygulandığı katmandır. Core katmanını kullanır ancak dış katmanlardan bağımsızdır. Bu katmanda iş akışları ve gerekli işlemler yönetilebilir.
> Repository Interface’leri tanımlanır.

3. Infrastructure Layer | Altyapı Katmanı: Veritabanı erişimi, dış servislerde entegrasyon ve diğer uygulama dışı kaynaklarla iletişimi sağlar. `Dependency Injection (bağımmlılık enjeksiyonu)` kullanarak, altyapı katmanındaki bağımlılıkların üst katmanlara aktarılmasını sağlar.
> Repository Implementations burada bulunur.

4. Prensentation Layer | Sunum Katmanı: API veya UI katmanı olarak işlev gören, kullanıcı arayüzünü veya dış dünyaya sunulan API'yı barındırır. Altyapı katmanına bağımlıdır ve kullanıcı etkileşimlerini yönetir.
> Controller veya View bileşenleri yer alır.

##### 📌Bu mimari, bağımlılıkların merkezden dış katmanlara doğru ilerlediği bir yapıdadır. Böylece iç katmanlarda yapılan değişiklikler dış katmanları daha az etkiler, test edilebilirliği ve bakımı kolaylaştırır.

#### 🟠Avantajları
+ `Bağımlılıklar tersine çevrilir:` İş mantığı, altyapıya bağımlı olmaz.
+ `Test edilebilirlik:` Merkezdeki iş mantığı, altyapı bağımlılıkları olmadan kolayca test edilebilir.
+ `Esneklik:` Dış katmanlarda kullanılan teknolojiler kolayca değiştirilebilir (ör. farklı bir veritabanına geçiş).
+ `Uzun ömürlü uygulamalar:` Mimari, yeni teknolojilere uyum sağlar.

#### 🟡Neden tercih edilmeli?
+ Karmaşık iş kuralları olan projelerde bağımlılığı yönetmek için.
+ Yüksek modülerlik ve test edilebilirlik sağlamak için.
+ Teknoloji bağımlılığını azaltarak uzun vadeli uygulama geliştirme için.

##### 📌Kısacası, Onion Architecture, "iş mantığını kral yap" felsefesini takip eden bir mimari desendir.
