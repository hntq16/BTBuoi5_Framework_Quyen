#pragma checksum "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64db9ea7dd5de2d941a6b91541d6398abe435af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ViewThietBi), @"mvc.1.0.view", @"/Views/NhanVien/ViewThietBi.cshtml")]
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
#line 1 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\_ViewImports.cshtml"
using OnThi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\_ViewImports.cshtml"
using OnThi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64db9ea7dd5de2d941a6b91541d6398abe435af9", @"/Views/NhanVien/ViewThietBi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30f2d71fb7589b11d41d42e6b15d2e15563936f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ViewThietBi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NV_BTModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/NhanVien/UpdateThietBi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
  
    ViewData["Title"] = "Update Thiet Bi";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Update Thiet Bi</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64db9ea7dd5de2d941a6b91541d6398abe435af94153", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"maNhanVien\" name=\"maNhanVien\"");
                BeginWriteAttribute("value", " value=\"", 225, "\"", 250, 1);
#nullable restore
#line 8 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 233, Model.maNhanVien, 233, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"maThietBiCu\" name=\"maThietBiCu\"");
                BeginWriteAttribute("value", " value=\"", 320, "\"", 344, 1);
#nullable restore
#line 9 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 328, Model.maThietBi, 328, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"maCanHoCu\" name=\"maCanHoCu\"");
                BeginWriteAttribute("value", " value=\"", 410, "\"", 432, 1);
#nullable restore
#line 10 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 418, Model.maCanHo, 418, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"LanThuCu\" name=\"LanThuCu\"");
                BeginWriteAttribute("value", " value=\"", 496, "\"", 517, 1);
#nullable restore
#line 11 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 504, Model.lanThu, 504, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <label for=\"MaThietBi\">M?? thi???t b???</label> <input type=\"text\" name=\"MaThietBi\"");
                BeginWriteAttribute("value", " value=\"", 611, "\"", 635, 1);
#nullable restore
#line 13 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 619, Model.maThietBi, 619, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label for=\"MaCanHo\">M?? c??n h???</label> <input type=\"text\" name=\"MaCanHo\"");
                BeginWriteAttribute("value", " value=\"", 725, "\"", 747, 1);
#nullable restore
#line 14 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 733, Model.maCanHo, 733, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label for=\"LanThu\">L???n s???a</label> <input type=\"text\" name=\"LanThu\"");
                BeginWriteAttribute("value", " value=\"", 833, "\"", 854, 1);
#nullable restore
#line 15 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 841, Model.lanThu, 841, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <label for=\"NgayBaoTri\">Ng??y s???a</label> <input type=\"text\" name=\"NgayBaoTri\"");
                BeginWriteAttribute("value", " value=\"", 949, "\"", 974, 1);
#nullable restore
#line 16 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\ViewThietBi.cshtml"
WriteAttributeValue("", 957, Model.ngayBaoTri, 957, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br>\r\n        <input type=\"submit\" name=\"submit\" value=\"Update\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NV_BTModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
