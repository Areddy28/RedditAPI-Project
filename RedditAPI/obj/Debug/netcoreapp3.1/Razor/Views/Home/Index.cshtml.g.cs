#pragma checksum "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd47706862fd43753e459ef18af6c40ef1861fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\_ViewImports.cshtml"
using RedditAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\_ViewImports.cshtml"
using RedditAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd47706862fd43753e459ef18af6c40ef1861fa3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8c153611c5c312ac703ab431f8b337d65c5c4dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Child>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"
 foreach(Child c in Model) 
{




#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 63, "\"", 110, 2);
            WriteAttributeValue("", 70, "https://www.reddit.com/", 70, 23, true);
#nullable restore
#line 8 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 93, c.data.permalink, 93, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<h2>");
#nullable restore
#line 9 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"
Write(c.data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 144, "\"", 167, 1);
#nullable restore
#line 11 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 150, c.data.thumbnail, 150, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <p>Up Votes: ");
#nullable restore
#line 12 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"
            Write(c.data.ups);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Down Votes: ");
#nullable restore
#line 13 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"
              Write(c.data.downs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</a>\r\n");
#nullable restore
#line 15 "C:\Users\areddy1\source\repos\RedditAPI\RedditAPI\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Child>> Html { get; private set; }
    }
}
#pragma warning restore 1591
