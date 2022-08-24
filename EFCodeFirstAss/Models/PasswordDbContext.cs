using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAss.Models
{
    public class PasswordDbContext: DbContext
    {
        public PasswordDbContext()
        {

        }
        public PasswordDbContext(DbContextOptions<PasswordDbContext> options): base(options)
        {

        }

        public DbSet<Passwords> Passwords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Server=.;Database=Passwordmanagerdb;Trusted_Connection=True; Encrypt=True;TrustServerCertificate=True;");
            }
        }
    }
}
