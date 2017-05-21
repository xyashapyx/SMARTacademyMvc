using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMARTacademyMvc.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public Contact StudentContact { get; set; }
    }
}