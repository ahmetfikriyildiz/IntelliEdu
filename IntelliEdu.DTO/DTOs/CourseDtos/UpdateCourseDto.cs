using IntelliEdu.Entity.Entities;

namespace IntelliEdu.DTO.DTOs.CourseDtos
{
    public class UpdateCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int CourseCategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
