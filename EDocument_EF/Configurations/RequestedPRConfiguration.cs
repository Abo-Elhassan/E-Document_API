using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDocument_EF.Configurations
{
    public partial class RequestedPRConfiguration : IEntityTypeConfiguration<RequestedPR>
    {
        public void Configure(EntityTypeBuilder<RequestedPR> entity)
        {
            entity.HasKey(e => e.RequestedPRId);

          
            entity.ToTable(nameof(RequestedPR), tb => tb.HasTrigger($"TR_{nameof(RequestedPR)}"));

            entity.Property(e => e.RequestedPRId)
            .UseIdentityColumn(1, 1);

            entity.Property(e => e.RequestNumber)
            .HasMaxLength(50);


            entity.Property(e => e.PRNumber)
            .HasMaxLength(50);

            entity.Property(e => e.BudgetType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.RequestType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.PRDescription)
            .IsRequired();

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


            entity.HasOne(d => d.PRRequest).WithMany(p => p.RequestedPRs)
            .HasForeignKey(d => d.RequestNumber)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_RequestedPR_PRRequest");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RequestedPR> entity);
    }
}
