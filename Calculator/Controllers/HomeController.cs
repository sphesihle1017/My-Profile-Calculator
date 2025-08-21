using Calculator.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        // Constructor: Inject the IWebHostEnvironment service
        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult DownloadCV()
        {
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Downloads", "Sphe_Shezi_IT_CV.pdf");

            string contentType = "application/pdf";

            string downloadName = "SphesihleShezi_CV.pdf";

            return PhysicalFile(filePath, contentType, downloadName);
        }

        
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        
    }
}
