#pragma checksum "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5004a38f2b904464515fed521e32dde800afd39"
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
#line 1 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\_ViewImports.cshtml"
using yeniproje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\_ViewImports.cshtml"
using yeniproje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5004a38f2b904464515fed521e32dde800afd39", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f795c95cbde1f43385debd3aa137f1dc7cc41e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<yeniproje.Models.EmpClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #customers {
        font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        #customers td, #customers th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #customers tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #customers tr:hover {
            background-color: #ddd;
        }

        #customers th {
            padding-top: 16px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #8d99bf;
            color: white;
        }
</style>
<div class=""col-md-8"">
    <div class=""card"">
        <div class=""card-header card-header-primary"">
            <h4 class=""card-title"">Kasa Listesi</h4>
            <p class=""card-category"">Bu alanda var olan kasaları silebilir ve güncelliyebilirsiniz.</p>
        </div>
        <div class=""card-body"">

            <table class=""table"" id=""customers");
            WriteLiteral(@""">
                <thead>
                    <tr>
                        <th>
                            &ensp;
                            Id
                        </th>
                        <th>
                            Kasa Adı
                        </th>
                        <th>
                            Kasa Sahibi Adı Soyadı
                        </th>
                        <th>
                            Telefon
                        </th>
                        <th>
                            Adres
                        </th>
                        <th>
                            Açıklama
                        </th>
                        <th>
                            Bakiye (₺)
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 71 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                &ensp; &ensp;\r\n                                ");
#nullable restore
#line 76 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                &ensp;\r\n                                ");
#nullable restore
#line 80 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.Kadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.Adsoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 86 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 89 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 92 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.Acik);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 95 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(item.Bakiye);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n\r\n\r\n                                ");
#nullable restore
#line 101 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Düzenle", "Edit", "Home", new { id = item.id },
                                new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                ");
#nullable restore
#line 104 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Sil", "Delete", "Home", new { id = item.id },
                                new { @class = "btn btn-danger" , onclick = "return confirm('Kasayı silmek istediğinize emin misiniz ?');" }
                                ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 109 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 112 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
              
                if (@TempData["msg"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <script>\r\n                   alert(\'");
#nullable restore
#line 116 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                     Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n                    </script>\r\n");
#nullable restore
#line 118 "C:\Users\HP\Desktop\kasatakip\yeniproje\yeniproje\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<yeniproje.Models.EmpClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
