using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPatternCarApp.Classes;
using RepositoryPatternCarApp.RepositoryPattern.Interfaces;
using System.IO;

namespace RepositoryPatternCarApp.RepositoryPattern.Repositories
{
    internal class FileCarRepo : ICarRepo
    {
        private readonly string _filePath;

        public FileCarRepo(string filePath)
        {
            _filePath = filePath; //Sikre at filen eksisterer

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }
        public void AddCar(Car car)
        {
            List<Car> cars = GetAllCars().ToList();
            //cars.LicensePlate = car.Any() ? cars.Max(p => p.LicensePlate) + 1 : 1;
            try
            {
                File.AppendAllText(_filePath, car.ToString() + Environment.NewLine);
            }
            catch (IOException ex)
            {
               Console.WriteLine($"There was an error writing to file: {ex.Message}");
            }
        }

        public void DeleteCar(string licensePlate)
        {
            List<Car> cars = GetAllCars().ToList();
            cars.RemoveAll(p => p.LicensePlate == licensePlate);
            RewriteFile(cars);
        }

        public List<Car> GetAllCars()
        {
            try
            {
                return File.ReadAllLines(_filePath)
                    .Where(Line => !string.IsNullOrWhiteSpace(Line))
                    .Select(Car.FromString)
                    .ToList();
            }
            catch(IOException ex)
            {
                Console.WriteLine($"There was an error reading file: {ex.Message}");
                return new List<Car>();
            }
               
        }

        public Car GetCar(string licensePlate)
        {
            return GetAllCars().FirstOrDefault(p => p.LicensePlate == licensePlate);
        }

        public void UpdateCar(Car car)
        {
            List<Car> cars = GetAllCars().ToList();
            int index = cars.FindIndex(p => p.LicensePlate == car.LicensePlate);
            if (index != -1)
            {
                cars[index] = car;
                RewriteFile(cars);
            }
        }
        private void RewriteFile(List<Car> cars)
        {
            try
            {
                File.WriteAllLines(_filePath, cars.Select(p => p.ToString()));
            }
            catch (IOException ex)
            {
                Console.WriteLine($"There was an error writing to file: {ex.Message}");
            }
        }
    }
}
