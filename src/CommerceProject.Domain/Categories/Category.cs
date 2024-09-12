using CommerceProject.Products;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommerceProject.Categories
{
    public class Category:FullAuditedEntity<int>
    {
        public Category(string Name)
        {
            this.Name = Name;
        }
        public String Name { get; set; }
        public List<ProductCategories> productcategories { get; set; }
    }
}
