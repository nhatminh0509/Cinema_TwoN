#pragma checksum "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654d2210565259231a6e0dff660771569379f94f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_SelectSeat), @"mvc.1.0.view", @"/Views/Booking/SelectSeat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654d2210565259231a6e0dff660771569379f94f", @"/Views/Booking/SelectSeat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037f7958d1f4644aabcf61b86ba31cb0c3b85a55", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_SelectSeat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formghe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
     foreach (var cate in ViewBag.listCate)
    {
        var w = cate.Count_Cell * 30;
        if (cate.Level == 1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <style type=\"text/css\">\r\n                .ghe");
#nullable restore
#line 8 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                 Write(cate.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" {\r\n                    display: none;\r\n                }\r\n\r\n                .ghe");
#nullable restore
#line 12 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                 Write(cate.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + label {\r\n                    background: url(\'../Uploads/Category_Equipment/");
#nullable restore
#line 13 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                              Write(cate.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                    height: 30px;\r\n                    width: ");
#nullable restore
#line 15 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                        Write(w);

#line default
#line hidden
#nullable disable
                WriteLiteral("px;\r\n                    display: inline-block;\r\n                    padding: 0 0 0 0px;\r\n                }\r\n\r\n                .ghe");
#nullable restore
#line 20 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                 Write(cate.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(":checked + label {\r\n                    background: url(\'../Uploads/Category_Equipment/");
#nullable restore
#line 21 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                              Write(cate.Image_Selected);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                    height: 30px;\r\n                    width: ");
#nullable restore
#line 23 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                        Write(w);

#line default
#line hidden
#nullable disable
                WriteLiteral("px;\r\n                    display: inline-block;\r\n                    padding: 0 0 0 0px;\r\n                }\r\n\r\n                .checked");
#nullable restore
#line 28 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                     Write(cate.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" {\r\n                    background: url(\'../Uploads/Category_Equipment/");
#nullable restore
#line 29 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                              Write(cate.Image_Checked);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                    height: 30px;\r\n                    width: ");
#nullable restore
#line 31 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                        Write(w);

#line default
#line hidden
#nullable disable
                WriteLiteral("px;\r\n                    display: inline-block;\r\n                    padding: 0 0 0 0px;\r\n                    margin-bottom: 7px;\r\n                }\r\n            </style>\r\n");
#nullable restore
#line 37 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
        }

        else if (cate.Level == 2)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <style>\r\n                .thietbi");
#nullable restore
#line 42 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                     Write(cate.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" {\r\n                    background: url(\'../Uploads/Category_Equipment/");
#nullable restore
#line 43 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                              Write(cate.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                    height: 30px;\r\n                    width: ");
#nullable restore
#line 45 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                        Write(w);

#line default
#line hidden
#nullable disable
                WriteLiteral("px;\r\n                    display: inline-block;\r\n                    padding: 0 0 0 0px;\r\n                    margin-bottom: 7px;\r\n                }\r\n            </style>\r\n");
