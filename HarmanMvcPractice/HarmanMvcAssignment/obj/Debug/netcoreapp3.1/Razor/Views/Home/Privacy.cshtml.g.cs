#pragma checksum "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b3b1ec4c74003727f6f0a77ead900289ed334b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\_ViewImports.cshtml"
using HarmanMvcAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\_ViewImports.cshtml"
using HarmanMvcAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b3b1ec4c74003727f6f0a77ead900289ed334b", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9439bcc0917af8b9bfe40e556dee9316866f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BusinessLayer.Student1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n<h1>More Mvc Concepts</h1>\r\n<h5>More Conceptss</h5>\r\n");
#nullable restore
#line 5 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
Write(Html.ActionLink("Click Here to see More concepts", "ExtraView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h6>Student List From Business Layer Class Library through Dependency Injection</h6>\r\n\r\n");
            WriteLiteral("<div class=\"row\">\r\n");
            WriteLiteral("\r\n    <button>");
#nullable restore
#line 23 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
       Write(Html.ActionLink("1", "Pagination", new { id = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n    <button> ");
#nullable restore
#line 24 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
        Write(Html.ActionLink("2", "Pagination", new { id = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button>");
#nullable restore
#line 25 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
       Write(Html.ActionLink("3", "Pagination", new { id = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button> ");
#nullable restore
#line 26 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
        Write(Html.ActionLink("4", "Pagination", new { id = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button> ");
#nullable restore
#line 27 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
        Write(Html.ActionLink("5", "Pagination", new { id = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button>\r\n        ");
#nullable restore
#line 29 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
   Write(Html.ActionLink("6", "Pagination", new { id = 6 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <button>\r\n        ");
#nullable restore
#line 32 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
   Write(Html.ActionLink("7", "Pagination", new { id = 7 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <button>\r\n        ");
#nullable restore
#line 35 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
   Write(Html.ActionLink("8", "Pagination", new { id = 8 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <button>\r\n        ");
#nullable restore
#line 38 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
   Write(Html.ActionLink("9", "Pagination", new { id = 9 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <button>\r\n        ");
#nullable restore
#line 41 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
   Write(Html.ActionLink("10", "Pagination", new { id = 10 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n    <button>\r\n        ");
#nullable restore
#line 44 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
   Write(Html.ActionLink("11", "Pagination", new { id = 11 }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </button>
</div>
<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th style=""width:350px"">Student Id </th>
        <th style=""width:406px"">Student Name </th>
        <th style=""width:350px"">Student Age </th>


    </tr>
");
#nullable restore
#line 55 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
     foreach (BusinessLayer.Student1 d in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 58 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
           Write(d.StudentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
           Write(d.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
           Write(d.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 65 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<h5>Cache Implemented </h5>\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <h3> Current Time: ");
#nullable restore
#line 71 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
                      Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        <h3>Cached Time: ");
#nullable restore
#line 74 "D:\net sol\HarmanMvcAssignment\HarmanMvcAssignment\Views\Home\Privacy.cshtml"
                    Write(ViewBag.time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BusinessLayer.Student1>> Html { get; private set; }
    }
}
#pragma warning restore 1591
