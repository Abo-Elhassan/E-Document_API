using EDocument_Data.Models;
using EDocument_Data.Models.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDocument_EF.Configurations
{
    public partial class RequestedItemConfiguration : IEntityTypeConfiguration<RequestedItem>
    {
        public void Configure(EntityTypeBuilder<RequestedItem> entity)
        {
            entity.HasKey(e => e.RequestedItemId);

          
            entity.ToTable(nameof(RequestedItem), tb => tb.HasTrigger($"TR_{nameof(RequestedItem)}"));

            entity.Property(e => e.RequestedItemId)
            .UseIdentityColumn(1, 1);

            entity.Property(e => e.ItemNumber)
           .HasMaxLength(50);

            entity.Property(e => e.BudgetType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.CommodityCode)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.StoreRoom)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.Unit)
             .IsRequired()
             .HasMaxLength(50);

            entity.Property(e => e.ItemDescription)
            .IsRequired();

            entity.Property(e => e.EquipmentType)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(e => e.PartNumber)
            .HasMaxLength(50);

            entity.Property(e => e.Manufacturing)
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


            entity.HasOne(d => d.Request).WithMany(p => p.RequestedItems)
            .HasForeignKey(d => d.RequestId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_RequestedItem_Request");


            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RequestedItem> entity);
    }
}
