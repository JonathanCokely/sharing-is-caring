#pragma checksum "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d45d0616408c54cf476499e076a3454424aa515"
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
#line 2 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\_ViewImports.cshtml"
using SharingIsCaring.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Messaging\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d45d0616408c54cf476499e076a3454424aa515", @"/Views/Messaging/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb257f04f758a2a3efb6f68ca51670d1dc01a49b", @"/Views/_ViewImports.cshtml")]
    public class Views_Messaging_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
            <td>Borrowing requeset</td>
        </tr>
    </table>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
