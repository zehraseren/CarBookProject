## ✨Mediator tasarım deseni nedir?
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
