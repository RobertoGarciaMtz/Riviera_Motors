#pragma checksum "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a5603e961fd503b0823b3f1d7f20fdaa537664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbCarros_Delete), @"mvc.1.0.view", @"/Views/TbCarros/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a5603e961fd503b0823b3f1d7f20fdaa537664", @"/Views/TbCarros/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbCarros_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbCarros>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Eliminar</h1>\r\n<p>Si este es el carro que desea eliminar de las ofertas favor de presionar el boton </p>\r\n<div id=\"informacion\">\r\n    <h4>Oferta Carros</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoCompraCanal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoCompraCanal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Kms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Kms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FolioFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FolioFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFactToma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaFactToma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Antiguedad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Antiguedad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ColorExt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ColorExt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ColorInt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ColorInt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NoMotor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NoMotor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumEconomicoOpc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumEconomicoOpc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MvaOpc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MvaOpc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Transmision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Transmision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClaveVehicular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClaveVehicular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DuenoAnterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DuenoAnterior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Origen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Origen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PropuestaCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PropuestaCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaOferta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaOferta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.IdEstados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdVersionNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdVersionNavigation.IdVersionCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28a5603e961fd503b0823b3f1d7f20fdaa53766420556", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28a5603e961fd503b0823b3f1d7f20fdaa53766420823", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 154 "C:\Users\Eduar\Documents\Roberto\Riviera_Motors\Riviera_Business\Views\TbCarros\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdCarros);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28a5603e961fd503b0823b3f1d7f20fdaa53766422633", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
