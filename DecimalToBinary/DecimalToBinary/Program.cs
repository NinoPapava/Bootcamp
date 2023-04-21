using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert decimal to binary
            Console.WriteLine("Decimal:");

            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;

            while(decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary : {0}", result);
            Console.ReadLine();

        }
    }
}
