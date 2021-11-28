using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Models
{
    public class CanHoModel
    {
        [Display(Name = "Mã Căn Hộ")]
        public string maCanHo { get; set; }
        [Display(Name = "Tên Chủ Hộ")]
        public string tenChuHo { get; set; }
        public ICollection<NV_BTModel> NVBTs { get; set; }
    }
}
