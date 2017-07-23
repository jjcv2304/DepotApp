using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
    public class ItemType : Entity<int>
    {
        //todo use oo technics
        //Name desc
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
