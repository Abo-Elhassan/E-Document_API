﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class VehicleRequestConfiguration : IEntityTypeConfiguration<VehicleRequest>
    {
        public void Configure(EntityTypeBuilder<VehicleRequest> entity)
        {
          
            entity.ToTable(nameof(VehicleRequest), tb => tb.HasTrigger($"TR_{nameof(AuditVehicleRequest)}"));

            entity.HasKey(e => e.RequestNumber);

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

            entity.Property(e => e.BeneficiaryExtention)
            .HasMaxLength(50);

            entity.Property(e => e.DepartureAddress)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DestinationAddress)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DepartureDate)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ReturnDate)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.LuggageDescription)
            .IsRequired();

            entity.Property(e => e.VehicleType)
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



            entity.HasOne(d => d.Request).WithOne(p => p.VehicleRequest)
            .HasForeignKey<VehicleRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_VehicleRequest_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VehicleRequest> entity);
    }
}
