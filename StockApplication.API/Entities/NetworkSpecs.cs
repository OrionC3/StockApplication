namespace StockApplication.API.Entities
{
    public class NetworkSpecs
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string? IpAddress { get; set; }
        public string? IpMask { get; set; }
        public string? IpGateway { get; set; }
        public string? MacAddress { get; set; }
        public string? VlanId { get; set; }
        public bool IsStatic { get; set; }

        public Item? Item { get; set; }
    }
}
