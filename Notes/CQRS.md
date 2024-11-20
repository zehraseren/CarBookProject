## ✨CQRS tasarım deseni nedir?
CQRS (Command Query Responsibility Segregation), bir uygulamanın okuma (query) ve yazma (command) işlemlerini birbirinden ayıran bir mimari desendir. Bu desen, hem veri modelini hem de iş mantığını iki farklı yapı olarak ele alır. Özellikle yüksek trafikli sistemlerde performansı artırmak, karmaşıklığı yönetmek ve ölçeklenebilirliği sağlamak için kullanılır.

#### ⚜️Detaylı Prensipler
1. Command | Yazma İşlemleri
+ Veritabanını değiştiren işlemleri kapsar (Create, Update, Delete).
+ Sadece işlem yapılır, veri döndürülmez.
  - Örnek: `AddProduct`, `UpdateUserProfile`, `DeleteOrder`

2. Query | Okuma İşlemleri
+ Veritabanından veri okumak için kullanılır (Read).
+ İşlemler yan etkisiz olmalıdır (yani veri tabanında değişiklik yapmamalıdır).
  - Örnek: `GetProductById`, `GetOrdersByCustomerId`

3. Ayrı Veri Modelleri
+ `Command:` Veri tabanını değiştirmek için gerekli olan detaylar.
+ `Query:` UI veya API’ye sunulacak veriye uygun, optimize edilmiş detaylar.
  - Örnek: Bir `Ürün` için yazma modelinde stok bilgisi gerekebilir; ancak okuma modelinde sadece ürün adı ve fiyat bilgisi yeterli olabilir.

#### 🟡Nasıl çalışır?
1. Command İş Akışı
+ Kullanıcı bir `komut` (Command) gönderir (ör. ürün ekleme).
+ Bu komut, bir `Command Handler` tarafından işlenir.
+ İş mantığı uygulanır ve veri tabanı güncellenir.

2. Query İş Akışı
+ Kullanıcı bir `sorgu` (Query) gönderir (ör. ürün listesini alma).
+ Bu sorgu, bir `Query Handler` tarafından işlenir.
+ Sorgunun sonucunda ilgili veri döndürülür.

#### 🟠Dosya ve Katman Yapısı
CQRS’te katmanlar genellikle şu şekilde organize edilir:
##### 1. Application Katmanı
+ Commands (Komutlar)
  - Örnek: `AddProductCommand`, `DeleteUserCommand`
  - `IRequest` veya `ICommand` arayüzünden üretilir.

+ Command Handlers (İşleyiciler)
  - Command işlemlerini yönetir.
  - Örnek: `AddProductCommandHandler`

+ Queires (Sorgular)
  - Örnek: `GetProductByIdQuery`, `GetAllOrdersQuery`
  - `IRequest` veya `IQuery` arayüzünden türetilir.

+ Query Handlers (İşleyiciler)
  - Query işlemlerini yönetir.
  - Örnek: `GetProductByIdQueryHandler`

##### 2. Domain Katmanı
+ İş kuralları ve domain varlıklarını içerir (örn. Entities, Value Object).

##### 3. Infrastructre Katmanı
+ Veritabanı ve harici servislerle iletişim kurar.
+ Repository implementasyonları burada yer alır.

##### 4. API veya UI Katmanı
+ Uygulamanın dış dünyaya açıldığı katman. Komutları ve sorguları gönderir.

#### 🔵Örnek Senaryo
###### Ürün Ekleme (Command)
1. Kullanıcı, API aracılığıyla bir ürün ekler (`AddProductCommand`).
2. `AddProductCommandHandler` iş mantığını uygular:
  - Ürünün benzersiz olduğunu konntrol eder.
  - Ürünü veritabanına ekler.
3. İşlem tamamlanır ve yanıt döndürülmez.

###### Ürün Listeleme (Query)
1. Kullanıcı, ürün listesini almak ister (`GetAllProductsQuery`).
2. `GetAllProductsQueryHandler` optimize edilmiş bir sorgu çalıştırır.
3. Sadece gerekli bilgiler döndürülür (örn. ürün adı ve fiyat).

#### 🟢Avantajları
1. Performans Artışı
  - Okuma ve yazma için farklı altyapılar veya veri modelleri kullanılabilir.
  - Sorgu işlemleri, yalnızca gerekli alanları döndürerek hızlandırılabilir.

2. Esneklik
  - Okuma ve yazma işlemleri bağımsız olduğu için ölçeklenebilirlik artılır.
  - Örneğin, okuma işlemleri için ayrı bir `read-only` veritabanı kullanılabilir.

3. Daha Temiz Kod
  - Sorgu ve yazma işlemleri ayrı ele alındığından kod karmaşası azalır.

4. Test Edilebilirlik
  - Komutlar ve sorgular izole olarak test edilebilir.

#### 🔴Dezavantajları
1. Ek Karmaşıklık: Küçük projelerde CQRS gereksiz yere karmaşık bir yapı oluşturabilir. 
2. Daha Fazla Kod ve Yönetimi: Okuma ve yazma için ayrı modellerin bakımı zor olabilir.

#### 🟣Kullanım Alanları
+ Büyük ve karmaşık sistemler (örn. e-ticaret, bankacılık uygulamaları).
+ Performans ve ölçeklenebilirlik gereksinimi olan projeler.
+ Okuma ve yazma operasyonlarının birbirinden çok farklı olduğu sistemler.

##### 📌Özetle, CQRS, işlemleri ayrıştırarak performans, esneklik ve kod organizasyonu sağlar; ancak sadece karmaşık sistemlerde uygulanması tavsiye edilir.
