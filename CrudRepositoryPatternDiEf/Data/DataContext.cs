global using Microsoft.EntityFrameworkCore;

namespace CrudRepositoryPatternDiEf.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-RN9SHTB9\\SQLExpress;Database=frontmansDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<FrontMan> FrontMans { get; set; }
    }
}
