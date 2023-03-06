using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SP2023_Assignment3_apayne.Models;

namespace SP2023_Assignment3_apayne.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SP2023_Assignment3_apayne.Models.Movie> Movie { get; set; }
        public DbSet<SP2023_Assignment3_apayne.Models.Actor> Actor { get; set; }
    }
}