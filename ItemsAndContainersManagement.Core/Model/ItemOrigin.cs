using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemsAndContainersManagement.Core.Interfaces;

namespace ItemsAndContainersManagement.Core.Model
{
    public class ItemOrigin: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
