using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.Entity.Entities
{
    public class Subscribe
    {
        public int SubscribeId { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
