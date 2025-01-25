

Given an integer array nums, return true if any value appears at least twice in the array,
and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true
Explanation:
The element 1 occurs at the indices 0 and 3.

Example 2:
Input: nums = [1,2,3,4]
Output: false
Explanation:
All elements are distinct.

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
---------------------------------------
Bu problemin çözümü için 3 farklı çözüm yöntemi uyguladım.
1) Brute Force
2) HashMap
3) Array Manipulation

1) Brute Force: 
    Array problemlerinin çözümünde aklan ilk gelen yöntem brute force approachtır. 
    Uygulama kolaylığı ve küçük veri setlerinde farkedilmeyen çalışma hızı farklarından dolayı uygulanabilirdir. 
    Fakat Time complexity O(n^2) olduğundan gerçek hayatta pek tercih edilen yöntemlerden değildir. 
    Yazılım geliştirme mülakatlarında genelde problemin çözümünün brute force yöntemiyle çözülmesi tercih edilmez.
   
    Time Complexity: O(n^2)
    Space Complexity: O(1)
    Artılar: Hızlı uygulama, küçük setlerde kullanılabilirlik ve basit ve anlaşılır kullanım
    Eksiler: Quadratic Time Complexity O(N^2)
--------------
2) HashMap: 
    Bilindiği üzere Hashmap veri yapısı elemanların bellekte tutulduğu bölgeleri referans ile tutarak veriye hızlı erişim sağlar O(1).
    Array de bir indexe ulaşmak her ne kadar index numarası ile mümkün olsa da, spesifik bir verinin o veri seti içerisinde aranması işlemini
    brute force dışında bir yapıyla yapamaz. Bu yüzden elimizdeki veriyi O(n) karmaşıklığıyla bir hashmape key olarak yükleriz.
    C# ta hashmap yapısını Dictionary ile kullanırız ve key value pair tanımlamasını bu şekilde yaparız.

    Bu sayede veriyi farklı bir sete aktarırken aynı zamanda eklenmek istenen elemanın o veri setinde olup olmadığının kontrolünü de O(1)
    karmaşıklığıyla sağlayabiliriz. 

    Bu yöntemin pek bir dezavantajı yoktur fakat bellekte refernsların (keylerin) tutulması bu veri yapısının Space complexityini O(n) 
    seviyesine çıkarabilmektedir.

    Time Complexity: O(n)
    Space Complexity: O(n)
    Artılar: Hızlı ve etkilili erişim
    Eksiler: Ekstra bellek kullanımı, Built in HashMap yok ise uygulama uzunluğu

    ---------------
3) Array Manipulation

    Bu yöntemin kullanılmasının en temel sebebi C# ve Java gibi nesne yönelimli dillerde Hashmap tanımlı olsada, JavaScript , C gibi 
    dillerde built in bir hashmap yapısı olmaz. Tabii ki kendi HashMapimizi yazabilir ve aynı yöntemi kullanabiliriz. Fakat bu problemin
    çözümü için daha kısa bir yöntem varsa uygulamak daha doğru olacaktır.

    Oluşturmamızı istenen fonksiyonda, tekrar eden elemanların index numaralarıyla bir işimiz olmadığı için bu arrayi sıralayabiliriz.
    Bu durumda sadece yan yana olan elemanların aynı olup olmadığı kontrolünü sağlamak tekrarlı eleman kontrolünü sayğlamak için yeterli olur.

    Yazdığım kodda Array.Sort(nums) metodu kullandığımda, veri setine bağlı olarak seçilen Quick Sort veya Tim Sort gibi optimize
    bir sıralama algoritması çalışır. Fakat yine C gibi temel seviye dillerde bu fonksiyon olmadığı için istediğimiz bir sıralama algoritmasını seçebiliriz
    Ben örnek olması açısından Quick Sort seçtim fakat caselerde küçük veri setleri kullanıldığından, Time Complexityi çok yükseltmeyecek şekilde 
    bir algoritma seçilmesi önemlidir

    Quick Sort o(n log n) karmaşıklığına sahiptir.
    Daha sonra yanyana olan sıralı verileri kıyaslamak için de brute force ile bir tur dönülür ve O(n) karmaşıklığına ulaşılır
    
    Time Complexity: O(n log n)
    Space Complexity: O(1)/O(n)
    Artılar: Düşük seviyeli dillerde kolay uygulama, düşük hafıza kulllanımı
    Eksiler: Sıralama gerektirir


