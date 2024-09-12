using CommerceProject.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CommerceProject.Data.Categories
{
    public class CategoriesDataSeeder : IDataSeedContributor, ITransientDependency
    {
        public IRepository<Category, int> CategoriesRepository { get; }

        public CategoriesDataSeeder(IRepository<CommerceProject.Categories.Category, int> CategoriesRepository)
        {
            this.CategoriesRepository = CategoriesRepository;
        }


        public Task SeedAsync(DataSeedContext context)
        {
            List<Category> category = new List<Category>()
            {
                new Category(Name: "Mobile Phones"),
                new Category(Name: "Laptops"),
                new Category(Name: "LCD")
            };

            //for insert list of categories in DB.
            return this.CategoriesRepository.InsertManyAsync(category);

        }

    }
}
