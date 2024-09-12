using CommerceProject.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CommerceProject.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(p=> p.Name).IsRequired();
            builder.Property(p=> p.price).HasDefaultValue(0.01M).HasColumnType("decimal(18,2)").IsRequired();

            builder.HasMany(C => C.ProductCategories).WithOne(C => C.product).HasForeignKey(C => C.productId);
            builder.ToTable("Products");
        }
    }
}
