using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ShopAPI.Domain.Common;

namespace ShopAPI.Domain
{
    public class Cart : BaseShopEntity
    {
        [JsonIgnore]
        public List<Item> Items { get; set; }=new List<Item>();
    }
}
