using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    interface Base
    {
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
