#pragma checksum "C:\Workspace\NETWorkspace\ci-test-mr\WebApplication1Core\WebApplication1Core\Pages\Marjan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd5702ca65ab143bfc95af0cb629260a69b909d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1Core.Pages.Pages_Marjan), @"mvc.1.0.razor-page", @"/Pages/Marjan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Marjan.cshtml", typeof(WebApplication1Core.Pages.Pages_Marjan), null)]
namespace WebApplication1Core.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Workspace\NETWorkspace\ci-test-mr\WebApplication1Core\WebApplication1Core\Pages\_ViewImports.cshtml"
using WebApplication1Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd5702ca65ab143bfc95af0cb629260a69b909d", @"/Pages/Marjan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865c751d3240916df9dadc92134a2a8b18d04b71", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Marjan : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Workspace\NETWorkspace\ci-test-mr\WebApplication1Core\WebApplication1Core\Pages\Marjan.cshtml"
  
    ViewData["Title"] = "Marjan";

#line default
#line hidden
            BeginContext(95, 23, true);
            WriteLiteral("\r\n<h2>Marjan</h2>\r\n<h3>");
            EndContext();
            BeginContext(119, 13, false);
#line 8 "C:\Workspace\NETWorkspace\ci-test-mr\WebApplication1Core\WebApplication1Core\Pages\Marjan.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(132, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1Core.Pages.MarjanModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1Core.Pages.MarjanModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1Core.Pages.MarjanModel>)PageContext?.ViewData;
        public WebApplication1Core.Pages.MarjanModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
