#pragma checksum "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba869e9d8c043ca12d1d9ae29b6642bbd35dfa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eba869e9d8c043ca12d1d9ae29b6642bbd35dfa9", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eba869e9d8c043ca12d1d9ae29b6642bbd35dfa93776", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eba869e9d8c043ca12d1d9ae29b6642bbd35dfa94103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css?family=Emilys+Candy&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Alfa+Slab+One&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Aldrich&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
                WriteLiteral("    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n    <title>");
#nullable restore
#line 15 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eba869e9d8c043ca12d1d9ae29b6642bbd35dfa96830", async() => {
                WriteLiteral("\r\n\r\n        <div class=\"firstmenu\">\r\n            <ul class=\"menu1\">\r\n                <li class=\"menu1\">\r\n                    <a class=\"menu1\" href=\"/Home/Index\">About us</a>\r\n                </li>\r\n");
#nullable restore
#line 24 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                 if (this.Context.Session.GetString("LoggedUserId") != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <li class=""menu1"">
                        <a class=""menu1"" href=""/Users/Index"">USERS</a>
                    </li>
                    <li class=""menu1"">
                        <a class=""menu1"" href=""/Books/Index"">BOOKS</a>
                    </li>
                    <li class=""menu1"">
                        <a class=""menu1"" href=""/Musics/Index"">Musics</a>
                    </li>
                    <li class=""menu1"">
                        <a class=""menu1"" href=""/Recipes/Index"">Recipes</a>
                    </li>
");
#nullable restore
#line 38 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"menu1\">\r\n");
#nullable restore
#line 40 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                     if (this.Context.Session.GetString("LoggedUserId") == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"menu1\" href=\"/Home/Login\">LOGIN</a>\r\n");
#nullable restore
#line 43 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"menu1\" href=\"/Home/Logout\">LOGOUT</a>\r\n");
#nullable restore
#line 47 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"zaglavie\">\r\n            <h1>SHARE with ME</h1>\r\n        </div>\r\n  \r\n\r\n    <div class=\"section\">\r\n");
#nullable restore
#line 58 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
         if (this.Context.Session.GetString("LoggedUserId") != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"rightgreeting\">Hi, ");
#nullable restore
#line 60 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                                        Write( this.Context.Session.GetString("LoggedUserUsername"));

#line default
#line hidden
#nullable disable
                WriteLiteral(". Glad to see you<i class=\"fa fa-heart\"></i></span>\r\n");
#nullable restore
#line 61 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"rightgreeting\">\r\n                Hello, ");
#nullable restore
#line 65 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
                   Write(this.Context.Session.GetString("LoggedUserId") != null
                                 ? this.Context.Session.GetString("LoggedUserUsername")
                                 : "Stranger, lets get starting");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 69 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n<div class=\"section\">\r\n   ");
#nullable restore
#line 73 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
</div>

    <div class=""foot"">
        <footer>
            <a href=""#"" class=""fa fa-instagram""></a>
            <a href=""#"" class=""fa fa-twitter""></a>
            <a href=""#"" class=""fa fa-google""></a>
            <div><p>SHAREwithME &copy;All Rights Reserved!</p></div>
        </footer>
    </div>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
