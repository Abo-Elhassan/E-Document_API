﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class VoucherRequestConfiguration : IEntityTypeConfiguration<VoucherRequest>
    {
        public void Configure(EntityTypeBuilder<VoucherRequest> entity)
        {
            entity.HasKey(e => new { e.BeneficiaryName, e.RequestId });

            entity.ToTable(nameof(VoucherRequest));


            entity.Property(e => e.VoucherCurrency)
            .HasConversion<string>();

            entity.Property(e => e.InvoiceDate)
            .HasColumnType("date");

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithOne(p => p.VoucherRequest)
            .HasForeignKey<VoucherRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_VoucherRequest_Request");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VoucherRequest> entity);
    }
}
