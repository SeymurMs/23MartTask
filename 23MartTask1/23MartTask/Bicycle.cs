using System;
using System.Collections.Generic;
using System.Text;

namespace _23MartTask
{
    internal class Bicycle : Vehicle
    {
        private double _km;

        public double Km
        {
            get => _km;
            set
            {
                if (value>= 0)
                {
                    _km = value;
                }
            }
        }
        public override void Drive()
        {
            Millage+=Km;
        }
    }
}
