
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class ApplicationUserRequestConfiguration : IEntityTypeConfiguration<ApplicationUserRequest>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRequest> entity)
        {
            entity.HasKey(e => new { e.BeneficiaryId, e.RequestId });

            entity.ToTable(nameof(ApplicationUserRequest));

            entity.Property(e => e.BeneficiaryId)
            .IsRequired()
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

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);

            entity.HasOne(d => d.Request).WithOne(p => p.ApplicationUserRequest)
            .HasForeignKey<ApplicationUserRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_ApplicationUserRequest_Request");



            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ApplicationUserRequest> entity);
    }
}
