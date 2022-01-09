using System;
using System.Collections.Generic;
using System.Text;
using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    public class TechnicianModel : IApplicantModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IAccounts AccountProccessor { get; set; } = new Account();
    }
}
