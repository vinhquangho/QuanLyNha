using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNha.EntityFramework
{
    public class Global
    {
        private static int _AccountId = 0;
        public static int AccountId
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }
    }
}
