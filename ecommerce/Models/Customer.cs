using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address{ get; set; }
        public string Customer_Email{ get; set; }
    }
} 
