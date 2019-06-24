using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileApp.Data.EF.Extensions;
using NTMobileApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .IsUnicode(false).HasMaxLength(50);
            // etc.
        }
    }
}
