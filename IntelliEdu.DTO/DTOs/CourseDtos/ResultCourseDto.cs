using IntelliEdu.DTO.DTOs.CourseCategoryDtos;
using IntelliEdu.Entity.Entities;

namespace IntelliEdu.DTO.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int CourseCategoryId { get; set; }
        public ResultCourseCategoryDto CourseCategory { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
