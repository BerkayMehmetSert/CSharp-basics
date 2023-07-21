# C# Temelleri

## Açıklama

Bu repository C# temellerini öğrenmek isteyenler için hazırlanmıştır.

## İçerik

* [CSarp Nedir](#csharp-nedir)
* [.Net Framework Nedir](#net-framework-nedir)
* [Değişkenler](#değişkenler)
* [Veri Tipleri ve Kullanımı](#veri-tipleri-ve-kullanımı)
* [Veri Dönüşümleri](#veri-dönüşümleri)
* [Null Değerli Türler](#null-değerli-türler)
* [Diziler](#diziler)
* [Referans Tipler](#referans-tipler)
* [Operatörler](#operatörler)
* [Koşullu İfadeler](#koşullu-ifadeler)
* [Döngüler](#döngüler)
* [OOP (Nesne Yönelimli Programlama)](#oop-nesne-yönelimli-programlama)
* [Yapıcı Metotlar (Constructor)](#yapıcı-metotlar-constructor)
* [Erişim Belirleyiciler (Access Modifiers)](#erişim-belirleyiciler-access-modifiers)

### CSharp Nedir

C#, Microsoft tarafından geliştirilen ve .NET Framework üzerinde çalışan modern, nesne yönelimli bir programlama
dilidir. C# (C sharp olarak okunur) dilinin ortaya çıkış amacı, hızlı, güvenilir ve yönetilebilir uygulamalar
geliştirmek için bir araç sunmaktır. Bu dil, C ve C++'ın yanı sıra Java ve Objective-C gibi dillerin etkilerini taşır ve
C++ dilinin karmaşıklığından arındırılarak daha basit, sade ve güvenli bir dil olarak tasarlanmıştır.

C# dilinin en önemli özelliklerinden bazıları şunlardır:

1. **Nesne Yönelimli Programlama (OOP):** C#, nesne yönelimli programlama prensiplerine dayanır. Bu, uygulamanın temel
   yapı taşlarını sınıflar ve nesnelerle oluşturmayı sağlar. Sınıflar, veri ve davranışları bir araya getiren bir
   tasarım şablonudur ve nesneler, bu sınıfların somut örnekleridir.

2. **Tipli Dil:** C#, bir tipli dil olarak adlandırılır, çünkü değişkenlerin türleri derleme zamanında belirlenir ve tür
   uyumsuzluğu hatalarının çoğunu önler. Bu, güvenli ve hatasız kod yazmayı kolaylaştırır.

3. **Platform Bağımsızlık:** C# dilinin en büyük avantajlarından biri, .NET Framework veya .NET Core gibi çeşitli
   platformlarda çalışabilme yeteneğidir. Bu sayede C# dilinde yazılan uygulamalar, Windows, Linux, macOS ve diğer
   platformlarda sorunsuz bir şekilde çalışabilir.

4. **Bellek Yönetimi:** C# dilinde, programcılar doğrudan bellek yönetimiyle uğraşmak zorunda değildir. Otomatik bellek
   yönetimi (garbage collection) sayesinde, gereksiz nesnelerin bellekten otomatik olarak temizlenmesi sağlanır, bu da
   hafıza sızıntılarını önler ve daha güvenilir uygulamalar geliştirilmesine yardımcı olur.

5. **Zengin Standart Kütüphane:** C#, .NET Framework veya .NET Core tarafından sağlanan zengin bir standart kütüphane
   ile birlikte gelir. Bu kütüphane, dosya işlemleri, ağ bağlantıları, veritabanı etkileşimi ve grafik kullanıcı
   arayüzleri gibi yaygın görevleri gerçekleştirmeyi kolaylaştırır.

6. **Hızlı ve Verimli:** C# dilinin performansı oldukça yüksektir ve derlenmiş bir dil olarak çalışır. Bu nedenle, C#
   dilinde yazılan uygulamalar genellikle hızlı ve verimlidir.

C# dilini öğrenmek, .NET platformunda çeşitli uygulamalar geliştirmek için önemli bir adımdır. İster masaüstü
uygulamaları, ister web siteleri veya mobil uygulamalar geliştirmek isteyin, C# dilinin esnekliği ve gücü sayesinde bu
hedeflere ulaşmak mümkündür. Başlangıçta temel programlama kavramlarından başlayarak, dilin gelişmiş özelliklerine kadar
ilerleyen bir öğrenme süreci, C# dilini ustaca kullanmanıza yardımcı olacaktır.

### .Net Framework Nedir

.NET, Microsoft tarafından geliştirilen bir yazılım platformudur ve çeşitli programlama dilleri kullanılarak Windows,
Linux ve macOS gibi farklı işletim sistemlerinde uygulama geliştirmek için kullanılır. .NET, açık kaynaklı .NET Core ve
Windows'a özel .NET Framework olmak üzere iki ana uygulama çatısı altında bulunmaktadır.

Aşağıda .NET'in temel özelliklerini ve kullanım alanlarını anlatan bir öğretici açıklama:

1. **Çok Dillilik Desteği:** .NET, C#, Visual Basic, F#, C++ ve diğer birçok programlama diliyle uyumludur. Bu sayede
   geliştiriciler, kendi tercih ettikleri dilleri kullanarak uygulamalar oluşturabilirler.

2. **Platform Bağımsızlık:** .NET Core, platform bağımsız bir sürüm olarak geliştirilmiştir. Bu nedenle, .NET Core
   kullanılarak yazılan uygulamalar Windows, Linux ve macOS gibi farklı işletim sistemlerinde sorunsuz bir şekilde
   çalışabilir.

3. **Kapsamlı Kütüphane Desteği:** .NET, geniş bir standart kütüphane sunar. Bu kütüphane, dosya işlemleri, veritabanı
   etkileşimi, ağ bağlantıları, güvenlik, veri yapıları, grafikler ve daha pek çok konuda hazır çözümler içerir. Bu
   sayede, geliştiricilerin belirli görevleri gerçekleştirirken tekerlekleri yeniden icat etmesi önlenir.

4. **Hız ve Performans:** .NET uygulamaları, derlendiği için C/C++'a kıyasla daha yüksek performans sağlar. Ayrıca, .NET
   Runtime'ın (CLR - Common Language Runtime) Just-in-Time (JIT) derleme özelliği sayesinde, uygulamaların çalışma
   zamanında en uygun makine koduna dönüştürülmesi sağlanır.

5. **Güçlü Araçlar ve Entegrasyon:** .NET, geliştiricilere kolaylık sağlayan zengin bir geliştirme ortamı sunar. Visual
   Studio gibi güçlü entegre geliştirme ortamları ve çeşitli araçlar sayesinde uygulama geliştirme süreci daha verimli
   ve etkili hale gelir.

6. **Web Uygulamaları ve Servisler:** .NET ile ASP.NET teknolojisi kullanılarak web tabanlı uygulamalar, web servisleri
   ve API'ler oluşturmak mümkündür. Bu sayede, farklı platformlar arasında veri paylaşımı ve işbirliği sağlanabilir.

7. **Masaüstü ve Mobil Uygulamalar:** .NET, masaüstü uygulamalarının geliştirilmesine de olanak tanır. Ayrıca Xamarin
   ile mobil uygulamaların oluşturulması için de destek verir. Bu sayede, hem Windows üzerinde hem de farklı mobil
   cihazlarda çalışan uygulamalar geliştirebilirsiniz.

.NET, geliştiricilere güçlü bir altyapı sağlayarak uygulama geliştirme süreçlerini kolaylaştıran ve hızlandıran bir
platformdur. .NET Core sayesinde, platform bağımsızlığı da sağlayarak uygulamaların daha geniş bir kullanıcı kitlesine
ulaşmasına olanak tanır. Yenilikçi projelerden büyük ölçekli kurumsal uygulamalara kadar çeşitli alanlarda kullanılan
.NET, güvenilir ve performanslı uygulamaların geliştirilmesi için popüler bir tercih haline gelmiştir.

### Değişkenler

C# (C sharp), Microsoft tarafından geliştirilen ve genellikle Windows uygulamaları ve web uygulamaları için kullanılan
popüler bir programlama dilidir. C# dilinde, verileri depolamak ve işlemek için değişkenler kullanılır. Değişkenler, bir
isim ve bir değer içeren saklama alanlarıdır. Değişkenler, program içinde bilgileri geçici olarak saklamak, hesaplamalar
yapmak ve sonuçları tutmak için kullanılır.

C# dilinde farklı veri türleri için değişkenler tanımlanabilir. Bazı temel C# veri türleri şunlardır:

1. **Tam Sayılar (Integers):** Tam sayıları temsil etmek için kullanılır ve "int" veri türü ile tanımlanır.

Örneğin:

```csharp
int age = 25;
```

2. **Ondalıklı Sayılar (Floating-Point Numbers):** Ondalıklı sayıları temsil etmek için kullanılır ve "double" veya "
   float" veri türleri ile tanımlanabilir.

Örneğin:

```csharp
double pi = 3.14159;
float temperature = 27.5f; // 'f' ile float türü olduğu belirtiliyor
```

3. **Metin (Strings):** Metinleri temsil etmek için kullanılır ve "string" veri türü ile tanımlanır. Metinler çift veya
   tek tırnaklar arasına yazılır.

Örneğin:

```csharp
string name = "John Doe";
```

4. **Mantıksal Değerler (Boolean):** Mantıksal değerleri (doğru veya yanlış) temsil etmek için kullanılır ve "bool" veri
   türü ile tanımlanır.

Örneğin:

```csharp
bool isStudent = true;
```

5. **Karakter (Character):** Tek bir karakteri temsil etmek için kullanılır ve "char" veri türü ile tanımlanır.
   Karakterler tek tırnak içinde yazılır.

Örneğin:

```csharp
char grade = 'A';
```

Değişkenler, program içinde farklı değerler alabilir ve bu değerler üzerinde işlemler yapılabilir. C# dilinde
değişkenler, belirli bir veri türüne sahip olmalıdır ve aynı türdeki verilerle kullanılmalıdır. Değişkenler, değer
atanarak veya kullanılmadan önce tanımlanarak oluşturulur. C# dilinde değişkenlerin değeri istenilen zaman
değiştirilebilir.

Örneğin:

```csharp
// Değişken tanımlama ve değer atama
int x; // Değer atanmadan tanımlama
x = 10; // Değer atama
string message = "Hello World!"; // Değişken tanımlama ve değer atama aynı satırda

// Değişken kullanımı ve işlemler
int y = 5;
int sum = x + y; // x ve y değişkenlerinin toplamını alır
string fullName = "John" + " " + "Doe"; // Metinleri birleştirir
bool isAdult = age >= 18; // Mantıksal değeri hesaplar
```

C# dilinde değişkenler, programlama dillerinde temel ve önemli bir kavramdır. Değişkenler, veri manipülasyonu,
hesaplamalar ve sonuçların saklanması için kullanılır. Programlama yaparken, değişkenlerin veri türlerine dikkat ederek
ve anlamlı isimler vererek kodların daha okunabilir ve anlaşılır olmasını sağlamak önemlidir.

### Veri Tipleri ve Kullanımı

C# (C sharp), güçlü bir tip güvenliğine sahip olan bir programlama dilidir. Bu nedenle, C# dilinde kullanılan veri
tipleri, değişkenlerin alabileceği değerlerin türlerini belirtmek için önemlidir. C# dilinde temel veri tipleri ve
bunların kullanımı şunlardır:

1. **Tam Sayılar (Integers):**

- int: En yaygın kullanılan tam sayı veri tipidir. 4 baytlık bellek alanı kullanır ve genellikle -2,147,483,648 ile
  2,147,483,647 arasındaki değerleri alır.

Örneğin:

```csharp
int age = 25;
```

- short: 2 baytlık bellek alanı kullanır ve genellikle -32,768 ile 32,767 arasındaki değerleri alır.

Örneğin:

```csharp
short temperature = -10;
```

- long: 8 baytlık bellek alanı kullanır ve genellikle -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807
  arasındaki değerleri alır.

Örneğin:

```csharp
long population = 7_600_000_000;
```

2. **Ondalıklı Sayılar (Floating-Point Numbers):**

double: Çift hassasiyetli ondalıklı sayıları temsil eder. 8 baytlık bellek alanı kullanır ve genellikle 15-16 basamak
hassasiyeti vardır.

Örneğin:

```csharp
double pi = 3.14159;
```

- float: Tek hassasiyetli ondalıklı sayıları temsil eder. 4 baytlık bellek alanı kullanır ve genellikle 7 basamak
  hassasiyeti vardır.

Örneğin:

```csharp
float temperature = 27.5f; // 'f' ile float türü olduğu belirtiliyor
```

3. **Metin (Strings):**

string: Metinleri temsil eder ve çift tırnaklar (" ") içine yazılır. String veri tipi, değişebilir ve geniş bir karakter
kümesini destekler.

Örneğin:

```csharp
string name = "John Doe";
```

4. **Mantıksal Değerler (Boolean):**

bool: Doğru veya yanlış değerlerini temsil eder. 1 baytlık bellek alanı kullanır ve sadece iki değeri alabilir: "true"
veya "false".

Örneğin:

```csharp
bool isStudent = true;
```

5. **Karakter (Character):**

- char: Tek bir karakteri temsil eder ve tek tırnaklar (' ') içine yazılır. 2 baytlık bellek alanı kullanır ve
  genellikle Unicode karakterlerini destekler.

Örneğin:

```csharp
char grade = 'A';
```

6. **Diğer Veri Tipleri:**

- byte: 1 baytlık bellek alanı kullanır ve 0 ile 255 arasındaki değerleri alır.

Örneğin:

```csharp
byte numberOfChildren = 3;
```

- decimal: Kesirli sayıları temsil eder ve finansal hesaplamalar için kullanılır. 16 baytlık bellek alanı kullanır ve
  genellikle para birimleri için tercih edilir.

Örneğin:

```csharp
decimal price = 24.99m; // "m" ile decimal türü olduğu belirtiliyor
```

- DateTime: Tarih ve saat değerlerini temsil eder.

Örneğin:

```csharp
DateTime currentDate = DateTime.Now;
```

C# dilinde farklı veri tipleri, uygulama gereksinimlerine ve işlemlere uygun olarak seçilmelidir. Doğru veri tiplerini
kullanmak, bellek kullanımını optimize eder ve doğru sonuçlar almayı sağlar. Ayrıca, veri türleri, veri dönüşümleri ve
tür uyumsuzluklarına dikkat edilerek uygulamanın sağlamlığı ve performansı artırılabilir.

### Veri Dönüşümleri

C# dilinde veri dönüşümleri, bir veri tipini başka bir veri tipine dönüştürme işlemidir. Bu işlem, farklı veri tipleri
arasında veri alışverişi yapmak veya farklı hesaplamalar yapmak için önemlidir.

1. **Otomatik Dönüşüm (Implicit Conversion):**

Otomatik dönüşüm, veri kaybı riski olmadan daha büyük bir veri tipinden daha küçük bir veri tipine dönüşüm yapılmasıdır.
C# dilinde, daha küçük bir veri tipi otomatik olarak daha büyük bir veri tipine dönüştürülebilir. Bu dönüşümde, veri
kaybı olmadan dönüşüm gerçekleşir ve ekstra bir işlem yapmaya gerek kalmaz.

Örneğin:

```csharp
int intValue = 10;
long longValue = intValue; // Otomatik dönüşüm, int'ten long'a
```

2. **Explicit Dönüşüm (Explicit Conversion):**

Explicit dönüşüm, veri kaybı riski olan veya doğrudan dönüşüm yapılamayan durumlarda kullanılır. Bu dönüşümde, veri
kaybını kabul ederek veya belirli dönüşüm yöntemlerini kullanarak dönüşüm yapılır. Explicit dönüşüm, kullanıcı
tarafından açıkça belirtilmelidir.

Örneğin:

```csharp
double doubleValue = 3.14;
int intValue = (int)doubleValue; // Explicit dönüşüm, double'dan int'e
```

**3. Convert Sınıfı Kullanımı:**

C# dilinde veri dönüşümleri için Convert sınıfı da kullanılabilir. Bu sınıf, farklı veri tipleri arasında dönüşüm yapmak
için yöntemler sağlar.

Örneğin:

```csharp
string numericString = "123";
int intValue = Convert.ToInt32(numericString);
```

**4. Parse ve TryParse Yöntemleri:**

Metin verilerini sayısal verilere dönüştürmek için Parse veya TryParse yöntemleri kullanılabilir. Parse yöntemi, metin
veriyi doğrudan sayısal veriye dönüştürürken, TryParse yöntemi ise başarılı bir dönüşüm olup olmadığını kontrol ederek
dönüşüm yapar.

Örneğin:

```csharp
string numericString = "456";
int intValue = int.Parse(numericString); // Parse yöntemi
int result;
if (int.TryParse(numericString, out result)) // TryParse yöntemi
{
    // Başarılı dönüşüm
}
else
{
    // Başarısız dönüşüm
}
```

Veri dönüşümleri, C# dilinde önemli bir konudur ve doğru kullanıldığında programın performansını ve esnekliğini
artırabilir. Ancak dikkatsizce yapılan dönüşümler, veri kaybına, hatalara veya beklenmeyen sonuçlara neden olabilir. Bu
nedenle, uygun dönüşüm yöntemlerini ve tür uyumsuzluklarını dikkate alarak veri dönüşümlerinin yapılması önemlidir.

### Null Değerli Türler

C# 2.0 sürümüyle birlikte, değer türü olan değişkenlerin null değerini almasına izin veren "nullable" türler
tanıtılmıştır. Değer türleri, null değerini alamayan ve bir değeri zorunlu olarak taşıyan türlerdir (örneğin, int,
double, bool). Ancak bazı durumlarda, bir değer türünün null değerini alması gerekebilir, özellikle veritabanlarından
veya diğer dış kaynaklardan veri alırken. Nullable type, bu tür durumları ele almak için kullanılır.

Nullable type, değer türüne `"?"` karakteri ekleyerek tanımlanır. Örneğin, "int?" nullable bir integer türüdür ve null
değerini kabul edebilir.

Örneğin:

```csharp
int? nullableInt = null; // Nullable integer, null değer alabilir
```

Null değeri kabul eden değer türleri, bir değer atanmadığı durumlarda varsayılan olarak null değeri alır.

Örneğin:

```csharp
int? age = null; // null değer atandı
```

Dikkat edilmesi gereken önemli bir nokta, nullable type'ların gereksiz yere kullanılmasından kaçınmaktır. Çünkü nullable
type'lar, normal değer türlerinden daha fazla bellek kullanımına ve performans kaybına neden olabilir. Bu nedenle, bir
değişkenin null değerini alması gerekiyorsa ve bununla ilgili kontrol yapılması önemliyse, nullable type kullanmak
mantıklıdır. Ancak null değerini alması beklenmiyorsa, normal değer türleri tercih edilmelidir.

Örneğin:

```csharp
int? count = 10; // Nullable kullanımı gereksiz
int totalCount = 0; // Normal değer türü kullanımı
```

Nullable type, C# dilinde değer türlerinin null değerini kabul etmesini sağlayan ve veri alışverişi sırasında kullanılan
önemli bir özelliktir. Doğru kullanıldığında, null değerleriyle çalışmak daha güvenli ve esnek kod yazmanıza yardımcı
olabilir. Ancak, gereksiz kullanımdan kaçınarak performans açısından da dikkatli olunmalıdır.

### Diziler

C# dilinde diziler, aynı türdeki öğeleri içeren ve indeks numaralarıyla erişilen veri yapılarıdır. Diziler, belirli bir
boyutta tanımlanır ve boyutları değiştirilemez. Diziler, birden çok değeri tutmak ve bu değerlere kolayca erişmek için
kullanılır. C# dilinde diziler, referans türüdür, yani dizinin kendisi bellekte bir referans olarak saklanır ve diziyi
oluşturan öğeler başka bellek alanlarında saklanır.

**Dizi Tanımlama ve Oluşturma**

C# dilinde bir dizi tanımlamak için, veri türü belirtilir ve ardından [] işareti ile dizi simgelenir. Daha sonra diziye
bir isim verilir ve bellekte bir alan ayrılır. Dizi oluşturulurken, eleman sayısını ve değerleri belirtmek için süslü
parantezler {} kullanılır.

Örneğin:

```csharp
// Integer türünde bir dizi tanımlama ve oluşturma
int[] numbers = new int[5]; // 5 elemanlı bir dizi oluşturuldu

// Değerlerle dizi oluşturma
int[] scores = { 85, 90, 78, 95, 88 }; // 5 elemanlı bir dizi oluşturuldu ve değerler atanıyor
```

**Dizi Elemanlarına Erişim ve Değiştirme**

Dizilerin elemanlarına erişmek için indeks numaraları kullanılır. C# dizilerinde indeks numaraları 0'dan başlar. Dizi
elemanlarına erişirken, dizi adı ve indeks numarası köşeli parantez içinde belirtilir.

Örneğin:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

// Dizi elemanlarına erişim
int firstNumber = numbers[0]; // 10
int thirdNumber = numbers[2]; // 30

// Dizi elemanlarını değiştirme
numbers[1] = 25; // 20, 25 ile değiştirildi
```

**Dizi Boyutu ve Uzunluğu**

Dizi boyutu, dizi oluşturulurken belirtilen eleman sayısıdır. Dizi uzunluğu ise dizinin kaç eleman içerdiğini döndüren
bir özelliktir.

Örneğin:

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

int arraySize = numbers.Length; // 5, dizinin boyutu
```

**Çok Boyutlu Diziler**

C# dilinde diziler, tek boyutlu veya çok boyutlu olabilir. Tek boyutlu diziler, tek bir indeks numarasıyla erişilen veri
yapılarıdır. Çok boyutlu diziler ise iki veya daha fazla indeks numarasıyla erişilen veri yapılarıdır. Çok boyutlu
diziler, matrisleri temsil etmek için kullanılır.

Örneğin:

```csharp
// 2 boyutlu bir dizi tanımlama ve oluşturma
int[,] matrix = new int[2, 3]; // 2 satır, 3 sütun

// 3 boyutlu bir dizi tanımlama ve oluşturma
int[,,] cube = new int[3, 4, 5]; // 3 boyutlu bir küp
```

**Dizi Döngüleri**

Dizilerle çalışırken, döngülerin kullanılması sıkça görülen bir durumdur. Döngüler sayesinde dizinin tüm elemanlarına
kolayca erişmek ve işlem yapmak mümkündür.

Örneğin:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

// For döngüsü ile dizi elemanlarına erişim
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Foreach döngüsü ile dizi elemanlarına erişim
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

**Dizi Sınırları**

Dizilerin boyutu oluşturulduktan sonra değiştirilemez. Bu nedenle, dizinin sınırlarını aşmaktan kaçınılmalıdır.
Dizilerin sınırlarını aşmak "IndexOutOfRangeException" hatasına neden olur.

Örneğin:

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

// Hatalı kullanım, dizinin sınırları aşıldı
int invalidNumber = numbers[10]; // IndexOutOfRangeException hatası
```

C# dilinde diziler, verilerin gruplandırılması ve erişilmesi için önemli bir veri yapısıdır. Dizi kullanarak benzer
türdeki verileri düzenlemek ve işlemek daha kolay ve verimli bir şekilde yapılabilir. Dizilerle çalışırken, dikkatli
olunmalı ve dizinin sınırlarını aşmaktan kaçınılmalıdır. Ayrıca, C# dilinde List<T> gibi dinamik koleksiyonlar da
kullanılarak daha esnek veri yapıları oluşturulabilir.

### Referans Tipler

C# Referans Tipleri

C# dilinde, veri tipleri iki ana kategoriye ayrılır: değer türleri (value types) ve referans türleri (reference types).
Referans tipleri, verilerin bellekteki adreslerini içerir ve bu adresler üzerinden veriye erişilir. Değer tipleri ise
verilerin kendisini içerir ve doğrudan değere erişilir.

**Referans Tipleri ve Bellek Yapısı**

Referans tipleri, heap adı verilen bellek bölgesinde saklanır. Bellekte bir nesne oluşturulduğunda, nesne değeri stack
alanında oluşturulan referansı (adresi) heap alanında depolanır. Daha sonra, bu referans aracılığıyla heap alanında
tutulan veriye erişilir. Birden fazla referans aynı nesneyi işaret edebilir, bu nedenle referans tipleri "paylaşımlı"
olarak kabul edilir.

Örneğin:

```csharp
// Referans türünde bir nesne oluşturma
Person person1 = new Person(); // Person, referans türü olan bir sınıftan türetilmiş olmalıdır
Person person2 = person1; // person2, person1'in referansını alır
```

**Referans Tipleri ve Metodlar**

Referans türleri, metodlara parametre olarak gönderildiğinde ve metodlar tarafından döndürüldüğünde oldukça
kullanışlıdır. Metoda gönderilen bir referans, orijinal nesneyi değiştirmeye izin verir ve bu değişiklikler orijinal
nesneyi etkiler. Ancak değer türlerinde böyle bir durum söz konusu değildir.

Örneğin:

```csharp
// Referans türünde bir nesne oluşturma
List<string> names = new List<string>() { "Alice", "Bob", "Carol" };

// Referans türünü metodun parametresine gönderme
AddName(names, "Dave");

// Metot, orijinal nesneyi değiştirir
void AddName(List<string> list, string name)
{
    list.Add(name);
}
```

**Null Değer ve Referans Tipleri**

Referans tipleri, null değerini de alabilirler. Bir referans değişkeni, bir nesneye referans etmiyorsa (boşsa), null
değerine sahip olur. Null değer, bir referansın hiçbir şeyi göstermediğini ifade eder.

Örneğin:

```csharp
Person person = null; // Person referansı, hiçbir nesneyi göstermiyor
```

Null referanslarla çalışırken, null kontrolü yapmak önemlidir. Null referanslar üzerinde işlem yapılmak istendiğinde "
NullReferenceException" hatası alınır.

Örneğin:

```csharp
Person person = null;

if (person != null)
{
    // Null olmayan bir nesne üzerinde işlem yapma
}
```

Referans tipleri, C# dilinde farklı yapıların oluşturulması ve veri yönetimi için önemli bir rol oynar. Referans
tipleri, bellek kullanımı ve performans açısından dikkatli kullanılmalı ve gereksiz yere oluşturulmamalıdır. Özellikle
büyük veri yapıları ve nesneler için referans tipleri kullanmak daha uygun olabilir. Ancak dikkatli olunmadığı takdirde
null referans hataları gibi problemlerle karşılaşmak mümkündür. Bu nedenle, null kontrolü ve doğru kullanımı dikkate
alarak referans tipleri ile çalışmak önemlidir.

### Operatörler

C# dilinde operatörler, değişkenler ve değerler üzerinde çeşitli işlemleri gerçekleştirmek için kullanılan sembollerdir.
C# dilinde farklı türde operatörler bulunur ve bu operatörler, matematiksel işlemlerden mantıksal işlemlere kadar geniş
bir yelpazede kullanılabilir. Operatörler, programlamanın temel yapı taşlarından biridir ve verilerin manipüle edilmesi
ve işlenmesi için önemli bir rol oynar.

1. **Aritmetik Operatörler:**

Aritmetik operatörler, matematiksel işlemler yapmak için kullanılır.

Örneğin:

```csharp
int x = 10;
int y = 5;

int sum = x + y; // Toplama, sonuç: 15
int difference = x - y; // Çıkarma, sonuç: 5
int product = x * y; // Çarpma, sonuç: 50
int quotient = x / y; // Bölme, sonuç: 2
int remainder = x % y; // Mod alma, sonuç: 0
```

2. **Atama Operatörleri:**

Atama operatörleri, değişkenlere değer atamak için kullanılır.

Örneğin:

```csharp
int x = 10;
int y;

y = x; // Değer atama
```

3. **Karşılaştırma Operatörleri:**

Karşılaştırma operatörleri, iki değeri karşılaştırmak için kullanılır ve sonuç olarak true veya false döner.

Örneğin:

```csharp
int x = 10;
int y = 5;

bool isEqual = x == y; // Eşit mi? false
bool isNotEqual = x != y; // Eşit değil mi? true
bool isGreater = x > y; // Büyük mü? true
bool isLess = x < y; // Küçük mü? false
bool isGreaterOrEqual = x >= y; // Büyük veya eşit mi? true
bool isLessOrEqual = x <= y; // Küçük veya eşit mi? false
```

4. **Mantıksal Operatörler:**

Mantıksal operatörler, boolean (true/false) değerler üzerinde mantıksal işlemler yapmak için kullanılır.

Örneğin:

```csharp
bool a = true;
bool b = false;

bool resultAnd = a && b; // VE, sonuç: false
bool resultOr = a || b; // VEYA, sonuç: true
bool resultNot = !a; // DEĞİL, sonuç: false
```

5. **Artırma ve Azaltma Operatörleri:**

Artırma ve azaltma operatörleri, bir değişkenin değerini 1 artırmak veya azaltmak için kullanılır.

Örneğin:

```csharp
int x = 5;

x++; // Post-increment, x = 6
++x; // Pre-increment, x = 7

x--; // Post-decrement, x = 6
--x; // Pre-decrement, x = 5
```

6. **Koşul Operatörü:**

Koşul operatörü (ternary operatör), bir koşulu değerlendirir ve sonuca göre farklı değerleri döndürür.

Örneğin:

```csharp
int x = 10;
int y = 5;

int result = (x > y) ? x : y; // x, y'den büyükse x'i, değilse y'yi döndürür
```

C# dilinde daha birçok operatör bulunmaktadır. Operatörler, programların veri işleme ve kontrol akışını yönetmek için
temel araçlardır. Doğru ve etkili bir şekilde operatörleri kullanarak, programlama dili olan C#'da çeşitli işlemleri
gerçekleştirebilir ve daha karmaşık uygulamalar oluşturabilirsiniz.

### Koşullu İfadeler

C# dilinde koşullu ifadeler, belirli bir koşulun doğru veya yanlış olduğuna bağlı olarak farklı kod bloklarının
çalıştırılmasını sağlar. Bu tür yapılar, programların farklı senaryolara göre çalışmasını ve çeşitli durumlara göre
farklı işlemler yapmasını sağlar.

1. **if İfadesi:**

if ifadesi, belirtilen koşulun doğru olduğu durumda ilgili kod bloğunun çalıştırılmasını sağlar. Eğer koşul yanlışsa, if
bloğu atlanır.

Örneğin:

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Ehliyet alabilirsiniz.");
}
```

2. **if-else İfadesi:**

if-else ifadesi, belirtilen koşulun doğru olduğu durumda bir kod bloğunu, yanlış olduğu durumda ise başka bir kod
bloğunu çalıştırır.

Örneğin:

```csharp
int score = 85;

if (score >= 60)
{
    Console.WriteLine("Geçtiniz.");
}
else
{
    Console.WriteLine("Kaldınız.");
}
```

3. **if-else if-else İfadesi (Nested if):**

Birden fazla koşulu kontrol etmek için if-else if-else yapısı kullanılır. Bu yapıda her koşul sırayla değerlendirilir ve
doğru olan kod bloğu çalıştırılır. Eğer hiçbir koşul sağlanmazsa, son olarak else bloğu çalışır.

Örneğin:

```csharp
int score = 75;

if (score >= 90)
{
    Console.WriteLine("AA");
}
else if (score >= 80)
{
    Console.WriteLine("BA");
}
else if (score >= 70)
{
    Console.WriteLine("BB");
}
else if (score >= 60)
{
    Console.WriteLine("CB");
}
else
{
    Console.WriteLine("Kaldınız.");
}
```

4. **switch-case İfadesi:**

switch-case ifadesi, bir değişkenin değerine göre farklı durumları kontrol etmek için kullanılır. Bir değer, farklı case
durumları ile karşılaştırılır ve uygun olan case bloğu çalıştırılır.

Örneğin:

```csharp
int dayOfWeek = 3;

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    // Diğer günler için case blokları eklenir.
    default:
        Console.WriteLine("Geçersiz gün");
        break;
}
```

Yeni switch-case gösterimi:

```csharp
int dayOfWeek = 3;

string dayName = dayOfWeek switch
{
    1 => "Pazartesi",
    2 => "Salı",
    3 => "Çarşamba",
    _ => "Geçersiz gün"
};

Console.WriteLine(dayName);
```

Koşullu ifadeler, C# dilinde programların farklı şartlara göre farklı davranışlar sergilemesini sağlar. Doğru ve
mantıklı koşullar belirleyerek, programların esnek ve akıllıca davranışlar sergilemesini sağlayabilirsiniz. Koşullu
ifadeler, kullanıcıdan alınan girdilere veya çeşitli verilere bağlı olarak programın akışını yönlendirmek ve karar
vermek için yaygın olarak kullanılır.

### Döngüler

C# dilinde döngüler, belirli bir işlemi tekrarlayarak çalıştırmak için kullanılan yapılardır. Döngüler, belirli koşullar
sağlandığı sürece veya belirli sayıda tekrar gerçekleşene kadar çalışır. Döngüler, programların tekrar eden görevleri
etkin bir şekilde yerine getirmesine olanak tanır ve kodun daha az tekrar eden, daha temiz ve daha kolay yönetilebilir
olmasını sağlar.

1. **for Döngüsü:**

for döngüsü, bir başlangıç değeriyle başlayarak, belirtilen koşul sağlandığı sürece belirli bir adımda tekrarlanır.
Döngü içindeki kod bloğu her iterasyonda çalıştırılır.

Örneğin:

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Döngü tekrarı: " + i);
}
```

2. **while Döngüsü:**

while döngüsü, belirtilen koşul sağlandığı sürece tekrarlanır. Döngü başlamadan önce koşul kontrol edilir ve koşul doğru
ise döngü içindeki kod bloğu çalıştırılır.

Örneğin:

```csharp
int count = 0;
while (count < 5)
{
    Console.WriteLine("Döngü tekrarı: " + count);
    count++;
}
```

3. **do-while Döngüsü:**

do-while döngüsü, while döngüsüne benzer, ancak koşul döngü bloğunun sonunda kontrol edilir. Bu nedenle, döngü bloğu en
az bir kez çalıştırılır ve koşul daha sonra kontrol edilir.

Örneğin:

```csharp
int count = 0;
do
{
    Console.WriteLine("Döngü tekrarı: " + count);
    count++;
} while (count < 5);
```

4. **foreach Döngüsü:**

foreach döngüsü, koleksiyonların (dizi, liste vb.) elemanları üzerinde dolaşmak için kullanılır. Her iterasyonda,
koleksiyondaki bir eleman alınır ve döngü içindeki kod bloğu çalıştırılır.

Örneğin:

```csharp
string[] names = { "Alice", "Bob", "Carol" };
foreach (string name in names)
{
    Console.WriteLine("İsim: " + name);
}
```

5. **break ve continue İfadeleri:**

break ifadesi, döngüyü tamamen sonlandırmak için kullanılırken, continue ifadesi, döngünün geri kalan kısmını atlayarak
bir sonraki iterasyona geçmek için kullanılır.

Örneğin:

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue; // 3. tekrarı atla
    Console.WriteLine("Döngü tekrarı: " + i);
    if (i == 4)
        break; // Döngüyü sonlandır
}
```

Döngüler, programların tekrar eden işlemleri gerçekleştirmek için önemli bir yapıdır. Döngüler sayesinde verilerinizi
işleyebilir, koleksiyonlar üzerinde dolaşabilir ve belirli şartlar sağlandığında işlemleri durdurabilirsiniz. C# dilinde
farklı döngü yapıları sayesinde, kodlarınızı daha az tekrar eden, daha düzenli ve daha etkin hale getirebilirsiniz.

### OOP (Nesne Yönelimli Programlama)

C# dilinde nesne yönelimli programlama (Object-Oriented Programming - OOP), programların gerçek dünya nesnelerini ve
kavramlarını modellemek için kullanılan bir programlama paradigmasıdır. OOP, kodun düzenlenmesini, bakımını ve
genişletilmesini kolaylaştırırken, daha anlaşılır, modüler ve yeniden kullanılabilir yazılım geliştirmeyi sağlar.

OOP'nin temel amacı, verileri ve bu veriler üzerinde işlemleri birleştiren nesneleri oluşturmaktır. Her nesne, kendi
özelliklerini (veri elemanları) ve davranışlarını (metotlar) içerir. C# dilinde nesne yönelimli programlama
kullanabilmek için sınıflar ve nesnelerin tanımlanması gereklidir.

1. **Sınıflar ve Nesneler**

Sınıflar, nesnelerin taslağıdır ve bir veri türü olarak düşünülebilir. Sınıflar, içerisinde özellikleri (alanlar) ve
metotları barındırır. Bir sınıfı kullanarak, o sınıfa ait nesneler oluşturulabilir.

Örneğin:

```csharp
// Örnek bir Sınıf tanımı
class Person
{
    // Sınıf özellikleri (alanlar)
    public string Name { get; set; }
    public int Age { get; set; }

    // Sınıf metotları
    public void SayHello()
    {
        Console.WriteLine("Merhaba, ben " + Name + " ve " + Age + " yaşındayım.");
    }
}

// Sınıftan bir nesne oluşturma
Person person1 = new Person();
person1.Name = "Alice";
person1.Age = 30;
person1.SayHello(); // Çıktı: Merhaba, ben Alice ve 30 yaşındayım.
```

2. **Kalıtım (Inheritance)**

Kalıtım, bir sınıfın başka bir sınıftan türetilmesini sağlayan bir OOP kavramıdır. Bir sınıf, başka bir sınıftan
türetilerek, türetilen sınıfın özelliklerini ve metotlarını miras alır.

Örneğin:

```csharp
// Ana sınıf: Ürün
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine("Ürün Adı: " + Name);
        Console.WriteLine("Fiyatı: " + Price);
        Console.WriteLine("Marka: " + Brand);
    }
}

// Türetilmiş sınıf: Elektronik Ürünler
class Electronics : Product
{
    public string Category { get; set; }

    public void ShowCategory()
    {
        Console.WriteLine("Kategori: " + Category);
    }
}

// Türetilmiş sınıf: Giyim Ürünleri
class Clothing : Product
{
    public string Size { get; set; }

    public void ShowSize()
    {
        Console.WriteLine("Beden: " + Size);
    }
}
```

3. **Kapsülleme (Encapsulation)**

Kapsülleme, sınıfın verilerini ve metotlarını bir kapsül (birim) altında toplama işlemidir. Sınıf içerisindeki verilere
doğrudan erişim engellenir ve sınıfın metotları aracılığıyla erişim ve işlemler yapılır.

Örneğin:

```csharp
class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

BankAccount account = new BankAccount();
account.Deposit(1000);
account.Withdraw(500);
Console.WriteLine("Bakiye: " + account.GetBalance()); // Çıktı: Bakiye: 500
```

4. **Çok Biçimlilik (Polymorphism)**

Çok biçimlilik, bir sınıfın birden fazla şekilde davranabilmesini sağlayan bir OOP kavramıdır. Bir sınıf, başka
sınıflardan türetilebilir ve türetilen sınıfların metotlarını ezerek kendi davranışlarını tanımlayabilir.

Örneğin:

```csharp
// Ana sınıf: MenuOption
abstract class MenuOption
{
    public string Title { get; set; }

    public MenuOption(string title)
    {
        Title = title;
    }

    public abstract void Execute();
}

// Türetilmiş sınıf: CheckBalance
class CheckBalance : MenuOption
{
    public CheckBalance() : base("Bakiye Sorgula")
    {
    }

    public override void Execute()
    {
        Console.WriteLine("Bakiyeniz: 5000 TL");
    }
}

// Türetilmiş sınıf: MakePayment
class MakePayment : MenuOption
{
    public MakePayment() : base("Ödeme Yap")
    {
    }

    public override void Execute()
    {
        Console.WriteLine("Ödeme işlemi başarılı.");
    }
}

// Türetilmiş sınıf: TransferMoney
class TransferMoney : MenuOption
{
    public TransferMoney() : base("Para Transferi Yap")
    {
    }

    public override void Execute()
    {
        Console.WriteLine("Para transferi işlemi başarılı.");
    }
}
```

### Yapıcı Metotlar (Constructor)

C# dilinde constructor (yapıcı metot), bir sınıftan nesne oluşturulurken, nesne üzerinde yapılacak başlangıç işlemlerini
gerçekleştiren özel bir metottur. Constructor, sınıfın adıyla aynı olan bir metottur ve sınıfın bir nesnesi
oluşturulduğunda otomatik olarak çalışır.

**Neden Constructor Kullanılır?**

Constructorlar, nesnelerin başlangıç durumunu ayarlamak ve başlangıç değerlerini belirlemek için kullanılır. Sınıfın
özelliklerine veya diğer üyelerine başlangıç değeri atamak, nesne oluşturulduğunda yapılacak işlemleri belirlemek gibi
amaçlarla kullanılabilir. Nesne oluşturulurken özel başlangıç durumları gerektiren durumlar için constructorlar oldukça
faydalıdır.

**Constructor Kullanımı**

Bir constructor oluşturmak için sınıfın adını kullanırız ve parametrelerle birlikte tanımlarız. Constructor, geri dönüş
türü olmayan ve sınıfın adıyla birebir aynı olan bir metottur.

Örneğin:

```csharp
class Person
{
    public string Name;
    public int Age;

    // Parametre alan constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Parametresiz constructor (default constructor)
    public Person()
    {
        Name = "Belirtilmedi";
        Age = 0;
    }
}
```

Yukarıdaki örnekte, "Person" sınıfı iki farklı constructor'a sahiptir. İlki parametre alan bir constructor ve nesne
oluşturulurken "name" ve "age" parametrelerini alarak nesne özelliklerini bu değerlerle başlatır. İkincisi ise parametre
almayan bir constructor (default constructor) ve nesne oluşturulduğunda özelliklere varsayılan değerler atanmasını
sağlar.

**Constructor Çeşitleri**

1. **Parametre Alan Constructor:** Bir veya daha fazla parametre alarak nesne özelliklerini bu değerlerle başlatır.
   Birden fazla constructor oluşturulabilir ve farklı sayıda veya türde parametreler alabilirler.

2. **Parametresiz Constructor** (Default Constructor): Parametre almadan nesne özelliklerine varsayılan değerler
   atanmasını sağlar. Eğer farklı constructor'lar tanımlanmışsa parametresiz constructor varsayılan olarak otomatik
   olarak eklenmez.

Constructor Kullanımı:

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Parametre alan constructor kullanımı
        Person person1 = new Person("Alice", 30);
        Console.WriteLine(person1.Name); // Çıktı: Alice
        Console.WriteLine(person1.Age);  // Çıktı: 30

        // Parametresiz constructor kullanımı
        Person person2 = new Person();
        Console.WriteLine(person2.Name); // Çıktı: Belirtilmedi
        Console.WriteLine(person2.Age);  // Çıktı: 0
    }
}
```

Bu örnekte "Person" sınıfından nesneler oluştururken hem parametre alan constructor hem de parametresiz constructor
kullanımını görebilirsiniz. Constructorlar sayesinde nesnelerin doğru şekilde başlangıç değerleri ile oluşturulmasını ve
kullanılmasını sağlayabiliriz.

### Erişim Belirleyiciler (Access Modifiers)

C# dilinde access modifiers (erişim belirleyiciler), sınıf üyelerinin (alanlar, özellikler, metotlar ve diğer üyeler)
erişim düzeyini kontrol etmek için kullanılan anahtar kelimelerdir. Bu belirleyiciler, sınıf üyelerinin hangi
kısımlardan erişilebileceğini ve hangi kısımlardan gizleneceğini belirler. C# dilinde dört farklı erişim belirleyici
bulunmaktadır:

1. **public:** Her yerden erişime izin verir. Yani, bu üyelere sınıfın içinden ve dışından erişilebilir.

2. **private:** Sadece aynı sınıf içerisindeki diğer üyelerden erişime izin verir. Dışarıdan erişime kapalıdır.

3. **protected:** Sadece aynı sınıf içerisindeki diğer üyeler ve bu sınıftan türetilmiş alt sınıflardaki üyeler
   tarafından erişime izin verir. Dışarıdan erişime kapalıdır.

4. **internal:** Yalnızca aynı proje (assembly) içerisinden erişime izin verir. Farklı projelerden erişime kapalıdır.

**Neden Erişim Belirleyiciler Kullanılır?**

Erişim belirleyiciler, kodun güvenliğini ve düzenini sağlamak için kullanılır. Bazı üyelerin sadece belirli kısımlardan
erişilmesini isteyebiliriz ve diğer kısımlardan gizlemek isteyebiliriz. Aynı zamanda, sınıfın iç yapısını gizlemek ve
nesne yönelimli programlamanın temel prensiplerinden biri olan "enkapsülasyon"u (kapsülleme) uygulamak için erişim
belirleyiciler kullanılır.

**Erişim Belirleyicilerin Kullanımı**

Erişim belirleyiciler, sınıfın üye tanımlarının önüne eklenerek kullanılır.

Örneğin:

```csharp
class Person
{
    // public erişim belirleyici ile her yerden erişilebilen bir özellik
    public string Name { get; set; }

    // private erişim belirleyici ile sadece sınıf içinden erişilebilen bir özellik
    private int age;

    // protected erişim belirleyici ile sadece sınıf ve alt sınıflardan erişilebilen bir metot
    protected void ShowAge()
    {
        Console.WriteLine("Yaş: " + age);
    }

    // internal erişim belirleyici ile yalnızca aynı proje içinden erişilebilen bir metot
    internal void DoSomething()
    {
        // ...
    }
}
```

Yukarıdaki örnekte, "Person" sınıfında çeşitli erişim belirleyicilerle üye tanımları görülmektedir. "Name" özelliği
public erişim belirleyici ile her yerden erişilebilirken, "age" alanı private erişim belirleyici ile sadece sınıf
içinden erişilebilir. "ShowAge" metodu protected erişim belirleyici ile sınıf içinden ve alt sınıflardan
erişilebilirken, "DoSomething" metodu ise internal erişim belirleyici ile yalnızca aynı proje içinden erişilebilir.

**Erişim Belirleyicilerin Kullanımı ve Örnek:**

 ```csharp
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Alice"; // public erişim belirleyicisi ile erişilebilir
        // person.age = 30;    // private erişim belirleyicisi ile erişilemez (Hata verir)
        // person.ShowAge();   // protected erişim belirleyicisi ile erişilemez (Hata verir)
        person.DoSomething(); // internal erişim belirleyicisi ile erişilebilir
    }
}
```

Bu örnekte "Person" sınıfının farklı üyelerine erişim belirleyicilere göre nasıl erişildiğini görebilirsiniz.
Özelliklere ve metotlara uygun erişim düzeylerinin belirlenmesi, programın güvenliğini ve düzenini sağlamada önemli bir
rol oynar.