using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MyProject9.Models
{
    public class Products
    {
        public int  proId { get; set; }


        public string code { get; set; } = string.Empty;

        public string name { get; set; } = string.Empty ;

        public int price { get; set; }



    }
}
