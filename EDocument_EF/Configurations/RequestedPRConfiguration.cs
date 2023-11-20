using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDocument_EF.Configurations
{
    public partial class RequestedPrConfiguration : IEntityTypeConfiguration<RequestedPr>
    {
        public void Configure(EntityTypeBuilder<RequestedPr> entity)
        {
            entity.HasKey(e => e.RequestedPrId);

          
            entity.ToTable(nameof(RequestedPr), tb => tb.HasTrigger($"TR_{nameof(RequestedPr)}"));

            entity.Property(e => e.RequestedPrId)
            .UseIdentityColumn(1, 1);


            entity.Property(e => e.PrNumber)
            .HasMaxLength(50);



            entity.Property(e => e.RequestType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.PrDescription)
            .IsRequired();

            entity.Property(e => e.ItemNumber)
            .HasMaxLength(50);

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


            entity.HasOne(d => d.Request).WithMany(p => p.RequestedPrs)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_RequestedPr_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RequestedPr> entity);
    }
}
