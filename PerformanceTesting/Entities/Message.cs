using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerformanceTesting.Entities
{
    [Table("Message")]
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Topic { get; set; }
        public string BrokerList { get; set; }
        public string Body { get; set; }
        public string FilePath { get; set; }
        [ForeignKey("RunTest")]
        public int RunTestId { get; set; }
        public RunTest RunTest { get; set; }
    }
}
