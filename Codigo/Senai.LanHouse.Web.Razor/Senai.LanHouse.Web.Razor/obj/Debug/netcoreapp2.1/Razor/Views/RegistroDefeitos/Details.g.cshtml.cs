#pragma checksum "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29aedb2d9b242a894550db51bc3690f7ec607fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroDefeitos_Details), @"mvc.1.0.view", @"/Views/RegistroDefeitos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroDefeitos/Details.cshtml", typeof(AspNetCore.Views_RegistroDefeitos_Details))]
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
#line 1 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\_ViewImports.cshtml"
using Senai.LanHouse.Web.Razor;

#line default
#line hidden
#line 2 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\_ViewImports.cshtml"
using Senai.LanHouse.Web.Razor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29aedb2d9b242a894550db51bc3690f7ec607fb", @"/Views/RegistroDefeitos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4454cc0c78a6dda1cb48c0bbee78e97740168", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroDefeitos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senai.LanHouse.Web.Razor.Domains.RegistroDefeito>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>RegistroDefeito</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(232, 47, false);
#line 14 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 43, false);
#line 17 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(366, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(410, 46, false);
#line 20 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(500, 42, false);
#line 23 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(586, 43, false);
#line 26 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Defeito));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 44, false);
#line 29 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Defeito.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(761, 51, false);
#line 32 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoEquipamento));

#line default
#line hidden
            EndContext();
            BeginContext(812, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(856, 52, false);
#line 35 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoEquipamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(908, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(955, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0d1a593f504a30a46363a78e4cc384", async() => {
                BeginContext(1001, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 40 "C:\Users\51755101856\Desktop\2s2019-t3-treinamento\Codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\RegistroDefeitos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1009, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1017, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "785a014bdc224aef8229dab3640f4989", async() => {
                BeginContext(1039, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1055, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senai.LanHouse.Web.Razor.Domains.RegistroDefeito> Html { get; private set; }
    }
}
#pragma warning restore 1591
