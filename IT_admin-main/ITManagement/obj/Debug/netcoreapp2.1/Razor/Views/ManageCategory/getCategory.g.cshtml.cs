#pragma checksum "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8222d69eccd8d675b0aeb4f619996c51070eb0ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageCategory_getCategory), @"mvc.1.0.view", @"/Views/ManageCategory/getCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageCategory/getCategory.cshtml", typeof(AspNetCore.Views_ManageCategory_getCategory))]
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
#line 1 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\_ViewImports.cshtml"
using ITManagement;

#line default
#line hidden
#line 2 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\_ViewImports.cshtml"
using ITManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8222d69eccd8d675b0aeb4f619996c51070eb0ab", @"/Views/ManageCategory/getCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0f013920f1d6b5866185b6f45c2fda83c66d51", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageCategory_getCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITManagement.Models.Categories>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "deleteCategoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteCategoryId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline; color: white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal fade"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("dialog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-labelledby", new global::Microsoft.AspNetCore.Html.HtmlString("exampleModalLabel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-hidden", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("hideErrorBox()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("categoryId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "categoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editCategoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 114, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n");
            EndContext();
#line 3 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
  
    ViewData["Title"] = "ManageCategoryController";

#line default
#line hidden
#line 6 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
 if (TempData.ContainsKey("DisplayAlert") && (bool)TempData["DisplayAlert"])
{

#line default
#line hidden
            BeginContext(288, 120, true);
            WriteLiteral("    <script>alert(\'This category exists in the Manage devices page. You need to delete it from there first.\');</script>\n");
            EndContext();
#line 9 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
}

#line default
#line hidden
            BeginContext(410, 1013, true);
            WriteLiteral(@"<style>

    /* Custom styles */
    .btn-icon {
        font-size: 2rem;
        margin: 4px;
    }

    .btn {
        margin: 5px;
    }

    .head {
        font-size: 4.5rem;
        font-weight: 600;
    }

    .info {
        font-size: 2rem;
    }

    .data {
        font-size: 1.7rem;
    }
</style>
<h1 class=""head text-center"">Manage Categories</h1>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                <i class=""fa fa-plus btn-icon""></i> Add Category
            </button>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-striped table-bordered"">
                <thead>
                    <tr class=""info"">
                        <th>Category Name</th>
                        <th style=""text-align: end"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 54 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
                     foreach (var item in ViewBag.categories)
                    {

#line default
#line hidden
            BeginContext(1507, 74, true);
            WriteLiteral("                        <tr>\n                            <td class=\"data\">");
            EndContext();
            BeginContext(1582, 17, false);
#line 57 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
                                        Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 133, true);
            WriteLiteral("</td>\n                            <td style=\"text-align: end\">\n                                <button class=\"btn btn-success btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1732, "\"", 1797, 6);
            WriteAttributeValue("", 1742, "openEditModal(\'", 1742, 15, true);
#line 59 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
WriteAttributeValue("", 1757, item.CategoryName, 1757, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1775, "\',", 1775, 2, true);
            WriteAttributeValue(" ", 1777, "\'", 1778, 2, true);
#line 59 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
WriteAttributeValue("", 1779, item.CategoryId, 1779, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1795, "\')", 1795, 2, true);
            EndWriteAttribute();
            BeginContext(1798, 155, true);
            WriteLiteral(">\n                                    <i class=\"fa fa-pencil btn-icon\"></i> Edit\n                                </button>\n                                ");
            EndContext();
            BeginContext(1953, 507, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dd4381f67b74e74893f9ed218d268a8", async() => {
                BeginContext(2062, 38, true);
                WriteLiteral("\n\n                                    ");
                EndContext();
                BeginContext(2100, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea2cc789bc474b99b91d292b73a0d73b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 64 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 64 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
                                                                                                                       WriteLiteral(item.CategoryId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2215, 238, true);
                WriteLiteral("\n                                    <button class=\"btn btn-danger btn-sm\">\n                                        <i class=\"fa fa-trash btn-icon\"></i> Delete\n                                    </button>\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            BeginContext(2460, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 71 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
                    }

#line default
#line hidden
            BeginContext(2547, 72, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n");
            EndContext();
#line 76 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
     if (TempData.ContainsKey("DisplayAlert") && (bool)TempData["DisplayAlert"])
    {

#line default
#line hidden
            BeginContext(2706, 121, true);
            WriteLiteral("        <script>alert(\'This category is allotted with a device. Delete it from the device and then continue.\');</script>\n");
            EndContext();
#line 79 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
    }

#line default
#line hidden
            BeginContext(2833, 10, true);
            WriteLiteral("\n\n\n</div>\n");
            EndContext();
            BeginContext(2843, 1356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098449df7af04c70b7bf85c714463b96", async() => {
                BeginContext(3008, 1184, true);
                WriteLiteral(@"
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h2 class=""modal-title"" id=""exampleModalLabel"">Add Category</h2>
            </div>
            <div class=""modal-body"">
                <label class=""control-label""></label>
                <input type=""text"" placeholder=""Category Name"" style=""width:100%; padding:7px"" id=""AddCategoryName"" />

                <div id=""addErrorAlert"" class=""alert alert-danger"" role=""alert"" style=""display: none; margin-top: 10px;"">
                    <!-- Error message will be displayed here -->
                </div>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" style=""background-color:#BB3F3F; color:white"" id=""addClo");
                WriteLiteral("seBtn\">Close</button>\n                <button type=\"button\" id=\"addSubmitBtn\" class=\"btn btn-primary\">Add</button>\n            </div>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4199, 1644, true);
            WriteLiteral(@"

<script>
    document.getElementById('addSubmitBtn').addEventListener('click', function () {
        var category = document.getElementById('AddCategoryName').value; // Assuming the input field ID is CategoryName

        $.ajax({
            type: ""POST"",
            url: '/ManageCategory/CreateCategory',
            data: { category: category },
            success: function (data) {
                if (data.errorMessage) {
                    var errorMessage = data.errorMessage;
                    var errorBox = document.getElementById('addErrorAlert');
                    errorBox.innerText = errorMessage;
                    errorBox.style.display = 'block';
                } else {
                    $('#exampleModal').modal('hide'); // Close the modal on success
                    location.reload(); // Refresh the page
                }
            },
            error: function (xhr, status, error) {
                console.error('Error:', error);
            }
        });
    });
</script>



<");
            WriteLiteral(@"div class=""modal fade"" id=""editCategoryModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""editCategoryModalLabel"" aria-hidden=""true"" onclick=""hideErrorBox()"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editCategoryModalLabel"">Edit Category</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(5843, 1007, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b2020a3e294a6bad31485e6b2fed57", async() => {
                BeginContext(5903, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(5924, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a5d3d14283442a8b1bd2e6778339320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#line 149 "C:\Users\VanditJain\Desktop\IT_admin-main\IT_admin-main\ITManagement\Views\ManageCategory\getCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6002, 841, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label  class=""control-label"">Category Name</label>
                        <input type=""text""  class=""form-control"" id=""editCategoryName"" name=""CategoryName"" />
                    </div>
                    <div id=""editErrorAlert"" class=""alert alert-danger"" role=""alert"" style=""display: none; margin-top: 10px;"">
                        <!-- Error message will be displayed here -->
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" style=""background-color: #BB3F3F; color: white"">Close</button>
                        <input type=""submit"" id=""editSubmitBtn"" value=""Save Changes"" class=""btn btn-primary"" />
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6850, 1778, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<script>
    function openEditModal(categoryName, categoryId) {
        document.getElementById('editCategoryName').value = categoryName;
        document.getElementById('categoryId').value = categoryId;
        $('#editCategoryModal').modal('show');
    }

    document.getElementById('editSubmitBtn').addEventListener('click', function (event) {
        event.preventDefault();
        var categoryName = document.getElementById('editCategoryName').value; // Assuming the input field ID is editCategoryName
        var categoryId = document.getElementById('categoryId').value; // Assuming the input field ID is categoryId

        $.ajax({
            type: ""POST"",
            url: '/ManageCategory/Edit',
            data: { CategoryId: categoryId, CategoryName: categoryName },
            success: function (data) {
                if (data.errorMessage1) {
                    var errorMessage1 = data.errorMessage1;
                    var errorBox = document.get");
            WriteLiteral(@"ElementById('editErrorAlert');
                    errorBox.innerText = errorMessage1;
                    errorBox.style.display = 'block';
                } else {
                    $('#editCategoryModal').modal('hide'); // Close the modal on success
                    location.reload(); // Refresh the page
                }
            },
            error: function (xhr, status, error) {
                console.error('Error:', error);
            }
        });
    });
    function hideErrorBox() {
        var errorBox1 = document.getElementById('editErrorAlert');
        var errorBox2 = document.getElementById('addErrorAlert');

        
        errorBox1.style.display = 'none';
        errorBox2.style.display = 'none';

    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITManagement.Models.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
