#pragma checksum "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\Television\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0674fbe70b27e40fe0d0d48cabf0f35427dc883"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Television_Details), @"mvc.1.0.view", @"/Views/Television/Details.cshtml")]
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
#line 1 "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\_ViewImports.cshtml"
using MilenWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\_ViewImports.cshtml"
using MilenWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0674fbe70b27e40fe0d0d48cabf0f35427dc883", @"/Views/Television/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59d2ee3d25ceb0c83d4229496c8971c50c5736d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Television_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\Television\Details.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Televizor</h1>\r\n\r\n<div class=\"col-md-4\">\r\n\t<div class=\"row\">\r\n\t\t<h1>");
#nullable restore
#line 10 "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\Television\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 169, "\"", 187, 1);
#nullable restore
#line 13 "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\Television\Details.cshtml"
WriteAttributeValue("", 175, Model.Image, 175, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"800\" height=\"400\" />\r\n\t</div>\r\n\t");
#nullable restore
#line 15 "C:\Users\N1\source\repos\MilenWebSite\MilenWebSite\Views\Television\Details.cshtml"
Write(Html.ActionLink("All tvs", "Index", "Television"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n");
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
