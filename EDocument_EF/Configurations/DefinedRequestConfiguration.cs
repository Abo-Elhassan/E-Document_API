﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class DefinedRequestConfiguration : IEntityTypeConfiguration<DefinedRequest>
    {
        public void Configure(EntityTypeBuilder<DefinedRequest> entity)
        {
            entity.ToTable(nameof(DefinedRequest), tb => tb.HasTrigger($"TR_{nameof(AuditDefinedRequest)}"));
          

            entity.Property(e => e.Id)
            .UseIdentityColumn(1, 1);

            entity.Property(e => e.RequestName)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.RouteName)
            .IsRequired()
            .HasMaxLength(50);

            

            entity.Property(e => e.ReviewersNumber)
            .IsRequired();

            entity.Property(e => e.CreatedAt)
           .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Department).WithMany(p => p.DefinedRequests)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_DefinedRequest_Department");

          
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DefinedRequest> entity);
    }
}
