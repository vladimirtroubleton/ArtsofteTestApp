#pragma checksum "D:\Develop\ArtsofteTestApp\Views\Home\LookProgLanguages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec1d6d9586585aa6d4a20dcc7a35b2546b1bde66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LookProgLanguages), @"mvc.1.0.view", @"/Views/Home/LookProgLanguages.cshtml")]
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
#line 1 "D:\Develop\ArtsofteTestApp\Views\_ViewImports.cshtml"
using ArtsofteTestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Develop\ArtsofteTestApp\Views\_ViewImports.cshtml"
using ArtsofteTestApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec1d6d9586585aa6d4a20dcc7a35b2546b1bde66", @"/Views/Home/LookProgLanguages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3169d763cda94cb717ed8ecde6decf21e4f5029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LookProgLanguages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProgrammingLanguageModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Develop\ArtsofteTestApp\Views\Home\LookProgLanguages.cshtml"
  
    ViewData["Title"] = "LookProgLanguages";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">

        <div class=""row"">
            <a href=""/Home/AddLanguageRecord"" class=""btn btn-outline-dark"" style=""margin-bottom:50px;"">Добавить язык</a>
            <a href=""/Home/Index"" class=""btn btn-outline-dark"" style=""margin-bottom:50px;margin-left:50px;"">На главную</a>
        </div>

        <table class=""text-center table table-bordered"">
            <tr>
                <td>Название языка</td>
            </tr>
");
#nullable restore
#line 17 "D:\Develop\ArtsofteTestApp\Views\Home\LookProgLanguages.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "D:\Develop\ArtsofteTestApp\Views\Home\LookProgLanguages.cshtml"
                   Write(item.LanguageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 22 "D:\Develop\ArtsofteTestApp\Views\Home\LookProgLanguages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProgrammingLanguageModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
