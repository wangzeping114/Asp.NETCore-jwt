#pragma checksum "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd58c376ba4373bbbed4a42a7d8a3f100686dd1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysRole_List), @"mvc.1.0.view", @"/Views/SysRole/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SysRole/List.cshtml", typeof(AspNetCore.Views_SysRole_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd58c376ba4373bbbed4a42a7d8a3f100686dd1f", @"/Views/SysRole/List.cshtml")]
    public class Views_SysRole_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(40, 596, true);
            WriteLiteral(@"<nav class=""breadcrumb""><i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 系统管理 <span class=""c-gray en"">&gt;</span> 角色管理 <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a></nav>
<div class=""page-container"">
    <div class=""text-c"">
        日期范围：
        <input type=""text"" onfocus=""WdatePicker({ maxDate:'#F{$dp.$D(\'datemax\')||\'%y-%M-%d\'}' })"" id=""datemin"" name=""datemin"" class=""input-text Wdate"" style=""width:120px;""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 636, "\"", 660, 1);
#line 8 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 644, ViewBag.datemin, 644, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(661, 196, true);
            WriteLiteral(" />\r\n        -\r\n        <input type=\"text\" onfocus=\"WdatePicker({ minDate:\'#F{$dp.$D(\\\'datemin\\\')}\',maxDate:\'%y-%M-%d\' })\" id=\"datemax\" name=\"datemax\" class=\"input-text Wdate\" style=\"width:120px;\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 857, "\"", 881, 1);
#line 10 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 865, ViewBag.datemax, 865, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(882, 120, true);
            WriteLiteral(" />\r\n        <input type=\"text\" class=\"input-text\" style=\"width:250px\" placeholder=\"角色编号、名称\" id=\"keyword\" name=\"keyword\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1002, "\"", 1026, 1);
#line 11 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 1010, ViewBag.keyword, 1010, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1027, 411, true);
            WriteLiteral(@" />
        <button type=""submit"" class=""btn btn-success radius"" id=""search"" name=""search"" onclick=""$.mainu.search()""><i class=""Hui-iconfont"">&#xe665;</i> 找查</button>
    </div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.deleteBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1438, "\"", 1464, 1);
#line 17 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 1445, Url.Action("list"), 1445, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1465, 113, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe667;</i> 角色列表</a>\r\n            <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1578, "\"", 1629, 4);
            WriteAttributeValue("", 1588, "$.mainu.add(\'新增角色\',", 1588, 19, true);
            WriteAttributeValue(" ", 1607, "\'", 1608, 2, true);
#line 18 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 1609, Url.Action("add"), 1609, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1627, "\')", 1627, 2, true);
            EndWriteAttribute();
            BeginContext(1630, 159, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe600;</i> 新增角色</a>\r\n        </span>\r\n        <span class=\"r\" onclick=\"$.mainu.dayin()\">共有数据：<strong>");
            EndContext();
            BeginContext(1790, 13, false);
#line 20 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                                                          Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 626, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""80"">角色编号</th>
                    <th width=""80"">角色名称</th>
                    <th width=""80"">描述</th>
                    <th width=""70"">状态</th>
                    <th width=""120"">操作时间</th>
                    <th width=""120"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 36 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(2554, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2663, "\"", 2680, 1);
