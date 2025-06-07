using Microsoft.EntityFrameworkCore;
using Tarea_2.Models.Entities;



namespace Tarea_2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
