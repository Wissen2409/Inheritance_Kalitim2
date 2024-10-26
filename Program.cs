// Akbank sınıfına ait bir nesne örneği alalım

Akbank akbank = new Akbank();
akbank.Url="https://akbank.com.tr";

Garanti garanti = new Garanti();
garanti.Url="https://garanti.com";

// Url alanı, tüm banka sınıflarına bankbase adında bir ana sınıftan gelmektedir.!!!

Ziraat ziraat= new Ziraat();
ziraat.Renk="Kırmızı";
// ziraat sınıfının ieçrisinde sadece ziratte olması gereken bir özellik ekledik
// nesne örneği üzeirnden baktığımızda, bankbase sınıfından kalıtım yolu ile gelen propların yanında kendine ait bir prop'da listelendi.!!!