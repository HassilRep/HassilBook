using System;
using System.Drawing;

namespace HassilBook
{
    /// <summary>
    /// This model controls all information about the flights.
    /// </summary>
    public class FlightModel
    {
        
        /// <summary>
        /// Airline company office ID
        /// </summary>
        public int OfficeID { get; set; }

        /// <summary>
        /// Airline company name
        /// </summary>
        public string Airlines { get; set; }

        /// <summary>
        /// Airline flight ID
        /// </summary>
        public string FlightID { get; set; }
        
        /// <summary>
        /// Airplane registred number
        /// </summary>
        public string RegisteredNumber { get; set; }
        
        /// <summary>
        /// Destination where customer is travelling
        /// </summary>
        public string From { get; set; }
        
        /// <summary>
        /// Departuring city of the customer
        /// </summary>
        public string CityFrom { get; set; }
        
        /// <summary>
        /// Arrival city of the customer
        /// </summary>
        public string CityTo { get; set; }
        
        /// <summary>
        /// Destination where customer is going to
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Stops of the current flights
        /// </summary>
        public string Stops { get; set; }
        
        /// <summary>
        /// Date of the travelling
        /// </summary>
        public DateTime DepartureDate { get; set; }
        
        /// <summary>
        /// Departure time of the customer
        /// </summary>
        public TimeSpan DepartureTime { get; set; }
        
        /// <summary>
        /// Arrival time of the customer
        /// </summary>
        public TimeSpan ArrivalTime { get; set; }
        
        /// <summary>
        /// Adult economy class price
        /// </summary>
        public decimal AdultEconomyPrice { get; set; }
        
        /// <summary>
        /// Adult business class price
        /// </summary>
        public decimal AdultBusinessPrice { get; set; }
        
        /// <summary>
        /// Child economy class price
        /// </summary>
        public decimal ChildEconomyPrice { get; set; }
        
        /// <summary>
        /// Child business class price
        /// </summary>
        public decimal ChildBusinessPrice { get; set; }
        
        /// <summary>
        /// Infant economy class price
        /// </summary>
        public decimal InfantEconomyPrice { get; set; }
        
        /// <summary>
        /// Infant business class price
        /// </summary>
        public decimal InfantBusinessPrice { get; set; }
        
        /// <summary>
        /// Total available economy seats
        /// </summary>
        public int EconomySeats { get; set; }
        
        /// <summary>
        /// Total available business seats
        /// </summary>
        public int BusinessSeats { get; set; }
        
        /// <summary>
        /// Status of the flight
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// Airlines company logo
        /// </summary>
        public byte[] Logo { get; set; }

    }
}
