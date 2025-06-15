# 🔐 RSA Şifreleme ve 🧬 SHA-256 Hashleme Uygulaması

---

## 🚀 Proje Hakkında

Bu web uygulaması, **ASP.NET Core MVC** kullanılarak geliştirilmiştir ve kriptografi alanında iki temel işlevi destekler:

- **RSA Şifreleme**: Metinlerinizi güvenli bir şekilde şifreleyip, şifreli metinleri çözülebilirsiniz.  
- **SHA-256 Hashleme**: Metin veya dosyaların güçlü bir şekilde hash değerini hesaplayabilirsiniz.

Kullanıcı dostu ve modern arayüz ile güvenli şifreleme ve hashleme işlemlerini kolayca yapabilirsiniz.

---
## Ana Sayfa
![image](https://github.com/user-attachments/assets/01aaa1de-4e03-4419-b757-07e89334a74f)
![image](https://github.com/user-attachments/assets/3ebf299d-646b-4aa0-93c1-e172fbc8fe0f)
Uygulamanın ana sayfasında kullanıcılar, aşağıdaki iki seçenekten istediklerini kolayca seçebilir:

🔐 RSA Şifreleme: Metinlerinizi güvenli şekilde şifrelemek ve şifre çözme işlemlerini gerçekleştirmek için RSA algoritmasını kullanabilirsiniz.
🧬 SHA-256 Hashleme: Metin veya dosyalarınızın SHA-256 hash değerlerini hızlı ve güvenli şekilde hesaplayabilirsiniz.

## RSA Şifreleme Sayfası
![image](https://github.com/user-attachments/assets/7e5d5b8e-402b-4299-94ab-43bee2f8ea19)

Uygulamanın RSA şifreleme sayfasında kullanıcılar:
- Güvenli public ve private anahtarlar üretebilir,
- Oluşturdukları public key ile metinleri şifreleyebilir,
- Şifrelenmiş metinleri private key kullanarak çözebilirler.
Kullanıcı dostu arayüz ile bu işlemler kolaylıkla gerçekleştirilebilir.

![image](https://github.com/user-attachments/assets/1e20ad09-ae63-464a-abd3-eb738ca2b8c5)
Yukarıda görüldüğü üzere kullanıcılar anahtar üretebilmektedir.
Üretilen anahtarlar kullanım kolaylığı açısından; public key şifre oluşturma alanına, private key ise şifre çözme alanına otomatik olarak atanır.
Bu sayede kullanıcılar, anahtarları manuel olarak kopyalamak zorunda kalmadan işlemlerini hızlı ve pratik şekilde gerçekleştirebilirler.

![image](https://github.com/user-attachments/assets/363141e8-03ab-4890-b183-9887498df0a8)
![image](https://github.com/user-attachments/assets/c9bc9a5a-f7d8-4f79-9cb6-61db81e19a8b)
Şifrelenmiş metin kullanım kolaylığı açısından otomatik olarak RSA ile şifre çözme alanına atanabilmektedir.

## RSA İle Çözme
![image](https://github.com/user-attachments/assets/e038e0b6-1910-4b40-bef8-fd91565ce6f5)
Yukarıda görüldüğü üzere şifre çözme işlemi başarıyla gerçekleşmektedir.

## SHA-256 Hashleme
![image](https://github.com/user-attachments/assets/f31a5f5e-afd8-4304-8d7a-5397abb00c76)
![image](https://github.com/user-attachments/assets/9c1c084b-072d-43f1-ae48-d2ce29748aac) ![image](https://github.com/user-attachments/assets/c25d7caa-2d2a-43f1-bb83-f78122f4e993)
![image](https://github.com/user-attachments/assets/24760ad8-6a64-4476-b3e8-a33b3044f76b)
![image](https://github.com/user-attachments/assets/4c7f68e7-4173-4b06-8143-d09132bd3936)

Yukarıdaki resimlerde görüldüğü üzere SHA-256 ile hashleme yapılmaktadır. Kullanıcı isteği doğrultusunda metin veya dosya seçebilmektedir. Hem metin hem de dosya aynı anda doldurulursa öncelik metne verilmektedir.


## ✨ Özellikler

- 🔑 **RSA Anahtar Çifti Üretimi** (Public & Private Key)  
- 🔒 **RSA ile Metin Şifreleme** ve **Şifre Çözme**  
- 🧾 **SHA-256 Hashleme** (Metin ve Dosya desteği)  
- 💻 Responsive ve modern Bootstrap 5 tabanlı arayüz  
- ⚙️ Basit ve anlaşılır kullanım  
- 🔐 Güçlü .NET kriptografi kütüphaneleri ile güvenlik  

---

## 🛠️ Teknolojiler

| Teknoloji            | Versiyon / Notlar         |
| -------------------- | ------------------------- |
| ASP.NET Core MVC     | .NET 8 ve üzeri           |
| C#                   | Modern C# 10+             |
| Bootstrap            | 5.x                       |
| System.Security.Cryptography | RSA ve SHA256 işlemleri |

---

## 📦 Kurulum ve Çalıştırma

```bash
# Depoyu klonla
git clone https://github.com/kosebaris1/CyrptoApp.git

# Proje klasörüne gir
cd proje-adi

# Projeyi aç (Visual Studio veya VS Code ile)

# Projeyi derle ve çalıştır
dotnet run
