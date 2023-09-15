
using EDocument_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml;

namespace EDocument_EF.Configurations
{
    public partial class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> entity)
        {
            entity.ToTable(nameof(Section));

            entity.Property(e => e.Id)
            .ValueGeneratedNever();

            entity.Property(e => e.HeadId)
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

            entity.HasOne(d => d.Department).WithMany(p => p.Sections)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Section_Department");

            entity.HasOne(d => d.Head).WithOne(p => p.MangedSection)
            .HasForeignKey<Section>(d => d.HeadId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Section_User");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Section> entity);
    }
}
