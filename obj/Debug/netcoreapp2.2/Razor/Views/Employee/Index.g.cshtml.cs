#pragma checksum "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7604467f35fa49ba12287dc7951c29b24cf6689e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7604467f35fa49ba12287dc7951c29b24cf6689e", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707ed085060d81e1a092e876778245b43e0d1ef1", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectManagement.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 93, true);
            WriteLiteral("\r\n<script src=\"https://kit.fontawesome.com/a076d05399.js\"></script>\r\n\r\n<h2>Employee</h2>\r\n<p>");
            EndContext();
            BeginContext(186, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7604467f35fa49ba12287dc7951c29b24cf6689e5695", async() => {
                BeginContext(209, 51, true);
                WriteLiteral("<button class=\"btn btn-primary\">Create New</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 95, true);
            WriteLiteral("</p>\r\n\r\n<table class=\"table table-striped\" style=\"width:100%\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(360, 44, false);
#line 15 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(404, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(430, 45, false);
#line 18 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(475, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(501, 46, false);
#line 21 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(547, 84, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th style=\"text-align:right\"></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t\r\n\t<tbody>\r\n");
            EndContext();
#line 28 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
         foreach (var item in Model) {
			var viewTM = "#viewModal" + item.ID;
			var viewMId = "viewModal" + item.ID;

			var deleteTM = "#deleteModal" + item.ID;
			var deleteMId = "deleteModal" + item.ID;


#line default
#line hidden
            BeginContext(841, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(866, 43, false);
#line 37 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(909, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(938, 44, false);
#line 40 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(982, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1011, 45, false);
#line 43 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 71, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<!-- <a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(1128, 7, false);
#line 46 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                                          Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 185, true);
            WriteLiteral("\"><button class=\"btn btn-primary\" title=\"View Details\"><i class=\"fas fa-file\"></i></button></a> -->\r\n\t\t\t\t\t<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"");
            EndContext();
            BeginContext(1321, 6, false);
#line 47 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                                                                              Write(viewTM);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 66, true);
            WriteLiteral("\" title=\"View Details\"><i class=\"fas fa-file\"></i></button>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1393, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7604467f35fa49ba12287dc7951c29b24cf6689e11080", async() => {
                BeginContext(1438, 90, true);
                WriteLiteral("<button class=\"btn btn-success\" title=\"Edit Employee\"><i class=\"fas fa-edit\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1532, 85, true);
            WriteLiteral("\r\n\t\t\t\t\t<button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"");
            EndContext();
            BeginContext(1618, 8, false);
#line 49 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                                                                             Write(deleteTM);

#line default
#line hidden
            EndContext();
            BeginContext(1626, 112, true);
            WriteLiteral("\" title=\"Delete Employee\"><i class=\"fas fa-trash\"></i></button>\r\n\t\t\t\t\t<!-- <a asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(1739, 7, false);
#line 50 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                                         Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1746, 297, true);
            WriteLiteral(@"""><button class=""btn btn-danger"" title=""Delete User""><i class=""fas fa-trash""></i></button></a> -->
					<!-- <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#myModal""><i class=""fas fa-trash""></i></button> -->

					<!-- View Modal -->
					<div class=""modal fade""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2043, "\"", 2056, 1);
#line 54 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2048, viewMId, 2048, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2057, 461, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""viewModalLabel"" aria-hidden=""true"">
						<div class=""modal-dialog"">
							<div class=""modal-content"">
								<div class=""modal-header"">
									<h5>Employee Details</h5>
									<button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
								</div>
								<div class=""modal-body"">
									<div>
										<dl class=""dl-horizontal"">
											<dt>
												");
            EndContext();
            BeginContext(2519, 48, false);
#line 65 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(2567, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2617, 44, false);
#line 68 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(2661, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2713, 47, false);
#line 72 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(2760, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2810, 43, false);
#line 75 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2905, 49, false);
#line 79 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(2954, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3004, 45, false);
#line 82 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(3049, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3101, 45, false);
#line 86 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3146, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3196, 41, false);
#line 89 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3237, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3289, 49, false);
#line 93 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Department));

#line default
#line hidden
            EndContext();
            BeginContext(3338, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3388, 45, false);
#line 96 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
            EndContext();
            BeginContext(3433, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3485, 43, false);
#line 100 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3578, 39, false);
#line 103 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(3617, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3669, 47, false);
#line 107 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3716, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3766, 43, false);
#line 110 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(3809, 51, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t<dt>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3861, 47, false);
#line 114 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayNameFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(3908, 49, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dt>\r\n\t\t\t\t\t\t\t\t\t\t\t<dd>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3958, 43, false);
#line 117 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(4001, 115, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</dd>\r\n\t\t\t\t\t\t\t\t\t\t</dl>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"modal-footer\">\r\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(4116, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7604467f35fa49ba12287dc7951c29b24cf6689e23014", async() => {
                BeginContext(4198, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 123 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4206, 210, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<!-- Delete Modal -->\r\n\t\t\t\t\t<div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4416, "\"", 4431, 1);
#line 131 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
WriteAttributeValue("", 4421, deleteMId, 4421, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4432, 469, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""deleteModalLabel"" aria-hidden=""true"">
						<div class=""modal-dialog"">
							<div class=""modal-content"">
								<div class=""modal-header"">
									<button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
								</div>
								<div class=""modal-body"">
									<p>Are you sure you want to delete this employee?</p>
								</div>
								<div class=""modal-footer"">
									");
            EndContext();
            BeginContext(4901, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7604467f35fa49ba12287dc7951c29b24cf6689e26640", async() => {
                BeginContext(4986, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 141 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
                                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4996, 173, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 149 "E:\GOAL\ProjectManagement\Views\Employee\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(5174, 25, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectManagement.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
