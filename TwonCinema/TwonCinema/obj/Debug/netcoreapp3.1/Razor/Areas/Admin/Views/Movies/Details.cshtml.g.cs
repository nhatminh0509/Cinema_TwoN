#pragma checksum "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ca32d9153408090449edf2636360e699820681e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Movies_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Movies/Details.cshtml")]
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
#line 2 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\_ViewImports.cshtml"
using TwonCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\_ViewImports.cshtml"
using TwonCinema.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca32d9153408090449edf2636360e699820681e", @"/Areas/Admin/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037f7958d1f4644aabcf61b86ba31cb0c3b85a55", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwonCinema.Areas.Admin.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning text-warning btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success text-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Chi Tiết Phim";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
  
    Random random = new Random();
    int rand = random.Next(1000);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>Chi Tiết Phim</h1>\r\n</center>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Tên:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Hình Ảnh:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ca32d9153408090449edf2636360e699820681e6290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 549, "~/Uploads/Movie/", 549, 16, true);
#nullable restore
#line 27 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("", 565, Model.Image_1, 565, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 579, "?", 579, 1, true);
#nullable restore
#line 27 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("", 580, rand, 580, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Hình Ảnh 2:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ca32d9153408090449edf2636360e699820681e8330", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 752, "~/Uploads/Movie/", 752, 16, true);
#nullable restore
#line 33 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("", 768, Model.Image_2, 768, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 782, "?", 782, 1, true);
#nullable restore
#line 33 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
AddHtmlAttributeValue("", 783, rand, 783, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Trailer:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.Raw(Model.Trailer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Đạo Diễn:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Directors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Diễn Viên:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Thể Loại:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Ngày Khởi Chiếu:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Release_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Thời Lượng:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Running_Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("p\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Ngôn Ngữ:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Đối Tượng Xem:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Mô Tả:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Trạng Thái:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 93 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
             if (Model.Status == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Kích Hoạt</p>\r\n");
#nullable restore
#line 96 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Không Kích Hoạt</p>\r\n");
#nullable restore
#line 100 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ca32d9153408090449edf2636360e699820681e15014", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Movies\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ca32d9153408090449edf2636360e699820681e17269", async() => {
                WriteLiteral("Trở Về");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwonCinema.Areas.Admin.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
