using ShopAPI.Domain.Common;
using ShopAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Infrastructure.Persistence.DatabaseContext
{
    public class ShopContext : DbContext
    {

        public ShopContext(DbContextOptions<ShopContext> options2) : base(options2)
        {
            
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseShopEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {

            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
