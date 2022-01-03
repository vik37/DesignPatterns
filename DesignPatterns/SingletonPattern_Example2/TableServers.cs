using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern_Example2
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> _servers = new List<string>();
        private int _nextServer = 0;
        private TableServers()
        {
            _servers.Add("Viktor");
            _servers.Add("Sue");
            _servers.Add("Mary");
            _servers.Add("Marinko");
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = _servers[_nextServer];
            _nextServer += 1;
            if(_nextServer >= _servers.Count)
            {
                _nextServer = 0;
            }
            return output;
        }
    }
}
