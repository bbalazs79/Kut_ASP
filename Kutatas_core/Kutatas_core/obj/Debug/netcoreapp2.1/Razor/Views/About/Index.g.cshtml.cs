#pragma checksum "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd39f6fed86d6158743cf0c95ab2f92d2548b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 1 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\_ViewImports.cshtml"
using Kutatas_core;

#line default
#line hidden
#line 2 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\_ViewImports.cshtml"
using Kutatas_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd39f6fed86d6158743cf0c95ab2f92d2548b3b", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82134c01113e2fb2df6510fcfc5fb3e5f06ac637", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aboutbody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\About\Index.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 25, true);
            WriteLiteral("\r\n<div id=\"navigation\">\r\n");
            EndContext();
#line 6 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\About\Index.cshtml"
       Html.RenderPartial("~/Views/Shared/Navigation.cshtml"); 

#line default
#line hidden
            BeginContext(132, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(142, 1978, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af8621f7cf2d44f69a42c0ff18154f88", async() => {
                BeginContext(166, 1947, true);
                WriteLiteral(@"
    <section class=""about"">

        <article class=""titleabout"">
            <h1>About</h1>
            <hr />
        </article>
        <article>
            <p>The Pizza Restaurant was founded in blabla by Mr. Italiano in lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>

            <article class=""textcontainer"">
                <div>
                    <p>The Chef? Mr. Italiano himselfChef</p>
                    <p> We are proud of our interiors.</p>
                </div>

                <figure>
                    <img src=""https://www.w3schools.com/w3images/chef.jpg"">
                </figure>

            </article>

            <figure class=""img_3"">
                <img src=""https://www.w3schools.com/w3images/onepage_restaurant.jpg"" alt=""kep"">
            </figure>

        </article");
                WriteLiteral(@">
        <section>
            <div class=""nyitvatartascontainer"">
                <article>
                    <h1>Opening Hours</h1>
                </article>
                <div class=""nyitvatartas"">
                    <div>
                        <ul>
                            <li><p>Mon & Tue CLOSED</p></li>
                            <li><p>Wednesday 10.00 - 24.00</p></li>
                            <li><p>Thursday 10:00 - 24:00</p></li>
                        </ul>
                    </div>
                    <div>
                        <ul>
                            <li><p>Friday 10:00 - 12:00</p></li>
                            <li><p>Saturday 10:00 - 23:00</p> </li>
                            <li><p>Sunday Closed</p></li>
                        </ul>
                    </div>
                </div>
            </div>

        </section>
    </section>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
