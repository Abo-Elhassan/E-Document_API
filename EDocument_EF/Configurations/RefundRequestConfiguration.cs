﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EDocument_EF.Configurations
{
    public partial class RefundRequestConfiguration : IEntityTypeConfiguration<RefundRequest>
    {
        public void Configure(EntityTypeBuilder<RefundRequest> entity)
        {
   
            entity.ToTable(nameof(RefundRequest), tb => tb.HasTrigger($"TR_{nameof(AuditRefundRequest)}"));

            entity.HasKey(e => e.RequestNumber);

            entity.Property(e => e.RequestNumber)
            .HasMaxLength(50)
            .ValueGeneratedNever();


            entity.Property(e => e.ConcernedEmployeeId)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.ConcernedEmployeeName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.CustomerName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.CustomerMobileNumber)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.RefundSubject)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.RefundType)
            .IsRequired()
            .HasMaxLength(50);


            entity.Property(e => e.ShipmentType)
            .HasMaxLength(50);

            entity.Property(e => e.DocumentNumber)
            .IsRequired()
            .HasMaxLength(50);
            
            
            entity.Property(e => e.Amount)
            .HasMaxLength(50);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithOne(p => p.RefundRequest)
            .HasForeignKey<RefundRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_RefundRequest_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RefundRequest> entity);
    }
}
