using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace kurs.Controllers
{
    public class DownLoadController : Controller
    {
        public static string Text { get; private set; }
        private readonly IWebHostEnvironment _appEnvironment;
        public DownLoadController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DownLoad()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Get(string name)
        {
            try
            {
                string file_path = Path.Combine(_appEnvironment.ContentRootPath, "file.docx");
                string file_type = "application/docx";
                string file_name = name;
                return PhysicalFile(file_path, file_type, file_name);
            }
            catch
            {
                return DownLoad();
            }
        }
    }
}