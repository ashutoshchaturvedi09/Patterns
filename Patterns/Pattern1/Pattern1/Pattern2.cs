using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Pattern2
    {
        /*
         11111
         22222
         33333
         44444
         55555
             */
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
