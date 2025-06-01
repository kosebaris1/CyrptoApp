using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace sifreleme.Controllers
{
    public class RSAController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["PublicKey"] != null)
                ViewBag.PublicKey = TempData["PublicKey"];

            if (TempData["PrivateKey"] != null)
                ViewBag.PrivateKey = TempData["PrivateKey"];

            return View();
        }

        [HttpPost]
        public IActionResult GenerateKeys()
        {
            using (RSA rsa = RSA.Create(2048))
            {
                string publicKey = Convert.ToBase64String(rsa.ExportSubjectPublicKeyInfo());
                string privateKey = Convert.ToBase64String(rsa.ExportPkcs8PrivateKey());

                TempData["PublicKey"] = publicKey;
                TempData["PrivateKey"] = privateKey;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Encrypt(string plainText, string publicKey, string privateKey)
        {
            try
            {
                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportSubjectPublicKeyInfo(Convert.FromBase64String(publicKey), out _);
                    byte[] data = Encoding.UTF8.GetBytes(plainText);
                    byte[] encrypted = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
                    ViewBag.EncryptedText = Convert.ToBase64String(encrypted);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Şifreleme hatası: " + ex.Message;
            }

            ViewBag.PublicKey = publicKey;
            ViewBag.PrivateKey = privateKey;

            return View("Index");
        }

        [HttpPost]
        public IActionResult Decrypt(string encryptedText, string privateKey, string publicKey)
        {
            try
            {
                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportPkcs8PrivateKey(Convert.FromBase64String(privateKey), out _);
                    byte[] data = Convert.FromBase64String(encryptedText);
                    byte[] decrypted = rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
                    ViewBag.DecryptedText = Encoding.UTF8.GetString(decrypted);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Çözme hatası: " + ex.Message;
            }

            ViewBag.PublicKey = publicKey;
            ViewBag.PrivateKey = privateKey;
            ViewBag.EncryptedText = encryptedText;

            return View("Index");
        }
    }
}
