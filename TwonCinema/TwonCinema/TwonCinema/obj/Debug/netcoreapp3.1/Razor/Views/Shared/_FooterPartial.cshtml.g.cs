#pragma checksum "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ddf3912584cfd00dadf3ff92cd1b4e660e2cc78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ddf3912584cfd00dadf3ff92cd1b4e660e2cc78", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037f7958d1f4644aabcf61b86ba31cb0c3b85a55", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""w3l-footer"">
    <section class=""footer-inner-main"">
        <div class=""footer-hny-grids py-5"">
            <div class=""container py-lg-4"">
                <div class=""text-txt"">
                    <div class=""right-side"">
                        <div class=""row footer-links"">
                            <div class=""col-md-3 col-sm-6 sub-two-right mt-5"">
                                <h6>Phim</h6>
                                <ul>
                                    <li><a href=""now-watching.html"">Phim Đang Chiếu</a></li>
                                    <li><a href=""#parentHorizontalTab2"">Phim Sắp Chiếu</a></li>
                                </ul>
                            </div>
                            <div class=""col-md-3 col-sm-6 sub-two-right mt-5"">
                                <h6>Sự kiện</h6>
                                <ul>
                                    <li><a href=""event.html#parentHorizontalTab1"">Ưu Đãi</a> </li>
                       ");
            WriteLiteral(@"             <li><a href=""event.html#parentHorizontalTab2"">Bình Luận Phim</a> </li>
                                </ul>
                            </div>
                            <div class=""col-md-3 col-sm-6 sub-two-right mt-5"">
                                <h6>Giới Thiệu</h6>
                                <ul>
                                    <li><a href=""about.html"">Về Chúng Tôi</a></li>
                                    <li><a href=""contact.html"">Liên Hệ</a></li>
                                </ul>
                            </div>
                            <div class=""col-md-3 col-sm-6 sub-two-right mt-5"">
                                <h6>Nhận Thông Báo</h6>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ddf3912584cfd00dadf3ff92cd1b4e660e2cc786159", async() => {
                WriteLiteral("\r\n                                    <input type=\"email\" name=\"email\" placeholder=\"Email của bạn\"");
                BeginWriteAttribute("required", " required=\"", 1916, "\"", 1927, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button><span class=\"fa fa-envelope-o\"></span></button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <p>
                                    Nhập email của bạn và nhận tin tức, cập nhật mới nhất và ưu đãi đặc biệt từ chúng tôi.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <button onclick=""topFunction()"" id=""movetop"" title=""Go to top"">
            <span class=""fa fa-arrow-up"" aria-hidden=""true""></span>
        </button>
        <script>
				window.onscroll = function () {
					scrollFunction()
				};

				function scrollFunction() {
					if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
						document.getElementById(""movetop"").style.display = ""block"";
					} else {
						document.getElementById(""movetop"").style.display = ""none"";
					}
				}
				function topFunction() {
					document.body.scrollTop = 0;
					document.documentElement.scrollTop = 0;
				}
        </script>
");
            WriteLiteral("    </section>\r\n</footer>");
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