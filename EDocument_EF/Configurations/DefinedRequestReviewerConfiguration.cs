﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class DefinedRequestReviewerConfiguration : IEntityTypeConfiguration<DefinedRequestReviewer>
    {
        public void Configure(EntityTypeBuilder<DefinedRequestReviewer> entity)
        {
            entity.HasKey(e => e.Key);


            entity.ToTable(nameof(DefinedRequestReviewer), tb => tb.HasTrigger($"TR_{nameof(AuditDefinedRequestReviewer)}"));


            entity.Property(e => e.AssignedReviewerId)
            .HasMaxLength(50)
            .IsRequired(false);

            entity.Property(e => e.StageName)
            .HasMaxLength(50);

            entity.Property(e => e.ReviewerType).HasConversion<string>()
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.DefinedRequest).WithMany(p => p.DefinedRequestReviewers)
            .HasForeignKey(d => d.DefinedRequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_DefinedRequestReviewer_DefinedRequest");

            entity.HasOne(d => d.Reviewer).WithMany(p => p.DefinedRequestReviewers)
            .HasForeignKey(d => d.AssignedReviewerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_DefinedRequestReviewer_User");





            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DefinedRequestReviewer> entity);
    }
}
