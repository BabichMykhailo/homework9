using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Homework9
{
    public class Raw : Item
    {
        public string Size { get; set; }

        public Raw (string size,string name)
        {
            Size = size;
            Name = name;
        }
    }
}
