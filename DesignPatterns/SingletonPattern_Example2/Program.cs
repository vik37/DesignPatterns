using System;

namespace SingletonPattern_Example2
{
    class Program
    {
        static TableServers host1List = TableServers.GetTableServers();
        static TableServers host2List = TableServers.GetTableServers();
        static void Main(string[] args)
        {
            TableServers servers = TableServers.GetTableServers();
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("The next server is: " + servers.GetNextServer());
                HostOneGetNextServer();
                HostTwoGetNextServer();
            }
            Console.ReadLine();
        }
        public static void HostOneGetNextServer()
        {
            Console.WriteLine("The next server is: " + host1List.GetNextServer());
        }
        public static void HostTwoGetNextServer()
        {
            Console.WriteLine("The next server is: " + host2List.GetNextServer());
        }
    }
}
