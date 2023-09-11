using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Unesi vrijednost za x, y, z :");
            do
            {
                x = Convert.ToInt16(Console.ReadLine());
            } while (x <= 0);
            do
            {
                y = Convert.ToInt16(Console.ReadLine());
            } while (y <= 0); 
            do
            {
                z = Convert.ToInt16(Console.ReadLine());
            } while (z <= 0);

            if (z == Math.Sqrt((x * x + y * y)) || x == Math.Sqrt((z * z + y * y)) || y == Math.Sqrt((x * x + z * z)))
            {
                Console.WriteLine("Sve 3 stranice su dio pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Sve 3 stranice nisu dio pravokutnog trokuta.");
            }

            Console.ReadLine();
        }
    }
}
