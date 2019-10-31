using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class User : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
    }
}
