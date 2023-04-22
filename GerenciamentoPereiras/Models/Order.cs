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
    [Table("Order")]
    public class Order
    {
        public Order() { }
        public Order(string name, int ordersGroupId, DateTime date)
        {
            this.Name = name;
            this.CreatedAt = date;
            this.IsOpen = true;
            this.ordersGroupId = ordersGroupId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [ForeignKey("OrdersGroup")]
        public int ordersGroupId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }


        [Required]
        [Column("createdAt" ,TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("isOpen")]
        public bool IsOpen { get; set; }
    }
}
