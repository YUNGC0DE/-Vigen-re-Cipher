using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kurs.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Spire.Doc;
using Spire.Doc.Documents;

namespace kurs.Controllers
{
    public class EncryptController : Controller
    {
        private IHostingEnvironment ihost;

        public EncryptController(IHostingEnvironment ihost)
        {
            this.ihost = ihost;
        }

        // GET: Encrypt/Create
        public ActionResult Encrypt()
        {   

            EncrypteModel.Text = "";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Encrypt(string keyEF, string textEF, IFormFile FileEF)
        {
            try
            {
                var dir = ihost.ContentRootPath;
                string type = FileEF.FileName;
                if (type.EndsWith(".txt"))
                {
                    var encoding = System.Text.Encoding.UTF8;
                    using (var fileStream = new FileStream(Path.Combine(dir, "fileEn.txt"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        FileEF.CopyTo(fileStream);
                    }
                    string text = System.IO.File.ReadAllText("fileEn.txt", encoding);
                    System.IO.File.Delete("fileEn.txt");
                    EncrypteModel.Encrypte(text, keyEF);
                    Document doc_dec = new Document();
                    Paragraph par = doc_dec.AddSection().AddParagraph();
                    par.AppendText(EncrypteModel.Text);
                    doc_dec.SaveToFile("file.docx", FileFormat.Docx);
                }
                if (type.EndsWith(".docx"))
                {
                   
                    using (var ms = new MemoryStream())
                    {
                        FileEF.CopyTo(ms);
                        Document doc = new Document();
                        doc.LoadFromStream(ms, FileFormat.Docx);
                        string text = doc.GetText();
                        EncrypteModel.Encrypte(text, keyEF);
                        Document doc_dec = new Document();
                        Paragraph par = doc_dec.AddSection().AddParagraph();
                        par.AppendText(EncrypteModel.Text);
                        doc_dec.SaveToFile("file.docx", FileFormat.Docx);

                    }
                }
                return View();
            }
            catch
            {
                try
                {
                    Document doc_dec = new Document();
                    Paragraph par = doc_dec.AddSection().AddParagraph();
                    EncrypteModel.Encrypte(textEF, keyEF);
                    par.AppendText(EncrypteModel.Text);
                    doc_dec.SaveToFile("file.docx", FileFormat.Docx);
                    return View();
                }
                catch (Exception)
                {
                    return View();
                }
            }
        }
    }
}