using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject9.Models
{
    public class UpdateOrderData
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

  
        public Guid cusId { get; set; }

        public int amount { get; set; }
    }
}
