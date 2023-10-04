
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml;

namespace EDocument_EF.Configurations
{
    public partial class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {

            
            entity
            .Property(e => e.Id)
            .HasMaxLength(50)
            .ValueGeneratedNever();


            entity.Property(e => e.UserName)
            .IsRequired(false)
            .HasMaxLength(50);

            entity.Property(e => e.NormalizedUserName)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.Email)
            .HasMaxLength(200);

            entity.Property(e => e.NormalizedEmail)
            .HasMaxLength(200);

            entity.Property(e => e.PhoneNumber)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.Company)
            .HasMaxLength(200);

            entity.Property(e => e.ManagerId)
            .IsRequired(false)
            .HasMaxLength(50);

            entity.Property(e => e.SectionId)
            .IsRequired(false);

            entity.Property(e => e.DepartmentId)
            .IsRequired(false);

            entity.Property(e => e.FullName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.Position)
            .HasMaxLength(200);

            entity.Property(e => e.LastLogin)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.Property(e => e.IsActive)
                .HasDefaultValue(true);

            entity.Property(e => e.EmailConfirmed)
                .HasDefaultValue(value: false);

            entity.Property(e => e.PhoneNumberConfirmed)
                .HasDefaultValue(false);

            entity.Property(e => e.TwoFactorEnabled)
                .HasDefaultValue(false);

            entity.Property(e => e.LockoutEnabled)
                .HasDefaultValue(false);

            entity.Property(e => e.AccessFailedCount)
                .HasDefaultValue(value: 0);

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_User_Department");

            entity.HasOne(d => d.Section).WithMany(p => p.Employees)
            .HasForeignKey(d => d.SectionId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_User_Section");

            entity.HasOne(d => d.Manager).WithMany(p => p.ManagedEmployees)
            .HasForeignKey(d => d.ManagerId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_User_User");



            OnConfigurePartial(entity);
        }


        partial void OnConfigurePartial(EntityTypeBuilder<User> entity);
    }
}
