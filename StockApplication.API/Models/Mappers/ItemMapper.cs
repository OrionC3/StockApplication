using StockApplication.API.Entities;
using StockApplication.API.Models.Dtos;
using System.Runtime.CompilerServices;

namespace StockApplication.API.Models.Mappers
{
    public static class ItemMapper
    {
        public static ItemDto ToDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Category = item.Category,
                IpAddress = item.NetworkSpec?.IpAddress ?? "No IP"
            };
        }
        public static Item ToEntity(this ItemCreateDto dto)
        {
            return new Item
            {
                Name = dto.Name,
                Category = dto.Category,
                NetworkSpec = new NetworkSpecs
                {
                    IpAddress = dto.IpAddress,
                    MacAddress = dto.MacAddress,
                    IpMask = dto.IpMask,
                    IpGateway = dto.IpGateway,
                    VlanId = dto.VlanId,
                    IsStatic = dto.IsStatic,
                },


                HardwareSpec = new HardwareSpecs
                {
                    Cpu = dto.Cpu,
                    Ram = dto.Ram,
                    Storage = dto.Storage,
                    GraphicCard = dto.GraphicCard,
                    Allimentation = dto.Allimentation,
                }
            };
        }
    }
}
