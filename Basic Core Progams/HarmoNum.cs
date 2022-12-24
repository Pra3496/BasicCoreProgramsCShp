using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class HarmoNum
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Please enter range for Harmonics");
            double range = Convert.ToInt32(Console.ReadLine());
            double value = 1;
            for (double n = 1; n <= range; n++)
            {
                value = value + (1 / value);
            }
            Console.WriteLine("The harmonic series of number is:" + value);
        }
    }
}
