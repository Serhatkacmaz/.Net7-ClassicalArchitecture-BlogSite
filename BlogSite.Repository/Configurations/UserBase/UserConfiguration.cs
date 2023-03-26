﻿using BlogSite.Core.Entities.UserBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Repository.Configurations.UserBase
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsUnicode().IsRequired().HasMaxLength(50);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Mail).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.User_ID)
                .OnDelete(DeleteBehavior.Restrict);

            int order = -1;

            builder.Property(p => p.Id).HasColumnOrder(++order);
            builder.Property(p => p.Name).HasColumnOrder(++order);
            builder.Property(p => p.UserName).HasColumnOrder(++order);
            builder.Property(p => p.Mail).HasColumnOrder(++order);
            builder.Property(p => p.Title).HasColumnOrder(++order);
            builder.Property(p => p.About).HasColumnOrder(++order);
            builder.Property(p => p.Image).HasColumnOrder(++order);
            builder.Property(p => p.Password).HasColumnOrder(++order);
            builder.Property(p => p.IsActive).HasColumnOrder(++order);
            builder.Property(p => p.CreatedDate).HasColumnOrder(++order);
            builder.Property(p => p.UpdatedDate).HasColumnOrder(++order);
            builder.Property(p => p.User_ID).HasColumnOrder(++order);
        }
    }
}