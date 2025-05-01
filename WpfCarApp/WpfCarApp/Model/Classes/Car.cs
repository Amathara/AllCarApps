using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCarApp.Model.Classes
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public string FuelType { get; set; }
        // public List Trips { get; set; }

        public Car() { } // To be able to make FromString.
        public Car(string brand, string model, int year, string color, string licensePlate, string fuelType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            LicensePlate = licensePlate;
            FuelType = fuelType;
        }

        public string ToString()
        {
            return $"{Brand},{Model},{Year},{Color},{LicensePlate},{FuelType}";
        }
        public static Car FromString(string input)
        {
            string[] parts = input.Split(',');

            return new Car
            {
                Brand = parts[0],
                Model = parts[1],
                Year = int.Parse(parts[2]),
                Color = parts[3],
                LicensePlate = parts[4],
                FuelType = parts[5]
                //Trips = parts [6]
            };

        }
    }
}