using System.Security.Cryptography;
using System.Text;

namespace CyrptoApp.Helpers
{
    public class CryptoHelper
    {
        public static string Encrypt(string plainText, string publicKeyXml)
        {
            using var rsa = RSA.Create();
            rsa.FromXmlString(publicKeyXml);
            var bytes = Encoding.UTF8.GetBytes(plainText);
            var encryptedBytes = rsa.Encrypt(bytes, RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string encryptedText, string privateKeyXml)
        {
            using var rsa = RSA.Create();
            rsa.FromXmlString(privateKeyXml);
            var bytes = Convert.FromBase64String(encryptedText);
            var decryptedBytes = rsa.Decrypt(bytes, RSAEncryptionPadding.Pkcs1);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        public static string HashSHA256(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        public static (string publicKeyXml, string privateKeyXml) GenerateKeys()
        {
            using var rsa = RSA.Create(2048);
            return (rsa.ToXmlString(false), rsa.ToXmlString(true));
        }
    }
}