#line 41 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 2671, m.RoleID, 2671, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2681, 134, true);
            WriteLiteral("></td>\r\n                            <td> </td>\r\n                            <td></td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(2816, 8, false);
#line 44 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                                          Write(m.Remark);

#line default
#line hidden
            EndContext();
            BeginContext(2824, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(2883, 146, false);
#line 45 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                                              Write(m.State.HasValue ? Html.Raw("<span class='label label-success radius'>启用</span>") : Html.Raw("<span class='label label-defaunt radius'>停用</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(3030, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3071, 77, false);
#line 46 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(3149, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n");
            EndContext();
#line 48 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                                 if (m.State.ToBool())
                                {

#line default
#line hidden
            BeginContext(3299, 111, true);
            WriteLiteral("                                    <a title=\"停用\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 3410, "\"", 3450, 3);
            WriteAttributeValue("", 3420, "$.mainu.stop(this,\'", 3420, 19, true);
#line 50 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 3439, m.RoleID, 3439, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3448, "\')", 3448, 2, true);
            EndWriteAttribute();
            BeginContext(3451, 9, true);
            WriteLiteral(">停用</a>\r\n");
            EndContext();
#line 51 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3568, 111, true);
            WriteLiteral("                                    <a title=\"启用\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 3679, "\"", 3720, 3);
            WriteAttributeValue("", 3689, "$.mainu.start(this,\'", 3689, 20, true);
#line 54 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 3709, m.RoleID, 3709, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 3718, "\')", 3718, 2, true);
            EndWriteAttribute();
            BeginContext(3721, 9, true);
            WriteLiteral(">启用</a>\r\n");
            EndContext();
#line 55 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(3765, 65, true);
            WriteLiteral("                                <a title=\"编辑\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3830, "\"", 3908, 4);
            WriteAttributeValue("", 3840, "$.mainu.add(\'新增角色\',", 3840, 19, true);
            WriteAttributeValue(" ", 3859, "\'", 3860, 2, true);
#line 56 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 3861, Url.Action("edit",new { roleid = m.RoleID }), 3861, 45, false);

#line default
#line hidden
            WriteAttributeValue("", 3906, "\')", 3906, 2, true);
            EndWriteAttribute();
            BeginContext(3909, 116, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\">编辑</a>\r\n                                <a title=\"删除\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4025, "\"", 4067, 3);
            WriteAttributeValue("", 4035, "$.mainu.delete(this,\'", 4035, 21, true);
#line 57 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
WriteAttributeValue("", 4056, m.RoleID, 4056, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 4065, "\')", 4065, 2, true);
            EndWriteAttribute();
            BeginContext(4068, 117, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 60 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4227, 120, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"pt-30\" style=\"width:100%; height:60px;\"></div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4426, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(4460, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7381ff01ac8d4ad39e35df0f06bd89fd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4552, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4558, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1eee012a2f4b9aa4ede6d9accaf8ef", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4659, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4665, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4597488a2336474693a4ba7e5bfa0f9f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4746, 1731, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.table-sort').dataTable({
                        ""aaSorting"": [[5, ""desc""]],//默认第几个排序
                        ""bStateSave"": true,//状态保存
                        ""aoColumnDefs"": [
                            { ""orderable"": false, ""aTargets"": [0, 6] }// 制定列不参与排序
                        ],
                        ""aLengthMenu"": [10, 25, 50, 100]
                    });
                },
                search: function () {
                    $dateMin = $(""input[name='datemin']"").val();
                    $dateMax = $(""input[name='datemax']"").val();
                    $keyword = $(""input[name='keyword']"").val();
                    if ($keyword == """") {
                        if ($dateMin == """" || $dateMax == """") {
                            layer.alert('日期范围不能空', { icon: 5 });
                            return;
                        }
   ");
                WriteLiteral(@"                 }
                    var url = ""?datemin="" + $dateMin + ""&datemax="" + $dateMax + ""&keyword="" + $keyword + """";
                    window.location.href = url;
                },
                add: function (title, url) {
                    var index = layer.open({
                        type: 2,
                        title: title,
                        content: url
                    });
                    layer.full(index);
                },
                stop: function (obj, id) {
                    layer.confirm('确认要停用吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(6478, 25, false);
#line 115 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(6503, 1472, true);
                WriteLiteral(@"',
                            data: { roleId: id, state: false },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""启用"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.start(this,\'' + id + '\')"">启用</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-defaunt radius"">已停用</span>');
                                    $(obj).remove();
                                    layer.msg('已停用！', { icon: 5, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                    ");
                WriteLiteral(@"        },
                            error: function (data) {
                                console.log(data.msg);
                            }
                        });
                    });
                },
                start: function (obj, id) {
                    layer.confirm('确认要启用吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(7976, 25, false);
#line 140 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                             Write(Url.Action("UpdateState"));

#line default
#line hidden
                EndContext();
                BeginContext(8001, 1472, true);
                WriteLiteral(@"',
                            data: { roleId: id, state: true },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""已停用"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.stop(this,\'' + id + '\')"">停用</a>');
                                    $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-success radius"">已启用</span>');
                                    $(obj).remove();
                                    layer.msg('已启用！', { icon: 6, time: 3000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 3000 });
                                }
                     ");
                WriteLiteral(@"       },
                            error: function (data) {
                                console.log(data.msg);
                            }
                        });
                    });
                },
                delete: function (obj, id) {
                    layer.confirm('确认要删除吗？', function (index) {
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(9474, 20, false);
#line 165 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                             Write(Url.Action("delete"));

#line default
#line hidden
                EndContext();
                BeginContext(9494, 1726, true);
                WriteLiteral(@"',
                            data: { roleId: id },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;
                                var message = result.message;
                                if (state == ""success"") {
                                    $(obj).parents(""tr"").remove();
                                    layer.msg('已删除!', { icon: 1, time: 1000 });
                                } else {
                                    layer.msg(message, { icon: 5, time: 1000 });
                                }
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                if (XMLHttpRequest.status != 200) {
                                    layer.alert(""系统错误！"", { icon: 5 });
                                }
                            }
                        });
                  ");
                WriteLiteral(@"  });
                },
                deleteBatch: function () {
                    layer.confirm('确认要删除吗？', function (index) {
                        var arrId = [];
                        $(""input:checkbox[name='id']:checked"").each(function () {
                            //alert($(this).val());
                            arrId.push($(this).val());
                        });
                        if (arrId.length == 0) {
                            layer.msg('请选择需要删除日志！', { icon: 5, time: 2000 });
                            return;
                        }
                        $.ajax({
                            type: 'POST',
                            url: '");
                EndContext();
                BeginContext(11221, 25, false);
#line 199 "G:\HYPJ\HYPJ.MVC.Test\Views\SysRole\List.cshtml"
                             Write(Url.Action("deletebatch"));

#line default
#line hidden
                EndContext();
                BeginContext(11246, 1145, true);
                WriteLiteral(@"',
                            data: { arrRoleId: arrId },
                            dataType: 'json',
                            success: function (result) {
                                var state = result.state;          //错误代码
                                var message = result.message;        //错误说明
                                if (state == ""success"") {
                                    window.location.replace(location.href);
                                } else {
                                    layer.msg(message, { icon: 5, time: 1000 });
                                }
                            },
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                if (XMLHttpRequest.status != 200) {
                                    layer.alert(""系统错误！"", { icon: 5 });
                                }
                            }
                        });
                    });
                }
          ");
                WriteLiteral("  };\r\n            $(function () {\r\n                $.mainu.init();\r\n            });\r\n        })(jQuery);\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(12394, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
