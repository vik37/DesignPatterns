using OCPLibrary;
using OCPLibrary.Accounts;
using OCPLibrary.Applicants;
using System;
using System.Collections.Generic;

namespace OpenSolid_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>()
            {
                new PersonModel(){Firstname="Viktor", Lastname="Zafirovski"},
                new ManagerModel(){Firstname="Sarma", Lastname="Posna"},
                new ExecutiveModel(){Firstname="Slagjana", Lastname="Trajkovska"}
            };
            List<EmployeeModel> employees = new List<EmployeeModel>();
            Account accountProccessor = new Account();
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProccessor.Create(person));
            }
            Console.WriteLine(" E M P L O Y E E S: ");
            foreach (var employee in employees)
            {
                Console.WriteLine($" -------- \n First name: {employee.Firstname} \n\n Last name: {employee.Lastname} \n\n " +
                    $"E-mail: {employee.Email} \n\n is manager: {employee.isManager} \n\n is executive: {employee.isExecutive}");
            }
            Console.ReadLine();
        }
    }
}
