﻿using KratomShop.Data;
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

        public async Task AddItemAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }

        //remove
        public async Task RemoveItemAsync(Guid id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item != null)
            {
                _context.Items.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddNewOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        //add review
        public async Task AddReviewAsync(Review review)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }

        //remove review
        public async Task RemoveReviewAsync(Guid id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            }
        }


    }
}
