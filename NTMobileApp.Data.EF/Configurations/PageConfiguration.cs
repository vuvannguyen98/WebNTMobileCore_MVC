﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileApp.Data.EF.Extensions;
using NTMobileApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileApp.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
