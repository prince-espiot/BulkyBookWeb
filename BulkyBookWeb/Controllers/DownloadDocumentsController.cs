using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class DownloadDocumentsController : Controller
    {
        public IActionResult DownloadPdf()
        {

            
            return View();
        }

        public IActionResult ClickableDownloadCV()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Documents","Prince Okumo devops.pdf");
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File not found.");
            }else {
                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "application/pdf", "Prince Okumo devops.pdf");
            }
        }
    }
}
