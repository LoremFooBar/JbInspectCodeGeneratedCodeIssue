using Microsoft.EntityFrameworkCore;

namespace JbInspectCodeGeneratedCodeIssue
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("test");
        }
    }
}
