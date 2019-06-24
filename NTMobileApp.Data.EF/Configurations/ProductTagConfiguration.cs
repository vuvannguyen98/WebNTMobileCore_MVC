using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileApp.Data.EF.Extensions;
using NTMobileApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasMaxLength(50).IsUnicode(false);
            // etc.
        }
    }
}
