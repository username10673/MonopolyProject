using Microsoft.EntityFrameworkCore;

namespace MonopolyProject.Classes
{
    public class ApplicationContextDB : DbContext
    {
        public DbSet<Pallet> Pallets { get; set; } = null!;
        public DbSet<Box> Boxes { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
