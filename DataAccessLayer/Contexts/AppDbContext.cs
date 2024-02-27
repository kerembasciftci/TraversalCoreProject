using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AboutDto> Abouts { get; set; }
        public DbSet<About2Dto> About2s { get; set; }
        public DbSet<ContactDto> Contacts { get; set; }
        public DbSet<DestinationDto> Destinations { get; set; }
        public DbSet<FeatureDto> Features { get; set; }
        public DbSet<Feature2Dto> Feature2s { get; set; }
        public DbSet<GuideDto> Guides { get; set; }
        public DbSet<NewsLetterDto> NewsLetters { get; set; }
        public DbSet<SubAboutDto> SubAbout { get; set; }
        public DbSet<TestimonialDto> Testimonials { get; set; }
        public DbSet<CommentDto> Comment { get; set; }
        public DbSet<ReservationDto> Reservations { get; set; }
    }
}
