using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BstCategory
    {
        public int BstId { get; set; }
        public string BstCategory {  get; set; }
        public virtual ICollection<BstBook> BstBook { get; set; }
    }
}