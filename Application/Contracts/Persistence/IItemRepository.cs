using ShopAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Contracts.Persistence
{
    public interface IItemRepository : IShopRepositoryGeneric<Item>
    {
        /*Task<Item> GetItemWithDetails(int id);*/
        Task<List<Item>> GetItemsList();
    }
}
