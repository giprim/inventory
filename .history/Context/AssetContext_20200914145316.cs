using Microsoft.EntityFrameworkCore;

namespace inventory.Context
{
    public class AssetContext : DbContext
    {
        public AssetContext(DbContextOptions<AssetContext> options): base(options){

        }

        public DbSet<AssetContext> Asset
    }
}