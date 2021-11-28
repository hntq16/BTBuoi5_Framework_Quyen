using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Models
{
    public class NV_BTModel
    {
        [Display(Name = "Mã Căn Hộ")]
        public string maCanHo { get; set; }
        [Display(Name = "Mã Thiết Bị")]
        public string maThietBi { get; set; }
        [Display(Name = "Mã Nhân Viên")]
        public string maNhanVien { get; set; }
        [Display(Name = "Lần thứ")]
        public int lanThu { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        [Display(Name = "Ngày bảo trì")]

        public DateTime ngayBaoTri { get; set; }
        public NhanVienModel nhanvien { get; set; }
        public CanHoModel canho { get; set; }
        public ThietBiModel thietbi { get; set; }
    }
}
