#pragma checksum "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd3c9980a786473ffe959ae3e32063825ea6c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\lukky\source\repos\PUXdesign\Views\_ViewImports.cshtml"
using PUXdesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukky\source\repos\PUXdesign\Views\_ViewImports.cshtml"
using PUXdesign.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd3c9980a786473ffe959ae3e32063825ea6c16", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43a86afdcdde4e9b8fb45db091beabaceac85b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PUXdesign.Models.RequestAndReportSingle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>File directory analysis</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd3c9980a786473ffe959ae3e32063825ea6c165476", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd3c9980a786473ffe959ae3e32063825ea6c165746", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 14 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd3c9980a786473ffe959ae3e32063825ea6c167453", async() => {
                    WriteLiteral("Write the full path to the directory.");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 16 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Request.Path);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4dd3c9980a786473ffe959ae3e32063825ea6c169111", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 17 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Request.Path);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd3c9980a786473ffe959ae3e32063825ea6c1610687", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 18 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Request.Path);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Send request"" name=""submit"" class=""btn btn-primary"" />
                <input type=""submit"" value=""Clear"" name=""submit"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
 if (Model != null && Model.Report.Added != null && Model.Report.Added.Count != 0 && Model.Report.CheckForDataFile(Model.Report.Added) == true && Model.Report.CheckForSameReq(Model.Report.Added, Model) == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Added data file</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Version"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("MD5 Hash"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Full Path"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
             foreach (var item in Model.Report.Added)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 if (item.Type == PUXdesign.Analysis.DataType.DataFile && item.RequiredPath == Model.Request.Path)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ActualVersion.identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ActualVersion.HashMD5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 72 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
 if (Model != null && Model.Report.Added != null && Model.Report.Added.Count != 0 && Model.Report.CheckForFolder(Model.Report.Added) == true && Model.Report.CheckForSameReq(Model.Report.Added, Model) == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Added folders</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 81 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 84 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Full Path"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 90 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
             foreach (var item in Model.Report.Added)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 if (item.Type == PUXdesign.Analysis.DataType.Folder && item.RequiredPath == Model.Request.Path)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 106 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
 if (Model != null && Model.Report.Changed != null && Model.Report.Changed.Count != 0 && Model.Report.CheckForDataFile(Model.Report.Changed) == true && Model.Report.CheckForSameReq(Model.Report.Changed, Model) == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Changed data file</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 115 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 118 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Version"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 121 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("MD5 Hash"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 124 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Full Path"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 130 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
             foreach (var item in Model.Report.Changed)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 if (item.Type == PUXdesign.Analysis.DataType.DataFile && item.RequiredPath == Model.Request.Path)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 136 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 139 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ActualVersion.identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 142 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ActualVersion.HashMD5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 145 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n            </tr>\r\n");
#nullable restore
#line 149 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 153 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 155 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
 if (Model != null && Model.Report.Changed != null && Model.Report.Changed.Count != 0 && Model.Report.CheckForFolder(Model.Report.Changed) == true && Model.Report.CheckForSameReq(Model.Report.Changed, Model) == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Changed folders</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 162 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 165 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Full Path"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 171 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
             foreach (var item in Model.Report.Changed)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 if (item.Type == PUXdesign.Analysis.DataType.Folder && item.RequiredPath == Model.Request.Path)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 177 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 180 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 183 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 187 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 189 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
 if (Model != null && Model.Report.Removed != null && Model.Report.Removed.Count != 0 && Model.Report.CheckForDataFile(Model.Report.Removed) == true && Model.Report.CheckForSameReq(Model.Report.Removed, Model) == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Removed data files</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 196 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 199 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Version"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 202 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("MD5 Hash"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 205 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Full Path"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 211 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
             foreach (var item in Model.Report.Removed)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 213 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 if (item.Type == PUXdesign.Analysis.DataType.DataFile && item.RequiredPath == Model.Request.Path)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 217 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 220 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ActualVersion.identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 223 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ActualVersion.HashMD5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 226 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n            </tr>\r\n");
#nullable restore
#line 230 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 230 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 234 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 236 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
 if (Model != null && Model.Report.Removed != null && Model.Report.Removed.Count != 0 && Model.Report.CheckForFolder(Model.Report.Removed) == true && Model.Report.CheckForSameReq(Model.Report.Removed, Model) == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Removed folders</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 243 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 246 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayName("Full Path"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 252 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
             foreach (var item in Model.Report.Removed)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 254 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 if (item.Type == PUXdesign.Analysis.DataType.Folder && item.RequiredPath == Model.Request.Path)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 258 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 261 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 264 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 264 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 268 "C:\Users\lukky\source\repos\PUXdesign\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PUXdesign.Models.RequestAndReportSingle> Html { get; private set; }
    }
}
#pragma warning restore 1591