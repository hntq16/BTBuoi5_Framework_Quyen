#pragma checksum "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNhanVienTheoSoLan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c74428346ba526a518eaf2050ad78b120476fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_KQLietKeNhanVienTheoSoLan), @"mvc.1.0.view", @"/Views/NhanVien/KQLietKeNhanVienTheoSoLan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c74428346ba526a518eaf2050ad78b120476fd", @"/Views/NhanVien/KQLietKeNhanVienTheoSoLan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30f2d71fb7589b11d41d42e6b15d2e15563936f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_KQLietKeNhanVienTheoSoLan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table border=\"1\" action=\"/NhanVien/\" method=\"GET\">\r\n    <tr>\r\n        <th>Tên nhân viên</th>\r\n        <th>Số điện thoại</th>\r\n        <th>Số lần sửa</th>\r\n    </tr>\r\n");
#nullable restore
#line 10 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNhanVienTheoSoLan.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 13 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNhanVienTheoSoLan.cshtml"
   Write(item.GetType().GetProperty("TenNV").GetValue(item,null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 14 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNhanVienTheoSoLan.cshtml"
   Write(item.GetType().GetProperty("SoDT").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 15 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNhanVienTheoSoLan.cshtml"
   Write(item.GetType().GetProperty("SoLan").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 17 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNhanVienTheoSoLan.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591