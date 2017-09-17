using ItemsAndContainersManagement.Core.Interfaces;

namespace ItemsAndContainersManagement.Core.Model
{
    public class Container: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double MaxWeight { get; set; }
        public int ContainerParentId { get; set; }
        //Todo investigate if better to point to childs or to parent
        public Container ContainerParent { get; set; }
        public ContainerType ContainerType { get; set; }
        public int ContainerTypeId { get; set; }

    }
}
