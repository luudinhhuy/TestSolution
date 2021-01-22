using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestSolution.Models;

namespace TestSolution.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Caption).HasMaxLength(200);
            builder.Property(x => x.ImagePath).IsRequired(true);
            builder.HasOne(x => x.product).WithMany(x => x.images).HasForeignKey(x => x.productId);

        }
    }
}
