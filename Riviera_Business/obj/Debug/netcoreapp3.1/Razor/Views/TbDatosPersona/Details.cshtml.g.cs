#pragma checksum "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd979d1b14ac2e1955480d714377332257ff894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbDatosPersona_Details), @"mvc.1.0.view", @"/Views/TbDatosPersona/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd979d1b14ac2e1955480d714377332257ff894", @"/Views/TbDatosPersona/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbDatosPersona_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbDatosPersona>
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
#line 3 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n<p>Si la persona es Fisica No es necesario haber llenado los datos a partir de \"Fecha Poder Notorial\" </p>\r\n<div>\r\n    <h4>Datos Persona</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ActividadUOcupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.ActividadUOcupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreCalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoInterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoInterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoExterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoExterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FisicaOMoral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 113 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
             if (Model.FisicaOMoral == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 3935, "\"", 3962, 1);
#nullable restore
#line 115 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
WriteAttributeValue("", 3943, Model.FisicaOMoral, 3943, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Persona</label>\r\n");
#nullable restore
#line 116 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 4051, "\"", 4078, 1);
#nullable restore
#line 119 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
WriteAttributeValue("", 4059, Model.FisicaOMoral, 4059, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Representante</label>\r\n");
#nullable restore
#line 120 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AutoridadEmite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.AutoridadEmite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Puesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Puesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdPmDpNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdPmDpNavigation.DenominacionRazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd979d1b14ac2e1955480d714377332257ff89422274", async() => {
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
#line 167 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Details.cshtml"
                           WriteLiteral(Model.IdDatosPersona);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd979d1b14ac2e1955480d714377332257ff89424451", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Riviera_Business.Models.TbDatosPersona> Html { get; private set; }
    }
}
#pragma warning restore 1591
