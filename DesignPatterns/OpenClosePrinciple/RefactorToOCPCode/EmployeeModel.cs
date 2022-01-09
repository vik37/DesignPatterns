using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class EmployeeModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public bool isManager { get; set; } = false;
        public bool isExecutive { get; set; } = false;
    }
}
