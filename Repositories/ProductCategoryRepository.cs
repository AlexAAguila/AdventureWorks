using AdventureWorks.Controllers;
using AdventureWorks.EfModels;
using AdventureWorks.Interfaces;
using AdventureWorks.ViewModels;
namespace AdventureWorks.Repositories
{
    public class ProductCategoryRepository : IRepository<ProductCategoryVM>
    {
        private readonly AdventureWorksContext _db;
        public ProductCategoryRepository(ILogger<HomeController> logger
                                , AdventureWorksContext db)
        {
            _db = db;
        }
        public ProductCategoryVM Get(int id)
        {
            ProductCategoryVM product = GetAll().FirstOrDefault(p => p.ProductId == id);
            return product;
        }
        public List<ProductCategoryVM> GetAll()
        {
            List<ProductCategoryVM> products = _db.Products.Select(p => new ProductCategoryVM
            {
                ProductId = p.ProductId,
                ProductName = p.Name,
                ProductNumber = p.ProductNumber,
                Color = p.Color,
                CategoryName = _db.ProductCategories.Where(pc => pc.ProductCategoryId == p.ProductCategoryId).Select(pc => pc.Name).FirstOrDefault()
            }).ToList();
            return products;
        }
    }
}