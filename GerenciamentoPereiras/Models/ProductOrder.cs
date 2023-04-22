using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoPereiras.Models
{
    public class ProductOrder
    {
        public ProductOrder() { }

        public ProductOrder(int productId, int orderId, int amount, decimal valuePerItem, DateTime date)
        {
            this.ProductId = productId;
            this.OrderId = orderId;
            this.Amount = amount;
            this.ValuePerItem = valuePerItem;
            this.OrderDate = date;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Product")]
        [Column("productId")]
        public int ProductId { get; set; }

        [ForeignKey("Order")]
        [Column("orderId")]
        public int OrderId { get; set; }

        [Required]
        [Column("amount")]
        public int Amount { get; set; }

        [Required]
        [Column("valuePerItem")]
        [Precision(4,2)]
        public decimal ValuePerItem { get; set; }

        [Required]
        [Column("orderDate", TypeName = "date")]
        public DateTime OrderDate { get; set; }
    }
}
