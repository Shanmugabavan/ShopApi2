using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Domain;

namespace ShopAPI.Data
{
    public class ShopAPIContext : DbContext
    {
        public ShopAPIContext (DbContextOptions<ShopAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ShopAPI.Domain.Item> Item { get; set; } = default!;
        public DbSet<ShopAPI.Domain.Cart> Cart { get; set; } = default!;
        
    }
}
