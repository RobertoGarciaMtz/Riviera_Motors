#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6209f903f06288df57f2cc3774dcc1eb4cd586ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbPapelesCarro_Index), @"mvc.1.0.view", @"/Views/TbPapelesCarro/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6209f903f06288df57f2cc3774dcc1eb4cd586ca", @"/Views/TbPapelesCarro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbPapelesCarro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Riviera_Business.Models.TbPapelesCarro>>
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
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6209f903f06288df57f2cc3774dcc1eb4cd586ca4664", async() => {
                WriteLiteral("Create New");
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
#line 16 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FactOrigen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RefactCompleta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tenencias4Anos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Baja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Verificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaUlltimaVerificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Repuve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEmisor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Transunionfolio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCarroNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 61 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                 if (item.FactOrigen == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 1793, "\"", 1817, 1);
#nullable restore
#line 63 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
WriteAttributeValue("", 1801, item.FactOrigen, 1801, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Entregada</label>\r\n");
#nullable restore
#line 64 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                 if (item.FactOrigen == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 1946, "\"", 1970, 1);
#nullable restore
#line 67 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
WriteAttributeValue("", 1954, item.FactOrigen, 1954, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No Entregada</label>\r\n");
#nullable restore
#line 68 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                 if (item.FactOrigen == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2102, "\"", 2126, 1);
#nullable restore
#line 71 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
WriteAttributeValue("", 2110, item.FactOrigen, 2110, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Problemas</label>\r\n");
#nullable restore
#line 72 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RefactCompleta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tenencias4Anos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 81 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                 if (item.Baja == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2496, "\"", 2514, 1);
#nullable restore
#line 83 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
WriteAttributeValue("", 2504, item.Baja, 2504, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Entregada</label>\r\n");
#nullable restore
#line 84 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                 if (item.Baja == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2637, "\"", 2655, 1);
#nullable restore
#line 87 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
WriteAttributeValue("", 2645, item.Baja, 2645, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No Entregada</label>\r\n");
#nullable restore
#line 88 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                 if (item.Baja == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label");
            BeginWriteAttribute("value", " value=\"", 2781, "\"", 2799, 1);
#nullable restore
#line 91 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
WriteAttributeValue("", 2789, item.Baja, 2789, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Problemas</label>\r\n");
#nullable restore
#line 92 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Verificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaUlltimaVerificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Repuve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEmisor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Transunionfolio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6209f903f06288df57f2cc3774dcc1eb4cd586ca19769", async() => {
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
#line 122 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                                       WriteLiteral(item.IdPapelesCarro);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6209f903f06288df57f2cc3774dcc1eb4cd586ca21961", async() => {
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
#line 123 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                                          WriteLiteral(item.IdPapelesCarro);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6209f903f06288df57f2cc3774dcc1eb4cd586ca24159", async() => {
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
#line 124 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
                                         WriteLiteral(item.IdPapelesCarro);

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
#line 127 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPapelesCarro\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Riviera_Business.Models.TbPapelesCarro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
