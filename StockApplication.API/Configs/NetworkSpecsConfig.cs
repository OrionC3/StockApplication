using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApplication.API.Entities;

namespace StockApplication.API.Configs
{
    public class NetworkSpecsConfig : IEntityTypeConfiguration<NetworkSpecs>
    {
        public void Configure(EntityTypeBuilder<NetworkSpecs> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.IpAddress)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(n => n.IpMask)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(n => n.IpGateway)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(n => n.MacAddress)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(n => n.Item)
                .WithOne(i => i.NetworkSpec)
                .HasForeignKey<NetworkSpecs>(n => n.ItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
