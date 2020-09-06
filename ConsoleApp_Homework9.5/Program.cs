using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Homework9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flower> flowers = new List<Flower>();
            double Sum = 0;
            flowers.Add(new Rose());
            flowers.Add(new Rose());
            flowers.Add(new Rose());
            flowers.Add(new Tulip());
            flowers.Add(new Carnation());
            foreach(var i in flowers)
            {
                Sum += i.Price;
            }
            Console.WriteLine("Price of bucket flowers " + Sum);
            Console.ReadLine();
        }
    }
}
