#pragma checksum "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26faa36c7a62830e6c8049c17a3cc6d39f4aa54e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_BookHistory), @"mvc.1.0.view", @"/Views/Booking/BookHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/BookHistory.cshtml", typeof(AspNetCore.Views_Booking_BookHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26faa36c7a62830e6c8049c17a3cc6d39f4aa54e", @"/Views/Booking/BookHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf90e995acc677fe9e73a134efc31f9993ba4c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_BookHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieTicketBooking.Models.MovieInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
  
    ViewData["Title"] = "Booked Movies";

#line default
#line hidden
            BeginContext(108, 26, true);
            WriteLiteral("\r\n<h2>Booked List</h2>\r\n\r\n");
            EndContext();
            BeginContext(138, 10, true);
            WriteLiteral("<h3>\r\n    ");
            EndContext();
            BeginContext(149, 42, false);
#line 11 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
Write(Html.ActionLink("Logout", "Logout","User"));

#line default
#line hidden
            EndContext();
            BeginContext(191, 9, true);
            WriteLiteral("\r\n</h3>\r\n");
            EndContext();
            BeginContext(209, 18, true);
            WriteLiteral("    <h3>\r\n        ");
            EndContext();
            BeginContext(228, 38, false);
#line 16 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
   Write(Html.ActionLink("Home","Home","Movie"));

#line default
#line hidden
            EndContext();
            BeginContext(266, 13, true);
            WriteLiteral("\r\n    </h3>\r\n");
            EndContext();
#line 19 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
 if(ViewBag.message!=null)
{

#line default
#line hidden
            BeginContext(313, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(322, 15, false);
#line 21 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
   Write(ViewBag.message);

#line default
#line hidden
            EndContext();
            BeginContext(337, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 22 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
}

#line default
#line hidden
            BeginContext(347, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(432, 45, false);
#line 27 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(477, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(533, 40, false);
#line 30 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(573, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(629, 40, false);
#line 33 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
            EndContext();
            BeginContext(669, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(725, 40, false);
#line 36 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Seat));

#line default
#line hidden
            EndContext();
            BeginContext(765, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(900, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(961, 44, false);
#line 46 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1073, 39, false);
#line 49 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1180, 39, false);
#line 52 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1287, 39, false);
#line 55 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Seat));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 58 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
                      var tt = DateTime.Parse(item.Time).TimeOfDay;
                        var gg = DateTime.Now.TimeOfDay;

#line default
#line hidden
            BeginContext(1501, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 60 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
                     if ((item.Date.Date == @DateTime.Now.Date && DateTime.Parse(item.Time).TimeOfDay >= DateTime.Now.TimeOfDay) ||(item.Date>DateTime.Now))
                    {
                        

#line default
#line hidden
            BeginContext(1707, 83, false);
#line 62 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
                   Write(Html.ActionLink("Delete", "CancelBooking", "Booking", new { bookid = item.BookID }));

#line default
#line hidden
            EndContext();
#line 62 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
                                                                                                            
                    }

#line default
#line hidden
            BeginContext(1815, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
            BeginContext(1992, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 69 "C:\Users\Mruthula.Manmadhan\source\repos\MovieTicketBooking\MovieTicketBooking\Views\Booking\BookHistory.cshtml"
        }

#line default
#line hidden
            BeginContext(2022, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieTicketBooking.Models.MovieInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
