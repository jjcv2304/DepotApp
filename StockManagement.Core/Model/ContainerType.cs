using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
    public class ContainerType : Entity<int>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ContainerType(int id)
            : base(id) { }
        public ContainerType() { }
    }
}
