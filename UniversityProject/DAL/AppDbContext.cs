using Microsoft.EntityFrameworkCore;
using UniversityProject.Models;

namespace UniversityProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<RelatedProducts> RelatedProducts { get; set; }
    }
}
