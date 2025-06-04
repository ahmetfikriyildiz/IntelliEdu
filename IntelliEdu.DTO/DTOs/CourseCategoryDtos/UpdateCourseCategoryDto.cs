using IntelliEdu.Entity.Entities;

namespace IntelliEdu.DTO.DTOs.CourseCategoryDtos
{
    public class UpdateCourseCategoryDto
    {
        public int CourseCategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public bool IsShown { get; set; }
    }
}
