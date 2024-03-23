using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        // Automatically-implemented properties with internal private field
        // Use private keyword on get/set to prevent property to being accessed
        // Use 'prop' code snippet

        // Mannually defining properties using get and set keywords
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
