#pragma checksum "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c9479fd37eccb0c5047ad739c6fd0963b73503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbDocumentacion_Details), @"mvc.1.0.view", @"/Views/TbDocumentacion/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c9479fd37eccb0c5047ad739c6fd0963b73503", @"/Views/TbDocumentacion/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbDocumentacion_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbDocumentacion>
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
#line 3 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Documentacion</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdentificacionVig));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 17 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.IdentificacionVig == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 416, "\"", 448, 1);
#nullable restore
#line 19 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 424, Model.IdentificacionVig, 424, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 20 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 532, "\"", 564, 1);
#nullable restore
#line 23 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 540, Model.IdentificacionVig, 540, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 24 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 30 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.Curp == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 815, "\"", 834, 1);
#nullable restore
#line 32 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 823, Model.Curp, 823, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 33 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 918, "\"", 937, 1);
#nullable restore
#line 36 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 926, Model.Curp, 926, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 37 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CifSat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 43 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.CifSat == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1192, "\"", 1213, 1);
#nullable restore
#line 45 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 1200, Model.CifSat, 1200, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 46 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1297, "\"", 1318, 1);
#nullable restore
#line 49 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 1305, Model.CifSat, 1305, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 50 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ComprobDomicilio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 56 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.ComprobDomicilio == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1593, "\"", 1624, 1);
#nullable restore
#line 58 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 1601, Model.ComprobDomicilio, 1601, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 59 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1708, "\"", 1739, 1);
#nullable restore
#line 62 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 1716, Model.ComprobDomicilio, 1716, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 63 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConocimientoDuenoBeneficiario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 69 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.ConocimientoDuenoBeneficiario == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2040, "\"", 2084, 1);
#nullable restore
#line 71 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 2048, Model.ConocimientoDuenoBeneficiario, 2048, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 72 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2168, "\"", 2212, 1);
#nullable restore
#line 75 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 2176, Model.ConocimientoDuenoBeneficiario, 2176, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 76 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ActaConstitutivaBoletaRpc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 82 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.ActaConstitutivaBoletaRpc == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2505, "\"", 2545, 1);
#nullable restore
#line 84 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 2513, Model.ActaConstitutivaBoletaRpc, 2513, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 85 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2629, "\"", 2669, 1);
#nullable restore
#line 88 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 2637, Model.ActaConstitutivaBoletaRpc, 2637, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 89 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PoderLegarExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 95 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.PoderLegarExp == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2938, "\"", 2966, 1);
#nullable restore
#line 97 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 2946, Model.PoderLegarExp, 2946, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 98 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 3050, "\"", 3078, 1);
#nullable restore
#line 101 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 3058, Model.PoderLegarExp, 3058, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 102 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConstanciaConocimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 108 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
             if (Model.ConstanciaConocimiento == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 3365, "\"", 3402, 1);
#nullable restore
#line 110 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 3373, Model.ConstanciaConocimiento, 3373, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 111 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 3486, "\"", 3523, 1);
#nullable restore
#line 114 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
WriteAttributeValue("", 3494, Model.ConstanciaConocimiento, 3494, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 115 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <!------------------------------------------------------------------------------>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MesCorrespondiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.MesCorrespondiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdDatosPersonaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdDatosPersonaNavigation.IdDatosPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.IdEstados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c9479fd37eccb0c5047ad739c6fd0963b7350323493", async() => {
                WriteLiteral("Editar");
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
#line 145 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDocumentacion\Details.cshtml"
                           WriteLiteral(Model.IdDocumentos);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c9479fd37eccb0c5047ad739c6fd0963b7350325671", async() => {
                WriteLiteral("Lista Personas Moral");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Riviera_Business.Models.TbDocumentacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
