#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03cd7042138b0ad39b3159ccaa624e76f9063d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbSeguimiento_Index), @"mvc.1.0.view", @"/Views/TbSeguimiento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03cd7042138b0ad39b3159ccaa624e76f9063d4a", @"/Views/TbSeguimiento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbSeguimiento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Riviera_Business.Models.TbSeguimiento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd7042138b0ad39b3159ccaa624e76f9063d4a4657", async() => {
                WriteLiteral("Agregar nuevo muestreo");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaSemana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaCita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asistio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model=>model.Toma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PruebaManejo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdTipoCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Termino en Venta\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Anticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadAnticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comentarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CMedioPublicitarioNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdAsesorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Num Serie
            </th>
            <th>
                Version
            </th>
            <th>
                Modelo
            </th>
            <th>
                Marca
            </th>
            <th>
                ");
#nullable restore
#line 85 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 91 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaSemana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 112 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Contesto == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3311, "\"", 3333, 1);
#nullable restore
#line 114 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3319, item.Contesto, 3319, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 115 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3433, "\"", 3455, 1);
#nullable restore
#line 118 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3441, item.Contesto, 3441, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 119 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 122 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Cita== 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3607, "\"", 3625, 1);
#nullable restore
#line 124 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3615, item.Cita, 3615, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 125 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3725, "\"", 3743, 1);
#nullable restore
#line 128 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3733, item.Cita, 3733, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 129 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 132 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaCita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 135 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Asistio == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3999, "\"", 4020, 1);
#nullable restore
#line 137 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4007, item.Asistio, 4007, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 138 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4120, "\"", 4141, 1);
#nullable restore
#line 141 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4128, item.Asistio, 4128, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 142 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 146 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Toma == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4312, "\"", 4330, 1);
#nullable restore
#line 148 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4320, item.Toma, 4320, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 149 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4430, "\"", 4448, 1);
#nullable restore
#line 152 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4438, item.Toma, 4438, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 153 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 157 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.PruebaManejo == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4627, "\"", 4653, 1);
#nullable restore
#line 159 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4635, item.PruebaManejo, 4635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 160 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4753, "\"", 4779, 1);
#nullable restore
#line 163 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4761, item.PruebaManejo, 4761, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 164 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 168 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.IdTipoCompra == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4958, "\"", 4984, 1);
#nullable restore
#line 170 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4966, item.IdTipoCompra, 4966, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Retail</label>\r\n");
#nullable restore
#line 171 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5088, "\"", 5114, 1);
#nullable restore
#line 174 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5096, item.IdTipoCompra, 5096, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">InterAgencias</label>\r\n");
#nullable restore
#line 175 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 179 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Venta == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5297, "\"", 5316, 1);
#nullable restore
#line 181 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5305, item.Venta, 5305, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 182 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5416, "\"", 5435, 1);
#nullable restore
#line 185 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5424, item.Venta, 5424, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 186 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 189 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Anticipo == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5592, "\"", 5614, 1);
#nullable restore
#line 191 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5600, item.Anticipo, 5600, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 192 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5714, "\"", 5736, 1);
#nullable restore
#line 195 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5722, item.Anticipo, 5722, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 196 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 199 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadAnticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 202 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comentarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 205 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CMedioPublicitarioNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 208 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdAsesorNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 211 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 214 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.VersionCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 217 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.ModeloCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 220 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation.NombreMarca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 223 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd7042138b0ad39b3159ccaa624e76f9063d4a31628", async() => {
                WriteLiteral("Edit");
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
#line 226 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                                       WriteLiteral(item.IdSeguimiento);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd7042138b0ad39b3159ccaa624e76f9063d4a33818", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 227 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                                          WriteLiteral(item.IdSeguimiento);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd7042138b0ad39b3159ccaa624e76f9063d4a36014", async() => {
                WriteLiteral("Delete");
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
#line 228 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                                         WriteLiteral(item.IdSeguimiento);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 231 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Riviera_Business.Models.TbSeguimiento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
