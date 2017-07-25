using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
    public class ItemType : Entity<int>
    {
        public string Name { get; private set; }

        public ItemType(int id)
            : base(id) { }
        public ItemType() { }
    }
}
