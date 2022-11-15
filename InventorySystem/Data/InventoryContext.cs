using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryItem> InventoryItems { get; set; }
    }

    public class InventoryItem
    { 
        public int InventoryItemID { get; set; }
        public string? ItemName { get; set; }
        public string? ImagePath { get; set; }
    }
}