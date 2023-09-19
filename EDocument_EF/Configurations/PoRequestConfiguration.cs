﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class PoRequestConfiguration : IEntityTypeConfiguration<PoRequest>
    {
        public void Configure(EntityTypeBuilder<PoRequest> entity)
        {
            entity.ToTable(nameof(PoRequest));

            entity.HasKey(p=>p.PoNumber).IsClustered(false);
            entity.HasIndex(p => p.RequestId).IsClustered();
            entity.HasIndex(p => p.VendorName);
            entity.HasIndex(p => p.InvoiceNumber);



            entity.Property(e => e.PoDescription)
            .IsRequired();
            
            entity.Property(e => e.VendorName)
            .IsRequired();
            
            entity.Property(e => e.VendorNumber)
            .IsRequired();
            
            entity.Property(e => e.InvoiceNumber)
            .IsRequired();
            
            
            entity.Property(e => e.PoAttachmentPath)
            .IsRequired();
            
            entity.Property(e => e.InvoiceAttachmentPath)
            .IsRequired();

            entity.Property(e => e.CreatedAt)
           .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);

            entity.HasOne(d => d.Request).WithOne(p => p.PoRequest)
            .HasForeignKey<PoRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PoRequest_Request");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PoRequest> entity);
    }
}
