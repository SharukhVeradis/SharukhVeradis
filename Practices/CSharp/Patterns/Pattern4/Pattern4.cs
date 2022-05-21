using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int x, y, z;
            for (x = 1; x < 5; x++)
            {
                for(y = 2; y <= x; y++)

                {
                    Console.Write(" ");
                }
                
                for(z=5; z>x; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
            //Console.ReadLine();
        }

    }
}
