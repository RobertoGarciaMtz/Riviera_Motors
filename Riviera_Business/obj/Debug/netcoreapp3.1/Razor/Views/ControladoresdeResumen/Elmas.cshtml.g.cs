#pragma checksum "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8310a5dfb01b106fc82161a27e329bc3a177dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControladoresdeResumen_Elmas), @"mvc.1.0.view", @"/Views/ControladoresdeResumen/Elmas.cshtml")]
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
#line 1 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\_ViewImports.cshtml"
using Riviera_Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\_ViewImports.cshtml"
using Riviera_Business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8310a5dfb01b106fc82161a27e329bc3a177dcc", @"/Views/ControladoresdeResumen/Elmas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_ControladoresdeResumen_Elmas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbCarros>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
  
    ViewData["Title"] = "Elmas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Elmas</h1>

<div>
   
</div>
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""box"">
                <div class=""box-header with-border"">Red Social de mayor influencia</div>
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th>Red Social</th>
                            <th>Cantidad</th>
                        </tr>
");
#nullable restore
#line 23 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                         foreach (var top1 in ViewBag.datos)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""box"">
                <div class=""box-header with-border"">Red Social de mayor influencia</div>
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th>Red Social</th>
                            <th>Cantidad</th>
                        </tr>
");
#nullable restore
#line 43 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                         foreach (var top1 in ViewBag.datos2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""box"">
                <div class=""box-header with-border"">Red Social de mayor influencia</div>
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th>Red Social</th>
                            <th>Cantidad</th>
                        </tr>
");
#nullable restore
#line 63 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                         foreach (var top1 in ViewBag.datos3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 66 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 67 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""box"">
                <div class=""box-header with-border"">Color mas comprado</div>
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th>Color</th>
                            <th>Cantidad</th>
                        </tr>
");
#nullable restore
#line 85 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                         foreach (var top1 in ViewBag.datos4)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 88 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 89 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""box"">
                <div class=""box-header with-border"">El asesor con mas atendidos</div>
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th>Asesor</th>
                            <th>Cantidad</th>
                        </tr>
");
#nullable restore
#line 105 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                         foreach (var top1 in ViewBag.datos5)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 108 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 109 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""box"">
                <div class=""box-header with-border"">Modelo de automovil mas vendido</div>
                <div class=""box-body"">
                    <table class=""table table-bordered"">
                        <tr>
                            <th>automovil mas vendido</th>
                            <th>Cantidad</th>
                        </tr>
");
#nullable restore
#line 125 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                         foreach (var top1 in ViewBag.datos6)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 128 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 129 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                               Write(top1.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 131 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\ControladoresdeResumen\Elmas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Riviera_Business.Models.TbCarros> Html { get; private set; }
    }
}
#pragma warning restore 1591
