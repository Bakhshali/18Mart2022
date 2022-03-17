using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack
{
    abstract class Vehicle
    {
        public string Marka;
        public double Price;
        public int MaxSpeed;

        public Vehicle(string marka,double price,int speed)
        {
            Marka = marka;
            Price = price;
            MaxSpeed = speed;
        }


        public abstract void FuelType();

        
        public abstract void Region();

        





        

    }
}
