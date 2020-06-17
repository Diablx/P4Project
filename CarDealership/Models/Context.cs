using Microsoft.EntityFrameworkCore;

namespace CarDealership.Models
{
    public class Context : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
