#pragma checksum "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b28a4323604e30679264b09b97e716d0313d30d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RemoveMovie), @"mvc.1.0.view", @"/Views/Admin/RemoveMovie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/RemoveMovie.cshtml", typeof(AspNetCore.Views_Admin_RemoveMovie))]
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
#line 1 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking;

#line default
#line hidden
#line 2 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b28a4323604e30679264b09b97e716d0313d30d3", @"/Views/Admin/RemoveMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RemoveMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieTicketBooking.Models.MovieInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;width:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "../", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
  
    ViewData["Title"] = "RemoveMovie";

#line default
#line hidden
            BeginContext(93, 97, true);
            WriteLiteral("\r\n<h2>RemoveMovie</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(190, 1550, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f3810e5750b47aeace30aa51b5ad972", async() => {
                BeginContext(221, 72, true);
                WriteLiteral("\r\n        <dl class=\"dl-horizontal\">\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(294, 41, false);
#line 15 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayFor(model => model.MovieName));

#line default
#line hidden
                EndContext();
                BeginContext(335, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(390, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed1809aa8515468daff1330eb266e4ac", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 400, "~/images/", 400, 9, true);
#line 18 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
AddHtmlAttributeValue("", 409, Html.DisplayFor(model =>model.Pic), 409, 35, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(482, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(538, 44, false);
#line 21 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
                EndContext();
                BeginContext(582, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(638, 40, false);
#line 24 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayFor(model => model.Director));

#line default
#line hidden
                EndContext();
                BeginContext(678, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(734, 41, false);
#line 27 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayNameFor(model => model.Actor));

#line default
#line hidden
                EndContext();
                BeginContext(775, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(831, 37, false);
#line 30 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayFor(model => model.Actor));

#line default
#line hidden
                EndContext();
                BeginContext(868, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(924, 43, false);
#line 33 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayNameFor(model => model.Release));

#line default
#line hidden
                EndContext();
                BeginContext(967, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1023, 39, false);
#line 36 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayFor(model => model.Release));

#line default
#line hidden
                EndContext();
                BeginContext(1062, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1118, 44, false);
#line 39 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
                EndContext();
                BeginContext(1162, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1218, 40, false);
#line 42 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
                EndContext();
                BeginContext(1258, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1277, 38, false);
#line 43 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\RemoveMovie.cshtml"
           Write(Html.HiddenFor(model => model.MovieID));

#line default
#line hidden
                EndContext();
                BeginContext(1315, 38, true);
                WriteLiteral("\r\n\r\n            </dd>\r\n        </dl>\r\n");
                EndContext();
                BeginContext(1549, 124, true);
                WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
                EndContext();
                BeginContext(1673, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4fd282ea64b4805904556313332e8aa", async() => {
                    BeginContext(1693, 14, true);
                    WriteLiteral("Back to Movies");
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
                BeginContext(1711, 22, true);
                WriteLiteral("\r\n        </div>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(1740, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieTicketBooking.Models.MovieInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
