#pragma checksum "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed0aa37dd7b32bc08b921ad4c888a445cfb7321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messaging_Index), @"mvc.1.0.view", @"/Views/Messaging/Index.cshtml")]
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
#line 1 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\_ViewImports.cshtml"
using SharingIsCaring;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
using SharingIsCaring.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed0aa37dd7b32bc08b921ad4c888a445cfb7321", @"/Views/Messaging/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb257f04f758a2a3efb6f68ca51670d1dc01a49b", @"/Views/_ViewImports.cshtml")]
    public class Views_Messaging_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharingIsCaring.Models.Messaging>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1 class=""d-flex justify-content-center jumbotron"">Messaging Hub</h1>

<div class=""d-flex justify-content-center"">
    <table class=""table"">
        <thead>
            <tr>
                <td>Date/Time</td>
                <td>From</td>
                <td>Subject</td>
            </tr>
        </thead>
        <tr>
            <td>2/13/2021 08:49</td>
            <td>copelandeva@gmail.com</td>
            <td>Borrowing request</td>
        </tr>
    </table>
</div>


<h1>Index</h1>
");
#nullable restore
#line 32 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
 using (Html.BeginForm("Index", "Admin", FormMethod.Post, new { id = "Article" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            Article Heading\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <input type=\"text\" id=\"articleHeading\" name=\"articleHeading\" />\r\n            ");
#nullable restore
#line 40 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
       Write(Html.TextBoxFor(model => Model.MessageSubject, new { @maxlength = "50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            Article Content\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 48 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
       Write(Html.TextBoxFor(model => Model.MessageBody, new { @maxlength = "100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <button type=\"submit\" id=\"Add\" value=\"Add\" />\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharingIsCaring.Models.Messaging> Html { get; private set; }
    }
}
#pragma warning restore 1591
