#pragma checksum "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3249403297def9213d83fb9cf24c5064dbea0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3249403297def9213d83fb9cf24c5064dbea0b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantCRUD.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n       <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml"
             foreach (var resto in Model.Restaurants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4 mb-2"">
   
                    <div class=""card booking-card"">

                        <!-- Card image -->
                        <div class=""view overlay"">
                            <div class=""mask rgba-white-slight""></div>
                        </div>

                        <div class=""card-body"">
                            <h4 class=""card-title font-weight-bold"">");
#nullable restore
#line 25 "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml"
                                                               Write(Html.ActionLink(resto.Name, "Details", new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            ");
#nullable restore
#line 26 "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Edit","Edit",new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 26 "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml"
                                                                             Write(Html.ActionLink("Delete","Delete",new {id = resto.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n         \r\n                </div>\r\n");
#nullable restore
#line 32 "E:\RestaurantCRUD\RestaurantCRUD\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantCRUD.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
