#pragma checksum "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c14b61b5aa55231a0f2cdc3980e2a3a1840d60bc"
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
#line 1 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\_ViewImports.cshtml"
using listeYapma;

#line default
#line hidden
#line 2 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\_ViewImports.cshtml"
using listeYapma.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c14b61b5aa55231a0f2cdc3980e2a3a1840d60bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672d413910690854085e2d6e6d3fd1fd110f6e0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\Home\Index.cshtml"
 foreach (personel eleman in Model.OrderBy(a=>a.Ad))
{

#line default
#line hidden
            BeginContext(80, 90, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"col-sm-4\">");
            EndContext();
            BeginContext(171, 9, false);
#line 6 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\Home\Index.cshtml"
                             Write(eleman.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(180, 42, true);
            WriteLiteral("</div>\r\n            <div class=\"col-sm-4\">");
            EndContext();
            BeginContext(223, 16, false);
#line 7 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\Home\Index.cshtml"
                             Write(eleman.Departman);

#line default
#line hidden
            EndContext();
            BeginContext(239, 42, true);
            WriteLiteral("</div>\r\n            <div class=\"col-sm-4\">");
            EndContext();
            BeginContext(282, 11, false);
#line 8 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\Home\Index.cshtml"
                             Write(eleman.Maas);

#line default
#line hidden
            EndContext();
            BeginContext(293, 36, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 11 "C:\Users\BT OGRETMEN\source\repos\listeYapma\listeYapma\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
