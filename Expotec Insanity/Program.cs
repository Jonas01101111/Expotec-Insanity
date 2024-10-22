using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expotec_Insanity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] pos = { 
            { 0,0 },{ 0, 1}, { 0, 2,},
            { 1,0 },{ 1, 1}, { 1, 2},
            { 2,0 },{ 2, 1}, { 2, 2}};
            int[,] charpos = { {0,0} };

            foreach (var item in pos)
            {
                Console.Write(item.ToString());
            }



            Console.ReadKey();
        }
    }
}
