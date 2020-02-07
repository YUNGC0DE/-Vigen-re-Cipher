using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using kurs.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Spire.Doc;
using Spire.Doc.Documents;

namespace kurs.Controllers
{
    public class DecryptController : Controller
    {
        private IHostingEnvironment ihost;

        public DecryptController(IHostingEnvironment ihost)
        {
            this.ihost = ihost;
        }
       
        public ActionResult Decrypt()
        {
            DecrypteModel.Text = "";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Decrypt( string keyDF, string textDf, IFormFile FileDF)
        {
            try
            {
                var dir = ihost.ContentRootPath;
                string type = FileDF.FileName;
                if (type.EndsWith(".txt"))
                {
                    var encoding = System.Text.Encoding.UTF8;
                    using (var fileStream = new FileStream(Path.Combine(dir, "fileDe.txt"), FileMode.Create, FileAccess.ReadWrite))
                    {
                        FileDF.CopyTo(fileStream); 
                    }
                    string text = System.IO.File.ReadAllText("fileDe.txt", encoding);
                    System.IO.File.Delete("fileDe.txt");
                    DecrypteModel.Decrypte(text, keyDF);
                    Document doc_dec = new Document();
                    Paragraph par = doc_dec.AddSection().AddParagraph();
                    par.AppendText(DecrypteModel.Text);
                    doc_dec.SaveToFile("file.docx", FileFormat.Docx);

                }
                if (type.EndsWith(".docx"))
                {
                    var encoding = System.Text.Encoding.UTF8;
                    using (var ms = new MemoryStream())
                    {
                        FileDF.CopyTo(ms);
                        Document doc = new Document();
                        doc.LoadFromStream(ms, FileFormat.Docx);
                        string text = doc.GetText();
                        DecrypteModel.Decrypte(text, keyDF);
                        Document doc_dec = new Document();
                        Paragraph par = doc_dec.AddSection().AddParagraph();
                        par.AppendText(DecrypteModel.Text);
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
                    DecrypteModel.Decrypte(textDf, keyDF);
                    par.AppendText(DecrypteModel.Text);
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