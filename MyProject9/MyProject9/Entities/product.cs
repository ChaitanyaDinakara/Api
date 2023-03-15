using System.ComponentModel.DataAnnotations;

namespace MyProject9.Entities
{
    public class product
    {
        [Key]
        public int proid { get; set; }

        [Required]
        [MaxLength(5)]
        public string code { get; set; } = string.Empty;

        public string name { get; set; } = string.Empty ;

        public int price { get; set; }

    }
}
