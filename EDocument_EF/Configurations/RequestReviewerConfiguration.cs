﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Consts.Enums;
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class RequestReviewerConfiguration : IEntityTypeConfiguration<RequestReviewer>
    {
        public void Configure(EntityTypeBuilder<RequestReviewer> entity)
        {
            entity.ToTable(nameof(RequestReviewer), tb => tb.HasTrigger($"TR_{nameof(AuditRequestReviewer)}"));

            entity.HasKey(e => e.Key)
            .IsClustered(false);

            entity.HasIndex(e => e.AssignedReviewerId)  
            .IsClustered();

            entity.Property(e => e.Key)
            .ValueGeneratedNever();

            entity.Property(e => e.AssignedReviewerId)
            .HasMaxLength(50);

            entity.Property(e => e.ReviewedBy)
            .HasMaxLength(200);


            entity.Property(e => e.ReviewerType).HasConversion<string>()
            .HasMaxLength(50);

            entity.Property(e => e.Status)
            .HasDefaultValue(RequestStatus.None.ToString())
            .HasMaxLength(50);


            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithMany(p => p.RequestReviewers)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_RequestReviewer_Request");

            entity.HasOne(d => d.Reviewer).WithMany(p => p.RequestReviewers)
            .HasForeignKey(d => d.AssignedReviewerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_RequestReviewer_User");



            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RequestReviewer> entity);
    }
}
