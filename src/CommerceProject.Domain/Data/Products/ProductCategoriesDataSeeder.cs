using CommerceProject.Categories;
using CommerceProject.Data.Categories;
using CommerceProject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CommerceProject.Data.Products
{
    public class ProductCategoriesDataSeeder /*: IDataSeedContributor ,ITransientDependency*/
    {
        //public IRepository<Category, int> CatgeoryRepo { get; }
        //public IRepository<Product, int> ProductRepo { get; }
        //public IRepository<ProductCategories, int> ProductCategoriesRepository { get; }

        //public ProductCategoriesDataSeeder(IRepository<Product, int> ProductRepo, IRepository<Category, int> CatgeoryRepo)
        //{
        //    this.CatgeoryRepo = CatgeoryRepo;
        //    this.ProductRepo = ProductRepo;
        //}

        //public  async Task SeedAsync(DataSeedContext context)
        //{
        //    ProductsDataSeeder ProductSeed = new ProductsDataSeeder(ProductRepo);
        //    CategoriesDataSeeder CategorySeed = new CategoriesDataSeeder(CatgeoryRepo);
            
        //    await CategorySeed.SeedAsync(context);
        //    await ProductSeed.SeedAsync(context);
            

        //    var productCategory = new List<ProductCategories>()
        //    {
        //            new ProductCategories( categoryId: , productId: 2),
        //            new ProductCategories( categoryId: 1, productId: 2),
        //            new ProductCategories( categoryId: 1, productId: 2),
        //            new ProductCategories( categoryId: 1, productId: 2),
        //    };

        //    //for insert list of categories in DB.
        //    await this.ProductCategoriesRepository.InsertManyAsync(productCategory);
        //}
    }
}
