#pragma checksum "E:\KutatasModszertan\Kutatas_core\Kutatas_core\Views\Registration\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5682d01ad3e5751745561cf6fffcdf1415a7c0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_index), @"mvc.1.0.view", @"/Views/Registration/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/index.cshtml", typeof(AspNetCore.Views_Registration_index))]
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
#line 1 "E:\KutatasModszertan\Kutatas_core\Kutatas_core\Views\_ViewImports.cshtml"
using Kutatas_core;

#line default
#line hidden
#line 2 "E:\KutatasModszertan\Kutatas_core\Kutatas_core\Views\_ViewImports.cshtml"
using Kutatas_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5682d01ad3e5751745561cf6fffcdf1415a7c0a3", @"/Views/Registration/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82134c01113e2fb2df6510fcfc5fb3e5f06ac637", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/login/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_user_registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\KutatasModszertan\Kutatas_core\Kutatas_core\Views\Registration\index.cshtml"
  
    ViewData["Title"] = "Registration Page";

#line default
#line hidden
            BeginContext(53, 115, true);
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"></script>\r\n\r\n<div id=\"navigation\">\r\n");
            EndContext();
#line 7 "E:\KutatasModszertan\Kutatas_core\Kutatas_core\Views\Registration\index.cshtml"
       Html.RenderPartial("~/Views/Shared/Navigation.cshtml"); 

