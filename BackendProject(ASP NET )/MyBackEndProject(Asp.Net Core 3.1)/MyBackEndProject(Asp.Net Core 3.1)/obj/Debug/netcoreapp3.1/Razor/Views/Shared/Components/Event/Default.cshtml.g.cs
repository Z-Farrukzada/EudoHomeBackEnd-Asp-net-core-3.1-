#pragma checksum "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13277555b1e2716439a5778b8db71aa5acdd27a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Event_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Event/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13277555b1e2716439a5778b8db71aa5acdd27a3", @"/Views/Shared/Components/Event/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6cc050c5df9a663d76173974df7fc291afd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Event_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewEvent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
   Layout = null;
    int count = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
 foreach (var item in Model)
{
    if (count == 4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-event\">\r\n            <div class=\"event-date\">\r\n                <h3><a href=\"event-details.html\">  <span style=\"width:50px !important; font-size: 20px !important\">");
#nullable restore
#line 12 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                                                                              Write(item.EventTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></h3>\r\n            </div>\r\n            <div class=\"event-content text-left\">\r\n                <div class=\"event-content-left\">\r\n                    <h4><a href=\"event-details.html\">");
#nullable restore
#line 16 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <ul>\r\n                        <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 18 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                    Write(item.EventStart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                                       Write(item.EventFinish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 19 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                       Write(item.EventPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"event-content-right\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13277555b1e2716439a5778b8db71aa5acdd27a37351", async() => {
                WriteLiteral("join now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                                                          WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div> ");
#nullable restore
#line 26 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
               }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-event mb-35\">\r\n            <div class=\"event-date\">\r\n                <h3><a href=\"event-details.html\">  <span style=\"width:50px !important; font-size: 20px !important\">");
#nullable restore
#line 31 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                                                                              Write(item.EventTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></h3>\r\n            </div>\r\n            <div class=\"event-content text-left\">\r\n                <div class=\"event-content-left\">\r\n                    <h4><a href=\"event-details.html\">");
#nullable restore
#line 35 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <ul>\r\n                        <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 37 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                    Write(item.EventStart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 37 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                                       Write(item.EventFinish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 38 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                       Write(item.EventPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"event-content-right\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13277555b1e2716439a5778b8db71aa5acdd27a312707", async() => {
                WriteLiteral("join now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
                                                                                          WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>");
#nullable restore
#line 45 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Shared\Components\Event\Default.cshtml"
              }
    count++;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
