using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class Bill_detail : Base
    {
        [Key]
        public int ID { get; set; }
        public int ID_Bill { get; set; }
        public int ID_Product { get; set; }
        public int quantity { get; set; }
        public int Unit_price { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
