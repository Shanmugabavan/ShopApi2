using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain;

namespace ShopAPI.Application.Contracts.Persistence
{
    public interface IOrderRepository : IShopRepositoryGeneric<Order>
    {
        Task CreateOrder(Order order);
    }
}
