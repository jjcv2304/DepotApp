using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Core.Model;

namespace StockManagement.Data
{
    public class StockContext : DbContext
    {

        public StockContext() : base("name=ItemAndContainerContext")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<ContainerType> ContainerTypes { get; set; }
    }
}
