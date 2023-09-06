﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class CarRequestConfiguration : IEntityTypeConfiguration<CarRequest>
    {
        public void Configure(EntityTypeBuilder<CarRequest> entity)
        {
            entity.HasKey(e => new { e.BeneficiaryId, e.RequestId });

            entity.ToTable(nameof(CarRequest));

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

            entity.Property(e => e.DepartureAddress)
            .HasConversion<String>()
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DestinationAddress)
            .HasConversion<String>()
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DepartureDate)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.RetrunDate)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.LuggageDescription)
            .IsRequired();

            entity.Property(e => e.VehicleType).HasConversion<string>()
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);



            entity.HasOne(d => d.Request).WithMany(p => p.CarRequests)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CarRequest_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CarRequest> entity);
    }
}
