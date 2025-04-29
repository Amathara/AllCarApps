using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPatternCarApp.Classes;

namespace RepositoryPatternCarApp.RepositoryPattern.Interfaces
{
    internal interface ICarRepo
    {
        public List<Car> GetAllCars();
        public Car GetCar(string licensePlate);
        public void AddCar(Car car);
        public void UpdateCar(Car car);
        public void DeleteCar(string licensePlate);

     

    }
}
