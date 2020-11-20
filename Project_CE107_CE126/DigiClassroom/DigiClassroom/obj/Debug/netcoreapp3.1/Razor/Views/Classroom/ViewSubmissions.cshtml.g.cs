#pragma checksum "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74661e52db031d64b38654636a596c88eb6edf4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classroom_ViewSubmissions), @"mvc.1.0.view", @"/Views/Classroom/ViewSubmissions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classroom/ViewSubmissions.cshtml", typeof(AspNetCore.Views_Classroom_ViewSubmissions))]
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
#line 2 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\_ViewImports.cshtml"
using DigiClassroom.Models;

#line default
#line hidden
#line 3 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
using DigiClassroom;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74661e52db031d64b38654636a596c88eb6edf4a", @"/Views/Classroom/ViewSubmissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75eeeec46ac66f1c2b806d7de44ad732c331b9ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Classroom_ViewSubmissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigiClassroom.Models.SubmittedAssignment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-loadPartial", "Assignments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(157, 35, true);
            WriteLiteral("\r\n<div class=\"col-sm-10\">\r\n    <h3>");
            EndContext();
            BeginContext(193, 27, false);
#line 6 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
   Write(ViewData["AssignmentTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(220, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 8 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(266, 33, true);
            WriteLiteral("        <span class=\"text-muted\">");
            EndContext();
            BeginContext(300, 24, false);
#line 10 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
                            Write(ViewData["EmptyMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(324, 25, true);
            WriteLiteral("</span>\r\n        <br />\r\n");
            EndContext();
#line 12 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden
            BeginContext(356, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 13 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
     foreach (var item in Model)
    {
        AppUser user = await _userManager.FindByIdAsync(item.AppUserID);

#line default
#line hidden
            BeginContext(471, 53, true);
            WriteLiteral("        <div class=\"content-block\">\r\n            <h6>");
            EndContext();
            BeginContext(525, 4, false);
#line 17 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
           Write(user);

#line default
#line hidden
            EndContext();
            BeginContext(529, 39, true);
            WriteLiteral("</h6>\r\n            <hr />\r\n            ");
            EndContext();
            BeginContext(569, 51, false);
#line 19 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
       Write(CustomHelpers.DisplayWithLinksFor(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(620, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
             if (item.Files != null)
            {
                string[] files = item.Files.Split(",");
                if (files.Count() > 1 || (files.Count() == 1 && files[0].Length != 0))
                {

#line default
#line hidden
            BeginContext(839, 28, true);
            WriteLiteral("                    <hr />\r\n");
            EndContext();
#line 26 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
                }
                foreach (string file in files)
                {
                    if (file.Length == 0)
                    {
                        continue;
                    }
                    var filePath = "~/posted_assignments/" + file;
                    var filename = file.Substring(file.IndexOf("_") + 1, file.Length - file.IndexOf("_") - 1);
                    var fileUrl = "https://localhost:44300" + "/submitted_assignments/" + file;

#line default
#line hidden
            BeginContext(1354, 38, true);
            WriteLiteral("                    <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1392, "\"", 1407, 1);
#line 36 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
WriteAttributeValue("", 1399, fileUrl, 1399, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1408, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1436, 8, false);
#line 37 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
                   Write(filename);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 56, true);
            WriteLiteral("\r\n                    </a>\r\n                    <br />\r\n");
            EndContext();
#line 40 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1534, 32, true);
            WriteLiteral("        </div>\r\n        <br />\r\n");
            EndContext();
#line 44 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden
            BeginContext(1573, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 45 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
     if ((string)ViewData["Role"] == "Mentor")
    {

#line default
#line hidden
            BeginContext(1628, 87, true);
            WriteLiteral("        <br />\r\n        <div>\r\n            <h5>Students yet to submit this Assignment: ");
            EndContext();
            BeginContext(1716, 17, false);
#line 49 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
                                                   Write(ViewData["Count"]);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 50 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
             foreach (ClassroomUser notSubmit in ViewBag.RemainingPeople)
            {

#line default
#line hidden
            BeginContext(1830, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1850, 26, false);
#line 52 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
              Write(notSubmit.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1876, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 53 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
            }

#line default
#line hidden
            BeginContext(1897, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 55 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden
            BeginContext(1920, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1924, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74661e52db031d64b38654636a596c88eb6edf4a11279", async() => {
                BeginContext(2013, 13, true);
                WriteLiteral("Back to Class");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Views\Classroom\ViewSubmissions.cshtml"
                           WriteLiteral(ViewBag.ClassId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-loadPartial", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loadPartial"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2030, 146, true);
            WriteLiteral("\r\n</div>\r\n<style>\r\n    .content-block {\r\n        border: 1px solid #dddddd;\r\n        border-radius: 20px;\r\n        padding: 20px;\r\n    }\r\n</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DigiClassroom.Models.SubmittedAssignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591