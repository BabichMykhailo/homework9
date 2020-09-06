using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Homework9
{
    public class Furniture : Item
    {
        public string Manufacture { get; set; }

        public Furniture(string manufacture, string name)
        {
            Manufacture = manufacture;
            Name = name;
        }
    }
}
