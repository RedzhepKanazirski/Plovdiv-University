#pragma checksum "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89361656779929c8948d40a3769f124c15e307d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Index), @"mvc.1.0.view", @"/Views/Recipes/Index.cshtml")]
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
#line 2 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
using ShareWithMe.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89361656779929c8948d40a3769f124c15e307d6", @"/Views/Recipes/Index.cshtml")]
    public class Views_Recipes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShareWithMe.ViewModels.Recipes.IndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("recipegif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/recipess.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89361656779929c8948d40a3769f124c15e307d64695", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89361656779929c8948d40a3769f124c15e307d65022", async() => {
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
#line 17 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89361656779929c8948d40a3769f124c15e307d67748", async() => {
                WriteLiteral("\r\n    <header class=\"header4\">\r\n        <div class=\"fourthmenu\">\r\n            <ul class=\"menu4\">\r\n                <li class=\"menu4\">\r\n                    <a class=\"menu4\" href=\"/Home/Index\">About us</a>\r\n                </li>\r\n");
#nullable restore
#line 26 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                 if (this.Context.Session.GetString("LoggedUserId") != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <li class=""menu4"">
                        <a class=""menu4"" href=""/Users/Index"">USERS</a>
                    </li>
                    <li class=""menu4"">
                        <a class=""menu4"" href=""/Books/Index"">BOOKS</a>
                    </li>
                    <li class=""menu4"">
                        <a class=""menu4"" href=""/Musics/Index"">Musics</a>
                    </li>
                    <li class=""menu4"">
                        <a class=""menu4"" href=""/Recipes/Index"">Recipes</a>
                    </li>
");
#nullable restore
#line 40 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"menu4\">\r\n");
#nullable restore
#line 42 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                     if (this.Context.Session.GetString("LoggedUserId") == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"menu4\" href=\"/Home/Login\">LOGIN</a>\r\n");
#nullable restore
#line 45 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"menu4\" href=\"/Home/Logout\">LOGOUT</a>\r\n");
#nullable restore
#line 49 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"zaglavie4\">\r\n            <h1>SHARE with ME</h1>\r\n        </div>\r\n    </header>\r\n    <div class=\"section\">\r\n");
#nullable restore
#line 58 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
         if (this.Context.Session.GetString("LoggedUserId") != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"rightgreeting\">Hi, ");
#nullable restore
#line 60 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                                        Write( this.Context.Session.GetString("LoggedUserUsername"));

#line default
#line hidden
#nullable disable
                WriteLiteral(". Glad to see you<i class=\"fa fa-heart\"></i></span>\r\n");
#nullable restore
#line 61 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"rightgreeting\">\r\n                Hello, ");
#nullable restore
#line 65 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(this.Context.Session.GetString("LoggedUserId") != null
                                 ? this.Context.Session.GetString("LoggedUserUsername")
                                 : "Stranger, lets get starting");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 69 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
                WriteLiteral("<div class=\"section\">\r\n    <button class=\"newbuttrecipe\"> <a class=\"newabuttrecipe\" href=\"/Recipes/Create\">ADD RECIPE</a></button> \r\n    <div class=\"grid\">\r\n        <div class=\"row\">\r\n        </div>\r\n");
#nullable restore
#line 77 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
         foreach (Recipe item in Model.Items)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row4\">\r\n                <div class=\"col-24\">\r\n                    <div class=\"padd\">\r\n                        <br />\r\n                        ");
#nullable restore
#line 83 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.one);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <br />\r\n                        INGRADIENTS: <br />\r\n                        <br />\r\n                        ");
#nullable restore
#line 87 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.two);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 88 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.three);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 89 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.four);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 90 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.five);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 91 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.six);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 92 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.seven);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 93 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.eight);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 94 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.nine);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        ");
#nullable restore
#line 95 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
                   Write(item.ten);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        <button class=\"edelmusic\"><a class=\"edelamusic\"");
                BeginWriteAttribute("href", " href=\"", 4028, "\"", 4061, 2);
                WriteAttributeValue("", 4035, "/Recipes/Share?id=", 4035, 18, true);
#nullable restore
#line 96 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
WriteAttributeValue("", 4053, item.Id, 4053, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">share</a></button>\r\n                        <button class=\"edelmusic\"><a class=\"edelamusic\"");
                BeginWriteAttribute("href", " href=\"", 4154, "\"", 4186, 2);
                WriteAttributeValue("", 4161, "/Recipes/Edit?id=", 4161, 17, true);
#nullable restore
#line 97 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
WriteAttributeValue("", 4178, item.Id, 4178, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">edit</a></button>\r\n                        <button class=\"edelmusic\"><a class=\"edelamusic\"");
                BeginWriteAttribute("href", " href=\"", 4278, "\"", 4312, 2);
                WriteAttributeValue("", 4285, "/Recipes/Delete?id=", 4285, 19, true);
#nullable restore
#line 98 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
WriteAttributeValue("", 4304, item.Id, 4304, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">delete</a></button>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-2\">\r\n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89361656779929c8948d40a3769f124c15e307d617380", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n            </div>\r\n");
#nullable restore
#line 107 "C:\Users\Kanazirski\Desktop\projectt\SampleLogin\Views\Recipes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n");
                WriteLiteral(@"    <div class=""foot4"">
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShareWithMe.ViewModels.Recipes.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
