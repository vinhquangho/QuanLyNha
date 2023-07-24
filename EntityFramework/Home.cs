using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    [Table("Home")]
    public class Home
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ResidentialArea { get; set; } // diện tích
        public Direction Direction { get; set; } // hướng nhà
        public int Storey { get; set; } // số tần
        public string Address { get; set; } // địa chỉ
        public Status Status { get; set; } // trạng thái
        public StatusHome StatusHome { get; set; } // trạng thái của nhà
        public int AreaId { get; set; } // khu vực
        public Area Area { get; set; }
    }
    public enum StatusHome
    {
        [Display(Name = "Đã cho thuê")]
        Active = 1,
        [Display(Name = "Chưa cho thuê")]
        DeActive = 2,
    }
    public enum Direction
    {
        [Display(Name = "Hướng Bắc")]
        North,
        [Display(Name = "Hướng Đông")]
        East,
        [Display(Name = "Hướng Nam")]
        South,
        [Display(Name = "Hướng Tây")]
        West,
        [Display(Name = "Hướng Đông Bắc")]
        NorthEat,
        [Display(Name = "Hướng Đông Nam")]
        SouthEat,
        [Display(Name = "Hướng Tây Bắc")]
        NorthWest,
        [Display(Name = "Hướng Tây Nam")]
        SouthWest
    }
}
