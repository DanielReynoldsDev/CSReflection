using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Car
    {

        private string Make { get; set; }
        private string Model { get; set; }
        private string Registration { get; set; }
        private string YearOfRegistration { get; set; }
        private decimal CurrentValue { get; set; }

        public Car(string make, string model, string registration, string yearOfRegistration, decimal currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            YearOfRegistration = yearOfRegistration;
            CurrentValue = currentValue;
        }
        public string Value()
        {
            return CurrentValue.ToString("C2");
        }

        public string Year()
        {
            return YearOfRegistration;
        }
        public override string ToString()
        {
            return $"Make: {Make} Model: {Model} Registration: '{Registration}' Registered: {YearOfRegistration} Value: {Value()}";
        }

    }
}
