﻿
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> entity)
        {

            entity.ToTable(nameof(Attachment));

            entity.Property(e => e.Id)
            .UseIdentityColumn();

            entity.Property(e => e.FilePath)
            .IsRequired();

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);

            entity.HasOne(d => d.Request).WithMany(p => p.Attachments)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Attachment_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Attachment> entity);
    }
}
