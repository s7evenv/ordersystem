using Microsoft.AspNetCore.Mvc;
using PurchaseOrderDemo.Models;
using System.IO;
using System.Threading.Tasks;

namespace PurchaseOrderDemo.Controllers
{
    public class PurchaseOrderController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PurchaseOrderController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(PurchaseOrderModel model)
        {
            if (model.PurchaseOrderFile != null)
            {
                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                string fileName = Path.GetFileName(model.PurchaseOrderFile.FileName);
                string filePath = Path.Combine(uploadPath, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.PurchaseOrderFile.CopyToAsync(fileStream);
                }

                // After saving, return file path to view PDF
                ViewBag.FilePath = "/uploads/" + fileName;
            }
            return View();
        }
    }
}
