using Microsoft.EntityFrameworkCore;
using Supermarket.Models;

namespace Supermarket.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
         public DbSet<Product> Products { get; set; }
         public DbSet<Employee> Employees { get; set; }
         public DbSet<Invoice> Invoices { get; set; }
         public DbSet<InvoiceItem> InvoiceItems { get; set; }


       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship between Product and Invoice
            modelBuilder.Entity<InvoiceItem>()
                .HasKey(ii => new { ii.ProductId, ii.InvoiceId });

            modelBuilder.Entity<InvoiceItem>()
                .HasOne(ii => ii.Product)
                .WithMany(p => p.InvoiceItems)
                .HasForeignKey(ii => ii.ProductId);

            modelBuilder.Entity<InvoiceItem>()
                .HasOne(ii => ii.Invoice)
                .WithMany(i => i.InvoiceItems)
                .HasForeignKey(ii => ii.InvoiceId);
        }*/

    }
}
