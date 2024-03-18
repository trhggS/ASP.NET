using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace lr7.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            var content = $"First Name: {firstName}\nLast Name: {lastName}";

            byte[] byteArray = Encoding.ASCII.GetBytes(content);
            MemoryStream stream = new MemoryStream(byteArray);

            return File(stream, "text/plain", $"{fileName}.txt");
        }
    }
}
