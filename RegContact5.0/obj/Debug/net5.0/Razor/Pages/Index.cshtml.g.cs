#pragma checksum "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8ef7cf2767e8612e5dbc4969d19222a7471380b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RegContact5._0.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RegContact5._0.Pages
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
#line 1 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/_ViewImports.cshtml"
using RegContact5._0;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ef7cf2767e8612e5dbc4969d19222a7471380b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c0a176bc19d785095562fc0a5a4bce4e0797f8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n\n");
#nullable restore
#line 12 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
 foreach (var company in Model.Companies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>\n        ");
#nullable restore
#line 15 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
   Write(company.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 16 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
   Write(company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 17 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
   Write(company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h4>\n");
#nullable restore
#line 19 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 21 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
 foreach (var contact in Model.Contacts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>\n    ");
#nullable restore
#line 24 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
Write(contact.CompanyId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 25 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
Write(contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 26 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
Write(contact.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 27 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
Write(contact.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</h4>\n");
#nullable restore
#line 30 "/Users/josefinlundquist/Projects/RegContact5.0/RegContact5.0/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
