#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dcb89dd826121e0ea030aac3ed256acdaebec1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbDocumentacion_Index), @"mvc.1.0.view", @"/Views/TbDocumentacion/Index.cshtml")]
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
#line 1 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\_ViewImports.cshtml"
using Riviera_Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\_ViewImports.cshtml"
using Riviera_Business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dcb89dd826121e0ea030aac3ed256acdaebec1c", @"/Views/TbDocumentacion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbDocumentacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Riviera_Business.Models.TbDocumentacion>>
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
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Lista de Documentacion Cliente</h1>
<style>

    .Entregado {
        background-color: lightgreen;
    }

    .No_Entregado {
        background-color: #ff726f;
    }

    .En_Espera {
        background-color: darkgoldenrod;
    }
</style>
<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dcb89dd826121e0ea030aac3ed256acdaebec1c5316", async() => {
                WriteLiteral("Agregar mas Documentacion Cliente");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"dataTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PersonaFM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdentificacionVig));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CifSat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComprobDomicilio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConocimientoDuenoBeneficiario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ActaConstitutivaBoletaRpc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PoderLegarExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConstanciaConocimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MesCorrespondiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Nombre\r\n            </th>\r\n            <th>\r\n                Persona correspondiente de documentacion\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 74 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 78 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.PersonaFM == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2187, "\"", 2210, 1);
#nullable restore
#line 80 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 2195, item.PersonaFM, 2195, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Fisica</label>\r\n");
#nullable restore
#line 81 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2314, "\"", 2337, 1);
#nullable restore
#line 84 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 2322, item.PersonaFM, 2322, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Moral/Representante</label>\r\n");
#nullable restore
#line 85 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 88 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.IdentificacionVig == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2520, "\"", 2551, 1);
#nullable restore
#line 90 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 2528, item.IdentificacionVig, 2528, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 91 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2669, "\"", 2700, 1);
#nullable restore
#line 94 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 2677, item.IdentificacionVig, 2677, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 95 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 98 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.Curp == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2874, "\"", 2892, 1);
#nullable restore
#line 100 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 2882, item.Curp, 2882, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 101 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3010, "\"", 3028, 1);
#nullable restore
#line 104 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 3018, item.Curp, 3018, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 105 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 108 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.CifSat == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3204, "\"", 3224, 1);
#nullable restore
#line 110 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 3212, item.CifSat, 3212, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 111 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3342, "\"", 3362, 1);
#nullable restore
#line 114 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 3350, item.CifSat, 3350, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 115 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 118 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.ComprobDomicilio == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3548, "\"", 3578, 1);
#nullable restore
#line 120 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 3556, item.ComprobDomicilio, 3556, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 121 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3696, "\"", 3726, 1);
#nullable restore
#line 124 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 3704, item.ComprobDomicilio, 3704, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 125 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 128 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.ConocimientoDuenoBeneficiario == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3925, "\"", 3968, 1);
#nullable restore
#line 130 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 3933, item.ConocimientoDuenoBeneficiario, 3933, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 131 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4086, "\"", 4129, 1);
#nullable restore
#line 134 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 4094, item.ConocimientoDuenoBeneficiario, 4094, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 135 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 138 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.ActaConstitutivaBoletaRpc == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4324, "\"", 4363, 1);
#nullable restore
#line 140 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 4332, item.ActaConstitutivaBoletaRpc, 4332, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 141 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4481, "\"", 4520, 1);
#nullable restore
#line 144 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 4489, item.ActaConstitutivaBoletaRpc, 4489, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 145 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 148 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.PoderLegarExp == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4703, "\"", 4730, 1);
#nullable restore
#line 150 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 4711, item.PoderLegarExp, 4711, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 151 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4848, "\"", 4875, 1);
#nullable restore
#line 154 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 4856, item.PoderLegarExp, 4856, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 155 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 158 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.ConstanciaConocimiento == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5067, "\"", 5103, 1);
#nullable restore
#line 160 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 5075, item.ConstanciaConocimiento, 5075, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"Entregado\">Si</label>\r\n");
#nullable restore
#line 161 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5221, "\"", 5257, 1);
#nullable restore
#line 164 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
WriteAttributeValue("", 5229, item.ConstanciaConocimiento, 5229, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"No_Entregado\">No</label>\r\n");
#nullable restore
#line 165 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <!-----------------------hasta aca llega ---------------------------------->\r\n            <td>\r\n                ");
#nullable restore
#line 169 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 172 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Enero</label>\r\n");
#nullable restore
#line 175 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Febrero</label>\r\n");
#nullable restore
#line 179 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Marzo</label>\r\n");
#nullable restore
#line 183 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Abril</label>\r\n");
#nullable restore
#line 187 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 188 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Mayo</label>\r\n");
#nullable restore
#line 191 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 192 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 6)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Junio</label>\r\n");
#nullable restore
#line 195 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 7)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Julio</label>\r\n");
#nullable restore
#line 199 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 8)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Agosto</label>\r\n");
#nullable restore
#line 203 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 204 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 9)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Septiembre</label>\r\n");
#nullable restore
#line 207 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 10)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Octubre</label>\r\n");
#nullable restore
#line 211 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 212 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 11)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Noviembre</label>\r\n");
#nullable restore
#line 215 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 216 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                 if (item.MesCorrespondiente == 12)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label>Diciembre</label>\r\n");
#nullable restore
#line 219 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 222 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdDatosPersonaNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 225 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdDatosPersonaNavigation.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 228 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dcb89dd826121e0ea030aac3ed256acdaebec1c34375", async() => {
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
#line 231 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                                       WriteLiteral(item.IdDocumentos);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dcb89dd826121e0ea030aac3ed256acdaebec1c36650", async() => {
                WriteLiteral("Detalles");
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
#line 232 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
                                          WriteLiteral(item.IdDocumentos);

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
#line 235 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbDocumentacion\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Riviera_Business.Models.TbDocumentacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
