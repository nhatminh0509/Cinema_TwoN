#pragma checksum "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ef66b92381854bc13387554eb7e81725c8e269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Movie), @"mvc.1.0.view", @"/Views/Movies/Movie.cshtml")]
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
#line 2 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\_ViewImports.cshtml"
using TwonCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\_ViewImports.cshtml"
using TwonCinema.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ef66b92381854bc13387554eb7e81725c8e269", @"/Views/Movies/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037f7958d1f4644aabcf61b86ba31cb0c3b85a55", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("show-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NowShowing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("title-gd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
   
    var today = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"w3l-breadcrumbs\">\r\n    <nav id=\"breadcrumbs\" class=\"breadcrumbs\">\r\n        <div class=\"container page-wrapper\">\r\n            <a href=\"index.html\">Trang Chủ</a> » <span class=\"breadcrumb_last\" aria-current=\"page\">");
#nullable restore
#line 8 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                              Write(ViewBag.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </nav>\r\n</div>\r\n\r\n<div class=\"py-5\">\r\n    <div class=\"container py-lg-4\">\r\n        <div class=\"row align-items-center\">\r\n            <div class=\"col-lg-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45ef66b92381854bc13387554eb7e81725c8e2696622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 514, "~/Uploads/Movie/", 514, 16, true);
#nullable restore
#line 17 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
AddHtmlAttributeValue("", 530, ViewBag.Movie.Image_2, 530, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-6 pl-lg-4 mt-lg-0 mt-5\">\r\n                <h3 class=\"hny-title\">");
#nullable restore
#line 20 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                 Write(ViewBag.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"mt-3\">\r\n                <p><b>Tác Giả: </b>");
#nullable restore
#line 22 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                              Write(ViewBag.Movie.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Diễn Viên: </b>");
#nullable restore
#line 23 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                Write(ViewBag.Movie.Cast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Khởi Chiếu: </b>");
#nullable restore
#line 24 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                 Write(ViewBag.Movie.Release_Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Thời lượng: </b>");
#nullable restore
#line 25 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                 Write(ViewBag.Movie.Running_Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" p</p>\r\n");
            WriteLiteral("                <div class=\"mt-4\">\r\n                    <a href=\"#\" data-toggle=\"modal\" data-target=\"#myModal\" class=\"datve btn read-button\" data-moviename=\"");
#nullable restore
#line 28 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                                    Write(ViewBag.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id_movie=\"");
#nullable restore
#line 28 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                                                                        Write(ViewBag.Movie.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-today=\"");
#nullable restore
#line 28 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                                                                                                       Write(today);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Đặt vé <span class=\"fa fa-ticket ml-2\" aria-hidden=\"true\"></span></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <p style=\"padding-top: 1rem;\">");
#nullable restore
#line 32 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                 Write(Html.Raw(ViewBag.Movie.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral(@"    </div>
</div>

<section class=""w3l-grids"">
    <div class=""grids-main py-5"">
        <div class=""container py-lg-3"">
            <div class=""headerhny-title"">
                <div class=""w3l-title-grids"">
                    <div class=""headerhny-left"">
                        <h3 class=""hny-title"">Phim Đang Chiếu</h3>
                    </div>
                    <div class=""headerhny-right text-lg-right"">
                        <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ef66b92381854bc13387554eb7e81725c8e26912360", async() => {
                WriteLiteral("Hiện tất cả");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"owl-three owl-carousel owl-theme\">\r\n");
