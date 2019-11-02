using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class Bill : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int iduser { get; set; }
        public int MyProperty { get; set; }
        public string total { get; set; }
        public string payment { get; set; }
        public string note { get; set; }
        public DateTime CreateTime { get; set ; }
        public DateTime UpdateTime { get ; set; }
        public bool IsDelete { get ; set ; }
    }
}
