#pragma checksum "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cec30b64aba71ed008f0fafb0a238c148fde46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classroom__PeoplePartial), @"mvc.1.0.view", @"/Views/Classroom/_PeoplePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classroom/_PeoplePartial.cshtml", typeof(AspNetCore.Views_Classroom__PeoplePartial))]
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
#line 1 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\_ViewImports.cshtml"
using DigiClassroom;

#line default
#line hidden
#line 2 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\_ViewImports.cshtml"
using DigiClassroom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56cec30b64aba71ed008f0fafb0a238c148fde46", @"/Views/Classroom/_PeoplePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75eeeec46ac66f1c2b806d7de44ad732c331b9ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Classroom__PeoplePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigiClassroom.ViewModels.ClassroomHomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InviteStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 28, true);
            WriteLiteral("\r\n<h5>Mentors</h5>\r\n<hr />\r\n");
            EndContext();
#line 5 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
 foreach (var item in Model.ClassroomMentors)
{

#line default
#line hidden
            BeginContext(134, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(142, 51, false);
#line 7 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
  Write(Html.DisplayFor(modelItem => item.AppUser.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(193, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 8 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
    //@Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) |
}

#line default
#line hidden
            BeginContext(278, 43, true);
            WriteLiteral("<br />\r\n<h5>\r\n    Students\r\n</h5>\r\n<hr />\r\n");
            EndContext();
#line 15 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
 if (Model.ClassroomStudents.Count() != 0)
{
    foreach (var item in Model.ClassroomStudents)
    {

#line default
#line hidden
            BeginContext(426, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(438, 51, false);
#line 19 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
      Write(Html.DisplayFor(modelItem => item.AppUser.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(489, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
        //@Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) |
    }
}
else if (Model.StudentInvites.Count() == 0)
{

#line default
#line hidden
            BeginContext(633, 92, true);
            WriteLiteral("    <span class=\"text-muted\">It\'s silent right now. Invite some students over!</span><br/>\r\n");
            EndContext();
#line 26 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
}

#line default
#line hidden
#line 27 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
 foreach (var item in Model.StudentInvites)
{

#line default
#line hidden
            BeginContext(776, 31, true);
            WriteLiteral("    <p style=\"color : #CCCCCC\">");
            EndContext();
            BeginContext(808, 10, false);
#line 29 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
                          Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(818, 16, true);
            WriteLiteral(" (Invited)</p>\r\n");
            EndContext();
#line 30 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
}

#line default
#line hidden
            BeginContext(837, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 32 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
 if (Model.ClassroomUserRole == "Mentor")
{

#line default
#line hidden
            BeginContext(891, 165, true);
            WriteLiteral("    <button title=\"Invite Students\" type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#StudentsModal\">\r\n        Invite Students\r\n    </button>\r\n");
            EndContext();
#line 37 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
}

#line default
#line hidden
            BeginContext(1059, 554, true);
            WriteLiteral(@"<div class=""modal fade"" id=""StudentsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""StudentsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""StudentsModalLabel"">Invite Students</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(1613, 1001, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cec30b64aba71ed008f0fafb0a238c148fde4610106", async() => {
                BeginContext(1647, 203, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <span class=\"small text-muted\">Enter email address. Seperate multiple email addresses by whitespace</span><br /><br/>\r\n                    ");
                EndContext();
                BeginContext(1850, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cec30b64aba71ed008f0fafb0a238c148fde4610701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 50 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1916, 70, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"ClassId\" name=\"ClassId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1986, "\"", 2013, 1);
#line 51 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\_PeoplePartial.cshtml"
WriteAttributeValue("", 1994, Model.Classroom.ID, 1994, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2014, 464, true);
                WriteLiteral(@" />
                    <div class=""form-group"">
                        <input placeholder=""Email(s)"" name=""emails"" id=""emails"" type=""text"" class=""form-control"" />
                        <span class=""text-danger""></span>
                    </div>
                </div>               
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                    ");
                EndContext();
                BeginContext(2478, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cec30b64aba71ed008f0fafb0a238c148fde4613514", async() => {
                    BeginContext(2538, 6, true);
                    WriteLiteral("Invite");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2553, 54, true);
                WriteLiteral("\r\n                </div>                \r\n            ");
                EndContext();
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2614, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiClassroom.ViewModels.ClassroomHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
