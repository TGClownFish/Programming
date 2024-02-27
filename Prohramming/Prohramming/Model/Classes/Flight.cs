using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    internal class Flight
    {
        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }
        private int _flightTimeMinutes; 
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _flightTimeMinutes = value;
                }
                else
                {
                    throw new ArgumentException("Введите значение между 0 и 60");
                }
            }
        }
        public Flight(string departurePoint, string destinationPoint, int flightTimeMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeMinutes = flightTimeMinutes;
        }
        public Flight() { }
    }
}
