using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.Email = $"{person.Firstname.Substring(0, 1).ToLower()}{person.Lastname.ToLower()}@gmail.com";
            return output;
        }
    }
}
