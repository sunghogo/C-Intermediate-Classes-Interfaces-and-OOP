using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    public class Vehicle
    {
        private readonly string? _registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Vehcile is being initialized. {registrationNumber}");
        }
    }
}
