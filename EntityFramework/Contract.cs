﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    [Table("Contract")]
    public class Contract
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int HomeId { get; set; }
        public Home Home { get; set; }
        public Status Status { get; set; }
    }
}
