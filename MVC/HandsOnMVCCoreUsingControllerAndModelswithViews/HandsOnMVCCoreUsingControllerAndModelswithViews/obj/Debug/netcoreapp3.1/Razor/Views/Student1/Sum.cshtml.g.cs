#pragma checksum "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnMVCCoreUsingControllerAndModelswithViews\HandsOnMVCCoreUsingControllerAndModelswithViews\Views\Student1\Sum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f4e40cb19a61528ec0e9930c8129b132f8f6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student1_Sum), @"mvc.1.0.view", @"/Views/Student1/Sum.cshtml")]
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
#line 1 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnMVCCoreUsingControllerAndModelswithViews\HandsOnMVCCoreUsingControllerAndModelswithViews\Views\_ViewImports.cshtml"
using HandsOnMVCCoreUsingControllerAndModelswithViews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnMVCCoreUsingControllerAndModelswithViews\HandsOnMVCCoreUsingControllerAndModelswithViews\Views\_ViewImports.cshtml"
using HandsOnMVCCoreUsingControllerAndModelswithViews.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f4e40cb19a61528ec0e9930c8129b132f8f6de", @"/Views/Student1/Sum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e4278064cf4b3822098d4dc49b50e40714d445", @"/Views/_ViewImports.cshtml")]
    public class Views_Student1_Sum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnMVCCoreUsingControllerAndModelswithViews\HandsOnMVCCoreUsingControllerAndModelswithViews\Views\Student1\Sum.cshtml"
  
	ViewData["Title"] = "Sum";
	Layout = "~/Views/Shared/_Layout.cshtml";
	int c = ViewBag.Result;
	int d = (int)ViewData["Result"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sum=");
#nullable restore
#line 9 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnMVCCoreUsingControllerAndModelswithViews\HandsOnMVCCoreUsingControllerAndModelswithViews\Views\Student1\Sum.cshtml"
   Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Sum=");
#nullable restore
#line 10 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnMVCCoreUsingControllerAndModelswithViews\HandsOnMVCCoreUsingControllerAndModelswithViews\Views\Student1\Sum.cshtml"
   Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
