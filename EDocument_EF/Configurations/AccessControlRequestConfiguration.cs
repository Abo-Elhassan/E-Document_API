using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDocument_EF.Configurations
{
    public partial class AccessControlRequestConfiguration : IEntityTypeConfiguration<AccessControlRequest>
    {
        public void Configure(EntityTypeBuilder<AccessControlRequest> entity)
        {
            entity.HasKey(e => e.RequestNumber);

          
            entity.ToTable(nameof(AccessControlRequest), tb => tb.HasTrigger($"TR_{nameof(AuditAccessControlRequest)}"));

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

            entity.Property(e => e.BeneficiaryExtention)
            .HasMaxLength(50);

            entity.Property(e => e.BeneficiaryCompany)
            .HasMaxLength(200);

            entity.Property(e => e.AccessedBlocks)
            .HasMaxLength(200);

            entity.Property(e => e.AccessMethods)
            .HasMaxLength(200);

            entity.Property(e => e.CreatedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.ModifiedAt)
            .HasColumnType("smalldatetime");

            entity.Property(e => e.CreatedBy)
            .HasMaxLength(200)
            .IsUnicode(false);

            entity.Property(e => e.ModifiedBy)
            .HasMaxLength(200)
            .IsUnicode(false);

            entity.HasOne(d => d.Request).WithOne(p => p.AccessControlRequest)
            .HasForeignKey<AccessControlRequest>(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_AccessControlRequest_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AccessControlRequest> entity);
    }
}
