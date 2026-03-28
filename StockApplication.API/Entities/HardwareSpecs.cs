namespace StockApplication.API.Entities
{
    public class HardwareSpecs
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string? Cpu { get; set; }
        public string? Ram { get; set; }
        public string? Storage { get; set; }
        public string? GraphicCard { get; set; }
        public string? Allimentation { get; set; }

        public Item? Item { get; set; }
    }
}
