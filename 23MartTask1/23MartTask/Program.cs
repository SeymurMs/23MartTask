using System;

namespace _23MartTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Length;
            string LengthStr;

            Console.WriteLine("Nece Masin daxil edeceksiniz:");
            LengthStr =Console.ReadLine();
            Length = Convert.ToInt32(LengthStr);

            Car [] cars = new Car[Length];

            for (int i = 0; i < Length; i++)
            {
                string brand = GetInputStr($"Brandi daxil edin {i + 1}",2,20);

                string color = GetInputStr($"Rengi daxil edin{i + 1}",2,20);

                double FuelCapacity = GetInputDouble($"FuelCapacity daxil edin {i + 1}", 0, 1000);

                double FuelFor1km = GetInputDouble($"1km`e ne qeder benzin istifa edir{i + 1}", 0, 50);

                double Millage = GetInputDouble($"Ne qeder surulub {i + 1}",0,double.MaxValue);

                double CurrentFuel = GetInputDouble($"Ne qeder benzini var{i + 1}", 0, 1000);

                cars[i] = new Car(FuelFor1km, CurrentFuel, FuelCapacity, Millage)
                {
                   Brand = brand,
                   Color = color,
                };


                
            }
            Console.WriteLine("\n----------------------------\n");


            
            do
            {
                string InputStr;
                int Input;
                Console.WriteLine("\n\n1. Masinlari millage-e gore filtirle");
                Console.WriteLine("2. Butun masinlari goster");
                Console.WriteLine("3. Prosesi bitir");
                InputStr = Console.ReadLine();
                int.TryParse(InputStr, out Input);

                if (Input == 1)
                {
                    Console.WriteLine("Min Millage daxil edin :");
                    double min = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Max Millage daxil edin:");
                    double max = Convert.ToDouble(Console.ReadLine());

                    Car [] Filtered = FilteredByMillage(cars,ref min, ref max);
                    Console.WriteLine("Filtered Cars:");
                    foreach (var item in Filtered)
                    {
                        Console.WriteLine(item.CheckInfo());
                    }
                    continue;

                }
                if (Input == 2)
                {
                    Console.WriteLine("\n\n------------------");
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine($"{i + 1}.ci Masin: ");
                        Console.WriteLine(cars[i].CheckInfo());
                    }

                }
                else if (Input == 3)
                    break;




            } while (true);

        }
        static string GetInputStr(string str,int min ,int max)
        {
            string input;
            
           do
           {

                    Console.WriteLine(str);
                    input = Console.ReadLine();



            }while (input.Length <= 2 || input.Length >= 20);


           while (CheckInputStr(input) != true)
           {
                Console.WriteLine(str);
                input = Console.ReadLine();

           }
            
            
            return input;
            

        }
        static double GetInputDouble(string name , double min , double max )
        {
            string InputStr;
            double Input;

            do
            {
                Console.WriteLine(name);
                InputStr= Console.ReadLine();
                double.TryParse(InputStr, out Input);

            } while (Input < 0 || Input > 1000 );

            while (CheckInputDouble(InputStr)!=false)
            {
                Console.WriteLine(name);
                InputStr = Console.ReadLine();
                double.TryParse(InputStr, out Input);

            }
            
            return Input;
        }
        static bool CheckInputStr(string name)
        {
            int count = 0; 

            if (!string.IsNullOrWhiteSpace(name))
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetter(name[i]))
                    {
                        count++;
                    }
                }
            }
            if (count==name.Length )
            {
                return true;
            }
            else
                return false;
        }
        static bool CheckInputDouble(string name)
        {
            int count = 0;
          
            if (!string.IsNullOrWhiteSpace(name))
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetter(name[i]))
                    {
                        count++;
                    }
                }
            }
            if (count == name.Length)
            {
                return false;
            }
            else
                return true;
        }


        static Car [] FilteredByMillage(Car[] cars, ref double min ,ref double max)
        {
            Car[] NewFilterArr = new Car [0];
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Millage >= min && cars[i].Millage <= max)
                {
                    Array.Resize(ref NewFilterArr, NewFilterArr.Length + 1);
                    NewFilterArr[NewFilterArr.Length - 1] = cars[i];
                }
            }
            return NewFilterArr;
        } 
    }
}
