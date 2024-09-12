using CommerceProject.Categories;
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
    public class ProductsDataSeeder : IDataSeedContributor, ITransientDependency
    {
        public IRepository<Product, int> ProductsRepository { get; }

        public ProductsDataSeeder(IRepository<Product, int> ProductsRepository)
        {
            this.ProductsRepository = ProductsRepository;
        }

        public Task SeedAsync(DataSeedContext context)
        {
            var product = new List<Product>()
            {
                new Product(Name: "Oppo", 
                            Description: "Smartphones of Chinese company",
                            price: 7500.0M),
                new Product(Name: "Realme",
                            Description: "Smartphones of Chinese company",
                            price: 5500.0M),
                new Product(Name: "Lenovo ideapad 330",
                            Description: "Lenovo laptop",
                            price: 10500.0M)
            };

            //for insert list of categories in DB.
            return this.ProductsRepository.InsertManyAsync(product);
        }
    }
}
