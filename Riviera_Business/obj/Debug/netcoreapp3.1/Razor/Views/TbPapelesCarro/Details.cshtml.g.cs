#pragma checksum "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c05a1f5990cef9c054d055cf0a16f8b6db739119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbPapelesCarro_Details), @"mvc.1.0.view", @"/Views/TbPapelesCarro/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c05a1f5990cef9c054d055cf0a16f8b6db739119", @"/Views/TbPapelesCarro/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbPapelesCarro_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbPapelesCarro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Papeles Carro</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FactOrigen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 17 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.FactOrigen == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.FactOrigen\">Entregado</label>\r\n");
#nullable restore
#line 20 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.FactOrigen == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <label value=\"Model.FactOrigen\">No Entregado</label>\r\n");
#nullable restore
#line 24 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.FactOrigen == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <label value=\"Model.FactOrigen\">Problemas</label>\r\n");
#nullable restore
#line 28 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RefactCompleta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.RefactCompleta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tenencias4Anos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tenencias4Anos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Baja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 46 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.Baja == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.Baja\">Entregado</label>\r\n");
#nullable restore
#line 49 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.Baja == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.Baja\">No Entregado</label>\r\n");
#nullable restore
#line 53 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.Baja == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.Baja\">Problemas</label>\r\n");
#nullable restore
#line 57 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Verificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 63 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.Verificacion == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.Verificacion\">Tiene</label>\r\n");
#nullable restore
#line 66 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.Verificacion == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.Verificacion\">No Tiene</label>\r\n");
#nullable restore
#line 70 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
             if (Model.Verificacion == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label value=\"Model.Verificacion\">Problemas</label>\r\n");
#nullable restore
#line 74 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaUlltimaVerificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaUlltimaVerificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Repuve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.Repuve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEmisor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEmisor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Transunionfolio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model=> model.Transunionfolio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCarroNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            Con\r\n            ");
#nullable restore
#line 117 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCarroNavigation.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c05a1f5990cef9c054d055cf0a16f8b6db73911917276", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbPapelesCarro\Details.cshtml"
                           WriteLiteral(Model.IdPapelesCarro);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c05a1f5990cef9c054d055cf0a16f8b6db73911919453", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Riviera_Business.Models.TbPapelesCarro> Html { get; private set; }
    }
}
#pragma warning restore 1591
