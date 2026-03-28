namespace StockApplication.API.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Category { get; set; } = null!;

        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }

        public string? Location { get; set; }
        public bool Status { get; set; }


        public NetworkSpecs? Network {  get; set; }
        public HardwareSpecs? Specs { get; set; }
    }
}
