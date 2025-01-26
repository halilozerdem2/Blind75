

Hedefimiz, her bir eleman için o eleman hariç tüm elemanların çarpımını O(n) time complexity ile hesaplamak. 
Bölme işlemi kullanmadan ve O(n) zaman karmaşıklığında çözüme ulaşmak için aşağıdaki adımları takip edebiliriz.

Temel Kavramlar:
Prefix Çarpımı (Önceki Çarpımlar): Her bir elemanın solundaki tüm elemanların çarpımı.
Suffix Çarpımı (Sonraki Çarpımlar): Her bir elemanın sağındaki tüm elemanların çarpımı.
Her bir eleman i için hesaplama şöyle yapılabilir:

i indeksinin solundaki tüm elemanların çarpımını hesaplayarak prefix çarpımını bulabiliriz.
i indeksinin sağındaki tüm elemanların çarpımını hesaplayarak suffix çarpımını bulabiliriz. Sonrasında, 
i'nin sonucu şu şekilde bulunur:


result[i] = prefix[i] * suffix[i].

Adım 1: Prefix çarpımını hesaplamak:
Diziyi soldan sağa doğru tarayarak her bir elemanın önündeki tüm elemanların çarpımını tutuyoruz.

Adım 2: Suffix çarpımını hesaplamak:
Diziyi sağdan sola doğru tarayarak her bir elemanın sonundaki tüm elemanların çarpımını tutuyoruz.

Adım 3: Sonuçları hesaplamak:
Prefix ve suffix çarpımlarını birleştirerek her bir elemanın sonucu hesaplanır.


Prefix ve suffix dizileri, sorunu iki basit alt probleme ayırmamıza yardımcı olur (soldaki çarpım ve sağdaki çarpım).
Diziyi iki kez geçerek (bir kez soldan sağa, bir kez sağdan sola), O(n) zaman karmaşıklığına ulaşırız ve ekstra space 
kullanımı yalnızca sonuç dizisi için gereklidir.