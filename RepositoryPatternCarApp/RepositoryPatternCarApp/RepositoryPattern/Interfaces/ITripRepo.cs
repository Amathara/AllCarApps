using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPatternCarApp.Classes;

namespace RepositoryPatternCarApp.RepositoryPattern.Interfaces
{
    internal interface ITripRepo
    {
        public List<Trip> GetTripsForCar(string regNr);
        public void AddTrip (Trip trip);
        public void DeleteTrip (Trip trip);
    }
}
