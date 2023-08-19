﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class CarRequestConfiguration : IEntityTypeConfiguration<CarRequest>
    {
        public void Configure(EntityTypeBuilder<CarRequest> entity)
        {
            entity.HasKey(e => new { e.BeneficiaryId, e.RequestId });

            entity.ToTable("CarRequest");

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

            entity.Property(e => e.DepartureAddress)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DestinationAddress)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.DepartureDate)
            .IsRequired();

            entity.Property(e => e.RetrunDate)
            .IsRequired();

            entity.Property(e => e.LuggageDescription)
            .IsRequired();

            entity.Property(e => e.AttachmentPath)
            .HasMaxLength(500);

            entity.Property(e => e.CarType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("datetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("datetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);



            entity.HasOne(d => d.Request).WithMany(p => p.CarRequests)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CarRequest_Request");

            entity.HasOne(d => d.Department).WithMany(p => p.CarRequests)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CarRequest_Department");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CarRequest> entity);
    }
}
