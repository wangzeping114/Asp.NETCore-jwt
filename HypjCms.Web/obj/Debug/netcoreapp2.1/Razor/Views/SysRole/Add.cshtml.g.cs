#pragma checksum "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b352cd64de011354e9c880e36459e4ebe131c3ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysRole_Add), @"mvc.1.0.view", @"/Views/SysRole/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SysRole/Add.cshtml", typeof(AspNetCore.Views_SysRole_Add))]
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
#line 1 "G:\HYPJ\HypjCms.Web\Views\_ViewImports.cshtml"
using HYPJ.Applicatoin.Dots;

#line default
#line hidden
#line 2 "G:\HYPJ\HypjCms.Web\Views\_ViewImports.cshtml"
using HYPJ.Applicatoin.Resources;

#line default
#line hidden
#line 3 "G:\HYPJ\HypjCms.Web\Views\_ViewImports.cshtml"
using HYPJ.Utilities.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b352cd64de011354e9c880e36459e4ebe131c3ae", @"/Views/SysRole/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3b871e6ca0d6c021e77bb8429b5e6a751d6131", @"/Views/_ViewImports.cshtml")]
    public class Views_SysRole_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HYPJ.Applicatoin.Resources.MenuResource>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
   
    ViewData["Title"] = "添加管理员";

