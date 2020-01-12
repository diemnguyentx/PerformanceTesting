using PerformanceTesting.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PerformanceTesting
{
    public partial class KafkaDbContext : DbContext
    {
        public KafkaDbContext() : base("KafkaPerformanceTestingConnectionString")
        {
            Database.SetInitializer<KafkaDbContext>(null);
        }
        public virtual IDbSet<RunTest> RunTest { get; set; }
        public List<RunTest> Get_RunTest_Table()
        {
            using (var dbContext = new KafkaDbContext())
            {
                return (from rt in dbContext.RunTest select rt).ToList();
            }
        }
    }
}
