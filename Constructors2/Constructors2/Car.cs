using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized");
        }

        // The parent class will be initialized using the default constructor unless specified with : base(overload args)
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine($"Car is being initialized. {registrationNumber}");
        }
    }
}
