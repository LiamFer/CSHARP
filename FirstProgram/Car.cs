using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public abstract class Vehicle
    {
        public string vehicleType;
        public string make;
        public int year;

        public virtual void Start()
        {
            Console.WriteLine($"The Engine of the {vehicleType} is Starting");
        }

        public override string ToString()
        {
            return $"This Vehicle is a {make} {vehicleType} from {year}";
        }

    }
    public class Car : Vehicle
    {
        public Car(string make, int year)
        {
            this.vehicleType = "Car";
            this.make = make;
            this.year = year;
        }
    }
    public class Boat : Vehicle
    {
        public Boat(string make, int year)
        {
            this.vehicleType = "Boat";
            this.make = make;
            this.year = year;
        }
    }
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string make, int year)
        {
            this.vehicleType = "Motorcycle";
            this.make = make;
            this.year = year;
        }

        public override void Start()
        {
            Console.WriteLine($"The ThunderBike is STARTINGGG");
        }

    }

}
