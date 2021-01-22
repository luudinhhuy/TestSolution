using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestSolution.Models;

namespace TestSolution.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.categoryId, x.productId });
            
            builder.HasOne(x => x.category).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.categoryId);
            builder.HasOne(x => x.product).WithMany(pc => pc.productInCategories).HasForeignKey(pc => pc.productId);
        }
    }
}
