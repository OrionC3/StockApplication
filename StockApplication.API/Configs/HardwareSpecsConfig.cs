using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApplication.API.Entities;

namespace StockApplication.API.Configs
{
    public class HardwareSpecsConfig : IEntityTypeConfiguration<HardwareSpecs>
    {
        public void Configure(EntityTypeBuilder<HardwareSpecs> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Cpu)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(h => h.Ram)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(h => h.Storage)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(h => h.GraphicCard)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(h => h.Allimentation)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(i => i.Item)
                .WithOne(h => h.HardwareSpec)
                .HasForeignKey<HardwareSpecs>(n => n.ItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