#line default
#line hidden
            BeginContext(234, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(244, 3698, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8b028dc352486cb6e9c5224289daba", async() => {
                BeginContext(250, 312, true);
                WriteLiteral(@"
    <main class=""container"">

        <section class=""registration-container"">

            <!--    Még szerencse, hogy a button nem submit, különben a regisztrációs form loginolni akarna...
            Ezt javítsd ki, a login-nál ott van a helyes példa (JS sem kell, felesleges)         -->
            ");
                EndContext();
                BeginContext(562, 3317, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c8aa03f11e24968a5abe67afc870a69", async() => {
                    BeginContext(660, 3212, true);
                    WriteLiteral(@"
                <label>
                    <h1>Regisztráció </h1>
                </label>
                <div class=""form-registration"">
                    <div>
                        <!-- Mi ez a validationServer? -->
                        <label for=""email"">Email</label>
                        <input type=""email"" name=""email"" class=""form-control is-valid"" id=""email"" placeholder=""email@email.com"" required>
                    </div>



                    <div>
                        <label for=""password"">Password</label>
                        <input type=""password"" name=""password"" class=""form-control is-valid"" id=""password"" placeholder=""password"" pattern=""(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}"" title=""Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters"" required>
                    </div>
                    <span id='message'></span>
                    <div  id=""messages"">
                        <h4 >Password must contai");
                    WriteLiteral(@"n the following:</h4>
                        <p id=""letter""  class=""invalid"">A <b>lowercase</b> letter</p>
                        <p id=""capital"" class=""invalid"">A <b>capital (uppercase)</b> letter</p>
                        <p id=""number"" class=""invalid"">A <b>number</b></p>
                        <p id=""length"" class=""invalid"">Minimum <b>6 characters</b></p>
                        <p id=""special"" class=""invalid"">A <b>speciális karakter(.-_?!)</b></p>
                    </div>
                    <div>
                        <label for=""psw"">Confirm Password</label>
                        <input type=""password"" name=""new-password"" class=""form-control is-valid"" id=""password2"" placeholder=""password"" required>

                    </div>

                    <div>
                        <label for=""firstname"">First Name</label>
                        <input type=""text"" class=""form-control is-valid"" id=""first_name"" placeholder=""First Name"" required>
                    </div>

        ");
                    WriteLiteral(@"            <div>
                        <label for=""lastname"">Last Name</label>
                        <input type=""text"" class=""form-control is-valid"" id=""last_name"" placeholder=""Last Name"" required>
                    </div>
                    <div>
                        <label for=""city"">City</label>
                        <input type=""text"" class=""form-control is-valid"" id=""city"" placeholder=""City"" required>
                    </div>
                    <div>
                        <label for=""phonenumber"">Phone number</label>
                        <input type=""number"" class=""form-control is-valid"" id=""phone"" placeholder=""example:+36201112242"" required>
                    </div>
                    <div>
                        <label for=""address"">Address</label>
                        <input type=""text"" class=""form-control is-valid"" id=""address"" placeholder=""Cool str."" required>
                    </div>


                </div>
                <div class=""form-button"">");
                    WriteLiteral("\r\n                    <button class=\"btn\" id=\"insertBtn\" onclick=\"InsertUser()\" >Registration</button>\r\n                </div>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3879, 56, true);
                WriteLiteral("\r\n           \r\n\r\n        </section>\r\n\r\n\r\n\r\n    </main>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3942, 5333, true);
            WriteLiteral(@"
<script>
    var passMatch = false;
    $('#password, #password2').on('keyup', function () {
        if ($('#password').val() == $('#password2').val() && $('#password').val() !=null) {
            $('#message').html('Matching').css('color', 'green');
            $('#message').html('Matching').css('font-size', '16px');
            $('#password').html('').css('background-color', 'lightgreen');
            passMatch = true;
        } else
            $('#message').html('Not Matching').css('color', 'red');
        passMath = false;

    });

    

    //password validation 

    var myInput = document.getElementById(""password"");
    var letter = document.getElementById(""letter"");
    var capital = document.getElementById(""capital"");
    var number = document.getElementById(""number"");
    var length = document.getElementById(""length"");
    var special = document.getElementById(""special"");
    document.getElementById(""messages"").style.display = ""none"";
    

    // When the user clicks ");
            WriteLiteral(@"on the password field, show the message box
    myInput.onfocus = function () {
        document.getElementById(""messages"").style.display = ""block"";
        document.getElementById(""messages"").style.backgroundColor = ""lightgray"";
        document.getElementById(""messages"").style.opacity = 0.5;
       
    }
    // When the user clicks outside of the password field, hide the message box
    myInput.onblur = function () {
        document.getElementById(""messages"").style.display = ""none"";
    }

    ;
    // When the user starts to type something inside the password field
    myInput.onkeyup = function () {
        
        // Validate lowercase letters
        var islower = false;
        var lowerCaseLetters = /[a-z]/g;
        if (myInput.value.match(lowerCaseLetters)) {
            letter.classList.remove(""invalid"");
            letter.classList.add(""valid"");
            islower = true;
        } else {
            letter.classList.remove(""valid"");
            letter.classList.add(""");
            WriteLiteral(@"invalid"");
            islower = false;
        }
        
        //Validate special char
        var isSpec = false;
        var spec = /[.\\-\\_\\?\\!]/g;
        if (myInput.value.match(spec)) {
            special.classList.remove(""invalid"");
            special.classList.add(""valid"");
            isSpec = true;
        } else {
            special.classList.remove(""valid"");
            special.classList.add(""invalid"");
            isSpec = false;
        }


        // Validate capital letters
        var isUpper = false;
        var upperCaseLetters = /[A-Z]/g;
        if (myInput.value.match(upperCaseLetters)) {
            capital.classList.remove(""invalid"");
            capital.classList.add(""valid"");
            isUpper = true;
        } else {
            capital.classList.remove(""valid"");
            capital.classList.add(""invalid"");
            isUpper = false;
        }

        // Validate numbers
        var isNum = false;
        var numbers = /[0-9]/g;
    ");
            WriteLiteral(@"    if (myInput.value.match(numbers)) {
            number.classList.remove(""invalid"");
            number.classList.add(""valid"");
            isNum = true;
        } else {
            number.classList.remove(""valid"");
            number.classList.add(""invalid"");
            isNum = false;
        }

        // Validate length
        var isLength = false;
        if (myInput.value.length >= 6) {
            length.classList.remove(""invalid"");
            length.classList.add(""valid"");
            isLength = true;
        } else {
            length.classList.remove(""valid"");
            length.classList.add(""invalid"");
            isLength = false;
        }
        console.log(isLength, islower, isNum, isSpec, isUpper);
        
       
    }
    
    

    /*user: email/ password/firstname / lastname/ city/ phone number/ address */

    var currentEmail;


    function returnData(param) {
        currentEmail = param.Email;
        //console.log(currentEmail);
    }

");
            WriteLiteral(@"    function SelectUser(email, callback) {
        $.post('/User/SelectUser', { email: email }, function (data) {
            callback(data);
        });
    }

    function InsertUser() {
        //SelectUser($('#email').val(), returnData);
        //if (currentEmail != null || currentEmail != """") {
        //    alert(""This email is already used for another user!"");
        //}
        //else {
        $.post('/User/RegisterUser', {
                firstName: document.getElementById(""first_name"").value,
                lastName: document.getElementById(""last_name"").value,
                email: document.getElementById(""email"").value,
                phoneNumber: document.getElementById(""phone"").value,
                password: document.getElementById(""password"").value,
                city: document.getElementById(""city"").value,
                address: document.getElementById(""address"").value
            },
                function (data) {
                    if (data.Succeed) {
   ");
            WriteLiteral("                     window.location.reload();\r\n                        window.localStorage.setItem(\'token\', data.token);\r\n                    }\r\n                }, \'json\');\r\n        //}\r\n\r\n    }\r\n\r\n   \r\n</script>");
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
