using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Models
{
    public class ThietBiModel
    {

        [Display(Name = "Mã Thiết Bị")]
        public string maThietBi { get; set; }
        [Display(Name = "Tên Thiết Bị")]
        public string tenThietBi { get; set; }
        public ICollection<NV_BTModel> NVBTs { get; set; }
    }
}
