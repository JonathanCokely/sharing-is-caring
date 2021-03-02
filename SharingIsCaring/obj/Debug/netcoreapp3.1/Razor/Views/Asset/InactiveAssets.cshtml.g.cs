#pragma checksum "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dca0f608fad2f75d1457350f9184eabb2107e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asset_InactiveAssets), @"mvc.1.0.view", @"/Views/Asset/InactiveAssets.cshtml")]
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
#line 1 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
using SharingIsCaring.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
using SharingIsCaring.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dca0f608fad2f75d1457350f9184eabb2107e57", @"/Views/Asset/InactiveAssets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb257f04f758a2a3efb6f68ca51670d1dc01a49b", @"/Views/_ViewImports.cshtml")]
    public class Views_Asset_InactiveAssets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharingIsCaring.Models.Asset>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Asset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivateAsset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
  
    List<Asset> assetList = Model.Where(x => x.ActiveInd == false).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"d-flex justify-content-center jumbotron\">Inactive Assets</h1>\r\n");
#nullable restore
#line 13 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
 if (assetList.Where(x => x.OwnerId == UserManager.GetUserId(User)).Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container text-center\">\r\n        <h2>No inactive assets!</h2>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <table class=""table"">
            <tr>
                <th>Brand Name</th>
                <th>Asset Description</th>
                <th>Asset Type</th>
                <th>Serial Number</th>
                <th> </th>
            </tr>

");
#nullable restore
#line 32 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
             foreach (Asset asset in assetList.Where(x => x.OwnerId == UserManager.GetUserId(User)))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
                   Write(asset.BrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
                   Write(asset.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
                   Write(asset.ItemTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
                   Write(asset.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dca0f608fad2f75d1457350f9184eabb2107e577813", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-success\" type=\"submit\" name=\"AssetId\"");
                BeginWriteAttribute("value", " value=\"", 1399, "\"", 1416, 1);
#nullable restore
#line 41 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
WriteAttributeValue("", 1407, asset.Id, 1407, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Activate Asset</button>\r\n                        ");
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Users\JC032926\Source\Repos\sharing-is-caring\SharingIsCaring\Views\Asset\InactiveAssets.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharingIsCaring.Models.Asset>> Html { get; private set; }
    }
}
#pragma warning restore 1591
