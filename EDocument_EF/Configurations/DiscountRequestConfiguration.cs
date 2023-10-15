﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EDocument_EF.Configurations
{
    public partial class DiscountRequestConfiguration : IEntityTypeConfiguration<DiscountRequest>
    {
        public void Configure(EntityTypeBuilder<DiscountRequest> entity)
        {
   
            entity.ToTable(nameof(DiscountRequest), tb => tb.HasTrigger($"TR_{nameof(AuditDiscountRequest)}"));

            entity.HasKey(e => e.RequestNumber);

            entity.HasIndex(e => e.DocumentNumber).IsUnique();
            entity.HasIndex(e => e.InvoiceNumber).IsUnique();

            entity.Property(e => e.RequestNumber)
            .HasMaxLength(50)
            .ValueGeneratedNever();


            entity.Property(e => e.CustomerType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.CustomerName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.CustomerName)
           .HasMaxLength(200);

            entity.Property(e => e.AgreementName)
           .HasMaxLength(200);

            entity.Property(e => e.LineName)
            .HasMaxLength(50);

            entity.Property(e => e.LineCode)
            .HasMaxLength(50);

            entity.Property(e => e.TaxId)
            .IsRequired(false);

            entity.Property(e => e.DocumentType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DocumentNumber)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.InvoiceNumber)
            .HasMaxLength(50);

            entity.Property(e => e.DiscountType)
            .IsRequired()
            .HasMaxLength(50);
            
            entity.Property(e => e.DiscountReason)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithOne(p => p.DiscountRequest)
            .HasForeignKey<DiscountRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_DiscountRequest_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DiscountRequest> entity);
    }
}