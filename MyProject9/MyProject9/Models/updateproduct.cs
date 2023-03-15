using System.ComponentModel.DataAnnotations;

namespace MyProject9.Models
{
    public class updateproduct
    {

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string code { get; set; } = string.Empty;

        public string name { get; set; } = string.Empty;

        public int price { get; set; }
    }
}
