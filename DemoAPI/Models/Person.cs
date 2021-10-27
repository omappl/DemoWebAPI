using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{

    /// <summary>
    /// represents one specific people
    /// </summary>
    public class Person
    {
        /// <summary>
        ///  id from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// users firstname
        /// </summary>
        /// 
        public string FirstName { get; set; } = "";
        /// <summary>
        /// users lastname
        /// </summary>

        public string LastName { get; set; } = string.Empty;

    }
}