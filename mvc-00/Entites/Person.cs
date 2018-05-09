using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_00.Entites
{
    public class Person
    {
        public string sEmail { get; set; }
        public string sEnterprise { get; set; }
        public string sMobile { get; set; }
        public virtual Text textPosition { get; set; }
        public virtual Text textBiography { get; set; }
    }
}