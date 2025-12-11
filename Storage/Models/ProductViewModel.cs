using Microsoft.AspNetCore.Mvc.Rendering;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; } // Price * Count

        //For filtering
        public string? SearchString { get; set; }
        public string? SelectedCategory { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; }

    }
}
