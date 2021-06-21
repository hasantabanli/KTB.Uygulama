using KTB.Uygulama.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace KTB.Uygulama.Dal
{
    public class PersonelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-3AEIA9M; Database=Personel;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        public DbSet<Personel> Personel { get; set; }
    }
}
