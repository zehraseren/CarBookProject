✨Mediator tasarım deseni nedir?
Mediator tasarım deseni, nesneler arasındaki iletişimi merkezileştiren bir tasarım desenidir. Nesnelerin birbirleriyle doğrudan iletişim kurmasını engelleyerek, tüm etkileşimleri bir arabulucu (mediator) üzerinden gerçekleştirir. Bu, bağımlılıkları azaltır ve kodun yönetilebilirliğini artırır.

#### ⚜️Temel Prensipler
1. `Merkezileştirilmiş İletişim:` Tüm iletişimler mediator aracılığıyla gerçekleşir.
2. `Gevşek Bağlılık:` Nesneler birbiriyle doğrudan bağlantılı olmadığından, bağımlılık azalır.
3. `Daha Temiz Kod:` İletişim mantığı tek bir yerde toplanır.

#### 🟡Nasıl çalışır?
1. Bir komut veya sorgu meaditor aracılığyla gönderilir.
2. Meaditor, ilgili handler'ı (işleyici) çağırarak işlemi yürütür.
3. Sonuç döndürülür veya işlem tamamlanır.

#### 🟠Kullanım Alanları
+ `CQRS desenlerinde:` Komut ve sorgu işlemlerini yönlendirmek.
+ `UI bileşenlerinde:` Kullanıcı arayüzündeki etkileşimleri yönetmek.

##### 📌Mediator tasarım desene özellikle CQRS deseninde sıkça kullanılır. Mediator, komut (Command) ve sorgu (Query) işlemlerini yönetmek ve bu işlemleri ilgili işleyicilere (Handlers) yönlendirmek için kullanılır.

***

### CQRS ile Mediator Kullanımı
#### Mediator'un Kullanımı
+ CQRS desenindeü komutlar (Commands) ve sorgular (Queries), doğrudan işleyicilere (Handlers) gönderilmez.
+ Bunun yerine, Mediator aracılığıyla ilgili işleyiciler çağırılır.
+ Bu, işlemleri merkezileştirir ve sistemin daha gevşek bağlı (loosely coupled) olmasını sağlar.

#### 🟡Kullanım Alanları
1. Komut ve Sorguların İşlenmesi
+ `Komutlar | Commands:` Veritabanında değişiklik yapan işlemleri kapsar. Mediator, bu komutları ilgili `CommandHandler`'a yönlendirir.
  - Örnek: `AddProductCommand` → `AddProductCommandHandler`
+ `Sorgular | Queries:` Veritabanından veri okuma işlemlerini kapsar. Mediator, sorguları ile ilgili `QueryHandler`'a yönlendirir.
  - Örnek: `GetProductByIdQuery` → `GetProductByIdQueryHandler`

2. Controller ve Service Katmanlarnıda Karmaşıklığı Azaltmak
+ Mediator, işlemleri yönlendirdiği için controller veya service katmanındaki işlem yükü azalır.
+ Controller sadece Mediator'a mantığı Mediator ve ilgili işleyiciler tarafından yönetilir.

3. Katmanlar Arası İletişim
+ Özellikle büyük ve karmaşık projelerde, birden fazla katmanın birbiriyle iletişim kurması gerekebilir. Mediator, bu iletişimi düzenler ve bağımlılıkları azaltır.

4. Event-Driven Mimari
+ Mediator, bir olay (event) meydana geldiğinde bu olayı ilgili dinleyicilere (EventHandlers) iletmek için de kullanabilir.
+ Örnek: Bir sipariş tamamlandığında, bir `OrderCompletedEvent` tetiklenir ve Mediator bu olayı ilgili handler'lara yönlendirir.

#### 🟢Avantajlar
+ `Bağımlılıkları Azaltır:` Komut ve sorgular doğrudan işleyicilere bağlı değildir; Mediator araya girer.
+ `Modülerlik:` Her komut veya sorgu için ayrı bir işleyici kullanılır, bu da kodun modüler olmasını sağlar.
+ `Geliştirme Kolaylığı:` Yeni bir işlem eklemek için yalnızca yeni bir komut, sorgu ve işleyici yazmak yeterlidir.
+ `Test Edilebilirlik:` Komutlar ve sorgular bağımsız olarak test edilebilir.

##### 📌Mediator tasarım deseni, CQRS gibi desenlerde işlemleri yönlendiren bir orkestra görevi görür. Bu sayede sistem, daha temiz, yönetilebilir ve genişletilebilir hale gelir. Özellikle büyük projelerde kullanım avantajı sağlar.
