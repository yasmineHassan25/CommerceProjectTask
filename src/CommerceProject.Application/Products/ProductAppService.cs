using CommerceProject.Categories;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CommerceProject.Products
{
    public class ProductAppService : CrudAppService
                                        <Product, ProductDTO, int, PagedAndSortedResultRequestDto, CreateUpdateProductDto>, IProductsAppService
    {
        public ProductAppService(IRepository<Product, int> repo) : base(repo)
        {
        }
    }
}
