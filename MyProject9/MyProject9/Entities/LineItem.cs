using System.ComponentModel.DataAnnotations;

namespace MyProject9.Entities
{
    public class LineItem
    {
        public int OrderLine { get; set; }

        [Key]
        public int Orderid { get; set; }

        public int proid { get; set; }  

        public int quantity { get; set; }

     

    }
}
