using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
               //calculate the area 
               Console.WriteLine("Enter the length, width, height to get the area and volume");

               Console.WriteLine("Length : ");
               int length = int.Parse(Console.ReadLine());

               Console.WriteLine("Width : ");
               int width = int.Parse(Console.ReadLine());

               Console.WriteLine("Height : ");
               int height = int.Parse(Console.ReadLine());


               var area = length * width;
               var volume = length * width * height;

               Console.WriteLine("Area is: " + area + " and Volume is: " + volume);

               Console.ReadKey();

            

        }
    }
}
