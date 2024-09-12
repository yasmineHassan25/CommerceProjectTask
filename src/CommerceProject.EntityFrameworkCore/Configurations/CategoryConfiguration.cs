using CommerceProject.Categories;
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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(C => C.Name).IsRequired();

            builder.HasMany(C => C.productcategories).WithOne(C => C.category).HasForeignKey(C=>C.categoryId);
            builder.ToTable("Categories");
        }
    }
}
