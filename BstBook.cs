using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BstBook
    {
        public int BstId { get; set; }
        public string BstTitle { get; set; }
        public string BstAuthor { get; set; }
        public string BstYear { get; set; }
        public string BstPulisher { get; set; }
        public string BstPicture { get; set; }
        public int BstCategoryId { get; set; }
        public virtual BstCategory BstCategory {get; set; } 
    }
}