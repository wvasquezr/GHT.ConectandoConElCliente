#pragma checksum "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fbdb96648afdb9ed682383956aa89638106fe51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ALIADO.GHT.Conectando.WebSite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ALIADO.GHT.Conectando.WebSite.Pages
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
#line 1 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Pages\_ViewImports.cshtml"
using ALIADO.GHT.Conectando.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Pages\Index.cshtml"
using ALIADO.GHT.Conectando.WebSite.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fbdb96648afdb9ed682383956aa89638106fe51", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd98b666c226da3a828721b3db86249b3d2665e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"text-light\">Conectando con el Cliente</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\J\Google Drive\4. DEV\20210405_GHT_Conectand_Cliente\ALIADO.GHT.Conectando\ALIADO.GHT.Conectando.WebSite\Pages\Index.cshtml"
Write(
        await Html.RenderComponentAsync<VideoList>(RenderMode.ServerPrerendered)
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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