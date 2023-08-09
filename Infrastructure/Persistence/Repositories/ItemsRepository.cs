using ShopAPI.Domain;
using ShopAPI.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Domain;

namespace ShopAPI.Infrastructure.Persistence.Repositories
{
    public class ItemsRepository : GenericShopRepository<Item>, IItemRepository
    {
        public ItemsRepository(ShopContext context) : base(context)
        {
        }


        public async Task<List<Item>> GetItemsList()
        {
            var items = await _context.Items.AsNoTracking()
               .ToListAsync();
            return items;
        }

        public async Task AddItem(Item item)
        {
            
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }
    }
}
