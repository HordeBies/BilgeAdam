using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    internal class Product
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        // Navigation Property
        public Category Category { get; set; }
    }
}
