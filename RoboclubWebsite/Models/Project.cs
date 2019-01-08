using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoboclubWebsite.Models
{
    public class Project
    {
        public string ProjectName { get; set; }
        public short ProjectId { get; set; }
        public User ProjectLead { get; set; }
    }
}