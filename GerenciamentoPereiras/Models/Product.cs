 using GerenciamentoPereiras.Utils;
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
    [Table("Product")]
    public class Product
    {

        public Product(string name, Category category, decimal price)
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("category")]
        public Category Category { get; set; }

        [Required]
        [Precision(4, 2)]
        [Column("price")]
        public decimal Price { get; set; }
    }
}
