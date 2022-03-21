using System;
using System.Collections.Generic;
using System.Text;

namespace _23MartTask
{
    internal class Car:Vehicle
    {
        public Car(double FuelFor1km , double CurrentFuel, double FuelCapacity , double Millage)
        {
            this.FuelCapacity = FuelCapacity;
            this.CurrentFuel = CurrentFuel;
            this.FuelFor1km = FuelFor1km;
            this.Millage = Millage;

        }
        private double _fuelCapacity;
        private double _currentFuel;
        private double _fuelFor1km;
        private double _km;
        Car [] cars =new Car [0];

        public double Km
        {
            get { return _km; }

            set
            {
                if (value >=0)
                {
                    this._km = value;
                }
            }
        }


        public double FuelCapacity
        {
            get=> _fuelCapacity;
            set
            {
                if (value >= 0)
                {
                    _fuelCapacity = value;
                }
            }
        }
        public double CurrentFuel
        {
            get => _currentFuel;
            set
            {
                if (value >= 0)
                {
                  _currentFuel = value;
                }
                

                
            }
        }
        public double FuelFor1km
        {
            get => _fuelFor1km;
            set
            {
                if (value>=0)
                {
                    _fuelFor1km = value;
                }
            }
        }

        public override void Drive()
        {
            if (CurrentFuel <= FuelCapacity)
            {

            
                if (CurrentFuel / FuelFor1km >= Km)
                {
                    Millage += Km;
                    CurrentFuel -= FuelFor1km * Km;
                }
                else
                    Console.WriteLine("Bu yol gedile bilmez");
            }else
                Console.WriteLine("CurrentFuel FuelCapacityden cox ola bilmez");

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Millage {this.Millage} CurrentFuel - {this.CurrentFuel} "); 
        }
        public string CheckInfo()
        {
            return ($"Color - {this.Color} Brand - {this.Brand} Millage- {this.Millage} CurrentFuel - {this.CurrentFuel}");
        }
        public Vehicle[] AddCar(Car car)
        {
           
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
            

            return cars;
        }

    }
}
