#pragma checksum "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71d44ef8419e94233a71833d6ef3fbc63b4d925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71d44ef8419e94233a71833d6ef3fbc63b4d925", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a6cc050c5df9a663d76173974df7fc291afd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Banner Area Start -->\r\n");
#nullable restore
#line 8 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
 foreach (var item in ViewBag.Banner)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"banner-area-wrapper\"");
            BeginWriteAttribute("style", " style=\"", 214, "\"", 387, 21);
            WriteAttributeValue(" ", 222, "background:", 223, 12, true);
            WriteAttributeValue(" ", 234, "rgba(0,", 235, 8, true);
            WriteAttributeValue(" ", 242, "0,", 243, 3, true);
            WriteAttributeValue(" ", 245, "0,", 246, 3, true);
            WriteAttributeValue(" ", 248, "0)", 249, 3, true);
            WriteAttributeValue(" ", 251, "url(\'~/../img/banner/", 252, 22, true);
#nullable restore
#line 10 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 273, item.BannerImage, 273, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 290, "\')", 290, 2, true);
            WriteAttributeValue(" ", 292, "no-repeat", 293, 10, true);
            WriteAttributeValue(" ", 302, "scroll", 303, 7, true);
            WriteAttributeValue(" ", 309, "center", 310, 7, true);
            WriteAttributeValue(" ", 316, "center", 317, 7, true);
            WriteAttributeValue(" ", 323, "/", 324, 2, true);
            WriteAttributeValue(" ", 325, "cover", 326, 6, true);
            WriteAttributeValue(" ", 331, ";", 332, 2, true);
            WriteAttributeValue("\r\n  ", 333, "position:", 337, 13, true);
            WriteAttributeValue(" ", 346, "relative;", 347, 10, true);
            WriteAttributeValue("\r\n  ", 356, "width:", 360, 10, true);
            WriteAttributeValue(" ", 366, "100%;", 367, 6, true);
            WriteAttributeValue("\r\n  ", 372, "z-index:", 376, 12, true);
            WriteAttributeValue(" ", 384, "1;", 385, 3, true);
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
#line 20 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                               Write(item.BannerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b71d44ef8419e94233a71833d6ef3fbc63b4d9257779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1197, "~/img/teacher/", 1197, 14, true);
#nullable restore
#line 36 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 1211, Model.Image, 1211, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 41 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 42 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 44 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                  Write(Model.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 46 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 47 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 48 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                             Write(Model.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 49 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 58 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                         Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 59 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                             Write(Model.ContactTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
#nullable restore
#line 60 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                       Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2418, "\"", 2440, 1);
#nullable restore
#line 62 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2425, Model.Facebook, 2425, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2517, "\"", 2540, 1);
#nullable restore
#line 63 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2524, Model.Pinterest, 2524, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2618, "\"", 2641, 1);
#nullable restore
#line 64 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2625, Model.Instagram, 2625, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2715, "\"", 2736, 1);
#nullable restore
#line 65 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2722, Model.Twitter, 2722, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                      
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3413, "\"", 3552, 11);
            WriteAttributeValue("", 3421, "width:", 3421, 6, true);
#nullable restore
#line 80 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3427, Model.Skills.Language, 3428, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3452, "%;", 3452, 2, true);
            WriteAttributeValue(" ", 3454, "visibility:", 3455, 12, true);
            WriteAttributeValue(" ", 3466, "visible;", 3467, 9, true);
            WriteAttributeValue(" ", 3475, "animation-duration:", 3476, 20, true);
            WriteAttributeValue(" ", 3495, "1.5s;", 3496, 6, true);
            WriteAttributeValue(" ", 3501, "animation-delay:", 3502, 17, true);
            WriteAttributeValue(" ", 3518, "1.2s;", 3519, 6, true);
            WriteAttributeValue(" ", 3524, "animation-name:", 3525, 16, true);
            WriteAttributeValue(" ", 3540, "fadeInLeft;", 3541, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 81 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4165, "\"", 4306, 11);
            WriteAttributeValue("", 4173, "width:", 4173, 6, true);
