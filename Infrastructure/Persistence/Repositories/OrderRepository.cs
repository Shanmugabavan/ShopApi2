using Microsoft.EntityFrameworkCore;
using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Domain;
using ShopAPI.Infrastructure.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Infrastructure.Persistence.Repositories
{
    public class OrderRepository : GenericShopRepository<Order>, IOrderRepository
    {
        public OrderRepository(ShopContext context) : base(context)
        {
        }

        public async Task CreateOrder(Order order)
        {
            /*UpdateCartStatusAndItems(order.CartId);*/

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCartStatusAndItems(int Id)
        {
            // Find the cart by its ID
            List<Item> items = await _context.Items.ToListAsync();
            /*foreach (Item item in items)
            {
                if (item.Id==await _c)
            }*/
            /*foreach (var item in  (_context.Carts.FindAsync(cartId).Items))
            {
                item.Status = "Bought";
                _context.Entry(item).State = EntityState.Modified;
            }*/

            // Save changes to the database
            await _context.SaveChangesAsync();
        }
    }

}

