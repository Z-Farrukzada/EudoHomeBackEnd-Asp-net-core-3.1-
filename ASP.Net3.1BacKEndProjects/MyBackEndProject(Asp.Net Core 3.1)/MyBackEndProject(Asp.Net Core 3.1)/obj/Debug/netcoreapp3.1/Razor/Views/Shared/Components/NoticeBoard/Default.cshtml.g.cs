#pragma checksum "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6a533e3b1ffee206d07ba66a8ebebd057ab35ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NoticeBoard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NoticeBoard/Default.cshtml")]
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
#line 1 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\_ViewImports.cshtml"
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\_ViewImports.cshtml"
using MyBackEndProject_Asp.Net_Core_3._1_.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a533e3b1ffee206d07ba66a8ebebd057ab35ee", @"/Views/Shared/Components/NoticeBoard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6cc050c5df9a663d76173974df7fc291afd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NoticeBoard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NoticeBoard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
  
    Layout = null;
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n           \r\n              <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                    <div class=\"notice-left\">\r\n");
#nullable restore
#line 11 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>");
#nullable restore
#line 14 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                           Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 15 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                            if (count == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-notice-left pb-75\">\r\n                                    <h4>");
#nullable restore
#line 18 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                                   Write(Html.Raw(item.NoticeTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 19 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                                  Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </div>\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                            }
                            else if (count == 6 || count == 9)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-notice-left pb-70\">\r\n                                    <h4>");
#nullable restore
#line 25 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                                   Write(Html.Raw(item.NoticeTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 26 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                                  Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </div>\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-notice-left mb-25 pb-25\">\r\n                                    <h4>");
#nullable restore
#line 32 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                                   Write(Html.Raw(item.NoticeTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 33 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                                  Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </div>\r\n");
#nullable restore
#line 35 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\NoticeBoard\Default.cshtml"
                            }
                            count++;

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n          \r\n       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NoticeBoard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
