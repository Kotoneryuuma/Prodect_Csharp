using System;
using System.ComponentModel.DataAnnotations;

namespace product.Models
{
    public class ProductForm
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Name")]
        public string ProductName {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Descriotion")]
        public string Description {get;set;}

        [Required]
        [Display(Name = "Price")]
        public decimal Price {get;set;}





    }
}