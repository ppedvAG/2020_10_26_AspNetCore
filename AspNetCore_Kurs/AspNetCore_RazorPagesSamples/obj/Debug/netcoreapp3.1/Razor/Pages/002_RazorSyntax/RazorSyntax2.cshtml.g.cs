#pragma checksum "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8b988dc8919057d516bf4c9609648001de242d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore_RazorPagesSamples.Pages._002_RazorSyntax.Pages_002_RazorSyntax_RazorSyntax2), @"mvc.1.0.razor-page", @"/Pages/002_RazorSyntax/RazorSyntax2.cshtml")]
namespace AspNetCore_RazorPagesSamples.Pages._002_RazorSyntax
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
#line 1 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\_ViewImports.cshtml"
using AspNetCore_RazorPagesSamples;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8b988dc8919057d516bf4c9609648001de242d", @"/Pages/002_RazorSyntax/RazorSyntax2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957875162a3ff80a1b5aba0a4642f4bc577a2d4b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_002_RazorSyntax_RazorSyntax2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Ein einfaches ");
            WriteLiteral("@-Zeichen reicht aus.\r\n");
#nullable restore
#line 4 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
  var numbers = Enumerable.Range(1, 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
 foreach (var number in numbers)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
Write(number);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
 foreach (var number in numbers)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
Write( number * 10 );

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
                    //Einfache Verschachtlungen, bzw kleine berechnungen oder formatierungen(bei strings(
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
 foreach (var number in numbers)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
Write(number * 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;\r\n");
#nullable restore
#line 23 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<p>Beispiel 4:</p>\r\n<br />\r\n");
#nullable restore
#line 31 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
 foreach (var number in numbers)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
Write(number * 10);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * 10 = ");
#nullable restore
#line 33 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
                        Write(number * 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p>Beispiel 5</p>\r\n");
#nullable restore
#line 38 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
 foreach (var number in numbers)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>");
#nullable restore
#line 40 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
      Write(number * 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</span>\r\n");
#nullable restore
#line 41 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\002_RazorSyntax\RazorSyntax2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_RazorPagesSamples.Pages._002_RazorSyntax.RazorSyntax2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPagesSamples.Pages._002_RazorSyntax.RazorSyntax2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPagesSamples.Pages._002_RazorSyntax.RazorSyntax2Model>)PageContext?.ViewData;
        public AspNetCore_RazorPagesSamples.Pages._002_RazorSyntax.RazorSyntax2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
