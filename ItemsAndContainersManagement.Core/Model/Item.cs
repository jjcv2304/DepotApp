using ItemsAndContainersManagement.Core.Interfaces;

namespace ItemsAndContainersManagement.Core.Model
{
     public class Item: IEntity 
    {
         public Item()
         {
             
         }

        //id name desc type, widht height weight
        public int Id { get; set; }
        public string Name { get; set; }
         public ItemType ItemType { get; set; }
        public string Description { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
