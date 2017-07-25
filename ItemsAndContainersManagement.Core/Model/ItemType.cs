using ItemsAndContainersManagement.Core.Interfaces;

namespace ItemsAndContainersManagement.Core.Model
{
    public class ItemType : IEntity
    {
        //todo use oo technics
        //Name desc
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
