#pragma checksum "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "714710de30fb925b56d6d68736d8ca5ac0af6ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebUser_UserInformation), @"mvc.1.0.view", @"/Views/WebUser/UserInformation.cshtml")]
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
#line 1 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/_ViewImports.cshtml"
using MVC_Tutorial.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"714710de30fb925b56d6d68736d8ca5ac0af6ec1", @"/Views/WebUser/UserInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a052df730a9b5d88896a620cfd42a3c46d64a157", @"/Views/_ViewImports.cshtml")]
    public class Views_WebUser_UserInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Tutorial.Models.WebUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>WebUserFOrm</h2>\n\n");
#nullable restore
#line 11 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
 using(var form = Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n    ");
#nullable restore
#line 14 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 15 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div>\n    ");
#nullable restore
#line 19 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 20 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 24 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.LabelFor(m => m.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 25 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.TextBoxFor(m => m.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <input type=\"submit\" value=\"Submit\" />\n");
#nullable restore
#line 28 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 31 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
 using(var form = Html.BeginForm()) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 34 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.LabelFor(m => m.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 35 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.TextBoxFor(m => m.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 36 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.ValidationMessageFor(m => m.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 40 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 41 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 42 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n");
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 47 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 48 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 49 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n");
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 54 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 55 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 56 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n");
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 61 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.LabelFor(m => m.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 62 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.TextBoxFor(m => m.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 63 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
   Write(Html.ValidationMessageFor(m => m.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n");
#nullable restore
#line 67 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
                             ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\n");
#nullable restore
#line 69 "/home/likeside/Desktop/C# Projects/MVC-Tutorial/MVC-Tutorial/MVC-Tutorial/Views/WebUser/UserInformation.cshtml"
                                       
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Footer", async() => {
                WriteLiteral("\n    <p>Footer section</p>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Tutorial.Models.WebUser> Html { get; private set; }
    }
}
#pragma warning restore 1591