using ItemsAndContainersManagement.Core.Interfaces;

namespace ItemsAndContainersManagement.Core.Model
{
    public class ContainerType : IEntity
    {
        //name desc
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
