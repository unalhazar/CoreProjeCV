#pragma checksum "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba53b8979bc5257c5c7604ca9526db9a09e9fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba53b8979bc5257c5c7604ca9526db9a09e9fee", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenek Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 26 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                   Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n                            <span class=\"completion mr-2\">");
#nullable restore
#line 37 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
                                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n                            <div>\r\n                                <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1492, "\"", 1519, 1);
#nullable restore
#line 40 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1508, item.Value, 1508, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1558, "\"", 1586, 3);
            WriteAttributeValue("", 1566, "width:", 1566, 6, true);
#nullable restore
#line 40 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1572, item.Value, 1573, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1584, "%;", 1584, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1757, "\"", 1796, 2);
            WriteAttributeValue("", 1764, "/Skill/DeleteSkill/", 1764, 19, true);
#nullable restore
#line 45 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1783, item.SkillID, 1783, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1898, 2);
            WriteAttributeValue("", 1868, "/Skill/EditSkill/", 1868, 17, true);
#nullable restore
#line 46 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1885, item.SkillID, 1885, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Skill/AddSkill/\" class=\"btn btn-primary\">Yeni Yetenek Ekle</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
