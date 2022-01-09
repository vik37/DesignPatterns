using OCPLibrary.Applicants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary.Accounts
{
    public class ExecutiveAccaunt : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.Email = $"{person.Firstname.Substring(0, 1).ToLower()}{person.Lastname.ToLower()}@gmail.com";
            output.isManager = true;
            output.isExecutive = true;

            return output;
        }
    }
}
