#pragma checksum "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d47f621a4dd046e4f52439f96173d031c3fff9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__EditEmpployeePartial), @"mvc.1.0.view", @"/Views/Home/_EditEmpployeePartial.cshtml")]
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
#line 1 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\_ViewImports.cshtml"
using HarmanMvcPractice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\_ViewImports.cshtml"
using HarmanMvcPractice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d47f621a4dd046e4f52439f96173d031c3fff9e", @"/Views/Home/_EditEmpployeePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b16efac87582a95b0bab5969bd3f6bb69ccb22", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__EditEmpployeePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignUp>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmployeeView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SignUp.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
   
        var item = new List<SelectListItem>
    {
        new SelectListItem () {Text = "select",Value = "0"},
        new SelectListItem () {Text = "sangrur",Value = "1"},
        new SelectListItem () {Text = "chandigarh",Value = "2"},
        new SelectListItem () {Text = "jammu",Value = "3"}
    };



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
     using (Html.BeginForm("EditEmployee", "Home", FormMethod.Post , new { id = "SignUp"})) ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
                                                                                             
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d47f621a4dd046e4f52439f96173d031c3fff9e6840", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Id\r\n            </label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 1523, "\"", 1540, 1);
#nullable restore
#line 51 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
WriteAttributeValue("", 1531, Model.Id, 1531, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" id=\"id\" placeholder=\"id\" />\r\n            ");
#nullable restore
#line 52 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.Id, "", new { id = "id_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Name\r\n            </label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 1822, "\"", 1841, 1);
#nullable restore
#line 59 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
WriteAttributeValue("", 1830, Model.Name, 1830, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"name\" type=\"text\" placeholder=\"Name\" />\r\n            ");
#nullable restore
#line 60 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name, "", new { id = "name_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Age\r\n            </label>\r\n            ");
#nullable restore
#line 66 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.TextBoxFor(m => m.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 67 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.Age, "", new { id = "age_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Salary\r\n            </label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 2393, "\"", 2414, 1);
#nullable restore
#line 73 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
WriteAttributeValue("", 2401, Model.Salary, 2401, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"salary\" onchange=\"HandleChange(id)\" type=\"text\" placeholder=\"salary\" />\r\n            ");
#nullable restore
#line 74 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.Salary, "", new { id = "salary_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Email\r\n            </label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 2739, "\"", 2747, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"email\" type=\"email\" onkeyup =\"HandleKeyPress(id)\" placeholder =\"email\" />\r\n            ");
#nullable restore
#line 81 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.email, "", new { id = "email_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Password\r\n            </label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 3075, "\"", 3083, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"password\" type=\"password\" placeholder=\"password\" />\r\n            ");
#nullable restore
#line 88 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.password, "", new { id = "password_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>\r\n                Designation\r\n            </label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 3398, "\"", 3423, 1);
#nullable restore
#line 94 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
WriteAttributeValue("", 3406, Model.Desination, 3406, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"desination\" type=\"text\" placeholder=\"designation\" />\r\n            ");
#nullable restore
#line 95 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.Desination, "", new { id = "desination_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Male</label>\r\n            ");
#nullable restore
#line 99 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.RadioButtonFor(m => m.gender, "male"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <label>Female</label>\r\n            ");
#nullable restore
#line 101 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.RadioButtonFor(m => m.gender, "female"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 104 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.DropDownListFor(m => m.genderDropdown, item));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 105 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
       Write(Html.ValidationMessageFor(m => m.genderDropdown, "", new { id = "city_error", @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <div id = ""target"" style="" height: 150px;  width: 300px; overflow-y: scroll "">
            harman harman harman harman harman harman  harman harman harman harman harman harman harman harman harman harman harman
            harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman
            harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman
            harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman harman
        </div>
        <div class=""form-group"">
            <label>filter1</label>
            <input type=""checkbox"" name=""male"" />
            <label>Filter2</label>
            <input type=""checkbox"" name=""female"" />
        </div>
        <button class=""btn btn-outline-danger"" type=""button"" onclick=""handleClick()"">Submit</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 121 "D:\net sol\MVC PROJECT practice\HarmanMvcPractice\HarmanMvcPractice\Views\Home\_EditEmpployeePartial.cshtml"
            
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button class=\"btn btn-outline-warning\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d47f621a4dd046e4f52439f96173d031c3fff9e17508", async() => {
                WriteLiteral(" Back ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d47f621a4dd046e4f52439f96173d031c3fff9e19079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignUp> Html { get; private set; }
    }
}
#pragma warning restore 1591
