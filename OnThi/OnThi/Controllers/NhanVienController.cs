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
        public IActionResult XoaThietBi(string MaNV, string MaTB, string MaCH, int LanThu)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            //return View(context.SqlXoaThietBi(Id, MaNhanVien));
            int count = context.SqlXoaThietBi(MaNV, MaTB, MaCH, LanThu);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View(context.SqlXoaThietBi(MaNV, MaTB, MaCH, LanThu));
        }
        public IActionResult ViewThietBi(string MaNV, string MaTB, string MaCH, int LanThu)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            return View(context.SqlViewThietBi(MaNV, MaTB, MaCH, LanThu));
        }
        [HttpPost]
        public IActionResult UpdateThietBi(string maThietBiCu, string maCanHoCu, int lanThuCu, NV_BTModel nv)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            
            count = context.SqlUpdateNVBT(maThietBiCu, maCanHoCu, lanThuCu, nv);
            if (count > 0)
            {
                ViewData["thongbao"] = "Update thành công";
            }
            else ViewData["thongbao"] = "Update không thành công";
            return View();
        }
    }
}
