#pragma checksum "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c2bfed14e675764566d33e5a0ccdbc6b460bc09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Equipments_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Equipments/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2bfed14e675764566d33e5a0ccdbc6b460bc09", @"/Areas/Admin/Views/Equipments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037f7958d1f4644aabcf61b86ba31cb0c3b85a55", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Equipments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwonCinema.Areas.Admin.Models.Equipment>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    string[] ChuCai = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ" };

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    div.table-custom {
        height: 550px;
        overflow: scroll;
        position: relative;
    }

    table.table-custom {
        position: relative;
        border-collapse: collapse;
    }

    td.table-custom, th.table-custom {
        padding: 0.25em;
    }

    thead.table-custom th {
        position: -webkit-sticky;
        position: sticky;
        top: 0;
        height: 40px;
        min-width: 50px;
        width: auto;
        background: #000;
        color: #FFF;
        text-align: center;
    }

        thead.table-custom th:first-child {
            left: 0;
            z-index: 1;
        }

    tbody.table-custom th {
        position: -webkit-sticky;
        position: sticky;
        left: 0;
        text-align: center;
        height: 40px;
        min-width: 50px;
        background: #FFF;
        border-right: 1px solid #CCC;
    }
</style>


<center>
    <h2>Sơ Đồ Của ");
#nullable restore
#line 55 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
             Write(ViewBag.Room.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n</center>\r\n<br />\r\n<center>\r\n    <div class=\"table-custom\">\r\n        <table class=\"table-custom\">\r\n            <thead class=\"table-custom\">\r\n                <tr>\r\n");
