#pragma checksum "C:\Users\User\Desktop\SportsSln\SportsStore\Views\Shared\Components\Turkiye\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4824e6e5a069a261ca2cb919e72367e8b0abe76f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Turkiye_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Turkiye/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4824e6e5a069a261ca2cb919e72367e8b0abe76f", @"/Views/Shared/Components/Turkiye/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc80837b2c0ae6043fbfe2d574cda754fde728b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Turkiye_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SportsStore.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\Shared\Components\Turkiye\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 card\">\r\n        <div class=\"container \">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-9 mt-3\">\r\n\r\n                  \r\n                    <h5>");
#nullable restore
#line 11 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\Shared\Components\Turkiye\Default.cshtml"
                   Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><!--haber Tarihi-->\r\n                    <p class=\"dikeyparagraf\">");
#nullable restore
#line 12 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\Shared\Components\Turkiye\Default.cshtml"
                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><!--i??eri??i-->\r\n                </div>\r\n                <div class=\"col-3 mt-5\"><img");
            BeginWriteAttribute("src", " src=\"", 457, "\"", 473, 1);
#nullable restore
#line 14 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\Shared\Components\Turkiye\Default.cshtml"
WriteAttributeValue("", 463, item.Name, 463, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 474, "\"", 480, 0);
            EndWriteAttribute();
            WriteLiteral(" /></div><!--Haber resmi-->\r\n                <!--<div class=\"col-3 mt-5\"><img src=\"item.Description\" alt=\"\" /></div>--><!--Haber resmi-->\r\n            </div>\r\n            <br />\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\SportsSln\SportsStore\Views\Shared\Components\Turkiye\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SportsStore.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
