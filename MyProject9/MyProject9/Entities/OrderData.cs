using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject9.Entities
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
