#pragma checksum "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916fa0aab3864724c732cda5a01014fed1ad9403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Edit), @"mvc.1.0.view", @"/Views/Books/Edit.cshtml")]
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
#line 2 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
using ShareWithMe.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916fa0aab3864724c732cda5a01014fed1ad9403", @"/Views/Books/Edit.cshtml")]
    public class Views_Books_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShareWithMe.ViewModels.Books.EditVM>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916fa0aab3864724c732cda5a01014fed1ad94033958", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "916fa0aab3864724c732cda5a01014fed1ad94034285", async() => {
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
#line 16 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916fa0aab3864724c732cda5a01014fed1ad94037008", async() => {
                WriteLiteral("\r\n    <header class=\"header2\">\r\n        <div class=\"secondmenu\">\r\n            <ul class=\"menu2\">\r\n                <li class=\"menu2\">\r\n                    <a class=\"menu2\" href=\"/Home/Index\">About us</a>\r\n                </li>\r\n");
#nullable restore
#line 25 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                 if (this.Context.Session.GetString("LoggedUserId") != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <li class=""menu2"">
                        <a class=""menu2"" href=""/Users/Index"">USERS</a>
                    </li>
                    <li class=""menu2"">
                        <a class=""menu2"" href=""/Books/Index"">BOOKS</a>
                    </li>
                    <li class=""menu2"">
                        <a class=""menu2"" href=""/Musics/Index"">Musics</a>
                    </li>
                    <li class=""menu2"">
                        <a class=""menu2"" href=""/Recipes/Index"">Recipes</a>
                    </li>
");
#nullable restore
#line 39 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"menu2\">\r\n");
#nullable restore
#line 41 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                     if (this.Context.Session.GetString("LoggedUserId") == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"menu2\" href=\"/Home/Login\">LOGIN</a>\r\n");
#nullable restore
#line 44 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"menu2\" href=\"/Home/Logout\">LOGOUT</a>\r\n");
#nullable restore
#line 48 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"zaglavie2\">\r\n            <h1>SHARE with ME</h1>\r\n        </div>\r\n    </header>\r\n    <div class=\"section\">\r\n");
#nullable restore
#line 57 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
         if (this.Context.Session.GetString("LoggedUserId") != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"rightgreeting\">Hi,");
#nullable restore
#line 59 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                       Write( this.Context.Session.GetString("LoggedUserUsername"));

#line default
#line hidden
#nullable disable
                WriteLiteral(". Glad to see you<i class=\"fa fa-heart\"></i></span>\r\n");
#nullable restore
#line 60 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"rightgreeting\">\r\n                Hello, ");
#nullable restore
#line 64 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                   Write(this.Context.Session.GetString("LoggedUserId") != null
                                 ? this.Context.Session.GetString("LoggedUserUsername")
                                 : "Stranger, lets get starting");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 68 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div class=\"section\">\r\n        <div class=\"center\">\r\n            <h1 class=\"loginnadpis\">Edit Book</h1>\r\n            <fieldset class=\"fieldsetlogin\">\r\n                <form action=\"/Books/Edit\" method=\"post\">\r\n                    ");
#nullable restore
#line 75 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
               Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 76 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
               Write(Html.HiddenFor(m => m.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"gridd\">\r\n                        <div class=\"roww\">\r\n                            <div class=\"coll-1\">ISBN:</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 80 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.TextBoxFor(m => m.ISBN));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 81 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.ValidationMessageFor(m => m.ISBN));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"roww\">\r\n                            <div class=\"coll-1\">Genre:</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 85 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.TextBoxFor(m => m.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 86 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.ValidationMessageFor(m => m.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"roww\">\r\n                            <div class=\"coll-1\">Title:</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 90 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.TextBoxFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 91 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"roww\">\r\n                            <div class=\"coll-1\">Author:</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 95 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 96 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"roww\">\r\n                            <div class=\"coll-1\">Year:</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 100 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.TextBoxFor(m => m.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"coll-2\">");
#nullable restore
#line 101 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Books\Edit.cshtml"
                                           Write(Html.ValidationMessageFor(m => m.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                        </div>
                        <div class=""roww"">
                            <div class=""coll-3"">
                                <input class=""buttcreateuser"" type=""submit"" value=""Save"" />
                                <button class=""buttcreateuser""><a class=""buttcreateusera"" href=""/Books/Index"">Back</a></button>
                            </div>
                        </div>
                    </div>
                </form>
            </fieldset>
        </div>
    </div>
    <div class=""foot2"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShareWithMe.ViewModels.Books.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
