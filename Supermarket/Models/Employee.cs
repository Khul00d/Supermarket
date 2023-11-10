using System.ComponentModel.DataAnnotations;

namespace Supermarket.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Position { get; set; } 

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+?1-?)?\d{3}-?\d{3}-?\d{4}$", ErrorMessage = "رقم الهاتف غير صحيح. يرجى استخدام الصيغة: +1-555-555-5555")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صحيح")]
        public string Email { get; set; }

        // Navigation property to represent the relationship with Invoice
        public List<Invoice> invoices { get; set; } 

    }
}
