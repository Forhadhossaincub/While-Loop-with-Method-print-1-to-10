using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_with_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();

            Console.ReadKey();

        }

        public static void Print()
        {

            int i = 1;
            while (i <= 10)
            {
                Console.Write($" {i} \t");
                i = i + 1;
            }

      

        }
    }
}
