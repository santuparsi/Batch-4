#pragma checksum "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ae9427eefb7c0d7530370dd060c02e28a277fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ae9427eefb7c0d7530370dd060c02e28a277fd", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb1d2fe47c66eccc56a47f1a629629d28e9afe2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1><div class=\"container\">\r\n");
#nullable restore
#line 7 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
     using (Html.BeginForm("Validate","Account","POST"))
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<table class=\"table table-bordered\">\r\n\t\t\t\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Username</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 13 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
               Write(Html.TextBox("uname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Password</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 17 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
               Write(Html.Password("pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t\r\n\t\t\t<tr>\r\n\t\t\t\t<td colspan=\"2\">\r\n\t\t\t\t\t<input type=\"submit\" value=\"SignIn\" />\r\n\t\t\t\t\t<input type=\"Reset\" value=\"Reset\" />\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td colspan=\"2\">\r\n\t\t\t\t\t");
#nullable restore
#line 28 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
               Write(Html.ActionLink("SignUp","Register","Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 31 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
             if (ViewBag.errMsg != null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td colspan=\"2\">\r\n\t\t\t\t\t<span class=\"text-danger\">");
#nullable restore
#line 35 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
                                         Write(ViewBag.errMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 38 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</table>\r\n");
#nullable restore
#line 40 "D:\OnlineBatch\Dotnet-Batch-4\MVC\HandsOnHelperMethods\Views\Account\Login.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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