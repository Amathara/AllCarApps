using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace RepositoryPatternCarApp.Classes
{
    internal class Trip
    {
        public string CarRegNr { get; set; }
        public double Distance { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        //public Trip(string carRegnr, double distance, DateTime date, TimeSpan startTime, TimeSpan endTime)
        //{
        //    CarRegNr = carRegnr;
        //    Distance = distance;
        //    Date = date;
        //    StartTime = startTime;
        //    EndTime = endTime;
        //}
        public string ToString()
        {
            return $"{CarRegNr},{Distance},{Date},{StartTime},{EndTime}";
        }
        public static Trip FromString(string input)
        {
            string[] parts = input.Split(',');

            return new Trip
            {
                CarRegNr = parts[0],
                Distance = double.Parse(parts[1]),
                Date = DateTime.Parse(parts[2]),
                StartTime = TimeSpan.Parse(parts[3]),
                EndTime = TimeSpan.Parse(parts[4])
              
            };
        }
    }
}
