#pragma checksum "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24361560f40e1d5bd49361ec1b675e15e2ae0a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_KQLietKeNV_BT), @"mvc.1.0.view", @"/Views/NhanVien/KQLietKeNV_BT.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24361560f40e1d5bd49361ec1b675e15e2ae0a0c", @"/Views/NhanVien/KQLietKeNV_BT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30f2d71fb7589b11d41d42e6b15d2e15563936f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_KQLietKeNV_BT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<p>Danh sách thiết bị của nhân viên được chọn sửa</p>
<table border=""1"" action=""/NhanVien/"" method=""GET"">
    <tr>
        <th>Mã thiết bị</th>
        <th>Mã căn hộ</th>
        <th>Lần thứ</th>
        <th>Ngày bảo trì</th>
        <th>Chức năng</th>
    </tr>
");
#nullable restore
#line 11 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
           Write(item.GetType().GetProperty("maThietBi").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
           Write(item.GetType().GetProperty("maCanHo").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
           Write(item.GetType().GetProperty("lanThu").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
           Write(item.GetType().GetProperty("ngayBaoTri").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 699, "\"", 880, 5);
            WriteAttributeValue("", 706, "XoaThietBi?Id=", 706, 14, true);
#nullable restore
#line 18 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
WriteAttributeValue("", 720, item.GetType().GetProperty("maThietBi").GetValue(item, null), 720, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("\r\n                     ", 781, "&&", 804, 25, true);
            WriteAttributeValue(" ", 806, "MaNhanVien=", 807, 12, true);
#nullable restore
#line 19 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
WriteAttributeValue("", 818, item.GetType().GetProperty("maNhanVien").GetValue(item, null), 818, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete\r\n                </a>\r\n                 <a");
            BeginWriteAttribute("href", " href=\"", 931, "\"", 1113, 5);
            WriteAttributeValue("", 938, "ViewThietBi?Id=", 938, 15, true);
#nullable restore
#line 21 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
WriteAttributeValue("", 953, item.GetType().GetProperty("maThietBi").GetValue(item, null), 953, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("\r\n                     ", 1014, "&&", 1037, 25, true);
            WriteAttributeValue(" ", 1039, "MaNhanVien=", 1040, 12, true);
#nullable restore
#line 22 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
WriteAttributeValue("", 1051, item.GetType().GetProperty("maNhanVien").GetValue(item, null), 1051, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View\r\n                </a>\r\n            </td> \r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\UIT\Xay dung HTTT tren cac framework\OnThi\OnThi\Views\NhanVien\KQLietKeNV_BT.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
