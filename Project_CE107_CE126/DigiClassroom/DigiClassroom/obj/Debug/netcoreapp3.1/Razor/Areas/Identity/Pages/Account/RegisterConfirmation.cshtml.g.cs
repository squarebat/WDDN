#pragma checksum "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c0a12112ce02dcf46e6ec35596dfbe30384566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), null)]
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
#line 1 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\_ViewImports.cshtml"
using DigiClassroom.Areas.Identity;

#line default
#line hidden
#line 3 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\_ViewImports.cshtml"
using DigiClassroom.Areas.Identity.Pages;

#line default
#line hidden
#line 1 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using DigiClassroom.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c0a12112ce02dcf46e6ec35596dfbe30384566", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478ad7db5e5ea6b00332a58f00c34ee72d01d8e1", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fa865fdec298e7758e2963bcf0a8e68aa20a436", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
            BeginContext(98, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(105, 17, false);
#line 7 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 8 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
            BeginContext(183, 232, true);
            WriteLiteral("<p>\r\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\r\n    Normally this would be emailed: <a id=\"confirm-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 415, "\"", 449, 1);
#line 13 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 422, Model.EmailConfirmationUrl, 422, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(450, 47, true);
            WriteLiteral(">Click here to confirm your account</a>\r\n</p>\r\n");
            EndContext();
#line 15 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(521, 69, true);
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
            EndContext();
#line 21 "G:\All_Projects\Digital_Classroom\DigiClassroom\DigiClassroom\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
