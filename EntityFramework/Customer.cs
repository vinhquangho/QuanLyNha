using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BrithDay { get; set; }
        public string CMND { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Status Status { get; set; }
    }
}
