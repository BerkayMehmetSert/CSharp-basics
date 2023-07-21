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