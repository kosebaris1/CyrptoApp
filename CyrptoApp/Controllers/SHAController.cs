using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace sifreleme.Controllers
{
    public class SHAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Hash(string inputText, IFormFile inputFile)
        {
            string result = "";
            string type = "";

            if (!string.IsNullOrWhiteSpace(inputText))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(inputText);
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    result = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                    type = "text";
                }
            }
            else if (inputFile != null && inputFile.Length > 0)
            {
                using (var sha256 = SHA256.Create())
                using (var stream = inputFile.OpenReadStream())
                {
                    byte[] hashBytes = await sha256.ComputeHashAsync(stream);
                    result = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                    type = "file";
                }
            }

            ViewBag.HashResult = result;
            ViewBag.InputText = inputText;
            ViewBag.Type = type;

            return View("Index");
        }
    }
}
