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
    public partial class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> entity)
        {
            entity.ToTable(nameof(Request) , tb=>tb.HasTrigger($"TR_{nameof(AuditRequest)}"));

            entity.HasIndex(e => e.CreatorId);

            entity.Property(e => e.Id)
            .ValueGeneratedNever();

            entity.Property(e => e.CreatorId)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.CurrentStage)
            .HasDefaultValue(1);

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

            entity.HasOne(d => d.Creator).WithMany(p => p.CreatedRequests)
            .HasForeignKey(d => d.CreatorId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Request_User");
           

            entity.HasOne(d => d.DefinedRequest).WithMany(p => p.Requests)
            .HasForeignKey(d => d.DefinedRequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Request_DefinedRequest");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Request> entity);
    }
}
