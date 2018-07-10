using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Exercise_1
{
    class Program
    {
        enum VehicleEnum
        {
            Car = 1,
            Boat,
            Motorcycle,
            Airplane,
            Unknown
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Komodo Insurance!");
            Console.Write("Please tell us your name: ");
            var nameInput = Console.ReadLine();
            Console.Write("What is your age: ");
            var ageInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What kind of vehicle will you be insuring?\n1: Car\n2: Boat\n3: Motorcycle\n4: Airplane");
            var vehicleInput = Console.ReadLine();
            VehicleEnum vehicleType = (VehicleEnum)Enum.Parse(typeof(VehicleEnum), vehicleInput);
            Console.WriteLine(vehicleType);

            //refactor as a switch
            //switch(vehicleType)
            //{
            //    case VehicleEnum.Car:
            //        if (ageInput > 18 && ageInput < 27)
            //        {
            //            Console.WriteLine("You're insurance estimate is $150 a month.");
            //        }
            //        if (ageInput > 18 && ageInput < 27 && vehicleType == VehicleEnum.Car)
            //        {
            //            Console.WriteLine("You're insurance estimate is $50 a month.");
            //        }
            //        if (ageInput >= 65 && vehicleType == VehicleEnum.Car)
            //        {
            //            Console.WriteLine("You're insurance estimate is $100 a month.");

            //            break;
            //        default:
            //            break;
            //}

            if (ageInput >= 18 && ageInput < 27 && vehicleType == VehicleEnum.Car)
            {
                Console.WriteLine("You're insurance estimate is $150 a month.");
            }
            else if (ageInput > 27 && ageInput < 65 && vehicleType == VehicleEnum.Car)
            {
                Console.WriteLine("You're insurance estimate is $50 a month.");
            }
            else if (ageInput >= 65 && vehicleType == VehicleEnum.Car)
            {
                Console.WriteLine("You're insurance estimate is $100 a month.");
            }

            Console.Read();
        }
    }
}
