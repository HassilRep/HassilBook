using System;

namespace HassilBook
{
    /// <summary>
    /// Model of client agencies
    /// </summary>
    public class AgencyModel
    {
        /// <summary>
        /// Agency primary ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Agency office ID
        /// </summary>
        public int OfficeID { get; set; }

        /// <summary>
        /// Agency company ID
        /// </summary>
        public string AgencyID { get; set; }

        /// <summary>
        /// Agency joined date
        /// </summary>
        public DateTime JoinedDate { get; set; }

        /// <summary>
        /// Agency company name
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Agency company owner name
        /// </summary>
        public string CompanyOwner { get; set; }

        /// <summary>
        /// Agency owner gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Agency street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Agency postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Agency city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Agency country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Agency telephone
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Agency email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Agency type
        /// </summary>
        public string AgencyType { get; set; }

        /// <summary>
        /// Agency current status
        /// </summary>
        public string Status { get; set; }
    }
}
