#pragma checksum "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f646e249e08c13142a9fc03a0f0a82029df888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TransferRequest_Index), @"mvc.1.0.view", @"/Views/TransferRequest/Index.cshtml")]
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
#line 1 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
using SharingIsCaring.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
using SharingIsCaring.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f646e249e08c13142a9fc03a0f0a82029df888", @"/Views/TransferRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb257f04f758a2a3efb6f68ca51670d1dc01a49b", @"/Views/_ViewImports.cshtml")]
    public class Views_TransferRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharingIsCaring.Models.TransferRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TransferRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTransferRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1 class=""d-flex justify-content-center jumbotron"">Transfers</h1>
<br />
<h2>Pending Transfers</h2>
<div class=""d-flex justify-content-center"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Asset</th>
                <th>Expected Return Date</th>
                <th> </th>
            </tr>
        </thead>
");
#nullable restore
#line 21 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
         foreach (TransferRequest transfer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
               Write(transfer.AssetId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
               Write(transfer.ExpectedReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79f646e249e08c13142a9fc03a0f0a82029df8886282", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" name=\"ViewRequest\"");
                BeginWriteAttribute("value", " value=\"", 964, "\"", 984, 1);
#nullable restore
#line 28 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
WriteAttributeValue("", 972, transfer.Id, 972, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">View</button>\r\n                    ");
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\TransferRequest\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<br />
<br />
<h2>Completed Transfers</h2>
<div class=""d-flex justify-content-center"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Asset</th>
                <th>Date of Transfer</th>
                <th>Expected Return Date</th>
            </tr>
        </thead>
        <tr>
            <td>Example Asset</td>
            <td>Example Date of Transfer</td>
            <td>Example Expected Return Date</td>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharingIsCaring.Models.TransferRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591