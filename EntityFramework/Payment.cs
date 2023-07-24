﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    [Table("Payment")]
    public class Payment
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int ContactId { get; set; }
        public Contract Contract { get; set; }
    }
}
