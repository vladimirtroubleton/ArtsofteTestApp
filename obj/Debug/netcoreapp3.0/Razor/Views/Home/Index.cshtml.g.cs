#pragma checksum "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1565fb37cc09a6ba1e7231bd69be3ecafe35b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1565fb37cc09a6ba1e7231bd69be3ecafe35b5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3169d763cda94cb717ed8ecde6decf21e4f5029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArtsofteTestApp.ViewModels.StaffViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"">
        <div class=""row"">
            <a href=""/Home/AddStaffRecord"" class=""btn btn-outline-dark"" style=""margin-bottom:50px;"">Добавить сотрудника</a>
            <a href=""/Home/LookProgLanguages"" class=""btn btn-outline-dark"" style=""margin-bottom:50px; margin-left:50px;"">Посмотреть информацию о языках</a>
            <a href=""/Home/LookDepartamentsData"" class=""btn btn-outline-dark"" style=""margin-bottom:50px; margin-left:50px;"">Посмотреть информацию о отделах</a>
        </div>
        <table class=""text-center table table-bordered"">
            <tr>
                <td>Имя</td>
                <td>Фамилия</td>
                <td>Возраст</td>
                <td>Пол</td>
                <td>Отдел</td>
                <td>Язык программирования</td>
                <td>Действия</td>
            </tr>
");
#nullable restore
#line 21 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
                   Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
                   Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
                   Write(item.DepartamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
                   Write(item.ProgrammingLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1337, "\"", 1374, 2);
            WriteAttributeValue("", 1344, "/Home/StaffRecordEdit/", 1344, 22, true);
#nullable restore
#line 30 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1366, item.Id, 1366, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\" style=\"margin:10px;\">Изменить</a><a");
            BeginWriteAttribute("href", " href=\"", 1440, "\"", 1479, 2);
            WriteAttributeValue("", 1447, "/Home/StaffRecordRemove/", 1447, 24, true);
#nullable restore
#line 30 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1471, item.Id, 1471, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Удалить</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "D:\Develop\ArtsofteTestApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArtsofteTestApp.ViewModels.StaffViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591