#nullable restore
#line 51 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <style>
        div.table-custom {
            height: 550px;
            overflow: scroll;
            position: relative;
        }

        table.table-custom {
            position: relative;
            border-collapse: collapse;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<div class=""w3l-breadcrumbs"">
    <nav id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container page-wrapper"">
            <a href=""index.html"">Trang Chủ</a> » <span class=""breadcrumb_last"" aria-current=""page"">Đặt vé / Chọn chổ ngồi</span>
        </div>
    </nav>
</div>

<div class=""booking"" style=""margin-top: 10px;"">
    <div class=""container"">
        <div class=""container"" style=""background-color: #fff1ce;"">
            <p style=""color: #000; font-weight: bold;"">
                ");
#nullable restore
#line 79 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
           Write(ViewBag.Room.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 79 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                       Write(ViewBag.Room.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Sức chứa: ");
#nullable restore
#line 79 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                      Write(ViewBag.Room.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n                ");
#nullable restore
#line 80 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
           Write(ViewBag.Show.Start_Show.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ~ ");
#nullable restore
#line 80 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                   Write(ViewBag.Show.Start_Show.AddMinutes(ViewBag.Movie.Running_Time).ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
        <div class=""main-content"">
            <div class=""ticketbox"">
                <center>
                    <div class=""table-custom"">
                        <table class=""table-custom"" id=""seatsBlock"">
                            <tbody class=""table-custom"">
");
#nullable restore
#line 89 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                 for (int i = 1; i <= ViewBag.Room.Length; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n");
#nullable restore
#line 92 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                         for (int j = 0; j <= ViewBag.Room.Width; j++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td");
            BeginWriteAttribute("id", " id=\"", 3420, "\"", 3429, 2);
#nullable restore
#line 94 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
WriteAttributeValue("", 3425, i, 3425, 2, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
WriteAttributeValue("", 3427, j, 3427, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p style=\"width: 30px; height: 30px;opacity:0;\">0</p></td>\r\n");
#nullable restore
#line 95 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 97 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                </center>
            </div>
        </div>
        <div class=""container"" style=""background-color: #000;"">
            <div class=""row"">
                <div class=""col-3"">
                    <button class=""btn btn-outline-warning btn-block"" style=""margin:10px 10px 10px 0px;"">Trở về</button>
                </div>

                <div class=""col-3"">
                    <p><b>Tên Phim:</b> ");
#nullable restore
#line 112 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                   Write(ViewBag.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>

                <div class=""col-3"">
                    <p>Ghế Đang Chọn: </p><textarea id=""seatsDisplay"" style="" border: none;
						background: transparent;
						color: white;
						resize: none;""></textarea>
                </div>
                <div class=""col-3"">
                    <button onclick=""$('#formghe').submit();"" class=""btn btn-outline-success btn-block"" style=""margin:10px 10px;"">Tiếp tục</button>
                </div>
            </div>
        </div>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "654d2210565259231a6e0dff660771569379f94f16161", async() => {
                WriteLiteral("\r\n    <input id=\"inputghe\" name=\"ghe[]\">\r\n    <input type=\"submit\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on(""change"", "".seat"", function () {
            var allSeatsVals = [];

            $('#seatsBlock :checked').each(function () {
                allSeatsVals.push($(this).val());
            });
            $('#inputghe').val(allSeatsVals);
            $('#seatsDisplay').val(allSeatsVals);
        });

    </script>


");
#nullable restore
#line 151 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
     foreach (var item in ViewBag.listEquipments)
    {
        int row = item.Row_ID;
        int col = item.Col_ID;


#line default
#line hidden
#nullable disable
                WriteLiteral("        <script> document.getElementById(\'");
#nullable restore
#line 156 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                     Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                         Write(col);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').colSpan=\'");
#nullable restore
#line 156 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                         Write(item.Category_Equipment.Count_Cell);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'; </script>\r\n");
#nullable restore
#line 157 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"

        if (item.Category_Equipment.Level == 1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script> document.getElementById(\'");
#nullable restore
#line 160 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                         Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                             Write(col);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').innerHTML =\'<Input type=\"checkbox\" class=\"seat ghe");
#nullable restore
#line 160 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                                                        Write(item.Category_Equipment.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"ghe");
#nullable restore
#line 160 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                                                                                               Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" value=\"");
#nullable restore
#line 160 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></Input><label for=\"ghe");
#nullable restore
#line 160 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                                                                                                                                                      Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></label>\';</script>\r\n");
#nullable restore
#line 161 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
        }
        else if (item.Category_Equipment.Level == 2)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script> document.getElementById(\'");
#nullable restore
#line 164 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                     Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                         Write(col);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').innerHTML =\'<span class=\"thietbi");
#nullable restore
#line 164 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                                  Write(item.Category_Equipment.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"thietbi");
#nullable restore
#line 164 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                                                                                                             Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" ></span>\';</script>\r\n");
#nullable restore
#line 165 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
        }
        for (int i = 1; i < item.Category_Equipment.Count_Cell; i++)
        {
            col = col + 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script> document.getElementById(\'");
#nullable restore
#line 169 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                         Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
                                             Write(col);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').style=\'display:none;\'; </script>\r\n");
#nullable restore
#line 170 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\TwonCinema\Views\Booking\SelectSeat.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
