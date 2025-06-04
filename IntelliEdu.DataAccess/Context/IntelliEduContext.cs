using IntelliEdu.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.DataAccess.Context
{
    public class IntelliEduContext : DbContext
    {
        public IntelliEduContext(DbContextOptions options): base(options) 
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subscriber> Subscriptions { get; set; }
        public DbSet<Testimonial> Testomonials { get; set; }

    }
}
