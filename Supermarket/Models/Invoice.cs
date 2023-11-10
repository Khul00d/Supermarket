using System.ComponentModel.DataAnnotations;

namespace Supermarket.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime IssueDate { get; set; }= DateTime.Now;

        public int EmployeeId { get; set; }  // Assuming a relationship with a Employee model
        public decimal TotalAmount { get; set; }

        // Navigation property to represent the relationship with InvoiceItems
        public List<InvoiceItem> InvoiceItems { get; set; }

        // Navigation property to represent the relationship Employee
        public Employee employee { get; set; }

    }
}
