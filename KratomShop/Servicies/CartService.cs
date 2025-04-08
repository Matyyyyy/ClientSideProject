using KratomShop.Models.Database;
using KratomShop.Models.Eshop;

namespace KratomShop.Servicies
{
    public class CartService
    {
        public event Action OnChange = delegate { };

        private readonly List<BasketItem> _basketItems = new();

        public void AddToCart(Item item)
        {
            var existingItem = _basketItems.FirstOrDefault(i => i.Item.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _basketItems.Add(new BasketItem { Item = item, Quantity = 1 });
            }
            NotifyStateChanged(); // Trigger the event  
        }

        public void RemoveFromCart(Item item)
        {
            var existingItem = _basketItems.FirstOrDefault(i => i.Item.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Quantity--;
                if (existingItem.Quantity <= 0)
                {
                    _basketItems.Remove(existingItem);
                }
            }
            NotifyStateChanged(); // Trigger the event  
        }

        public List<BasketItem> GetCartItems()
        {
            return _basketItems;
        }

        public int GetTotalItemsCount()
        {
            return _basketItems.Sum(i => i.Quantity);
        }

        public decimal GetTotalPrice()
        {
            return _basketItems.Sum(i => i.Item.Price * i.Quantity);
        }

        public void ClearCart()
        {
            _basketItems.Clear();
            NotifyStateChanged(); // Trigger the event  
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
