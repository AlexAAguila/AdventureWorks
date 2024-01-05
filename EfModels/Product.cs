using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.EfModels;

public partial class Product
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

    public string? Size { get; set; }

    public double? Weight { get; set; }

    public int? ProductCategoryId { get; set; }

    public int? ProductModelId { get; set; }

    public string SellStartDate { get; set; } = null!;

    public string? SellEndDate { get; set; }

    public string? DiscontinuedDate { get; set; }

    public byte[]? ThumbNailPhoto { get; set; }

    public string? ThumbnailPhotoFileName { get; set; }

    public string Rowguid { get; set; } = null!;

    public string ModifiedDate { get; set; } = null!;
}
