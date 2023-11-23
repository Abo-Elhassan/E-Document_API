using EDocument_Data.Models;
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
    public partial class EquipmentRequestOutConfiguration : IEntityTypeConfiguration<EquipmentRequestOut>
    {


        public void Configure(EntityTypeBuilder<EquipmentRequestOut> entity)
        {

            entity.ToTable(nameof(EquipmentRequestOut), tb => tb.HasTrigger($"TR_{nameof(AuditEquipmentRequestOut)}"));

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


            entity.Property(e => e.SupervisorId)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.SupervisorName)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(e => e.SupervisorPhoneNumber)
            .HasMaxLength(50);

            entity.Property(e => e.CommunicationFacility)
            .IsRequired()
            .HasMaxLength(300);

            entity.Property(e => e.Area)
            .IsRequired()
            .HasMaxLength(300);

            entity.Property(e => e.EquipmentType)
            .IsRequired()
            .HasMaxLength(300);


            entity.Property(e => e.RequestedDateFrom)
          .HasColumnType("smalldatetime");

            entity.Property(e => e.RequestedDateTo)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.Additionaltools)
                    .HasMaxLength(300);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200);

            entity.HasOne(d => d.Request).WithOne(p => p.EquipmentRequestOut)
            .HasForeignKey<EquipmentRequestOut>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_EquipmentRequestOut_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EquipmentRequestOut> entity);
    }
}
