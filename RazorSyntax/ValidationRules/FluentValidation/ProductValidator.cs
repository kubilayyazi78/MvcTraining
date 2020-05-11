using FluentValidation;
using RazorSyntax.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorSyntax.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(t => t.ProductName).NotEmpty();
           //clientside uygun değil RuleFor(t => t.CategoryId).GreaterThan(0).WithMessage("Select");
            RuleFor(t => t.QuantityPerUnit).NotEmpty().Length(3, 10);
            //yerine   RuleFor(t => t.UnitPrice).GreaterThan(5);

            RuleFor(t => t.UnitPrice).InclusiveBetween(5, int.MaxValue)
                .WithMessage("5den büyük olmalı");
        }
    }
}