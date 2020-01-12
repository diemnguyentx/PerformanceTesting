using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTesting
{
    public partial class LogDbContext : DbContext
    {
        public LogDbContext() : base("name=LogDbContext")
        {
            Database.SetInitializer<LogDbContext>(new CreateDatabaseIfNotExists<LogDbContext>());
        }
    }
}
