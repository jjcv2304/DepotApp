using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
    public class Container : Entity<int>
    {
        //name desc type width height location(string) carefoull this info is also in shelfpart
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public ContainerType ContainerType { get; set; }
        public int ContainerTypeId { get; set; }

        public Container(int id)
            : base(id) { }
        public Container() { }
    }
}
