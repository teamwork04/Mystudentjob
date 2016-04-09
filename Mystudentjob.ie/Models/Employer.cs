using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mystudentjob.ie.Models
{
    public class Employer : ApplicationUser
    {
        public string Address { get; set; }
        public string IndustryType { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
    }
}