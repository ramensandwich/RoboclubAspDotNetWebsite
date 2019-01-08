using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoboclubWebsite.Models
{
    public class User
    {
        public enum DuesStatus { No, Semester, Year };

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AndrewID { get; set; }
        //TODO: determine how best to store this value
        public long StudentID { get; set; }
        public DuesStatus DuesPaid { get; set; }

        
    }
}