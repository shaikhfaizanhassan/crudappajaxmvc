using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAJAX.Models
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string EEmail { get; set; }
        public string EPassword { get; set; }
        public string EGender { get; set; }
    }
}