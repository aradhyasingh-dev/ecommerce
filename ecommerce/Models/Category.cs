using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Category
    {
        [Key]
        public int Catergory_id { get; set; }
        public string Catergory_name { get; set; }
    }
}
