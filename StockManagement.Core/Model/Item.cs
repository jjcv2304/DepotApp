using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
     public class Item: Entity<int>
    {
        public string Name { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public ItemType ItemType { get; private set; }
        public int ItemTypeId { get; private set; }

        public Item(int id)
        {
            this.Id = id;
        }

        protected Item() //required for EF
        {
        }
    }
}
