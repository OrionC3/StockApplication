using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace StockApplication.API.Models.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string IpAddress { get; set; }
    }
}
