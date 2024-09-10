using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohramming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полёте.
    /// </summary>
    public class Flight
    {
        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        private int _flightTimeMinutes; 
        public int FlightTimeMinutes
        {
            get { return _flightTimeMinutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(FlightTimeMinutes)); 
                _flightTimeMinutes = value;
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
