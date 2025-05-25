using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.Entity.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string ImageUrlFirst { get; set; } = string.Empty;
        public string ImageUrlSecond { get; set; } = string.Empty;
        public string ItemFirst { get; set; } = string.Empty;
        public string ItemSecond { get; set; } = string.Empty;
        public string ItemThird { get; set; } = string.Empty;
        public string ItemFourth { get; set;} = string.Empty;
    }
}