#nullable restore
#line 90 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 4179, Model.Skills.TeamLeader, 4180, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4206, "%;", 4206, 2, true);
            WriteAttributeValue(" ", 4208, "visibility:", 4209, 12, true);
            WriteAttributeValue(" ", 4220, "visible;", 4221, 9, true);
            WriteAttributeValue(" ", 4229, "animation-duration:", 4230, 20, true);
            WriteAttributeValue(" ", 4249, "1.5s;", 4250, 6, true);
            WriteAttributeValue(" ", 4255, "animation-delay:", 4256, 17, true);
            WriteAttributeValue(" ", 4272, "1.2s;", 4273, 6, true);
            WriteAttributeValue(" ", 4278, "animation-name:", 4279, 16, true);
            WriteAttributeValue(" ", 4294, "fadeInLeft;", 4295, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 91 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.TeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4921, "\"", 5062, 11);
            WriteAttributeValue("", 4929, "width:", 4929, 6, true);
#nullable restore
#line 100 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 4935, Model.Skills.Development, 4935, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4962, "%;", 4962, 2, true);
            WriteAttributeValue(" ", 4964, "visibility:", 4965, 12, true);
            WriteAttributeValue(" ", 4976, "visible;", 4977, 9, true);
            WriteAttributeValue(" ", 4985, "animation-duration:", 4986, 20, true);
            WriteAttributeValue(" ", 5005, "1.5s;", 5006, 6, true);
            WriteAttributeValue(" ", 5011, "animation-delay:", 5012, 17, true);
            WriteAttributeValue(" ", 5028, "1.2s;", 5029, 6, true);
            WriteAttributeValue(" ", 5034, "animation-name:", 5035, 16, true);
            WriteAttributeValue(" ", 5050, "fadeInLeft;", 5051, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 101 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Development);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 5673, "\"", 5810, 11);
            WriteAttributeValue("", 5681, "width:", 5681, 6, true);
#nullable restore
#line 110 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 5687, Model.Skills.Design, 5688, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5710, "%;", 5710, 2, true);
            WriteAttributeValue(" ", 5712, "visibility:", 5713, 12, true);
            WriteAttributeValue(" ", 5724, "visible;", 5725, 9, true);
            WriteAttributeValue(" ", 5733, "animation-duration:", 5734, 20, true);
            WriteAttributeValue(" ", 5753, "1.5s;", 5754, 6, true);
            WriteAttributeValue(" ", 5759, "animation-delay:", 5760, 17, true);
            WriteAttributeValue(" ", 5776, "1.2s;", 5777, 6, true);
            WriteAttributeValue(" ", 5782, "animation-name:", 5783, 16, true);
            WriteAttributeValue(" ", 5798, "fadeInLeft;", 5799, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 111 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Design);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6420, "\"", 6561, 11);
            WriteAttributeValue("", 6428, "width:", 6428, 6, true);
#nullable restore
#line 120 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6434, Model.Skills.Innovation, 6435, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6461, "%;", 6461, 2, true);
            WriteAttributeValue(" ", 6463, "visibility:", 6464, 12, true);
            WriteAttributeValue(" ", 6475, "visible;", 6476, 9, true);
            WriteAttributeValue(" ", 6484, "animation-duration:", 6485, 20, true);
            WriteAttributeValue(" ", 6504, "1.5s;", 6505, 6, true);
            WriteAttributeValue(" ", 6510, "animation-delay:", 6511, 17, true);
            WriteAttributeValue(" ", 6527, "1.2s;", 6528, 6, true);
            WriteAttributeValue(" ", 6533, "animation-name:", 6534, 16, true);
            WriteAttributeValue(" ", 6549, "fadeInLeft;", 6550, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 121 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Innovation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 7178, "\"", 7322, 11);
            WriteAttributeValue("", 7186, "width:", 7186, 6, true);
#nullable restore
#line 130 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 7192, Model.Skills.Communication, 7193, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7222, "%;", 7222, 2, true);
            WriteAttributeValue(" ", 7224, "visibility:", 7225, 12, true);
            WriteAttributeValue(" ", 7236, "visible;", 7237, 9, true);
            WriteAttributeValue(" ", 7245, "animation-duration:", 7246, 20, true);
            WriteAttributeValue(" ", 7265, "1.5s;", 7266, 6, true);
            WriteAttributeValue(" ", 7271, "animation-delay:", 7272, 17, true);
            WriteAttributeValue(" ", 7288, "1.2s;", 7289, 6, true);
            WriteAttributeValue(" ", 7294, "animation-name:", 7295, 16, true);
            WriteAttributeValue(" ", 7310, "fadeInLeft;", 7311, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 131 "C:\Users\user\source\repos\MyBackEndProject(Asp.Net Core 3.1)\MyBackEndProject(Asp.Net Core 3.1)\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Communication);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
