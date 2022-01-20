using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependensy_Inversion_Principle
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessage());
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IMessageSender CreateMessage()
        {
            return new Texter();
        }
    }
}
