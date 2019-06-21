using System;
using System.ComponentModel.DataAnnotations;

namespace product.Models
{
    public class CategoryForm
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Name")]
        public string Name {get;set;}


    }
}