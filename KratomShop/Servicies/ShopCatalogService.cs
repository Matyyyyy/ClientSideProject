using KratomShop.Data;
using KratomShop.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace KratomShop.Servicies
{
    public class ShopCatalogService
    {
        //ApplicationDbContext
        private readonly ApplicationDbContext _context;
        public ShopCatalogService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get all items
        public async Task<List<Item>> GetAllItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }

        //Get item by id
        public async Task<Item?> GetItemByIdAsync(Guid id)
        {
            return await _context.Items
                .Include(i => i.Reviews)
                    .ThenInclude(r => r.User)
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();
        }

    }
}
