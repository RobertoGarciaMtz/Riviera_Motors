#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21cc8ba91338f4b39a719ceecd1815b772f3daae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbControl_Index), @"mvc.1.0.view", @"/Views/TbControl/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21cc8ba91338f4b39a719ceecd1815b772f3daae", @"/Views/TbControl/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbControl_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Riviera_Business.Models.TbControl>>
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
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cc8ba91338f4b39a719ceecd1815b772f3daae4629", async() => {
                WriteLiteral("Agregar Compra");
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
<p>
    En este apartado estaran todas las Ventas de autos realizados y las personas a las que
    pertenece o les fue realizada la transaccion
</p>

<table class=""table"">
    <thead>
        <tr>
            <th id=""desaparecer"">
                ");
#nullable restore
#line 21 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompraVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NoFacturaArv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFacturaToma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FolioFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCarros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Iva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PagadaCobrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GastoTotalEnCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VoBoFacturarSat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VoBoLeyAntiLavado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClienteVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 75 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecioPactado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 81 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Debiendo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 84 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadDebida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 87 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 90 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeyAntilavado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 93 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BajaCambProp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 96 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComprobarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 99 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConstanciaFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 102 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CurpPf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 105 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComprobantesPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 108 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdBancoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 111 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 114 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdFormaPagoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 120 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 123 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompraVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 126 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 129 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NoFacturaArv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 132 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFacturaToma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 135 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FolioFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 138 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 141 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 144 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 147 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Iva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 150 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 153 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PagadaCobrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 156 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GastoTotalEnCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 159 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 162 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VoBoFacturarSat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 165 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VoBoLeyAntiLavado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 168 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClienteVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 171 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 174 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 177 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 180 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrecioPactado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 183 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Debiendo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 186 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadDebida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 189 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 192 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeyAntilavado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 195 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BajaCambProp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 198 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComprobarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 201 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConstanciaFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 204 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurpPf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 207 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComprobantesPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 210 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdBancoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 213 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 216 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdFormaPagoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cc8ba91338f4b39a719ceecd1815b772f3daae27514", async() => {
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
#line 219 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
                                       WriteLiteral(item.IdMovimiento);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cc8ba91338f4b39a719ceecd1815b772f3daae29699", async() => {
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
#line 220 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
                                          WriteLiteral(item.IdMovimiento);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cc8ba91338f4b39a719ceecd1815b772f3daae31890", async() => {
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
#line 221 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
                                         WriteLiteral(item.IdMovimiento);

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
#line 224 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbControl\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
            function filtro(select) {
                var idSelected = select.value;
                $.ajax({
                    url: ""/TbControl/Esconder"",
                    method: ""GET"",
                    data: { ""id"": idSelected },
                    success: function (w) {
                        
                    }   
                });
            }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Riviera_Business.Models.TbControl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
