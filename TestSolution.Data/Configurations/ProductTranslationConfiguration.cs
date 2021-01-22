using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestSolution.Models;

namespace TestSolution.Configurations
{
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.SeoTitle).IsRequired();
            builder.Property(x => x.SeoDescription).IsRequired();
            builder.Property(x => x.languageId).IsUnicode(false).HasMaxLength(5);
            builder.HasOne(x => x.product).WithMany(x => x.productTranslations).HasForeignKey(x => x.productId);
            builder.HasOne(x => x.language).WithMany(x => x.productTranslations).HasForeignKey(x => x.languageId);
        }
    }
}
