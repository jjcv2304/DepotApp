using Depot.SharedKernel;

namespace StockManagement.Core.Model
{
     public class Item: Entity<int>
    {
        public string FullName { get; private set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
         public Container Container { get; set; }

        public Item(int id)
        {
            this.Id = id;
        }

        protected Item() //required for EF
        {
        }
    }
}
