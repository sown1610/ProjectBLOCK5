#pragma checksum "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "491ef5a52b4ab45db60eb2365afe008e50cd2638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectBLOCK5.Pages.Comment.Views_Comment_Index), @"mvc.1.0.view", @"/Views/Comment/Index.cshtml")]
namespace ProjectBLOCK5.Pages.Comment
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
#line 2 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
using ProjectBLOCK5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
using ProjectBLOCK5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"491ef5a52b4ab45db60eb2365afe008e50cd2638", @"/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0fc396ee5b07658f9ece791acd825491745ae1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rate>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491ef5a52b4ab45db60eb2365afe008e50cd26384462", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Quản lý sản phẩm</title>
    <link rel=""icon"" href=""https://shop.mixigaming.com/wp-content/uploads/2019/06/cropped-logo-mixi-tét-1-32x32.png"" sizes=""32x32"" />
    <link rel=""icon"" href=""https://shop.mixigaming.com/wp-content/uploads/2019/06/cropped-logo-mixi-tét-1-192x192.png"" sizes=""192x192"" />
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/");
                WriteLiteral("bootstrap/3.3.7/js/bootstrap.min.js\"></script>\r\n    <link href=\"css/manager.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    img {
        width: 150px;
        height: 200px;
    }

    .thumb {
        width: 300px;
    }

    body {
        color: #566787;
        background: #f5f5f5;
        font-family: 'Varela Round', sans-serif;
        font-size: 13px;
    }

    .table-wrapper {
        background: #fff;
        padding: 20px 25px;
        margin: 30px 0;
        border-radius: 3px;
        box-shadow: 0 1px 1px rgba(0,0,0,.05);
    }

    .table-title {
        padding-bottom: 15px;
        background: #0a4da8;
        color: #fff;
        padding: 16px 30px;
        margin: -20px -25px 10px;
        border-radius: 3px 3px 0 0;
    }

        .table-title h2 {
            margin: 5px 0 0;
            font-size: 24px;
        }

        .table-title .btn-group {
            float: right;
        }

        .table-title .btn {
            color: #fff;
            float: right;
            font-size: 13px;
            border: none;
            min-width: 50px;
  ");
            WriteLiteral(@"          border-radius: 2px;
            border: none;
            outline: none !important;
            margin-left: 10px;
        }

            .table-title .btn i {
                float: left;
                font-size: 21px;
                margin-right: 5px;
            }

            .table-title .btn span {
                float: left;
                margin-top: 2px;
            }

    table.table tr th, table.table tr td {
        border-color: #e9e9e9;
        padding: 12px 15px;
        vertical-align: middle;
    }

        table.table tr th:first-child {
            width: 60px;
        }

        table.table tr th:last-child {
            width: 100px;
        }

    table.table-striped tbody tr:nth-of-type(odd) {
        background-color: #fcfcfc;
    }

    table.table-striped.table-hover tbody tr:hover {
        background: #f5f5f5;
    }

    table.table th i {
        font-size: 13px;
        margin: 0 5px;
        cursor: pointer;
    }

    ");
            WriteLiteral(@"table.table td:last-child i {
        opacity: 0.9;
        font-size: 22px;
        margin: 0 5px;
    }

    table.table td a {
        font-weight: bold;
        color: #566787;
        display: inline-block;
        text-decoration: none;
        outline: none !important;
    }

        table.table td a:hover {
            color: #2196F3;
        }

        table.table td a.edit {
            color: #FFC107;
        }

        table.table td a.delete {
            color: #F44336;
        }

    table.table td i {
        font-size: 19px;
    }

    table.table .avatar {
        border-radius: 50%;
        vertical-align: middle;
        margin-right: 10px;
    }

    .pagination {
        float: right;
        margin: 0 0 5px;
    }

        .pagination li a {
            border: none;
            font-size: 13px;
            min-width: 30px;
            min-height: 30px;
            color: #999;
            margin: 0 2px;
            line-height: 30px;
   ");
            WriteLiteral(@"         border-radius: 2px !important;
            text-align: center;
            padding: 0 6px;
        }

            .pagination li a:hover {
                color: #666;
            }

        .pagination li.active a, .pagination li.active a.page-link {
            background: #03A9F4;
        }

            .pagination li.active a:hover {
                background: #0397d6;
            }

        .pagination li.disabled i {
            color: #ccc;
        }

        .pagination li i {
            font-size: 16px;
            padding-top: 6px
        }

    .hint-text {
        float: left;
        margin-top: 10px;
        font-size: 13px;
    }
    /* Custom checkbox */
    .custom-checkbox {
        position: relative;
    }

        .custom-checkbox input[type=""checkbox""] {
            opacity: 0;
            position: absolute;
            margin: 5px 0 0 3px;
            z-index: 9;
        }

        .custom-checkbox label:before {
            width:");
            WriteLiteral(@" 18px;
            height: 18px;
        }

        .custom-checkbox label:before {
            content: '';
            margin-right: 10px;
            display: inline-block;
            vertical-align: text-top;
            background: white;
            border: 1px solid #bbb;
            border-radius: 2px;
            box-sizing: border-box;
            z-index: 2;
        }

        .custom-checkbox input[type=""checkbox""]:checked + label:after {
            content: '';
            position: absolute;
            left: 6px;
            top: 3px;
            width: 6px;
            height: 11px;
            border: solid #000;
            border-width: 0 3px 3px 0;
            transform: inherit;
            z-index: 3;
            transform: rotateZ(45deg);
        }

        .custom-checkbox input[type=""checkbox""]:checked + label:before {
            border-color: #03A9F4;
            background: #03A9F4;
        }

        .custom-checkbox input[type=""checkbox""]:chec");
            WriteLiteral(@"ked + label:after {
            border-color: #fff;
        }

        .custom-checkbox input[type=""checkbox""]:disabled + label:before {
            color: #b8b8b8;
            cursor: auto;
            box-shadow: none;
            background: #ddd;
        }
    /* Modal styles */
    .modal .modal-dialog {
        max-width: 400px;
    }

    .modal .modal-header, .modal .modal-body, .modal .modal-footer {
        padding: 20px 30px;
    }

    .modal .modal-content {
        border-radius: 3px;
    }

    .modal .modal-footer {
        background: #ecf0f1;
        border-radius: 0 0 3px 3px;
    }

    .modal .modal-title {
        display: inline-block;
    }

    .modal .form-control {
        border-radius: 2px;
        box-shadow: none;
        border-color: #dddddd;
    }

    .modal textarea.form-control {
        resize: vertical;
    }

    .modal .btn {
        border-radius: 2px;
        min-width: 100px;
    }

    .modal form label {
        font");
            WriteLiteral("-weight: normal;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491ef5a52b4ab45db60eb2365afe008e50cd263813037", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""table-wrapper"">
            <div class=""table-title"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <a style=""color: white""  <h2>Comment <b></b>Manager</h2></a>
                    </div>
                    <div class=""col-sm-3"">
                        <div class=""input-group"">
                            <div class=""input-group-btn"">
                            </div><!-- /btn-group -->
                        </div><!-- /input-group -->
                    </div><!-- /.col-lg-6 -->

                    


                </div>
            </div>
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr>

                        <th style=""padding-right: 150px;"">Title</th>
                        <th>Person</th>
                        <th>Comment</th>
                        <th>Rate</th>
                        <th style=""pa");
                WriteLiteral("dding-right: 150px;\">Time</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 327 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                     foreach (Rate rate in Model)
                    {



#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n\r\n                            <td>");
#nullable restore
#line 334 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                           Write(rate.Movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 335 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                            Write(rate.Person.Fullname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 337 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                           Write(rate.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 341 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                           Write(rate.NumericRating);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 343 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                           Write(rate.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 346 "D:\FPTU\Learning\Ki5\PRN211\ProjectBLOCK5\ProjectBLOCK5\Views\Comment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n    <div class=\"text-center\" style=\"margin-bottom: 50px\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "491ef5a52b4ab45db60eb2365afe008e50cd263816857", async() => {
                    WriteLiteral("<button type=\"button\" class=\"btn btn-primary text-center\">Home</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    function ConfirmDelete() {\r\n        if (confirm(\"Do you want delete?\")) {\r\n            return true;\r\n        }\r\n        return false;\r\n    }\r\n</script>\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rate>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591