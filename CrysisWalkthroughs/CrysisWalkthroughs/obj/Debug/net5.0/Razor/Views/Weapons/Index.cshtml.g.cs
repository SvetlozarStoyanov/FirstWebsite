#pragma checksum "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88996d18d416434f097373ec900d0edaac03aa05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Weapons_Index), @"mvc.1.0.view", @"/Views/Weapons/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88996d18d416434f097373ec900d0edaac03aa05", @"/Views/Weapons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff6234ac042118b754f4c875309bd66bbb2850b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Weapons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string,CrysisWalkthroughs.Models.WeaponModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("filter-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Weapons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilterIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("game-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88996d18d416434f097373ec900d0edaac03aa055274", async() => {
                WriteLiteral(@"
    <style type=""text/css"">
        body, html {
            height: 100%;
            width: 100%;
            margin: 0;
            background-image: url(""/img/Weapons/Weapons.jpg"");
            background-repeat: no-repeat;
            background-size: cover;
            background-attachment: fixed;
            margin-bottom: 60px;
            color: #777;
            position: relative;
            min-height: 100%;
            font-size: 14px;
            overflow: hidden;
        }

        .header-style {
            color: red;
        }



        .game-button:hover {
            color: gold;
        }

        .list-styling {
            color: firebrick;
            font-size: 20px;
        }

        .weapon-button-size {
            width: 160px;
        }

        .game-button {
            width: 200px;
            height: 100px;
        }

        .game-button-image {
            width: 20%;
            color: greenyellow;
            text-decora");
                WriteLiteral(@"tion: none;
            border: 2px solid green;
            outline: none;
            background: rgb(0,0,0,0.4);
        }

            .game-button-image:hover {
                color: gold;
                text-decoration: none;
                border: 2px solid gold;
            }

            .game-button-image:active {
                color: cadetblue;
                text-decoration: none;
                border: 2px solid cadetblue;
            }

        .line-break {
            flex-basis: 100%;
            height: 0;
        }

        .weapon-zone {
            display: flex;
            flex-wrap: wrap;
            position: relative;
            border: none;
            text-align: center;
            top: 100px;
            background: none;
        }

        .weapon-label {
            font-size: 20px;
            text-align: left;
        }

        .title-styling {
            margin: auto;
            position: center;
            text-align: ce");
                WriteLiteral(@"nter;
            top: 100px;
            right: 480px;
            width: 50%;
            height: auto;
            font-size: 40px;
            color: whitesmoke;
            padding: 10px;
            background: rgb(0,0,0,0.4);
        }

        .filter-link {
            position: relative;
            margin: auto;
            text-align: center;
            width: 50%;
            display: block;
            top: 50px;
            padding: 10px;
            font-size: 40px;
            border: 3px solid green;
            text-decoration: none;
            color: whitesmoke;
            background: rgb(0,0,0,0.4);
        }

            .filter-link:hover {
                color: gold;
                text-decoration: none;
                border: 3px solid gold;
            }

            .filter-link:active {
                color: cadetblue;
                text-decoration: none;
                border: 3px solid cadetblue;
            }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88996d18d416434f097373ec900d0edaac03aa059378", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 132 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
      
        string[] imageNames = { "Pistol.png", "AY69.png", "SCAR.png", "FY71.png", "Shotgun.png", "SMG.png", "Precision Rifle.png", "Gauss Rifle.png", "Minigun.png", "Alien Gun.png", "Rocket Launcher.png", "Grenade Launcher.png", "C4.png", "Claymore.png", "Mine.png", "Grenade.png", "EMP.png", "Flashbang.png", "Smoke.png", "Fists.png" };
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h1 class=\"title-styling\">Click on a weapon to see information</h1>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88996d18d416434f097373ec900d0edaac03aa0510276", async() => {
                    WriteLiteral("\r\n        <div>\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88996d18d416434f097373ec900d0edaac03aa0510572", async() => {
                        WriteLiteral("Filter by attachment");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"weapon-zone\">\r\n");
#nullable restore
#line 143 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
              
                int i = 0;
                string name = string.Empty;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
             foreach (var weapon in Model)
            {
                name = weapon.Key;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
                 if (i % 5 == 0)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"line-break\"></div>\r\n");
#nullable restore
#line 153 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <a class=\"game-button-image\"");
                    BeginWriteAttribute("href", " href=\"", 4179, "\"", 4237, 1);
#nullable restore
#line 155 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
WriteAttributeValue("", 4186, Url.Action("ShowWeaponStats","Weapons",new {name}), 4186, 51, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"submit\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88996d18d416434f097373ec900d0edaac03aa0513853", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 4305, "~/img/Weapons/", 4305, 14, true);
#nullable restore
#line 156 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
AddHtmlAttributeValue("", 4319, imageNames[i++], 4319, 16, false);

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
                    WriteLiteral("\r\n                    <div class=\"weapon-label\">\r\n                        ");
#nullable restore
#line 158 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"
                   Write(weapon.Key);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 161 "D:\Git Repositories\CrysisWalkthroughs\CrysisWalkthroughs\Views\Weapons\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        </div>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string,CrysisWalkthroughs.Models.WeaponModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
