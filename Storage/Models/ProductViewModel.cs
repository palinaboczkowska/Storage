namespace Storage.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; } // Price * Count
    }
}