#nullable restore
#line 63 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                     for (int i = 0; i <= ViewBag.Room.Width; i++)
                    {
                        if (i == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th class=\"table-custom\"></th>\r\n");
#nullable restore
#line 68 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th class=\"table-custom\">");
#nullable restore
#line 71 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 72 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody class=\"table-custom\">\r\n");
#nullable restore
#line 77 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                 for (int i = 1; i <= ViewBag.Room.Length; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 80 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                         for (int j = 0; j <= ViewBag.Room.Width; j++)
                        {
                            if (j == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th class=\"table-custom\">");
#nullable restore
#line 84 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                    Write(ChuCai[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 85 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"height: auto;text-align: center;border: 2px solid #002447;\"");
            BeginWriteAttribute("id", " id=\"", 2792, "\"", 2801, 2);
#nullable restore
#line 88 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
WriteAttributeValue("", 2797, i, 2797, 2, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
WriteAttributeValue("", 2799, j, 2799, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" colspan=\"1\">\r\n                                    <a href=\"#\" data-idroom=\"");
#nullable restore
#line 89 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                        Write(ViewBag.Room.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-row=\"");
#nullable restore
#line 89 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-col=\"");
#nullable restore
#line 89 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                                                                  Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#equipment\" data-toggle=\"modal\" class=\"identifyingClass\"><label class=\"fa fa-plus\"></label></a>\r\n                                </td>\r\n");
#nullable restore
#line 91 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</center>\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 103 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
 foreach (var item in ViewBag.listEquipment)
{
    int row = item.Row_ID;
    int col = item.Col_ID;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <script> document.getElementById(\'");
#nullable restore
#line 108 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                 Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                     Write(col);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').colSpan=\'");
#nullable restore
#line 108 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                     Write(item.Category_Equipment.Count_Cell);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'; </script>\r\n    <script> document.getElementById(\'");
#nullable restore
#line 109 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                 Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                     Write(col);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').innerHTML =\'<a href=\"/Admin/Equipments/Details/");
#nullable restore
#line 109 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                                                           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"display:block\">");
#nullable restore
#line 109 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\';</script>\r\n");
#nullable restore
#line 110 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
    if (item.Category_Equipment.Level == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script> document.getElementById(\'");
#nullable restore
#line 112 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                     Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                         Write(col);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style = \'background:#26c6da; height: auto;text-align: center;border: 2px solid #002447;\'; </script>\r\n");
#nullable restore
#line 113 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script> document.getElementById(\'");
#nullable restore
#line 116 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                     Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                         Write(col);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style = \'background:#e3d318; height: auto;text-align: center;border: 2px solid #002447;\'; </script>\r\n");
#nullable restore
#line 117 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
    }

    for (int i = 1; i < item.Category_Equipment.Count_Cell; i++)
    {
        col = col + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script> document.getElementById(\'");
#nullable restore
#line 122 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                     Write(row);

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                         Write(col);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').style=\'display:none;\'; </script>\r\n");
#nullable restore
#line 123 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""equipment"" tabindex=""-1"" role=""dialog"" aria-labelledby=""my_modalLabel"">

    <div class=""modal-dialog"" role=""dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" id=""btnClose"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""myModalLabel"">Thêm Ghế</h4>
            </div>

            <div class=""modal-body"">
                <div class=""form-group"">
                    <label class=""control-label"">Tên:</label>
                    <input type=""text"" name=""Name"" id=""txtName"" class=""form-control"" />
                    <span id=""error"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Loại Ghế:</label>
                    <select class=""form-control"" id=""select_level"" onchange=""Levelchange(this);"" name=""Equipment_");
            WriteLiteral("Level_ID\">\r\n");
#nullable restore
#line 144 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                         foreach (var item in ViewBag.listCategory_Equipment)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2bfed14e675764566d33e5a0ccdbc6b460bc0917851", async() => {
#nullable restore
#line 146 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                                                                Write(item.Count_Cell);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-countcell", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 147 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Hủy</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""btnAddClick();"" id=""btnAdd"">Thêm</button>
            </div>
        </div>
    </div>

</div>

<script type=""text/javascript"">
    var idroom;
    var row;
    var col;
    var idLevel;

    var btn = document.getElementById('btnAdd');
    var select = document.getElementById('select_level');


    $(document).on(""click"", "".identifyingClass"", function () {
        idroom = $(this).data('idroom');
        row = $(this).data('row');
        col = $(this).data('col');
        Levelchange(select);
    });

    function Levelchange(obj) {
        idLevel = obj.value;
        var options = obj.children;
        var cell;
        for (var i = 0; i < options.length; i++) {
            if (options[i].selected");
            WriteLiteral(") {\r\n                cell = options[i].getAttribute(\"data-countcell\");\r\n            }\r\n        }\r\n        var column = col;\r\n        if (column > (");
#nullable restore
#line 188 "C:\Users\Nhat-Minh\Desktop\TwonCinema_ASP\TwonCinema\TwonCinema\Areas\Admin\Views\Equipments\Index.cshtml"
                 Write(ViewBag.Room.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - cell + 1)) {
            btn.disabled = true;
            return 0;
        }

        $.ajax({
            method: ""GET"",
            url: ""../../../API/EquipmentsAPI/ListInRow"",
            data: {
                'id': idroom,
                'row': row,
            }
        })
        .done(function (msg) {
            var obj = JSON.parse(msg);
            for (var x in obj) {
                column = col;
                for (var i = 1; i <= cell; i++) {
                    if (column == obj[x].Col_ID) {
                        btn.disabled = true;
                        return 0;
                    }
                    column++;
                }
            }
        });
        btn.disabled = false;
        return 0;
    }

    function btnAddClick() {
        var txtname = document.getElementById('txtName');
        var name = txtname.value;
        var error = document.getElementById('error');
        if (name == """") {
            error.innerText = ""Tên Khô");
            WriteLiteral(@"ng Được Bỏ Trống"";
            return 0;
        }
        else {
            error.innerText = """";
        }
        $.ajax({
            type: ""GET"",
            url: ""../../../API/EquipmentsAPI/Create"",
            data: {
                Name: name,
                Row_ID: row,
                Col_ID: col,
                Room_ID: idroom,
                Equipment_Level_ID: idLevel
            },
            success: function (response) {
                var obj = JSON.parse(response);

                var row = obj.Row_ID;
                var col = obj.Col_ID;
                document.getElementById(row + '' + col).colSpan=obj.Count_Cell;
                document.getElementById(row + '' + col).innerHTML = '<a href=""/Admin/Equipments/Details/' + obj.ID + '"" style=""display:block"">' + obj.Name + '</a>';
                if (obj.Level_Equipment == 1)
                {
                    document.getElementById(row + '' + col).style = 'background:#26c6da;height: auto;text-align: cente");
            WriteLiteral(@"r;border: 2px solid #002447;';
                }
                else
                {
                    document.getElementById(row + '' + col).style = 'background:#e3d318;height: auto;text-align: center;border: 2px solid #002447;';
                }
                for (var i = 1; i < obj.Count_Cell; i++)
                {
                    col = col + 1;
                    document.getElementById(row + '' + col).style='display:none;';
                }
                var btnClose = document.getElementById('btnClose');
                txtname.value = """";
                btnClose.click();
            },
        })
    }
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwonCinema.Areas.Admin.Models.Equipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
