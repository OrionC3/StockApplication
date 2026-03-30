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
    }
}
