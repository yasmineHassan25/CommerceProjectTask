using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommerceProject.Products
{
    public class Product:FullAuditedEntity<int>
    {
        public Product(string Name, string Description, decimal price)
        {
            this.Name = Name;
            this.Description = Description;
            this.price = price;
        }
        //[Required(ErrorMessage="Name is required.")]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal price { get; set; }

        public List<ProductCategories> ProductCategories { get; set; }
    }
}
