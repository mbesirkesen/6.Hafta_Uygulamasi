# C# Programlama Uygulamaları - 6. Hafta

Bu proje, C# programlama dilinde **Enum**, **Method Overloading**, **Struct** ve **Indexer** kavramlarını öğrenmek için hazırlanmış uygulama örneklerini içermektedir.

## 📁 Proje Yapısı

Proje, aşağıdaki konuları kapsayan uygulama örneklerinden oluşmaktadır:

### 🔹 Enum (Numaralandırma) Örnekleri

#### enum1 - Trafik Işığı Durumu
Trafik ışıkları (kırmızı, sarı, yeşil) için enum oluşturma ve duruma göre ne yapılması gerektiğini döndüren metot örneği.

#### enum2 - Hava Durumu Tahmini
Hava durumu tiplerini (güneşli, yağmurlu, bulutlu, fırtınalı) temsil eden enum ve hava durumuna göre tavsiye veren metot örneği.

#### enum3 - Çalışan Rolleri ve Maaş Hesaplama
Çalışan rolleri (Müdür, Geliştirici, Tasarımcı, Testçi) için enum oluşturma ve role göre maaş hesaplayan metot örneği.

### 🔹 Method Overloading (Aşırı Yükleme) Örnekleri

#### overloading1 - Matematiksel İşlemleri Çeşitlendiren Fonksiyon
Aynı adla farklı parametrelerle toplam işlemi yapan fonksiyon örnekleri:
- İki tam sayı toplama
- Üç tam sayı toplama
- Dizi tam sayı toplama

#### overloading2 - Farklı Şekillerin Alanını Hesaplayan Fonksiyon
Aynı adla farklı parametrelerle farklı şekillerin alanını hesaplayan fonksiyon örnekleri:
- Kare alanı (bir kenar uzunluğu)
- Dikdörtgen alanı (iki kenar uzunluğu)
- Daire alanı (yarıçap)

#### overloading3 - String İşlemleri
Farklı parametrelerle string işlemleri yapan fonksiyon örnekleri.

### 🔹 Struct (Yapı) Örnekleri

#### struct1 - Zaman İşlemleri
Saat ve dakika tutan struct yapısı:
- Geçersiz saat/dakika kontrolü
- Toplam dakika hesaplama
- İki zaman arasındaki farkı hesaplama

#### struct2 - Karmaşık Sayı Hesaplama
Karmaşık sayıları temsil eden struct:
- Toplama ve çıkarma işlemleri
- ToString() metodu ile (a + bi) formatında gösterim

#### struct3 - Nokta Koordinatları
2D koordinat sistemi için struct örneği.

### 🔹 Indexer (İndeksleyici) Örnekleri

#### Tek Boyutlu ve Çift Boyutlu İndeksleyiciler1-4
Özel koleksiyon sınıfları için indeksleyici örnekleri:
- Tek boyutlu indeksleyici örnekleri
- Çift boyutlu indeksleyici örnekleri
- Geçersiz indeks kontrolü ve hata yönetimi

## 🛠️ Gereksinimler

- **.NET Framework 4.6.1** veya üzeri
- **Visual Studio** 2015 veya üzeri (veya herhangi bir C# IDE)
- **Windows** işletim sistemi (veya .NET Core ile uyumlu sistem)

## 📦 Projeyi Çalıştırma

1. Projeyi klonlayın veya indirin
2. Her bir uygulama klasöründeki `.sln` dosyasını Visual Studio ile açın
3. Projeyi derleyin (Build)
4. Projeyi çalıştırın (Run)

Alternatif olarak:
```bash
# Her bir proje klasöründe
cd enum1/enum1
dotnet build
dotnet run
```

## 📝 Notlar

- Tüm projeler `.NET Framework 4.6.1` hedeflemektedir
- Her proje bağımsız olarak çalıştırılabilir
- Proje dosyaları `.csproj` formatındadır
- Kaynak kod dosyaları `Program.cs` içinde bulunmaktadır

## 📚 Öğrenilen Kavramlar

- ✅ Enum (Numaralandırma) kullanımı
- ✅ Method Overloading (Aşırı Yükleme)
- ✅ Struct (Yapı) tanımlama ve kullanımı
- ✅ Indexer (İndeksleyici) oluşturma
- ✅ C# temel programlama yapıları
- ✅ Hata yönetimi ve validasyon

## 📄 Lisans

Bu proje eğitim amaçlı hazırlanmıştır.

---

**Hazırlayan:** [İsim]
**Tarih:** 2024

