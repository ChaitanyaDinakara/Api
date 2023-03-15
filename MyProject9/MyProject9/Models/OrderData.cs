using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyProject9.Models
{
    public class OrderData
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("cusId")]
        public Guid cusId { get; set; }

        public int amount { get; set; }
    }
}
