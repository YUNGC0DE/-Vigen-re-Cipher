#pragma checksum "C:\Users\menin\source\repos\kurs\Views\Decrypt\Decrypt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a1e13139ef2e35328a70392e4e18f1362b078d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Decrypt_Decrypt), @"mvc.1.0.view", @"/Views/Decrypt/Decrypt.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\menin\source\repos\kurs\Views\_ViewImports.cshtml"
using kurs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\menin\source\repos\kurs\Views\_ViewImports.cshtml"
using kurs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a1e13139ef2e35328a70392e4e18f1362b078d", @"/Views/Decrypt/Decrypt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7d7689cb7e8fb094c328ac53bd87815f271e27", @"/Views/_ViewImports.cshtml")]
    public class Views_Decrypt_Decrypt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("decrypt-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\menin\source\repos\kurs\Views\Decrypt\Decrypt.cshtml"
  
    ViewData["Title"] = "Decrypt";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Расшифровать</h1>

<!DOCTYPE HTML>
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">
<title>Контактная форма</title>
<style>
     textarea{
        width:100%;
        border-radius: 2px;
        height:150px;
    }
    #decrypt-form { /* вся форма */
        max-width: 100%;
        padding: 2%;
        border-radius: 3px;
        background: #f1f1f1;
    }

        #decrypt-form label { /* наименование полей */
            float: left;
            display: block;
            clear: right;
        }

        #decrypt-form .w100 { /* поля */
            float: right;
            max-width: 80%;
            width: 97%;
            margin-bottom: 1em;
            padding: 1.5%;
        }

        #decrypt-form .border { /* граница полей */
            border-radius: 1px;
            border-width: 1px;
            border-style: solid;
            border-color: #C0C0C0 #D9D9D9 #D9D9D9;
            box-shadow: 0 1px 1px rgba(255,255,255,.5), 0 1px 1px rgba");
            WriteLiteral(@"(0,0,0,.1) inset;
        }

            #decrypt-form .border:focus {
                outline: none;
                border-color: #abd9f1 #bfe3f7 #bfe3f7;
            }

            #decrypt-form .border:hover {
                border-color: #7eb4ea #97cdea #97cdea;
            }

            #decrypt-form .border:focus::-moz-placeholder { /* убрать при фокусе первоначальный текст поля */
                color: transparent;
            }

            #decrypt-form .border:focus::-webkit-input-placeholder {
                color: transparent;
            }

            #decrypt-form .border:not(:focus):not(:hover):valid { /* правильно заполненные поля */
                opacity: .8;
            }

    #submitDF { /* кнопка ""Отправить"" */
        padding: 2%;
        border: none;
        border-radius: 3px;
        box-shadow: 0 0 0 1px rgba(0,0,0,.2) inset;
        background: #669acc;
        color: #fff;
    }

    #decrypt-form br {
        height: 0;
        clear: bot");
            WriteLiteral("h;\r\n    }\r\n\r\n    #submitDF:hover {\r\n        background: #5c90c2;\r\n    }\r\n\r\n    #submitDF:focus {\r\n        box-shadow: 0 1px 1px #fff, inset 0 1px 2px rgba(0,0,0,.8), inset 0 -1px 0 rgba(0,0,0,.05);\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01a1e13139ef2e35328a70392e4e18f1362b078d7045", async() => {
                WriteLiteral("\r\n    <label for=\"keyEF\">Ключ:</label>\r\n    <input type=\"text\" name=\"keyDF\" id=\"keyDF\" required placeholder=\"Например, Скорпион\" x-autocompletetype=\"Key\" class=\"w100 border\">\r\n    <label for=\"fileDF\">Прикрепить файл:</label>\r\n");
#nullable restore
#line 92 "C:\Users\menin\source\repos\kurs\Views\Decrypt\Decrypt.cshtml"
     using (Html.BeginForm("Upload", "UploadController", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"file\" name=\"fileDF\" multiple id=\"fileDF\" class=\"w100\">\r\n");
#nullable restore
#line 95 "C:\Users\menin\source\repos\kurs\Views\Decrypt\Decrypt.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <label for=\"textDF\">Текст:</label>\r\n<textarea name=\"textDF\" id=\"textDF\" required rows=\"5\" placeholder=\"Текст для дешифровки\" class=\"w100 border\"></textarea>\r\n    <br>\r\n    <input value=\"Расшифровать\" type=\"submit\" id=\"submitDF\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01a1e13139ef2e35328a70392e4e18f1362b078d9805", async() => {
                WriteLiteral("\r\n    <textarea name=\"dec_text\">");
#nullable restore
#line 102 "C:\Users\menin\source\repos\kurs\Views\Decrypt\Decrypt.cshtml"
                         Write(DecrypteModel.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
