using System;

namespace HassilBook
{
    /// <summary>
    /// Client basic information
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// Client primary ID
        /// </summary>
        public int ClientID { get; set; }
        
        /// <summary>
        /// Client office ID
        /// </summary>
        public string OfficeID { get; set; }
        
        /// <summary>
        /// Client company name
        /// </summary>
        public string Company { get; set; }
        
        /// <summary>
        /// Cient joined date
        /// </summary>
        public DateTime JoinDate { get; set; }
        
        /// <summary>
        /// Client email
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Client telephone
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Client street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Client postal code
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// Client city
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// Client country
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// Client subscription type
        /// </summary>
        public string SubscriptionType { get; set; }
        
        /// <summary>
        /// Client license expiry date
        /// </summary>
        public DateTime LicenseExpiry { get; set; }
        
        /// <summary>
        /// Client current status
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// Client current logo
        /// </summary>
        public byte[] Logo { get; set; }
    }
}
