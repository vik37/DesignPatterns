using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcepts_2
{
    public interface IEmail
    {
        void SendEmail();
    }
    public class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("send outlook email");
        }
    }
    public class WebServiceEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("send Web Service email");
        }
    }
}
