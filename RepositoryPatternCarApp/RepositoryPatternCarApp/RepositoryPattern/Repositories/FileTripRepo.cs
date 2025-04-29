using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using RepositoryPatternCarApp.Classes;
using RepositoryPatternCarApp.RepositoryPattern.Interfaces;


namespace RepositoryPatternCarApp.RepositoryPattern.Repositories
{

    internal class FileTripRepo : ITripRepo
    {
        private readonly string _filePath;

        public void AddTrip(Trip trip)
        {
            List<Trip> trips = GetTripsForCar(trip.CarRegNr).ToList();
            //cars.LicensePlate = car.Any() ? cars.Max(p => p.LicensePlate) + 1 : 1;
            try
            {
                File.AppendAllText(_filePath, trip.ToString() + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"There was an error writing to file: {ex.Message}");
            }
        }

        public void DeleteTrip(Trip trip)
        {
            

            List<Trip> trips = GetTripsForCar(trip.CarRegNr).ToList();
            trips.RemoveAll(p => p.CarRegNr == trip.CarRegNr);
            
        }

        public List<Trip> GetTripsForCar(string regNr)
        {
            
            try
            {
                return File.ReadAllLines(_filePath)
                    .Where(Line => !string.IsNullOrWhiteSpace(Line))
                    .Select(Trip.FromString)
                    .ToList();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"There was an error reading file: {ex.Message}");
                return new List<Trip>();
            }
        }
    }
}
