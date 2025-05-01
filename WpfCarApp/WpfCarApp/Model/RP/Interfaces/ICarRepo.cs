using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCarApp.Model.Classes;


namespace WpfCarApp.Model.RP.Interfaces
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
