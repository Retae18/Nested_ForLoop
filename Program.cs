using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Hmwk
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;          //number of rows
            int column = 1;         //starting line

            for (int x = 1; x<= rows; x++)
            {
                for (int y=1; y<=x; y++)            //example of a nested forloop
                {
                    Console.Write(column + " ");        // Use .Write NOT WriteLine
                    column++;                           //increase column 
                }
                Console.Write("\n");        // ("\n") starts a new line after the first loop was executed
                

            }

            Console.ReadLine(); 



        }
    }
}
