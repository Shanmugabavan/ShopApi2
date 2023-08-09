using ShopAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Domain
{
    public class Order: BaseShopEntity
    {
        public string Address { get; set; }
        public int CartId { get; set; }
    }
}
