using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnectionString")
        {

        }
    }
}
