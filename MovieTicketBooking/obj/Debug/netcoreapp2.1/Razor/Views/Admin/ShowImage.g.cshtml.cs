#pragma checksum "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ShowImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dedb16959fd1c015c515eaa86ccb21494dd188d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowImage), @"mvc.1.0.view", @"/Views/Admin/ShowImage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ShowImage.cshtml", typeof(AspNetCore.Views_Admin_ShowImage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dedb16959fd1c015c515eaa86ccb21494dd188d", @"/Views/Admin/ShowImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ShowImage.cshtml"
  
    ViewData["Title"] = "ShowImage";

#line default
#line hidden
            BeginContext(47, 22, true);
            WriteLiteral("\r\n<h2>ShowImage</h2>\r\n");
            EndContext();
#line 7 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ShowImage.cshtml"
  
    var data = ViewData["message"];

#line default
#line hidden
            BeginContext(113, 47, true);
            WriteLiteral("<div>\r\n    <p>Taken from wikpedia</p>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 160, "\"", 171, 1);
#line 12 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Admin\ShowImage.cshtml"
WriteAttributeValue("", 166, data, 166, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(172, 27, true);
            WriteLiteral(" alt=\"Red dot\" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
