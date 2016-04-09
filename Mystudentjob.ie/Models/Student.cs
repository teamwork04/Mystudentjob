using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mystudentjob.ie.Models
{
    public class Student : ApplicationUser
    {
        public string location { get; set; }
        public string Qualification { get; set; }
        public string ProfessionalQualification { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
        public string Language { get; set; }
        public string ProfilePicPath { get; set; }
        public string CVPath { get; set; }
    }
}