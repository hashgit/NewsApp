using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Threading.Tasks;
using NewsWeb.Models;

namespace NewsWeb.Repository
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public new async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }

    }

    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; set; }
        Task SaveChangesAsync();
    }
}