#pragma checksum "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Attachment\ShowAttachment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd4bb4d3beb0f4d14de63c6df63f89bfa0cf22d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attachment_ShowAttachment), @"mvc.1.0.view", @"/Views/Attachment/ShowAttachment.cshtml")]
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
#line 1 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\_ViewImports.cshtml"
using CrysisWalkthroughs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\_ViewImports.cshtml"
using CrysisWalkthroughs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd4bb4d3beb0f4d14de63c6df63f89bfa0cf22d", @"/Views/Attachment/ShowAttachment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff6234ac042118b754f4c875309bd66bbb2850b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Attachment_ShowAttachment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrysisWalkthroughs.Models.AttachmentModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image-styling"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    body, html {
        height: 100%;
        width: 100%;
        margin: 0;
        background-image: url(""/img/Weapons/View Weapon Background.jpg"");
        background-repeat: no-repeat;
        background-size: cover;
        background-attachment: fixed;
        margin-bottom: 60px;
        color: #777;
        position: relative;
        min-height: 100%;
        font-size: 14px;
        overflow: visible;
    }

    .paragraph-styling {
        position: relative;
        margin: auto;
        display: block;
        top: 200px;
        font-size: 33px;
        color: white;
        border:3px solid green;
        padding:10px;
        background: rgb(0,0,0,0.4);
    }

    .link-styling {
        margin: auto;
        position: absolute;
        text-align: center;
        text-decoration: none;
        border: 3px solid green;
        top: 80px;
        right: 750px;
        width: 20%;
        height: auto;
        font-size: 50px;
        color: wh");
            WriteLiteral(@"itesmoke;
        padding: 10px;
        background: rgb(0,0,0,0.4);
        background-clip: border-box;
    }

        .link-styling:hover {
            color: gold;
            text-decoration: none;
            border: 3px solid gold;
        }

        .link-styling:active {
            color: cadetblue;
            text-decoration: none;
            border: 3px solid cadetblue;
        }

    .line-break {
        flex-basis: 100%;
        height: 0;
    }

    .image-styling {
        width: 500px;
        margin: auto;
        display: block;
        height: 300px;
        border: 3px solid green;
        background: rgb(0,0,0,0.4);
        padding: 10px;
    }

    .image-background {
        top: 250px;
        position: center;
        position: relative;
    }

    .image-background {
        position: center;
    }
</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdd4bb4d3beb0f4d14de63c6df63f89bfa0cf22d5714", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 89 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Attachment\ShowAttachment.cshtml"
      
        string[] imageNames = { "Silencer.png", "Flashlight.png", "Laser Pointer.png", "Incendiary Ammo.png", "EMP Grenade.png", "Under Barrel Grenade Launcher.png", "Tactical Attachment.png", "Reflex Sight.png", "Assault Scope.png", "Sniper Scope.png" };
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"paragraph-styling\">\r\n        ");
#nullable restore
#line 93 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Attachment\ShowAttachment.cshtml"
   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <a class=\"link-styling\" href=\"javascript:javascript:history.go(-1)\">Back to Weapon</a>\r\n    </div>\r\n    <div class=\"image-background\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdd4bb4d3beb0f4d14de63c6df63f89bfa0cf22d6969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2548, "~/img/Attachments/", 2548, 18, true);
#nullable restore
#line 99 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Attachment\ShowAttachment.cshtml"
AddHtmlAttributeValue("", 2566, imageNames[Model.Id], 2566, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrysisWalkthroughs.Models.AttachmentModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
