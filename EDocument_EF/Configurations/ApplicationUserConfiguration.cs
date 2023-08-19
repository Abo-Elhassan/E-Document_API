
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml;

namespace EDocument_EF.Configurations
{
    public partial class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> entity)
        {

            entity.ToTable("User");
            entity
            .Property(e => e.Id)
            .HasMaxLength(50);

            entity.Ignore(e => e.EmailConfirmed);
            entity.Ignore(e => e.PhoneNumberConfirmed);
            entity.Ignore(e => e.TwoFactorEnabled);

            entity.Property(e => e.UserName)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.NormalizedUserName)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.Email)
            .HasMaxLength(200);

            entity.Property(e => e.NormalizedEmail)
            .HasMaxLength(200);

            entity.Property(e => e.PhoneNumber)
            .HasMaxLength(50);


            entity.Property(e => e.DepartmentName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.Company)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.ManagerId)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.FullName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.Position)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("datetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("datetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(50);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_User_Department");

            entity.HasOne(d => d.Manager).WithMany(p => p.ManagedEmployees)
            .HasForeignKey(d => d.ManagerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_User_User");

            entity.HasMany(d => d.ReviewingRequests).WithMany(p => p.Reviewers)
            .UsingEntity<Dictionary<string, object>>(
                "RequestReviewer",
                r => r.HasOne<Request>().WithMany()
                    .HasForeignKey("RequestId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RequestReviewer_Request"),
                l => l.HasOne<ApplicationUser>().WithMany()
                    .HasForeignKey("ReviewerId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RequestReviewer_User"),
                j =>
                {
                    j.HasKey("ReviewerId", "RequestId");
                    j.ToTable("RequestReviewer");
                    j.IndexerProperty<string>("ReviewerId")
                        .HasMaxLength(50);
                    j.IndexerProperty<long>("RequestId");
                });

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ApplicationUser> entity);
    }
}
