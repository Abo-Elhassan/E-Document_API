﻿using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDocument_Data.Models.Audit;

namespace EDocument_EF.Configurations
{
    public partial class EquipmentRequestInConfiguration: IEntityTypeConfiguration<EquipmentRequestIn>
    {

        public void Configure(EntityTypeBuilder<EquipmentRequestIn> entity)
        {

            entity.ToTable(nameof(EquipmentRequestIn), tb => tb.HasTrigger($"TR_{nameof(AuditEquipmentRequestIn)}"));

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

            entity.Property(e => e.CommunicationFacility)
            .IsRequired()
            .HasMaxLength(300);

            entity.Property(e => e.Additionaltools)
              .HasMaxLength(300);

            entity.Property(e => e.InConcessionArea)
            .IsRequired()
            .HasMaxLength(300);

            entity.Property(e => e.RequestedDateFrom)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.RequestedDateTo)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.Equipment)
            .IsRequired()
            .HasMaxLength(300);

           

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithOne(p => p.EquipmentRequestIn)
            .HasForeignKey<EquipmentRequestIn>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_EquipmentRequestIn_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EquipmentRequestIn> entity);
    }
}