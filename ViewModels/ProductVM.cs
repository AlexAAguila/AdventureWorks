using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.ViewModels
{
    public class ProductVM
    {
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }


        public string Name { get; set; } = null!;

        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; } = null!;

        public string? Color { get; set; }

        [Display(Name = "Standard Cost")]

        public double StandardCost { get; set; }

        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
    }

}
