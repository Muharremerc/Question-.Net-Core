#pragma checksum "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a388b6cba3e1a3905a67aa3e720ee19d91cfd827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Index), @"mvc.1.0.view", @"/Views/Exam/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exam/Index.cshtml", typeof(AspNetCore.Views_Exam_Index))]
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
#line 1 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\_ViewImports.cshtml"
using KO.Entity;

#line default
#line hidden
#line 2 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\_ViewImports.cshtml"
using KO.UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a388b6cba3e1a3905a67aa3e720ee19d91cfd827", @"/Views/Exam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f69b4f3ce3eca29834fcc2c9a5b696fb358189", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExamMemberDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 5 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(95, 489, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-2""></div>
        <div class=""col-lg-8"">
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">Title</th>
                        <th scope=""col"">Created Date</th>
                        <th scope=""col"">Creater</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 20 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(657, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(720, 11, false);
#line 23 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
                           Write(item.Header);

#line default
#line hidden
            EndContext();
            BeginContext(731, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(771, 16, false);
#line 24 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
                           Write(item.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(787, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(827, 12, false);
#line 25 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
                           Write(item.Creater);

#line default
#line hidden
            EndContext();
            BeginContext(839, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(879, 73, false);
#line 26 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
                           Write(Html.ActionLink("Start", "Index", "QuestionOfExam", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(952, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1013, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 33 "C:\Users\Merc\source\repos\KO\KO.UI.MVC\Views\Exam\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1092, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExamMemberDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