#line default
#line hidden
            BeginContext(96, 38, true);
            WriteLiteral("<article class=\"page-container\">\r\n    ");
            EndContext();
            BeginContext(134, 3192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88a48cf6fe744b7fa5f6128e3f70247b", async() => {
                BeginContext(225, 800, true);
                WriteLiteral(@"
         <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>角色名称：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text"" value="""" placeholder="""" id=""fRoleName"" name=""fRoleName"">
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">备注：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text"" value="""" placeholder="""" id=""fRemark"" name=""fRemark"">
            </div>
        </div>

        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">角色功能：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
");
                EndContext();
#line 23 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(1090, 171, true);
                WriteLiteral("                    <dl class=\"permission-list\">\r\n                        <dt>\r\n                            <label>\r\n                                <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1261, "\"", 1277, 1);
#line 28 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 1269, item.Id, 1269, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1278, "\"", 1293, 1);
#line 28 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 1285, item.Id, 1285, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1294, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1298, 9, false);
#line 28 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1307, 101, true);
                WriteLiteral("\r\n                            </label>\r\n                        </dt>\r\n                        <dd>\r\n");
                EndContext();
#line 32 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
                             foreach (var item2 in item.Children)
                            {

#line default
#line hidden
                BeginContext(1506, 231, true);
                WriteLiteral("                                <dl class=\"cl permission-list\">\r\n                                    <dt>\r\n                                        <label class=\"\">\r\n                                            <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1737, "\"", 1754, 1);
#line 37 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 1745, item2.Id, 1745, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1755, "\"", 1771, 1);
#line 37 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 1762, item2.Id, 1762, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1772, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(1777, 10, false);
#line 37 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
                                                                                                    Write(item2.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1787, 261, true);
                WriteLiteral(@"
                                        </label>
                                    </dt>
                                    <dt>
                                        <label class="""">
                                            <input type=""checkbox""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2048, "\"", 2065, 1);
#line 42 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2056, item2.Id, 2056, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2066, "\"", 2082, 1);
#line 42 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2073, item2.Id, 2073, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2083, 184, true);
                WriteLiteral(" /> 查看列表\r\n                                        </label>\r\n                                        <label class=\"\">\r\n                                            <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2267, "\"", 2284, 1);
#line 45 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2275, item2.Id, 2275, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2285, "\"", 2301, 1);
#line 45 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2292, item2.Id, 2292, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2302, 182, true);
                WriteLiteral(" /> 新增\r\n                                        </label>\r\n                                        <label class=\"\">\r\n                                            <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2484, "\"", 2501, 1);
#line 48 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2492, item2.Id, 2492, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2502, "\"", 2518, 1);
#line 48 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2509, item2.Id, 2509, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2519, 182, true);
                WriteLiteral(" /> 删除\r\n                                        </label>\r\n                                        <label class=\"\">\r\n                                            <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2701, "\"", 2718, 1);
#line 51 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2709, item2.Id, 2709, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2719, "\"", 2735, 1);
#line 51 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2726, item2.Id, 2726, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2736, 140, true);
                WriteLiteral(" /> 编辑\r\n                                        </label>\r\n                                    </dt>\r\n                                </dl>\r\n");
                EndContext();
#line 55 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
                            }

#line default
#line hidden
                BeginContext(2907, 58, true);
                WriteLiteral("                        </dd>\r\n                    </dl>\r\n");
                EndContext();
#line 58 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
                }

#line default
#line hidden
                BeginContext(2984, 335, true);
                WriteLiteral(@"            </div>
        </div>
        <div class=""row cl"">

            <div class=""col-xs-8 col-sm-9 col-xs-offset-4 col-sm-offset-2"">
                <button type=""submit"" class=""btn btn-success radius"" id=""admin-role-save"" name=""admin-role-save""><i class=""icon-ok""></i> 确定</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "G:\HYPJ\HypjCms.Web\Views\SysRole\Add.cshtml"
AddHtmlAttributeValue("", 148, Url.Action("add"), 148, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3326, 16, true);
            WriteLiteral("\r\n</article>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3421, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(3455, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad00ab6cf1964b7fa53ad3c7e4f13acb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3557, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3563, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41cb25abf7a040f38f40cd10cf7c7969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3666, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3672, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0de37154f5e437d90fa296ae6e4789b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3770, 4132, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.skin-minimal input').iCheck({
                        checkboxClass: 'icheckbox-blue',
                        radioClass: 'iradio-blue',
                        increaseArea: '20%'
                    });
                    $("".permission-list dt input:checkbox"").click(function () {
                        $(this).closest(""dl"").find(""dd input:checkbox"").prop(""checked"", $(this).prop(""checked""));
                    });
                    $("".permission-list2 dd input:checkbox"").click(function () {
                        var l = $(this).parent().parent().find(""input:checked"").length;
                        var l2 = $(this).parents("".permission-list"").find("".permission-list2 dd"").find(""input:checked"").length;
                        if ($(this).prop(""checked"")) {
                            $(this).closest(""dl"").find(""dt input:checkbox"").prop(""chec");
                WriteLiteral(@"ked"", true);
                            $(this).parents("".permission-list"").find(""dt"").first().find(""input:checkbox"").prop(""checked"", true);
                        }
                        else {
                            if (l == 0) {
                                $(this).closest(""dl"").find(""dt input:checkbox"").prop(""checked"", false);
                            }
                            if (l2 == 0) {
                                $(this).parents("".permission-list"").find(""dt"").first().find(""input:checkbox"").prop(""checked"", false);
                            }
                        }
                    });
                },
                formSubmit: function () {
                    $(""#form-add"").validate({
                        rules: {
                            fRoleId: {
                                required: true,
                                minlength: 3,
                                maxlength: 4
                            },
                      ");
                WriteLiteral(@"      fRoleName: {
                                required: true,
                                minlength: 2,
                                maxlength: 20
                            }
                        },
                        onkeyup: false,
                        focusCleanup: true,
                        success: ""valid"",
                        submitHandler: function (form) {
                            var fState = $(""input[name='fState']"").is(':checked');
                            $(form).ajaxSubmit({
                                type: ""POST"",
                                cache: false,
                                data: { fState: fState },
                                dataType: ""json"",
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""POST[FAIL]"", { icon: 5 });
                              ");
                WriteLiteral(@"      }
                                },
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        var index = parent.layer.getFrameIndex(window.name);
                                        parent.location.reload();
                                        parent.layer.close(index);
                                    } else {
                                        layer.alert(message, { icon: 5 });
                                    }
                                }
                            });
                        }
                    });
                }
            };
            $(function () {
                $.mainu.init();
                $.mainu.formSubmit();
            });

        })(jQuery);
    </sc");
                WriteLiteral("ript>\r\n    <!--/请在上方写此页面业务相关的脚本-->\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HYPJ.Applicatoin.Resources.MenuResource>> Html { get; private set; }
    }
}
#pragma warning restore 1591
