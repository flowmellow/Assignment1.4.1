//Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2.
//Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates.
//( if p1.x is more than p2.x , it is to the right )

using System.Runtime.InteropServices;

namespace Assignment1._4._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            if (point1.x == point2.x)
            {
                Console.WriteLine("The points are on the same axis:");
            }
            else
            {
                Console.WriteLine("The points are not on the same axis");
            }
        }
        public struct Point
        {
            public double x;
            public double y;

        }

    }
}
