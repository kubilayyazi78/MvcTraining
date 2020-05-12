using RazorSyntax.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RazorSyntax.Models.Entities
{   [FluentValidation.Attributes.Validator(typeof(ProductValidator))]
    public class Product
    {    [Display(Name ="İsim")]
        //[Required]
        public string ProductName { get; set; }
        //[Required(ErrorMessage ="Zorunlu")]
        public int CategoryId { get; set; }
        //[StringLength(5)]
        public string QuantityPerUnit { get; set; }
       // [Range(0,100)]
        public decimal UnitPrice { get; set; }
       // [UIHint("Date")]
        public DateTime? BirthDay { get; set; }
    }
}