using inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory.Context
{
    public class AssetContext : DbContext
    {
        public AssetContext(DbContextOptions<AssetContext> options): base(options){

        }

        public DbSet<Asset> Asset {get; set;}
        public DbSet<Staff> Staff {get; set;}
        public DbSet<Inventory> Inventories{get ;set;}
    }
}