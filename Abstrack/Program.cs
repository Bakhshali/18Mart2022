using System;

namespace Abstrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship("L-imo76583",2.000000,200,"Old");
            Plane plane = new Plane("Army", 500.000, 100, 747);
            
            Console.WriteLine(ship.getInfo());
            ship.FuelType();
            ship.Region();

            Console.WriteLine(plane.keepInfo());
            plane.FuelType();
            plane.Region();

            

        }
    }
}
