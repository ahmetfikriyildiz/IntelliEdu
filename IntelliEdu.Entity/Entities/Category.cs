﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.Entity.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public string Icon {  get; set; } = string.Empty;
        public bool IsShown { get; set; }
    }
}
