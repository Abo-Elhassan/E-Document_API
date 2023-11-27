﻿using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDocument_EF.Configurations
{
    public partial class MultimediaRequestConfiguration : IEntityTypeConfiguration<MultimediaRequest>
    {
        public void Configure(EntityTypeBuilder<MultimediaRequest> entity)
        {
            entity.HasKey(e => e.RequestNumber);

          
            entity.ToTable(nameof(MultimediaRequest), tb => tb.HasTrigger($"TR_{nameof(MultimediaRequest)}"));

            entity.Property(e => e.RequestNumber)
            .HasMaxLength(50)
            .ValueGeneratedNever();

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

            entity.Property(e => e.BeneficiaryPosition)
            .HasMaxLength(200);

            entity.Property(e => e.BeneficiaryPhoneNumber)
            .HasMaxLength(50);

            entity.Property(e => e.BeneficiaryCompany)
            .HasMaxLength(200);

            entity.Property(e => e.RequestType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.ProjectDetails)
            .IsRequired()
            .HasMaxLength(1000);

            entity.Property(e => e.AnnouncementType)
            .HasMaxLength(50);

            entity.Property(e => e.DeliveryDate)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.EstimatedDeliveryDate)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200)
            .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200)
            .IsUnicode(false);


            entity.HasOne(d => d.Request).WithOne(p => p.MultimediaRequest)
            .HasForeignKey<MultimediaRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_MultimediaRequest_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MultimediaRequest> entity);
    }
}
