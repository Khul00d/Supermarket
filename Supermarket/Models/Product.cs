using System.ComponentModel.DataAnnotations;

namespace Supermarket.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string? name { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "This product cannot be entered because it has expired")]
        public DateTime Expiry_Date { get; set; }

        [Required]
        public double price { get; set; }
        [Required]
        [Range(1,100)]
        public int quantity { get; set; }


      
        

    }



    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            return date > DateTime.Now;
        }
    }


}
