using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject9.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid cusId { get; set; }

        public string name { get; set; }=string.Empty;
         
        public string address { get; set; }=string.Empty;

        public ICollection<Customerid> customerids { get; set; }
        = new List<Customerid>();



    }
}