#nullable restore
#line 51 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                 foreach (var movie in ViewBag.listMovie)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item vhny-grid\">\r\n                        <div class=\"box16 mb-0\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ef66b92381854bc13387554eb7e81725c8e26914178", async() => {
                WriteLiteral("\r\n                                <figure>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45ef66b92381854bc13387554eb7e81725c8e26914514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2873, "~/Uploads/Movie/", 2873, 16, true);
#nullable restore
#line 57 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
AddHtmlAttributeValue("", 2889, movie.Image_2, 2889, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </figure>
                                <div class=""box-content"">

                                    <h4>
                                        <span class=""post"">
                                            <span class=""fa fa-clock-o""> </span> ");
#nullable restore
#line 63 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                            Write(movie.Running_Time);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" p

                                        </span>

                                        <span class=""post fa fa-heart text-right""></span>
                                    </h4>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                              WriteLiteral(movie.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <h3> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ef66b92381854bc13387554eb7e81725c8e26919373", async() => {
#nullable restore
#line 72 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                                    Write(movie.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                WriteLiteral(movie.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                        <div class=\"button-center text-center mt-4\">\r\n                            <a href=\"#\" data-toggle=\"modal\" data-target=\"#myModal\" data-id_movie=\"");
#nullable restore
#line 74 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                             Write(movie.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-moviename=\"");
#nullable restore
#line 74 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                                        Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-today=\"");
#nullable restore
#line 74 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                                                                 Write(today);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"datve btn watch-button\">Đặt vé ngay</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>

    </div>
</section>

<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""row"">
                    <div class=""col-2""><button id=""current"" data-day=""");
#nullable restore
#line 89 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                 Write(today);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDay btn-gray\">");
#nullable restore
#line 89 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                    Write(today.ToString("dd/MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\r\n                    <div class=\"col-2\"><button data-day=\"");
#nullable restore
#line 90 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                    Write(today.AddDays(1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDay btn-outline-gray\">");
#nullable restore
#line 90 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                          Write(today.AddDays(1).ToString("dd/MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\r\n                    <div class=\"col-2\"><button data-day=\"");
#nullable restore
#line 91 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                    Write(today.AddDays(2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDay btn-outline-gray\">");
#nullable restore
#line 91 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                          Write(today.AddDays(2).ToString("dd/MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\r\n                    <div class=\"col-2\"><button data-day=\"");
#nullable restore
#line 92 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                    Write(today.AddDays(3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDay btn-outline-gray\">");
#nullable restore
#line 92 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                          Write(today.AddDays(3).ToString("dd/MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\r\n                    <div class=\"col-2\"><button data-day=\"");
#nullable restore
#line 93 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                    Write(today.AddDays(4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDay btn-outline-gray\">");
#nullable restore
#line 93 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                          Write(today.AddDays(4).ToString("dd/MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></div>\r\n                    <div class=\"col-2\"><button data-day=\"");
#nullable restore
#line 94 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                    Write(today.AddDays(5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"selectDay btn-outline-gray\">");
#nullable restore
#line 94 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
                                                                                                          Write(today.AddDays(5).ToString("dd/MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button></div>
                </div>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body"" style=""min-height: 500px;"">
                <b style=""color:#df0e62;display:inline;"">Phim: </b><p id=""moviename"" style=""color:#df0e62;display:inline;""></p>
                <div class=""modal-body"" id=""listrap"" style=""height: 500px;overflow-y:scroll;"">

                </div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 111 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Movies\Movie.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<script>
    var idMovie;
    var day;
   
    $(document).on(""click"", "".datve"", function () {
        $('.selectDay').each(function () {
            $(this).removeClass('btn-gray');
            $(this).addClass('btn-outline-gray');
        });
        $('#current').addClass('btn-gray');
        $('#current').removeClass('btn-outline-gray');
        document.getElementById('moviename').innerText = $(this).data('moviename');


        idMovie = $(this).data('id_movie');
        day = $(this).data('today');
        listRap(idMovie, day);
    });

    $(document).on(""click"", "".selectDay"", function () {
        $('.selectDay').each(function () {
            $(this).removeClass('btn-gray');
            $(this).addClass('btn-outline-gray');
        });
        $(this).addClass('btn-gray');
        $(this).removeClass('btn-outline-gray');

        day = $(this).data('day');
        
        listRap(idMovie, day);
    });

    function listRap(idMovie, day) {
        document.getEleme");
                WriteLiteral(@"ntById('listrap').innerHTML = '';
        $.ajax({
            type: ""GET"",
            url: ""../../API/Movie_ShowAPI/ListCinemaHaveShowByMovieAndDay"",
            data: {
                idMovie: idMovie,
                day: day
            }
        }).done(function (listID) {
            var listidrap = JSON.parse(listID);
            var listRapHTML = [];
            listidrap.map((id) => {
                var elementcinema;
                $.ajax({
                    type: ""GET"",
                    url: ""../../API/Movie_ShowAPI/ListShowInCinemaByMovieAndDay"",
                    data: {
                        idCinema: id,
                        idMovie: idMovie,
                        day: day
                    }
                }).done(function (listShowRes) {
                    var listshow = JSON.parse(listShowRes);

                    var listShowHTML = listshow.map((movie_show) => {
                        return `<li class=""time"">
                               ");
                WriteLiteral(@"             <a href=""../../booking/selectseat?idShow=${movie_show.id}"" class=""button"">${movie_show.h_start}:${movie_show.m_start}</a>
                                        </li>`;
                    });

                    $.ajax({
                        type: ""GET"",
                        url: ""../../API/CinemasAPI/GetByID"",
                        data: {
                            id: id,
                        }
                    }).done(function (cinemaRes) {
                        var cinema = JSON.parse(cinemaRes);
                        elementcinema = `<div class=""rap"">
                                            <b>${cinema.Name}</b>
                                            <ul class=""listTime"">
                                                ${listShowHTML.join('')}
                                            </ul>
                                        </div>`;
                        listRapHTML.push(elementcinema);
                        document.getElementBy");
                WriteLiteral("Id(\'listrap\').innerHTML = listRapHTML.join(\'\');\r\n                    });\r\n                });\r\n            });\r\n        });\r\n    }\r\n</script>\r\n");
            }
            );
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
