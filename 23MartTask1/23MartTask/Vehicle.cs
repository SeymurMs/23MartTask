using System;
using System.Collections.Generic;
using System.Text;

namespace _23MartTask
{
    internal abstract class Vehicle
    {
        public string Color;
        public string Brand;
        private double _millage;

        public double Millage
        {
            get { return _millage; }
            set
            {
                if (value >=0)
                    _millage = value;
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color - {this.Color} Brand - {this.Brand}"); 
        }
        public abstract void Drive();
    }
}
