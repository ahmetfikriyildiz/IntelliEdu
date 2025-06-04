using IntelliEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.DTO.DTOs.CourseDtos
{
    public class CreateCourseDto
    {
        public string CourseName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int CourseCategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
