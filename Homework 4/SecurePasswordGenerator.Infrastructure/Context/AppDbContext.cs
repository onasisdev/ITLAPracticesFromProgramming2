using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecurePasswordGenerator.Domain.Entities;

namespace SecurePasswrodGenerator.Infraestructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PasswordHistory> PasswordHistories { get; set; }
    }
}
