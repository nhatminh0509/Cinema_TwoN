#pragma checksum "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d75282e8621dbe6da1dd2af1e2f6a71478c9c054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Customers/Index.cshtml")]
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
#line 2 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\_ViewImports.cshtml"
using TwonCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\_ViewImports.cshtml"
using TwonCinema.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d75282e8621dbe6da1dd2af1e2f6a71478c9c054", @"/Areas/Admin/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037f7958d1f4644aabcf61b86ba31cb0c3b85a55", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwonCinema.Areas.Admin.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex justify-content-center md-form form-sm active-cyan active-cyan-2 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex justify-content-end md-form form-sm active-cyan active-cyan-2 mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Danh Sách Khách Hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .active-cyan-2 input.form-control[type=text]:focus:not([readonly]) {
        border-bottom: 1px solid #4dd0e1;
        box-shadow: 0 1px 0 0 #4dd0e1;
    }

    .active-cyan input.form-control[type=text] {
        border-bottom: 1px solid #4dd0e1;
        box-shadow: 0 1px 0 0 #4dd0e1;
    }

    .active-cyan .fa, .active-cyan-2 .fa {
        color: #4dd0e1;
    }
</style>
<center>
    <h1>Danh Sách Khách Hàng</h1>
</center>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75282e8621dbe6da1dd2af1e2f6a71478c9c0546647", async() => {
                WriteLiteral("\r\n    <i class=\"fas fa-search\" aria-hidden=\"true\"></i>\r\n    <input class=\"form-control form-control-sm ml-3 w-75\" type=\"text\" id=\"myInput\" placeholder=\"Search\"\r\n           aria-label=\"Search\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75282e8621dbe6da1dd2af1e2f6a71478c9c0548173", async() => {
                WriteLiteral("\r\n    <select name=\"status\" onchange=\"$(\'#myform\').submit();\" class=\"form-control\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75282e8621dbe6da1dd2af1e2f6a71478c9c0548532", async() => {
                    WriteLiteral("Lọc");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75282e8621dbe6da1dd2af1e2f6a71478c9c0549760", async() => {
                    WriteLiteral("Còn sử dụng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75282e8621dbe6da1dd2af1e2f6a71478c9c05410996", async() => {
                    WriteLiteral("Ngưng sử dụng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </select>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br/>
<table class=""table"" style=""text-align:center"">
    <thead>
        <tr>
            <th>
                Tên
            </th>
            <th>
                Email
            </th>
            <th>
                Số điên thoại
            </th>
            <th>
                Trạng Thái
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""myTable"">
");
#nullable restore
#line 58 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
         foreach (var item in ViewBag.ListCustomer)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1876, "\"", 1889, 1);
#nullable restore
#line 60 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1881, item.ID, 1881, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 71 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                     if (item.Status == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button data-id=\"");
#nullable restore
#line 73 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                    Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"btnStatus\" class=\"btn btn-link\"><i class=\"fa fa-unlock-alt\"></i></button>\r\n");
#nullable restore
#line 74 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                    }
                    else if (item.Status == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button data-id=\"");
#nullable restore
#line 77 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                    Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"btnStatus\" class=\"btn btn-link\"><i class=\"fa fa-lock\"></i></button>\r\n");
#nullable restore
#line 78 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <a data-toggle=\"modal\" data-target=\"#myDetail\" data-id=\"");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                                                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-name=\"");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-email=\"");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                                                                                                    Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-phone=\"");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                                                                                                                             Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-tongchitieu=\"");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                                                                                                                                                            Write(item.Total_Spending);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-status=\"");
#nullable restore
#line 81 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
                                                                                                                                                                                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"detail\"><label class=\"fa fa-info\"></label> Chi Tiết</a> \r\n                   \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral(@"<div class=""container"">
    <div class=""modal fade"" id=""myDetail"" role=""dialog"">
       
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        <h4 class=""modal-title"" id=""title"">Chi Tiết Khách Hàng</h4>
                    </div>
                    <div class=""modal-body"">
                        <dl class=""row"">
                            <dt class=""col-sm-5"">
                                Tên:
                            </dt>
                            <dd class=""col-sm-7"" id=""lbTen"">
                              
                            </dd>
                            <dt class=""col-sm-5"">
                               Email:
                            </dt>
                            <dd class=""col-sm-7""id=""lbEmail"">
                               
                         ");
            WriteLiteral(@"   </dd>
                            <dt class=""col-sm-5"">
                                Số điện thoại:
                            </dt>
                            <dd class=""col-sm-7""id=""lbSDT"">
                               
                            </dd>
                            <dt class=""col-sm-5"">
                                Tổng chi tiêu:
                            </dt>
                            <dd class=""col-sm-7""id=""lbTongChiTieu"">
                           
                            </dd>
                            <dt class=""col-sm-5"">
                                Trạng Thái:
                            </dt>
                            <dd class=""col-sm-7""id=""lbTrangThai"">
                              
                            </dd>
                        </dl>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" data-dismiss=""modal"" value=""Xóa"" class=""btn btn-outline-danger dele");
            WriteLiteral("te\" />\r\n                        <button type=\"button\" class=\"btn btn-outline-danger\" data-dismiss=\"modal\">Đóng</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Areas\Admin\Views\Customers\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $(document).ready(function () {
            $(""#myInput"").on(""keyup"", function () {
                var value = $(this).val().toLowerCase();
                $(""#myTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        });
    </script>
    <script>
        $('button[name =btnStatus]').click(function () {
            var id = $(this).data('id');
            var btn = $(this);
            $.ajax({
                method: ""GET"",
                url: ""../API/CustomersAPI/ChangeStatus"",
                data: { 'id': id }
            })
                .done(function (msg) {
                    var obj = JSON.parse(msg);
                    document.getElementById('' + obj.ID).remove(this);
                });
        });
    </script>
    <script>
        $(document).on(""click"", "".detail"", function () {
            var id = $(this).data('id');
            docume");
                WriteLiteral(@"nt.getElementById('lbTen').innerText = $(this).data('name');
            document.getElementById('lbEmail').innerText = $(this).data('email');
            document.getElementById('lbSDT').innerText = $(this).data('phone');
            var status = $(this).data('status');
            if (status == 0) {
                document.getElementById('lbTrangThai').innerText = ""Không kích hoạt"";
            }
            else {
                document.getElementById('lbTrangThai').innerText = ""Kích hoạt"";
            }
           
            document.getElementById('lbTongChiTieu').innerText = $(this).data('tongchitieu');


            $(document).on(""click"", "".delete"", function () {
                $.ajax({
                    method: ""GET"",
                    url: ""../API/CustomersAPI/ChangeStatus"",
                    data: { 'id': id }
                })
                    .done(function (msg) {
                        var obj = JSON.parse(msg);
                        document.getElementB");
                WriteLiteral("yId(\'\' + obj.ID).remove();\r\n                    });\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwonCinema.Areas.Admin.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591