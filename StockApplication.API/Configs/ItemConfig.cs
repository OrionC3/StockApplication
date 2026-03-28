using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApplication.API.Entities;

namespace StockApplication.API.Configs
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(i => i.Category)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasOne(i => i.NetworkSpec)
                .WithOne(n => n.Item)
                .HasForeignKey<NetworkSpecs>(n => n.ItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
