using Microsoft.EntityFrameworkCore;

namespace BlazorInfoSysApp.Models
{
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
        
        public DbSet<Person> People => Set<Person>();
    }
}