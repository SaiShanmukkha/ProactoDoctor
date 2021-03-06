#pragma checksum "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb2c710dce11f70e59bb970155d7745bf369813e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AddEditAppointment), @"mvc.1.0.view", @"/Views/Shared/_AddEditAppointment.cshtml")]
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
#line 1 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\_ViewImports.cshtml"
using ProactoDoctor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\_ViewImports.cshtml"
using ProactoDoctor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb2c710dce11f70e59bb970155d7745bf369813e", @"/Views/Shared/_AddEditAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0164a6c027d8048643c6360455ae619dce65ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AddEditAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("duration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("appointmentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal fade\" id=\"appointmentInput\" role=\"dialog\" data-backdrop=\"static\" data-keyboard=\"false\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb2c710dce11f70e59bb970155d7745bf369813e5354", async() => {
                WriteLiteral("\r\n                <div class=\"modal-header\">\r\n");
#nullable restore
#line 6 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                     if (User.IsInRole(ProactoDoctor.Utilities.Helper.Admin))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h5 class=\"modal-title\">Add/Edit Appointment:</h5>\r\n");
#nullable restore
#line 9 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h5 class=\"modal-title\">Appointment Details:</h5>\r\n");
#nullable restore
#line 13 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""title"">Title</label>
                        <input type=""text"" maxlength=""100"" class=""form-control"" id=""title"" />
                    </div><div class=""form-group"">
                        <label for=""description"">Description:</label>
                        <textarea type=""text"" class=""form-control"" id=""description""></textarea>
                    </div>
");
#nullable restore
#line 23 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                     if (User.IsInRole(ProactoDoctor.Utilities.Helper.Admin))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            <label for=\"patientId\">Select Patient:</label>\r\n                            ");
#nullable restore
#line 27 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                       Write(Html.DropDownList("patientId", new SelectList(ViewBag.PatientList, "Id", "Name", new { @class = "form-control select2" })));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 29 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                         if (User.IsInRole(ProactoDoctor.Utilities.Helper.Doctor))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""form-group"">
                                <label for=""lblPatientName"">Patient Name:</label>
                                <label type=""text"" class=""form-control"" disabled id=""lblPatientName""></label>
                            </div>
                            <div class=""form-group"">
                                <label for=""lblstatus"">Status:</label>
                                <label type=""text"" class=""form-control"" disabled id=""lblstatus""></label>
                            </div>
");
#nullable restore
#line 42 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                         if (User.IsInRole(ProactoDoctor.Utilities.Helper.Patient))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""form-group"">
                                <label for=""lblDoctorName"">Doctor Name:</label>
                                <label type=""text"" class=""form-control"" disabled id=""lblDoctorName""></label>
                            </div>
                            <div class=""form-group"">
                                <label for=""lblstatus"">Status:</label>
                                <label type=""text"" class=""form-control"" disabled id=""lblstatus""></label>
                            </div>
");
#nullable restore
#line 53 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group"">
                        <label for=""appointmentDate"">Appointment Date & Time:</label>
                        <input class=""form-control"" id=""appointmentDate"" />
                    </div>

                    <div class=""form-group"">
                        <label for=""duration"">Select Duration:</label>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb2c710dce11f70e59bb970155d7745bf369813e11056", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 62 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Duration;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <input type=""hidden"" id=""Id"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" onclick=""onCloseModal();"">Close</button>
");
#nullable restore
#line 68 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                     if (User.IsInRole(ProactoDoctor.Utilities.Helper.Admin))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <button type=""button"" id=""btnSubmit"" class=""btn btn-success"" onclick=""onSubmitForm();"">Submit</button>
                        <button type=""button"" id=""btnDelete"" class=""btn btn-danger hidden"" onclick=""onDeleteAppointment();"">Delete</button>
");
#nullable restore
#line 72 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                      if (User.IsInRole(ProactoDoctor.Utilities.Helper.Doctor))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <button type=""button"" id=""btnConfirm"" class=""btn btn-success"" onclick=""onConfirm();"">Confirm</button>
                        <button type=""button"" id=""btnDelete"" class=""btn btn-danger hidden"" onclick=""onDeleteAppointment();"">Delete</button>
");
#nullable restore
#line 76 "F:\CS Projects\ProactoDoctor\ProactoDoctor\Views\Shared\_AddEditAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
