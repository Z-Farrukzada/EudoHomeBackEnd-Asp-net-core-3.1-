#pragma checksum "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ed0526636ec44e75dfbbe7e26c792279299f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ed0526636ec44e75dfbbe7e26c792279299f78", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6cc050c5df9a663d76173974df7fc291afd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Banner Area Start -->\r\n");
#nullable restore
#line 8 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
 foreach (var item in ViewBag.Banner)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"banner-area-wrapper\"");
            BeginWriteAttribute("style", " style=\"", 199, "\"", 372, 21);
            WriteAttributeValue(" ", 207, "background:", 208, 12, true);
            WriteAttributeValue(" ", 219, "rgba(0,", 220, 8, true);
            WriteAttributeValue(" ", 227, "0,", 228, 3, true);
            WriteAttributeValue(" ", 230, "0,", 231, 3, true);
            WriteAttributeValue(" ", 233, "0)", 234, 3, true);
            WriteAttributeValue(" ", 236, "url(\'~/../img/banner/", 237, 22, true);
#nullable restore
#line 10 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 258, item.BannerImage, 258, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 275, "\')", 275, 2, true);
            WriteAttributeValue(" ", 277, "no-repeat", 278, 10, true);
            WriteAttributeValue(" ", 287, "scroll", 288, 7, true);
            WriteAttributeValue(" ", 294, "center", 295, 7, true);
            WriteAttributeValue(" ", 301, "center", 302, 7, true);
            WriteAttributeValue(" ", 308, "/", 309, 2, true);
            WriteAttributeValue(" ", 310, "cover", 311, 6, true);
            WriteAttributeValue(" ", 316, ";", 317, 2, true);
            WriteAttributeValue("\r\n  ", 318, "position:", 322, 13, true);
            WriteAttributeValue(" ", 331, "relative;", 332, 10, true);
            WriteAttributeValue("\r\n  ", 341, "width:", 345, 10, true);
            WriteAttributeValue(" ", 351, "100%;", 352, 6, true);
            WriteAttributeValue("\r\n  ", 357, "z-index:", 361, 12, true);
            WriteAttributeValue(" ", 369, "1;", 370, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""banner-area text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""banner-content-wrapper"">
                            <div class=""banner-content"">
                                <h2>");
#nullable restore
#line 20 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
                               Write(item.BannerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Banner Area End -->\r\n<!--Teacher Area Start-->\r\n<!-- Teacher Start -->\r\n<div class=\"teacher-area pt-150 pb-105\">\r\n    <div class=\"container\">\r\n        <div class=\"row\" id=\"TeacherList\">\r\n            ");
#nullable restore
#line 35 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
       Write(await Component.InvokeAsync("Teacher", new { skip = 0, count = 12 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            <input type=\"hidden\" id=\"TeacherCount\"");
            BeginWriteAttribute("value", " value=\"", 1259, "\"", 1288, 1);
#nullable restore
#line 38 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1267, ViewBag.TeacherCount, 1267, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <div class=""col-12"">
                <a href=""#"" class=""btn btn-primary  teacherloadmore"" style=""background-color:rgb(44, 43, 99);font-size:20px;color:white;width:170px;height:50px;padding-top:10px;font-weight:bold;"">Load More</a>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        let count = 9;
        $(document).on(""click"", "".teacherloadmore"", function (e) {
            let Eventcount = $(""#TeacherCount"").val();

            $.ajax({
                url: ""/Teacher/Load?count="" + count,
                type: ""Get"",
                success: function (res) {
                    $(""#TeacherList"").append(res);

                    count += 9;
                    if (count >= Eventcount) {
                        $("".teacherloadmore"").remove();
                    }
                }
            })
            e.preventDefault();

        })



    </script>


");
            }
            );
            WriteLiteral("<!-- Teacher End -->\r\n");
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
