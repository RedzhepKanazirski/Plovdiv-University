#pragma checksum "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d36c6b2b2d6af6b6842b55d9373f6637708d1ac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d36c6b2b2d6af6b6842b55d9373f6637708d1ac4", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShareWithMe.ViewModels.Home.LoginVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""center"">
    <h1 class=""loginnadpis"">LOGIN</h1>
    <fieldset class=""fieldsetlogin"">
        <form action=""/Home/Login"" method=""post"">
            <div class=""gridd"">
                <div class=""roww"">
                    <div class=""coll-1"">Username:</div>
                    <div class=""coll-2"">");
#nullable restore
#line 13 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml"
                                   Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"coll-2\">");
#nullable restore
#line 14 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"roww\">\r\n                    <div class=\"coll-1\">Password:</div>\r\n                    <div class=\"coll-2\">");
#nullable restore
#line 18 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml"
                                   Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"coll-2\">");
#nullable restore
#line 19 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"roww\">\r\n                    <div class=\"coll-3\">");
#nullable restore
#line 22 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Home\Login.cshtml"
                                   Write(Html.ValidationMessage("AuthenticationFailed"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""roww"">
                    <div class=""coll-3""><input class=""butt"" type=""submit"" value=""Login"" /></div>
                    <div class=""coll-3""><input class=""butt2"" type=""button"" value=""Register"" /></div>

                </div>
            </div>
        </form>
    </fieldset>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShareWithMe.ViewModels.Home.LoginVM> Html { get; private set; }
    }
}
#pragma warning restore 1591