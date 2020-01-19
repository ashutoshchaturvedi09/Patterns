using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Program
    {

        /*
         12345
         12345
         12345
         12345
         12345
             */
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
               
            }
        }
    }
}
