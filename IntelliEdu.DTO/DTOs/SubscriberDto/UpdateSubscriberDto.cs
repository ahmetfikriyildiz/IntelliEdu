﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.DTO.DTOs.SubscriberDto
{
    public class UpdateSubscriberDto
    {
        public int SubscribeId { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
