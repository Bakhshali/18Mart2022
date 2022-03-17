using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack
{
    internal class Ship:Vehicle
    {
        public string Sail;

        public Ship(string marka, double price, int speed, string sail):base(marka,price,speed)
        {
            Sail = sail;
        }
        public override void FuelType()
        {
            Console.WriteLine("Gas oil");
        }

        public override void Region()
        {
            Console.WriteLine("Sea"); 
        }

        public virtual string getInfo()
        {
            return $"Marka: {Marka},Price: {Price}, Speed: {MaxSpeed}, Sail: {Sail}";
        }



    }
}
