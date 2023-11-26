﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class ReschedulePmWoRequestConfiguration : IEntityTypeConfiguration<ReschedulePmWoRequest>
    {
        public void Configure(EntityTypeBuilder<ReschedulePmWoRequest> entity)
        {

            entity.ToTable(nameof(ReschedulePmWoRequest), tb => tb.HasTrigger($"TR_{nameof(AuditReschedulePmWoRequest)}"));

            entity.HasKey(e => e.RequestNumber);

            entity.Property(e => e.RequestNumber)
            .HasMaxLength(50)
            .ValueGeneratedNever();

            entity.Property(e => e.RequesterSection)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.WoNumber)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.RescheduleFrom)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.RescheduleTo)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithOne(p => p.ReschedulePmWoRequest)
            .HasForeignKey<ReschedulePmWoRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_ReschedulePmWoRequest_Request");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ReschedulePmWoRequest> entity);
    }
}
