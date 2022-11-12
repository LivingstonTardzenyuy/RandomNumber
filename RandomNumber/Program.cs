using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
          //  int min = int.Parse(Console.ReadLine("enter the min number:"));
            //int max = int.Parse(Console.ReadLine("enter the max number:"));
            for (int i=0; i<=20;i++)

            {
                int number = rand.Next(100) + 1;
                Console.WriteLine("the random number are:{0}", number);
                

            }
            Console.ReadKey();
        }
    }
}
