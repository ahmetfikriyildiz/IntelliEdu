using IntelliEdu.DTO.DTOs.BlogCategoryDtos;
using IntelliEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.DTO.DTOs.BlogDtos
{
    public class CreateBlogDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgageUrl { get; set; }
        public DateTime BlogData { get; set; }
        public int BlogCategoryId { get; set; }
        
    }
}
