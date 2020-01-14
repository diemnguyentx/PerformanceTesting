using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerformanceTesting.Entities
{
    [Table("RunTest")]
    public class RunTest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
