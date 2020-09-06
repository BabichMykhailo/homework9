using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase.item.Add(new Raw("50kg","Sand"));
            foreach(var i in DataBase.item)
            {
                Console.WriteLine(i.Name);
            }
            DataBase.item.Add(new Furniture("Ikea","Sofa"));
            foreach (var i in DataBase.item)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();
        }
    }
}
