#pragma checksum "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\001_Einstieg\001_SingleFileApproach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fabf71cc60b173bb1f6614ecb623a59cac6ebd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore_RazorPagesSamples.Pages._001_Einstieg.Pages_001_Einstieg_001_SingleFileApproach), @"mvc.1.0.razor-page", @"/Pages/001_Einstieg/001_SingleFileApproach.cshtml")]
namespace AspNetCore_RazorPagesSamples.Pages._001_Einstieg
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fabf71cc60b173bb1f6614ecb623a59cac6ebd3", @"/Pages/001_Einstieg/001_SingleFileApproach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957875162a3ff80a1b5aba0a4642f4bc577a2d4b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_001_Einstieg_001_SingleFileApproach : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n//HTML \r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fabf71cc60b173bb1f6614ecb623a59cac6ebd33657", async() => {
                WriteLiteral("\r\n        <div>Name: <input name=\"name\" /></div>\r\n        <div><input type=\"submit\" /> </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n");
#nullable restore
#line 25 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\001_Einstieg\001_SingleFileApproach.cshtml"
     if(!string.IsNullOrEmpty(Model.Name)) //Ist die Variable name ausgefüllt? Dann ->
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Hello ");
#nullable restore
#line 27 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\001_Einstieg\001_SingleFileApproach.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n");
#nullable restore
#line 28 "C:\Aktueller Kurs\2020_10_26_AspNetCore\AspNetCore_Kurs\AspNetCore_RazorPagesSamples\Pages\001_Einstieg\001_SingleFileApproach.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_RazorPagesSamples.Pages._001_Einstieg._001_SingleFileApproach> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPagesSamples.Pages._001_Einstieg._001_SingleFileApproach> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPagesSamples.Pages._001_Einstieg._001_SingleFileApproach>)PageContext?.ViewData;
        public AspNetCore_RazorPagesSamples.Pages._001_Einstieg._001_SingleFileApproach Model => ViewData.Model;
    }
}
#pragma warning restore 1591
