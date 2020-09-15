using System.Collections.Generic;
namespace inventory.Models
{
    public class Inventory
    {
        public int InventoryId {get;set;}
        
        public int StaffId {get; set;}
        public List<Staff> Staff {get; set;}
        public int AssetId {get; set;}
        public List<Asset> Asset {get;set;}
    }
}