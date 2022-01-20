﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMessageSender _messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;            
            _logger.Log($"Performed work on { ChoreName }");
        }
        public void ComplateChore()
        {
            IsComplete = true;            
            _logger.Log($"Completed { ChoreName }");           
            _messageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
