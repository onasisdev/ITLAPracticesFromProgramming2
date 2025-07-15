using CRUD_API.Models.Entitie;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }


    }
}
