using PerformanceTesting.Entities;
using System.Data.Entity;

namespace PerformanceTesting
{
    public partial class LogDbContext : DbContext
    {
        public LogDbContext() : base("name=LogDbContext")
        {
            Database.SetInitializer<LogDbContext>(new CreateDatabaseIfNotExists<LogDbContext>());
        }
        public  DbSet<Message> Message { get; set; }
        public DbSet<RunLog> RunLog { get; set; }
        public DbSet<RunTest> RunTest { get; set; }
    }
}
