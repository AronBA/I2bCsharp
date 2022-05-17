using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2bCsharp
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));
        }
        static int Points(int levels)
        {
            int points = 0;
            for (int i = 1; i <= levels; i++)
            {
                points = points + i;
              
            }
            return points;
        }
    }
}