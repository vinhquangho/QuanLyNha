using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    public enum Status
    {
        [Display(Name = "Đang hoạt động")]
        Active = 1,
        [Display(Name = "Ngừng hoạt động")]
        DeActive = 2,
    }
}
