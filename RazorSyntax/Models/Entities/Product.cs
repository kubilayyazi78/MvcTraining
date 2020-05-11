using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RazorSyntax.Models.Entities
{
    public class Product
    {
        [Required]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Zorunlu")]
        public int CategoryId { get; set; }
        [StringLength(5)]
        public string QuantityPerUnit { get; set; }
        [Range(0,100)]
        public decimal UnitPrice { get; set; }
    }
}