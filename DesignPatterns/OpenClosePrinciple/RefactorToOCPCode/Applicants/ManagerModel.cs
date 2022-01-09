﻿using OCPLibrary.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary.Applicants
{
    public class ManagerModel : IApplicantModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IAccounts AccountProccessor { get; set; } = new ManagerAccounts();
    }
}
