# C# Temelleri

## Açıklama

Bu repository C# temellerini öğrenmek isteyenler için hazırlanmıştır.

## İçerik

* [CSarp Nedir](#csharp-nedir)
* [.Net Framework Nedir](#net-framework-nedir)
* [Değişkenler](#değişkenler)

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