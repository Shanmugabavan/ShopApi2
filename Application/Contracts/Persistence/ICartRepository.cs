using ShopAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Contracts.Persistence
{
    public interface ICartRepository : IShopRepositoryGeneric<Cart>
    {
        Task CreateCart(Cart cart);
        Task AddItemToCart(int itemId,int cartId);
    }
}
