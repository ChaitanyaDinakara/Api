using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyProject9.Entities
{
    public class Customerid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid cusId { get; set; }

        public string drivinglicense { get; set; } = string.Empty;
    }
}
