using FluentValidation;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Text;

namespace eShop.BlazorWasm.UI.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        //[Required]
        //[StringLength(12,ErrorMessage = "Maker Name is too long (12 characters limit)")]
        public string Maker { get; set; }
        //[Required]
        //[StringLength(15, ErrorMessage = "Title is too long (15 characters limit)")]
        public string Title { get; set; }

        //[StringLength(50, ErrorMessage = "Description Name is too long (50 characters limit)")]
        //[Required]
        public string Description { get; set; }
    }
    public class ProductViewModelValidator:AbstractValidator<ProductViewModel>
    {
        public ProductViewModelValidator()
        {
            RuleFor(x => x.Maker).NotEmpty().Length(5,12);
            RuleFor(x => x.Title).NotEmpty().Length(5, 15); ;
            RuleFor(x => x.Description).NotEmpty().MaximumLength(50);

        }

    }
}
