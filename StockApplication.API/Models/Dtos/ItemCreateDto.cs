namespace StockApplication.API.Models.Dtos
{
    public class ItemCreateDto
    {
        public string Name { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string? IpAddress { get; set; }
        public string? MacAddress { get; set; }
        public string? IpMask { get; set; }
        public string? IpGateway { get; set; }
        public string? VlanId { get; set; }
        public bool? IsStatic { get; set; }
        public string? Cpu { get; set; }
        public string? Ram { get; set; }
        public string? Storage { get; set; }
        public string? GraphicCard { get; set; }
        public string? Allimentation { get; set; }
    }
}
