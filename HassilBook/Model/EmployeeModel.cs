using System;

namespace HassilBook
{
    public class EmployeeModel
    {
        /// <summary>
        /// Client employee ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Client employee [Generated] ID
        /// </summary>
        public string EmployeeID { get; set; }

        /// <summary>
        /// Client employee firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Client employee lastname
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Client employee gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Client employee email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Client employee telephone
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Client employee birthdate
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Client employee hired date
        /// </summary>
        public DateTime HiredDate { get; set; }

        /// <summary>
        /// Client employee department
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Client employee username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Client employee username ID
        /// </summary>
        public int UsernameID { get; set; }

        /// <summary>
        /// Client employee Role
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Client employee user image
        /// </summary>
        public byte[] UserImage { get; set; }

    }
}
