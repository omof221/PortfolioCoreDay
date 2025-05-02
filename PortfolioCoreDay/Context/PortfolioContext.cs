using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Context
{
    public class PortfolioContext:DbContext
{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;initial Catalog=PortfolioCoreDayDb;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");
        public DbSet<Education> educations { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Myjobs> myjobss { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Socialmedia> socialmedias { get; set; }
        public DbSet<Contact> contacts { get; set; }


    }
}
