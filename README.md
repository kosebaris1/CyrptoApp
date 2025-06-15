# 🔐 RSA Şifreleme ve 🧬 SHA-256 Hashleme Uygulaması

---

## 🚀 Proje Hakkında

Bu web uygulaması, **ASP.NET Core MVC** kullanılarak geliştirilmiştir ve kriptografi alanında iki temel işlevi destekler:

- **RSA Şifreleme**: Metinlerinizi güvenli bir şekilde şifreleyip, şifreli metinleri çözülebilirsiniz.  
- **SHA-256 Hashleme**: Metin veya dosyaların güçlü bir şekilde hash değerini hesaplayabilirsiniz.

Kullanıcı dostu ve modern arayüz ile güvenli şifreleme ve hashleme işlemlerini kolayca yapabilirsiniz.

---
## Ana Sayfa
![image](https://github.com/user-attachments/assets/62f9e96c-0851-4f5d-9fb6-34c25c13ead2)
![image](https://github.com/user-attachments/assets/ec44bc72-b9fe-4aa2-b92a-f15a8c15503a)
Uygulamanın ana sayfasında kullanıcılar, aşağıdaki iki seçenekten istediklerini kolayca seçebilir:

🔐 RSA Şifreleme: Metinlerinizi güvenli şekilde şifrelemek ve şifre çözme işlemlerini gerçekleştirmek için RSA algoritmasını kullanabilirsiniz.
🧬 SHA-256 Hashleme: Metin veya dosyalarınızın SHA-256 hash değerlerini hızlı ve güvenli şekilde hesaplayabilirsiniz.

## RSA Şifreleme Sayfası
![image](https://github.com/user-attachments/assets/d6c1f7c6-e6d9-44d2-a14a-960b632964ea)

Uygulamanın RSA şifreleme sayfasında kullanıcılar:
- Güvenli public ve private anahtarlar üretebilir,
- Oluşturdukları public key ile metinleri şifreleyebilir,
- Şifrelenmiş metinleri private key kullanarak çözebilirler.
Kullanıcı dostu arayüz ile bu işlemler kolaylıkla gerçekleştirilebilir.

![image](https://github.com/user-attachments/assets/1f4cbf14-f8bf-4ab4-82c0-cfab1a98f9a5)
Yukarıda görüldüğü üzere kullanıcılar anahtar üretebilmektedir.
Üretilen anahtarlar kullanım kolaylığı açısından; public key şifre oluşturma alanına, private key ise şifre çözme alanına otomatik olarak atanır.
Bu sayede kullanıcılar, anahtarları manuel olarak kopyalamak zorunda kalmadan işlemlerini hızlı ve pratik şekilde gerçekleştirebilirler.

![image](https://github.com/user-attachments/assets/74d502dd-b0ec-4f59-bdd3-106851bd0b0c)
![image](https://github.com/user-attachments/assets/7727e53c-08b1-4740-afc6-f69107b38115)
Şifrelenmiş metin kullanım kolaylığı açısından otomatik olarak RSA ile şifre çözme alanına atanabilmektedir.

## RSA İle Çözme
![image](https://github.com/user-attachments/assets/8d814fdc-6b91-4a2a-8e22-098d438a5673)
Yukarıda görüldüğü üzere şifre çözme işlemi başarıyla gerçekleşmektedir.

## SHA-256 Hashleme
![image](https://github.com/user-attachments/assets/a6879498-04c1-43bb-bf06-f54a2ccda3e3)
![image](https://github.com/user-attachments/assets/24ad25ff-d8ec-46be-822d-2c997c116d51) 
![image](https://github.com/user-attachments/assets/391878be-7825-4429-8648-2b4b753c9e52)
![image](https://github.com/user-attachments/assets/a4f2991b-1767-473a-aa74-4293d69893e7)
![image](https://github.com/user-attachments/assets/3d09288d-8114-47e2-81a1-5b795bbcd7e6)

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
