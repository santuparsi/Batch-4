#pragma checksum "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2890463f546ffe83b7e6743a81dfb0fce6f8456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
#line 1 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\_ViewImports.cshtml"
using HandsOnHelperMethods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\_ViewImports.cshtml"
using HandsOnHelperMethods.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2890463f546ffe83b7e6743a81dfb0fce6f8456", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb1d2fe47c66eccc56a47f1a629629d28e9afe2a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnHelperMethods.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 6 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\User\Details.cshtml"
       Write(Html.Display("Fname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 6 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\User\Details.cshtml"
                               Write(Html.Display("Lname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
#nullable restore
#line 7 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\User\Details.cshtml"
Write(Html.ActionLink("LogOut","Login","Account"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnHelperMethods.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591