#pragma checksum "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1338c2dcb735e474e4f2fda6fef9bfde7f19a5"
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
#line 1 "E:\GOAL\ProjectManagement\Views\_ViewImports.cshtml"
using ProjectManagement;

#line default
#line hidden
#line 2 "E:\GOAL\ProjectManagement\Views\_ViewImports.cshtml"
using ProjectManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1338c2dcb735e474e4f2fda6fef9bfde7f19a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707ed085060d81e1a092e876778245b43e0d1ef1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagement.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5, true);
            WriteLiteral("<!-- ");
            EndContext();
#line 1 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
       
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(50, 197, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div> -->\r\n\r\n");
            EndContext();
            BeginContext(289, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
  
	ViewBag.Title = "Login";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(369, 172, true);
            WriteLiteral("<div class=\"row justify-content-md-center\">\r\n\t<div class=\"col-md-4\">\r\n\t\t<div class=\"card\">\r\n\t\t\t<div class=\"card-header\">\r\n\t\t\t\tLogin\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-body\">\r\n");
            EndContext();
#line 23 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                 using (Html.BeginForm("Index", "Home", FormMethod.Post))
				{
					
					

#line default
#line hidden
            BeginContext(624, 23, false);
#line 26 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(649, 37, true);
            WriteLiteral("\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(687, 30, false);
#line 28 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
            EndContext();
            BeginContext(717, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(726, 96, false);
#line 29 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Username, "", new { @class = "form-control", @placeholder = "Username" }));

#line default
#line hidden
            EndContext();
            BeginContext(822, 54, true);
            WriteLiteral("\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(877, 30, false);
#line 33 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(907, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(916, 93, false);
#line 34 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 141, true);
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t<input type=\"submit\" name=\"submit\" class=\"btn btn-primary\" value=\"Login\"/>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 39 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(1157, 6, true);
            WriteLiteral("\t\t\t\t  ");
            EndContext();
#line 40 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                   if (ViewBag.Message != null)  
    {  

#line default
#line hidden
            BeginContext(1205, 111, true);
            WriteLiteral("        <script type=\"text/javascript\">  \r\n            window.onload = function () {  \r\n                alert(\"");
            EndContext();
            BeginContext(1317, 15, false);
#line 44 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1332, 46, true);
            WriteLiteral("\");  \r\n            };  \r\n        </script>  \r\n");
            EndContext();
#line 47 "E:\GOAL\ProjectManagement\Views\Home\Index.cshtml"
    } 

#line default
#line hidden
            BeginContext(1386, 38, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagement.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591