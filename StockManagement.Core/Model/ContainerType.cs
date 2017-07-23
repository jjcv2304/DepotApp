using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
    public class ContainerType : Entity<int>
    {
        //name desc
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
