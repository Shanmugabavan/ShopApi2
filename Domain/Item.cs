using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain.Common;

namespace ShopAPI.Domain
{
    public class Item : BaseShopEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

    }
}
