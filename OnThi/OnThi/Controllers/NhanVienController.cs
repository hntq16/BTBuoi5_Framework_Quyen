using Microsoft.AspNetCore.Mvc;
using OnThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Controllers
{
    public class NhanVienController:Controller
    {
        public IActionResult ListNhanVien()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            return View(context.SqlListNhanVien());
        }
        public IActionResult LietkeNhanVienTheoSoLan(int soLan)
        {
            return View();
        }
        public IActionResult KQLietkeNhanVienTheoSoLan(int soLan)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            return View(context.sqlListByTimeNhanVien(soLan));
        }
        public IActionResult LietKeThietBi(string MaNhanVien)
        {
            return View();
        }
        public IActionResult KQLietKeNV_BT(string MaNhanVien)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            return View(context.SqlLietKeThietBi(MaNhanVien));
        }
        public IActionResult XoaThietBi(string Id, string MaNhanVien)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            //return View(context.SqlXoaThietBi(Id, MaNhanVien));
            int count = context.SqlXoaThietBi(Id, MaNhanVien);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
        public IActionResult ViewThietBi(string Id, string MaNhanVien)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            return View(context.SqlViewThietBi(Id, MaNhanVien));
        }
    }
}
