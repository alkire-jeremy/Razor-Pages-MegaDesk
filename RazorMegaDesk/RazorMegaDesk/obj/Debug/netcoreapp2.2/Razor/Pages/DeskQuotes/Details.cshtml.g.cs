#pragma checksum "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec8b804e6d7b391e2958c31a4a7ad0c7c1b8370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorMegaDesk.Pages.DeskQuotes.Pages_DeskQuotes_Details), @"mvc.1.0.razor-page", @"/Pages/DeskQuotes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DeskQuotes/Details.cshtml", typeof(RazorMegaDesk.Pages.DeskQuotes.Pages_DeskQuotes_Details), null)]
namespace RazorMegaDesk.Pages.DeskQuotes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\_ViewImports.cshtml"
using RazorMegaDesk;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec8b804e6d7b391e2958c31a4a7ad0c7c1b8370", @"/Pages/DeskQuotes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e94965409c5a913580e1c6ce614d411397ae60d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskQuotes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Desk Quote</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(236, 58, false);
#line 15 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(294, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(356, 54, false);
#line 18 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(410, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(471, 58, false);
#line 21 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeskMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(529, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(591, 54, false);
#line 24 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeskMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(645, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(706, 51, false);
#line 27 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(757, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(819, 47, false);
#line 30 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(866, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(927, 51, false);
#line 33 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(978, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1040, 47, false);
#line 36 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1148, 61, false);
#line 39 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.NumberOfDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1271, 57, false);
#line 42 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.NumberOfDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1389, 54, false);
#line 45 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1505, 50, false);
#line 48 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.RushDays));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1616, 55, false);
#line 51 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1733, 51, false);
#line 54 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1845, 56, false);
#line 57 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.QuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1963, 52, false);
#line 60 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.QuoteTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2062, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec8b804e6d7b391e2958c31a4a7ad0c7c1b837011659", async() => {
                BeginContext(2118, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Swanson\source\repos\Razor-Pages-MegaDesk\RazorMegaDesk\RazorMegaDesk\Pages\DeskQuotes\Details.cshtml"
                           WriteLiteral(Model.DeskQuote.ID);

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
            BeginContext(2126, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2134, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec8b804e6d7b391e2958c31a4a7ad0c7c1b837014020", async() => {
                BeginContext(2156, 14, true);
                WriteLiteral("Back to Quotes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2174, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorMegaDesk.Pages.DeskQuotes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorMegaDesk.Pages.DeskQuotes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorMegaDesk.Pages.DeskQuotes.DetailsModel>)PageContext?.ViewData;
        public RazorMegaDesk.Pages.DeskQuotes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
