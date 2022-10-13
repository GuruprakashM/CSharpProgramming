using System;

namespace MovieBooking
{

    public class Personal
    {
        /// <summary>
        /// user name
        /// </summary>
        /// <value></value>
        public string  Name { get; set; }
        /// <summary>
        /// Age of user
        /// </summary>
        /// <value></value>
        public int Age {get;set;}

        /// <summary>
        /// Mobile Number of user
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }
        /// <summary>
        /// constructor of personal details
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="mobileNumber"></param>
        public Personal(string name, int age, long mobileNumber)
        {
            Name=name;
            Age=age;
            MobileNumber=mobileNumber;
        }
        public Personal()
        {

        }

    }
}