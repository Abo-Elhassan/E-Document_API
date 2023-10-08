﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EDocument_EF.Configurations
{
    public partial class DefinedApplicationConfiguration : IEntityTypeConfiguration<DefinedApplication>
    {
        public void Configure(EntityTypeBuilder<DefinedApplication> entity)
        {
         
            entity.ToTable(nameof(DefinedApplication), tb => tb.HasTrigger($"TR_{nameof(AuditDefinedApplication)}"));

            entity.Property(e => e.Id)
            .UseIdentityColumn(1, 1);

            entity.Property(e => e.ApplicationName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.ApplicationOwnerId)
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


            entity.HasOne(d => d.ApplicationOwner).WithMany(p => p.OwnedApplications)
            .HasForeignKey(d => d.ApplicationOwnerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_DefinedApplication_User");

            entity.HasMany(d => d.ItAdmins).WithMany(p => p.ManagedApplications)
           .UsingEntity<Dictionary<string, object>>(
               "ApplicationItAdmin",
               r => r.HasOne<User>().WithMany()
                   .HasForeignKey("ItAdminId")
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_ApplicationItAdmin_User"),
               l => l.HasOne<DefinedApplication>().WithMany()
                   .HasForeignKey("ApplicationId")
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_ApplicationItAdmin_DefinedApplication"),
               j =>
               {
                   j.HasKey("ItAdminId", "ApplicationId");
                   j.ToTable("ApplicationItAdmin");
                   j.IndexerProperty<string>("ItAdminId")
                       .HasMaxLength(50);
                   j.IndexerProperty<long>("ApplicationId");
               });



            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DefinedApplication> entity);
    }
}
