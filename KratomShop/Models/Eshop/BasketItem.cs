using KratomShop.Models.Database;

namespace KratomShop.Models.Eshop
{
    public class BasketItem
    {
        public Item Item { get; set; } = null!;
        public int Quantity { get; set; } = 1;
    }
}
