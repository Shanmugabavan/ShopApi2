using ShopAPI.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain;
using ShopAPI.Infrastructure.Persistence.DatabaseContext;

namespace ShopAPI.Infrastructure.Persistence.Repositories
{
    public class CartsRepository : GenericShopRepository<Cart>, ICartRepository
    {
        public CartsRepository(ShopContext context) : base(context)
        {
        }
        public async Task CreateCart(Cart cart)
        {

            _context.Carts.Add(new Cart());
            await _context.SaveChangesAsync();
        }

        public async Task AddItemToCart(int itemId, int cartID)
        {
            Item item = await _context.Items.FindAsync(itemId);
            Cart cart= await _context.Carts.FindAsync(cartID);
            cart.Items.Add(item);
            await _context.SaveChangesAsync();
            
        }
    }
}
