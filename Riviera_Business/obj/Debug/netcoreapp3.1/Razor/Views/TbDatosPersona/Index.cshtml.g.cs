#pragma checksum "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38d642e4781afb0c965b00068d60b0b15fed452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbDatosPersona_Index), @"mvc.1.0.view", @"/Views/TbDatosPersona/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38d642e4781afb0c965b00068d60b0b15fed452", @"/Views/TbDatosPersona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbDatosPersona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Riviera_Business.Models.TbDatosPersona>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Clientes</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38d642e4781afb0c965b00068d60b0b15fed4525109", async() => {
                WriteLiteral("Agregar Otra Persona");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table border=""0"" cellspacing=""5"" cellpadding=""5"">
    <tbody>
        <tr>
            <td>Fecha Inicial:</td>
            <td><input type=""text"" id=""min"" name=""min""></td>
        </tr>
        <tr>
            <td>Fecha Final:</td>
            <td><input type=""text"" id=""max"" name=""max""></td>
        </tr>
    </tbody>
</table>
<p>Si la persona es ""Fisica"" los datos a partir de ""Fecha Poder Notorial"" se mostraran vacios </p>
<table class=""table""  id=""dataTable1"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 29 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ActividadUOcupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoInterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoExterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FisicaOMoral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AutoridadEmite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Puesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Denominacion Razon Social\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 104 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nacionalidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 122 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ActividadUOcupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 125 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreCalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoInterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 131 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoExterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 134 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 137 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 140 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 143 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 146 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 149 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 152 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 155 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
                 if (item.FisicaOMoral == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4973, "\"", 4999, 1);
#nullable restore
#line 157 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
WriteAttributeValue("", 4981, item.FisicaOMoral, 4981, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Persona Unica</label>\r\n");
#nullable restore
#line 158 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5110, "\"", 5136, 1);
#nullable restore
#line 161 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
WriteAttributeValue("", 5118, item.FisicaOMoral, 5118, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Representante</label>\r\n");
#nullable restore
#line 162 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 165 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 168 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 171 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoPoderNotorial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 174 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AutoridadEmite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 177 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Puesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 180 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 183 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdPmDpNavigation.DenominacionRazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38d642e4781afb0c965b00068d60b0b15fed45224635", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 186 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
                                       WriteLiteral(item.IdDatosPersona);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38d642e4781afb0c965b00068d60b0b15fed45226917", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 187 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
                                          WriteLiteral(item.IdDatosPersona);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 190 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbDatosPersona\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>

    $.fn.dataTable.ext.search.push(
        function (settings, data, dataIndex) {
            var min = $(""#min"").val();
            min = min.split(""/"");
            min = new Date(min[2], min[1], min[0]);

            var max = $(""#max"").val();
            max = max.split(""/"");
            max = new Date(max[2], max[1], max[0]);

            var age = data[5].split("" "")[0];
            age = age.split(""/"");
            age = new Date(age[2], age[1], age[0]);


            if ((isNaN(min.getTime()) && isNaN(max.getTime())) ||
                (isNaN(min.getTime()) && age.getTime() <= max.getTime()) ||
                (min.getTime() <= age.getTime() && isNaN(max.getTime())) ||
                (min.getTime() <= age.getTime() && age.getTime() <= max.getTime())) {
                return true;
            }
            return false;
        }
    );


    $(document).ready(function () {
        var table = $(""#dataTable1"").DataTable({
            s");
            WriteLiteral("crollX: \"true\"\r\n        });\r\n        $(\'#min, #max\').keyup(function () {\r\n            table.draw();\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Riviera_Business.Models.TbDatosPersona>> Html { get; private set; }
    }
}
#pragma warning restore 1591
