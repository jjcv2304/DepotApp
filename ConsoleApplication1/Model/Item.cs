using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    class Item
    {
        //id name desc type, widht height weight
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
