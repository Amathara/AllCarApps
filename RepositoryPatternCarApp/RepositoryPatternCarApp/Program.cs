using RepositoryPatternCarApp.RepositoryPattern;
using RepositoryPatternCarApp.Classes;
using RepositoryPatternCarApp.RepositoryPattern.Repositories;
using RepositoryPatternCarApp.RepositoryPattern.Interfaces;
using System;
using System.Runtime.ConstrainedExecution;

namespace RepositoryPatternCarApp

{
    internal class Program
    {


        static void Main(string[] args)
        {
            FileCarRepo carRepo = new FileCarRepo("Cars.txt");

            Console.WriteLine("HEJ");

            carRepo.AddCar(new Car("Toyota", "Corolla", 2015, "White", "ABC123", "Petrol"));
            carRepo.AddCar(new Car("Volkswagen", "Golf", 2018, "Black", "XYZ987", "Diesel"));
            carRepo.AddCar(new Car("Tesla", "Model 3", 2021, "Red", "ELEC42", "Electric"));
            carRepo.AddCar(new Car("Ford", "Focus", 2016, "Blue", "FORD16", "Petrol"));
            carRepo.AddCar(new Car("BMW", "320i", 2019, "Silver", "BM1234", "Hybrid"));

            Console.WriteLine("\nAll Cars:");
            foreach (var car in carRepo.GetAllCars())
            {
                Console.WriteLine($"{car.Brand}, {car.Model}, {car.Year}, {car.Color}, {car.LicensePlate}, {car.FuelType}");
            }
            Car car1 = carRepo.GetCar("ABC123");
            if (car1 != null)
            {
                Console.WriteLine($"Found car with License Plate {car1.LicensePlate}: {car1.Brand}, {car1.Model}, {car1.Year}, {car1.Color}, {car1.FuelType}");
                Console.ReadLine();
            }
        }
    }
}
