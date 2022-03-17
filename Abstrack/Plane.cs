using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack
{
    internal class Plane:Vehicle
    {
        public int WheelSize;

        public Plane(string marka, double price, int speed, int size) : base(marka, price, speed)
        {
            WheelSize = size;
        }
        public override void FuelType()
        {
            Console.WriteLine("Avgas 82UL");
        }

        public override void Region()
        {
            Console.WriteLine("Air");
        }

        public virtual string keepInfo()
        {
            return $"Marka: {Marka},Price: {Price}, Speed: {MaxSpeed}, Whee: {WheelSize}";
        }
    }
}
