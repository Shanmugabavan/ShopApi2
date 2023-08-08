using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Domain
{
    public class Cart
    {
        public int Id { get; set; }
        public string? Status { get; set; }
        public List<Item> Items { get; set; }=new List<Item>();
    }
}
