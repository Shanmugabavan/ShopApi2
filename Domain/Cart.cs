using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain.Common;

namespace ShopAPI.Domain
{
    public class Cart : BaseShopEntity
    {
        public List<Item> Items { get; set; }=new List<Item>();
    }
}
