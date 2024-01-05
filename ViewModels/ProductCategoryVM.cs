using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.ViewModels
{
    public class ProductCategoryVM
    {
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]

        public string ProductName { get; set; } = null!;

        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; } = null!;

        public string? Color { get; set; }

        [Display(Name = "Category Name")]

        public string? CategoryName { get; set; }


    }
}

