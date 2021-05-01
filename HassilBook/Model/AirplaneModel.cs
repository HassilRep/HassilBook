using System;

namespace HassilBook
{
    /// <summary>
    /// A model of taking care the airplane
    /// </summary>
    public class AirplaneModel
    {
        /// <summary>
        /// Airline company office ID
        /// </summary>
        public int OfficeID { get; set; }

        /// <summary>
        /// Registration number of the airplane
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Registration date of the airplane
        /// </summary>
        public DateTime RegisteredDate { get; set; }
        
        /// <summary>
        /// Manufacturer name of the airplane
        /// </summary>
        public string Manufacturer { get; set; }
        
        /// <summary>
        /// Model or type of the airplane
        /// </summary>
        public string Model { get; set; }
        
        /// <summary>
        /// Which category is been used for.
        /// </summary>
        public string Category { get; set; }
        
        /// <summary>
        /// Number of seats in the airplane
        /// </summary>
        public int Seats { get; set; }
        
        /// <summary>
        /// Current status of the airplane
        /// </summary>
        public string Status { get; set; }
    }
}
