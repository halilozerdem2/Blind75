
İstenen problemin çözümü için kullanılması gereken yöntem Kadane algoritmasıdır

Kadane algoritması, bir dizideki ardışık alt diziler (subarray) arasından en büyük toplamı bulan etkili bir algoritmadır.
En iyi yanı, doğrusal zaman karmaşıklığı (𝑂(𝑛)
O(n)) ile çalışmasıdır, bu da onu çok büyük dizilerde bile oldukça hızlı bir çözüm yöntemi yapar.
Algoritmanın temel mantığı, diziyi baştan sona dolaşırken alt dizilerin toplamlarını dinamik bir 
şekilde hesaplamak ve negatif toplamları sıfırlayarak maksimum toplamı bulmaktır. Bu şekilde, gereksiz hesaplamalar 
ve tekrar eden işlemler önlenir.

Kadane algoritması, iki temel değişken kullanır:
    currentSum (Mevcut Toplam): O anki alt dizinin toplamını tutar.
    maxSum (En Büyük Toplam): Şu ana kadar bulunan en büyük toplamı tutar.

BASAMAKLAR
1) maxSum başlangıçta dizinin ilk elemanına ayarlanır (bu, en kötü durumda bile bir eleman dönebilmemizi sağlar).
2) currentSum başlangıçta 0'a ayarlanır ve her bir eleman diziyi dolaşırken buna eklenir.
3) Eğer currentSum, maxSum'den büyükse, maxSum güncellenir.
4) Eğer currentSum negatif bir değere düşerse, bu toplam sıfırlanır. Çünkü negatif bir toplam, yeni bir alt dizi başlatmak
   için uygun değildir.


   TEST CASE 1:
   Input: nums = [-2,1,-3,4,-1,2,1,-5,4]

   maxSum Default olarak ilk indexe atanır böylece her durumda bir değer döner

   Foreach 
    1. Döngüde                     
        currentSum= -2 // currentSum negatif değer olduğundna 0lanır
        maxSum= -2
    2. Döngüde 
        currentSum= 1
        maxSum= 1
    3. Döngüde 
        currentSum= 1+(-3)= -2 // currentSum negatif değer olduğundna 0lanır
        maxSum= 1
    4. Döngüde 
        currentSum= 0+4 =4 
        maxSum= 4
    5. Döngüde 
        currentSum= 4+(-1)= 3
        maxSum= 4
    6. Döngüde 
        currentSum= 3+2= 5
        maxSum= 5
    7. Döngüde 
        currentSum= 5+1=6
        maxSum= 6
    8. Döngüde 
        currentSum= 6
        maxSum= 6

    Özetle maxSum değeri negatif etkilenecekse currentSum değeri maxsuma eklenmez ve 
    böylece istenen en büyük alt dizi toplamı bulunmuş olur
    ----------------------------------------------------------------------------------------------------

    Divie And Conquer Approach

    Divide and Conquer (Böl ve Fethet), bir problemi daha küçük parçalara bölüp bu parçaları bağımsız olarak çözdükten sonra
    sonuçları birleştiren bir algoritma tasarım paradigmasıdır. Maksimum alt dizi toplamı problemini çözmek için Divide and Conquer yaklaşımı, 
    diziyi ortadan böler ve üç farklı alt dizi durumunu değerlendirir.

    Diziyi Böl (Divide):
        Diziyi ortadan iki alt diziye ayır (sol ve sağ).
        Ortadaki indeksi mid olarak belirle.
    Alt Dizi Toplamlarını Bul:
        Sol alt dizideki en büyük toplamı bul (maxLeft).
        Sağ alt dizideki en büyük toplamı bul (maxRight).
        Ortadan geçen (çapraz) alt dizideki en büyük toplamı bul (maxCross).
        Bu durumda, bir alt dizi hem sol hem de sağ alt diziyi kapsayabilir.
    Sonuçları Birleştir (Conquer):
        En büyük toplamı bulmak için şu üçünün maksimumunu al:
        Sol alt dizideki maksimum toplam (maxLeft).
        Sağ alt dizideki maksimum toplam (maxRight).
        Ortadan geçen çapraz alt dizideki maksimum toplam (maxCross).
    Rekürsif (Tekrarlı )İşlem:
        Sol ve sağ alt dizilerde aynı işlemleri tekrar et.
    Durdurma Kriteri:
        Eğer dizinin boyutu 1’e inerse, o elemanın kendisi alt dizinin toplamıdır.
------------------------------------------------------------------------------------------------------------------------
    Yorum: Her ne kadar böl ve fethet yaklaşımı kademeli çözüm ve bütünsel bakış açısından güzel bir yaklaşım da olsa iki sebepten ötürü
    bu problemin çözümü için en uygun yaklaşım olduğundan şüpheliyim. 

    1) Time Complexity: Birinci çözüm O(n) karmşıklığında iken istenen ikinci çözüm O(n log n) karmaşıklığındadır
    2) Uygulama zorluğu: Kadane Algoritması anlaması ve uygulaması kolay bir yaklaşım olup daha kısa sürede kodlanması mümkünken
        ikinci yöntemimizde Binary Search Tree yapısına benzer bir yaklaşım sergilenmekle beraber uygulaması daha uzun sürecektir.
    
    Fakat burada amaç "Code Challenge çözmek" olduğundan, bu yaklaşımı uygulamak algoritma kurma yeteneğinin gelişmesine olanak sağlar
    
