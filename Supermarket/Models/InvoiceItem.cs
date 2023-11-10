using System.ComponentModel.DataAnnotations;

namespace Supermarket.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "رقم المنتج مطلوب")]
       
        [Range(1, int.MaxValue, ErrorMessage = "يرجى إدخال قيمة صحيحة للكمية")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "يرجى إدخال قيمة صحيحة للسعر")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "يرجى إدخال قيمة صحيحة للمبلغ الإجمالي")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }


        public int ProductId { get; set; }
        public int InvoiceId { get; set; }

        // Navigation properties to represent the relationships with Product and Invoice
        public Product Product { get; set; }
       
        public Invoice Invoice { get; set; }
       


    }
}
