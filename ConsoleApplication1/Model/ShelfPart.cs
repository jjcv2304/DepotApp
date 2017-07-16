using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    public class ShelfPart
    {
        //width height name (A4) location
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double MaxWeight { get; set; }

    }
}
