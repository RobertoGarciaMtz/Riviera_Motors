#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815e5c6c3c3103a24e6953069e9b00fa1de51c3d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815e5c6c3c3103a24e6953069e9b00fa1de51c3d", @"/Views/TbSeguimiento/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815e5c6c3c3103a24e6953069e9b00fa1de51c3d4657", async() => {
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"dataTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Fecha Muestreo\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                ¿Contesto Llamada?
            </th>
            <th>
                ¿Cita Previa?
            </th>
            <th>
                Fecha Llegda
            </th>
            <th>
                Contacto
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
#line 55 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asistio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Toma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PruebaManejo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdTipoCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Termino en Venta\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Anticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadAnticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comentarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdAsesorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 88 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 106 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Contesto == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2953, "\"", 2975, 1);
#nullable restore
#line 108 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 2961, item.Contesto, 2961, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 109 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3075, "\"", 3097, 1);
#nullable restore
#line 112 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3083, item.Contesto, 3083, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 113 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 116 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Cita== 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3249, "\"", 3267, 1);
#nullable restore
#line 118 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3257, item.Cita, 3257, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 119 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 3367, "\"", 3385, 1);
#nullable restore
#line 122 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 3375, item.Cita, 3375, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 123 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 126 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaCita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 129 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CMedioPublicitarioNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 132 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 135 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.VersionCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 138 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.ModeloCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 141 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation.NombreMarca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 144 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Asistio == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4360, "\"", 4381, 1);
#nullable restore
#line 146 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4368, item.Asistio, 4368, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 147 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4481, "\"", 4502, 1);
#nullable restore
#line 150 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4489, item.Asistio, 4489, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 151 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 155 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Toma == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4673, "\"", 4691, 1);
#nullable restore
#line 157 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4681, item.Toma, 4681, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 158 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4791, "\"", 4809, 1);
#nullable restore
#line 161 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4799, item.Toma, 4799, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 162 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 166 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.PruebaManejo == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 4988, "\"", 5014, 1);
#nullable restore
#line 168 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 4996, item.PruebaManejo, 4996, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 169 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5114, "\"", 5140, 1);
#nullable restore
#line 172 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5122, item.PruebaManejo, 5122, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 173 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 177 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.IdTipoCompra == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5319, "\"", 5345, 1);
#nullable restore
#line 179 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5327, item.IdTipoCompra, 5327, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Retail</label>\r\n");
#nullable restore
#line 180 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5449, "\"", 5475, 1);
#nullable restore
#line 183 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5457, item.IdTipoCompra, 5457, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">InterAgencias</label>\r\n");
#nullable restore
#line 184 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                \r\n");
#nullable restore
#line 188 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Venta == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5658, "\"", 5677, 1);
#nullable restore
#line 190 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5666, item.Venta, 5666, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 191 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5777, "\"", 5796, 1);
#nullable restore
#line 194 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5785, item.Venta, 5785, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 195 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 198 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                 if (item.Anticipo == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 5953, "\"", 5975, 1);
#nullable restore
#line 200 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 5961, item.Anticipo, 5961, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Si</label>\r\n");
#nullable restore
#line 201 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 6075, "\"", 6097, 1);
#nullable restore
#line 204 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
WriteAttributeValue("", 6083, item.Anticipo, 6083, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</label>\r\n");
#nullable restore
#line 205 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 208 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadAnticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 211 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comentarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 214 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdAsesorNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 217 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815e5c6c3c3103a24e6953069e9b00fa1de51c3d29666", async() => {
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
#line 220 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815e5c6c3c3103a24e6953069e9b00fa1de51c3d31856", async() => {
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
#line 221 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815e5c6c3c3103a24e6953069e9b00fa1de51c3d34052", async() => {
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
#line 222 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
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
#line 225 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbSeguimiento\Index.cshtml"
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
