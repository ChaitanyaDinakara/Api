using MyProject9.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyProject9.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid cusId { get; set; }

        public string name { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;

        public ICollection<Customerid> customerids { get; set; }
        = new List<Customerid>();
    }
}
