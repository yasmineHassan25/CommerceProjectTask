using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommerceProject.Products
{
    public class ProductCategories: FullAuditedEntity<int>
    {
        public ProductCategories(int categoryId, int productId)
        {
            this.categoryId = categoryId;
            this.productId = productId;
        }
        public int categoryId { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
        public Categories.Category category { get; set; }
    }
}
