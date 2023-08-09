using ShopAPI.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain;
using ShopAPI.Infrastructure.Persistence.DatabaseContext;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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

        public async Task RemoveItemFromCart(int itemId,int cartId)
        {
            string sql = "UPDATE [db_shop_clean3].[dbo].[Items] SET [CartId] = Null WHERE CartId = @cartId AND Id=@itemId";
            await _context.Database.ExecuteSqlRawAsync(sql, new SqlParameter("@cartId", cartId),new SqlParameter("@itemId",itemId));

        }
    }
}
