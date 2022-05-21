using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Pattern
    {
        int x = 2;
        static void Main(string[] args)
        {
            int row, column;
            Pattern pat = new Pattern();
            
            for (row=1; row <= 4; row++)
            {
                for(column = 1; column <= 6; column++)
                {
                    if (row % 2 == 1 && column == 3 || row % 2 == 1 && column == 4)
                    {
                        Console.Write("#");
                    }
                    else if (row % 2 == 1)
                    {
                        Console.Write("*");
                    };

                    if (row % 2 == 0 && column == 3 || row % 2 == 0 && column == 4 )
                    {
                        Console.Write("*");
                    }
                    else if (row % 2 == 0)
                    {
                        Console.Write("#");
                    };    
                }
                Console.WriteLine();
            }

        }

    }
}
