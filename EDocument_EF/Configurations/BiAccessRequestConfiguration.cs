
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class BiAccessRequestConfiguration : IEntityTypeConfiguration<BiAccessRequest>
    {
        public void Configure(EntityTypeBuilder<BiAccessRequest> entity)
        {
            entity.HasKey(e => new { e.BeneficiaryId, e.RequestId });

            entity.ToTable("BiAccessRequest");

            entity.Property(e => e.BeneficiaryId)
            .HasMaxLength(50);

            entity.Property(e => e.BeneficiaryDepartment)
            .HasMaxLength(200);

            entity.Property(e => e.BeneficiaryEmail)
            .HasMaxLength(50);

            entity.Property(e => e.BeneficiaryName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.BeneficiaryPostion)
            .HasMaxLength(200);

            entity.Property(e => e.BeneficiaryPhone)
            .HasMaxLength(50)
            .IsRequired();

            entity.Property(e => e.BeneficiaryExtention)
            .HasMaxLength(50);

            entity.Property(e => e.RequesterPurpose)
            .IsRequired();

            entity.Property(e => e.CreatedAt)
            .HasColumnType("datetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("datetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);

            entity.HasOne(d => d.Request).WithMany(p => p.BiAccessRequests)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_BiAccessRequest_Request");

            entity.HasOne(d => d.Department).WithMany(p => p.BiAccessRequests)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_BiAccessRequest_Department");



            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BiAccessRequest> entity);
    }
}
