#pragma checksum "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23822c3b2c4d18ee969e0aca91efc16ca66106d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23822c3b2c4d18ee969e0aca91efc16ca66106d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82134c01113e2fb2df6510fcfc5fb3e5f06ac637", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Kutatas_core.Models.Food>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 1 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
   
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(85, 25, true);
            WriteLiteral("\r\n<div id=\"navigation\">\r\n");
            EndContext();
#line 7 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
       Html.RenderPartial("~/Views/Shared/Navigation.cshtml"); 

#line default
#line hidden
            BeginContext(176, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(186, 936, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e33c85518a0449eb566ff086fb935f7", async() => {
                BeginContext(210, 195, true);
                WriteLiteral("\r\n\r\n    <main class=\"cart\">\r\n        <ul>\r\n            <li class=\"listhead\">\r\n\r\n                <h2>Étel</h2>\r\n                <h2>Ár</h2>\r\n                <h2>Kosár</h2>\r\n\r\n            </li>\r\n\r\n");
                EndContext();
#line 22 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(462, 103, true);
                WriteLiteral("                <li class=\"foodelements\">\r\n                    <div>\r\n                        <div><h2>");
                EndContext();
                BeginContext(566, 39, false);
#line 26 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(605, 225, true);
                WriteLiteral("</h2></div>\r\n                        <div>\r\n                            <p>allergének fdddddddddddddddddddddddddddddddddddddd</p>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div><h2> ");
                EndContext();
                BeginContext(831, 40, false);
#line 33 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
                         Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(871, 90, true);
                WriteLiteral(" Ft</h2> </div>\r\n\r\n                    <div class=\"cart\" onclick=\"addItem(this)\" data-id=\"");
                EndContext();
                BeginContext(962, 7, false);
#line 35 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
                                                                  Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(969, 70, true);
                WriteLiteral("\"><i class=\"fas fa-shopping-cart\"> </i></div>\r\n                </li>\r\n");
                EndContext();
#line 37 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1054, 61, true);
                WriteLiteral("        </ul>\r\n        <div class=\"sum\"></div>\r\n    </main>\r\n");
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
            BeginContext(1122, 1711, true);
            WriteLiteral(@"
<script>



    var cartContent = JSON.parse(sessionStorage.getItem('cart'));
    var adatb = [];
    if (cartContent == null) {
        var cartContent = [];
    }


    var name;
    var price;
    var count=1;
   
    var Item = function (id, name, price, count) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.count = count;
    }
    function addItemToCart(id, name, price, count) {
        for (var i in cartContent) {
            if (cartContent[i].name === name) {
                cartContent[i].count++;
                return;
            }
        }
        var item = new Item(id, name, price, count);

        cartContent.push(item);
        
    }
    function addItem(item) {
        var id = item.dataset.id;
        for (var i = 0; i < adatb.length; i++) {
            if (id == adatb[i].id) {
                addItemToCart(adatb[i].id, adatb[i].name, adatb[i].price, Number(count));
                sessionStorage.setItem('");
            WriteLiteral(@"cart', JSON.stringify(cartContent));
                /*szum*/ //document.querySelector('.sum').innerHTML = `<i class=""fas fa-shopping-cart""> </i> $ ${cartTotal()}`;
            }

        }
    }




    function cartTotal() {
        var sum = 0;
        for (var index = 0; index < adatb.length; index++) {
            for (var j = 0; j < cartContent.length; j++) {
                if (cartContent[j].id == adatb[index].id) {  
                    sum += adatb[index].price * cartContent[j].count;
                }
            }
        }
       // console.log(sessionStorage.getItem(cart));
        
        return sum;
    }


    var adatb;
 
</script>
");
            EndContext();
#line 108 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
 foreach (var item in Model)
{



#line default
#line hidden
            BeginContext(2870, 65, true);
            WriteLiteral("    <script>\r\n\r\n        var items = [];\r\n\r\n        items = { id: ");
            EndContext();
            BeginContext(2936, 7, false);
#line 116 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
                 Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2943, 8, true);
            WriteLiteral(", name:\'");
            EndContext();
            BeginContext(2952, 9, false);
#line 116 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2961, 10, true);
            WriteLiteral("\', price: ");
            EndContext();
            BeginContext(2972, 10, false);
#line 116 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2982, 178, true);
            WriteLiteral(" };\r\n     \r\nif (adatb == null) {\r\n    var adatb = [];\r\n    }\r\n        \r\n        adatb.push(items);\r\n        //sessionStorage.setItem(cartContent,adatb);\r\n       \r\n    </script>\r\n");
            EndContext();
#line 126 "E:\KutatasModszertan\Kut_ASP\Kutatas_core\Kutatas_core\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Kutatas_core.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
