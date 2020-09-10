using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Cosmos.Business.Samples.Models;
using Cosmos.FileTypeSniffers;
using Cosmos.MimeTypeSniffers;
using Microsoft.AspNetCore.Hosting;

namespace Cosmos.Business.Samples.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IMimeSniffer _sniffer1;
        private readonly IFileTypeSniffer _sniffer2;

        public HomeController(IWebHostEnvironment env, IMimeSniffer sniffer1, IFileTypeSniffer sniffer2)
        {
            _env = env;
            _sniffer1 = sniffer1;
            _sniffer2 = sniffer2;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sniffer()
        {
            var path = _env.WebRootFileProvider.GetFileInfo("img/sniffer.jpg").PhysicalPath;
            byte[] array = new byte[20];
            using (var file = System.IO.File.Open(path, FileMode.Open))
            {
                file.Read(array, 0, array.Length);
            }

            var result0 = _sniffer1.Match(array, true);
            var results = _sniffer2.Match(array, true);
            var statistics = _sniffer2.GetMetadataStatistics();
            var content = $@"
//MimeTypeSniffer:
count:  {result0.Count}
result: {result0.ToListString()}

//FileTypeSniffer:
statistics: total={statistics.Total}
count:  {results.Count}
result: {results.ToListString()}
";
            return Content(content);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
