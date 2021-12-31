using System;

namespace BasicConcepts_2
{
    class Employee
    {
        private int _empId;
        private string _empName;
        public double salery { get; set; }
        public int grade { get; set; }
        private string _company = "IBM";

        IEmail email;
        public Employee(int empId, string empName, IEmail email)
        {
            this._empId = empId;
            this._empName = empName;
            this.email = email;
        }

        public void NotifyEmail()
        {
            email.SendEmail();
        }
    }
    class BasicConcept2
    {
        static void Main()
        {
            IEmail email = new OutlookEmail();
            Employee obj = new Employee(100,"Alex", email);
            obj.salery = 100000;
            //obj.empId = 100;
            //obj.empName = "Alex";
            obj.NotifyEmail();

            email = new WebServiceEmail();
            Employee obj3 = new Employee(200, "Marina", email);
            obj3.NotifyEmail();
            Console.ReadLine();
        }
    }
}
