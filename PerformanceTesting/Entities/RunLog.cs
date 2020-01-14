using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerformanceTesting.Entities
{
    [Table("RunLog")]
    public class RunLog
    {
        [Key]
        public int Id { get; set; }
        public string RunDateTime { get; set; }
        public int TotalConsumedSeconds { get; set; }
        public int NumberOfMessage { get; set; }
        public string Topic { get; set; }
        public string BrokerList { get; set; }
    }
}
