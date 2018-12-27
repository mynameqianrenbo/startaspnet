using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ConnectionOptions
    {
        public  string DefaultConnection { get; set; }
        public  List<Connect> AllConnect { get; set; }

        public class Connect
        {
            public  string Provider { get; set; }
            public  string ConnStr { get; set; }
        }
    }
}
