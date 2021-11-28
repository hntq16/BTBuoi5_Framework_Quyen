using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Models
{
    public class NhanVienModel
    {

        [Display(Name = "Mã Nhân Viên")]
        public string maNhanVien { get; set; }
        [Display(Name = "Tên Nhân Viên")]
        public string tenNhanVien { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string soDienThoai { get; set; }
        [Display(Name = "Giới Tính")]
        public int gioiTinh { get; set; }
        public ICollection<NV_BTModel> NVBTs { get; set; }
    }
}
