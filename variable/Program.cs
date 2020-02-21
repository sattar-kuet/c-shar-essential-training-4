using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int globe = 10;   
            {
                globe = 20;
                int asia = 5;
                {
                    int bd = 2;

                    Console.WriteLine(bd);
                }
               

            }
           


        }
    }
}
