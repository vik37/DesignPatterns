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
            List<PersonModel> applicants = new List<PersonModel>()
            {
                new PersonModel(){Firstname="Viktor", Lastname="Zafirovski"},
                new PersonModel(){Firstname="Sarma", Lastname="Posna"},
                new PersonModel(){Firstname="Slagjana", Lastname="Trajkovska"}
            };
            List<EmployeeModel> employees = new List<EmployeeModel>();
            Account accountProccessor = new Account();
            foreach (var person in applicants)
            {
                employees.Add(accountProccessor.Create(person));
            }
            Console.WriteLine(" E M P L O Y E E S: ");
            foreach (var employee in employees)
            {
                Console.WriteLine($" -------- \n First name: {employee.Firstname} \n\n Last name: {employee.Lastname} \n\n " +
                    $"E-mail: {employee.Email} \n\n");
            }
            Console.ReadLine();
        }
    }
}
