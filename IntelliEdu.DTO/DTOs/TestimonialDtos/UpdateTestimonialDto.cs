using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.DTO.DTOs.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestomonialId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public int Star { get; set; }
    }
}
