using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static int AreaMethodInt(int x, int y)
        {

            return x * y;
        }

        static int VolumeMethod(int x, int y, int z)
        {
            return x * y * z;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length, width, height to get the area and volume");

            Console.WriteLine("Length : ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Width : ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Height : ");
            int height = Convert.ToInt32(Console.ReadLine());

            int area = AreaMethodInt(length, width);
            Console.WriteLine("Area result : " + area);

            int volume = VolumeMethod(length, width, height);
            Console.WriteLine("Volume result : " + volume);
        }
    }
}
