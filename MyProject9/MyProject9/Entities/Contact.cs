using System.ComponentModel.DataAnnotations;

namespace MyProject9.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Key]
        public Guid cusId { get; set; }

        [Required]
        [MaxLength(10)]
        public int phone { get; set; }

    
    }
}
