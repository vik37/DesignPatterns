using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.singleton
{
    public class Logger
    {
        //private static Logger _logger;
        private static Logger _instance;
        private Logger()
        {

        }
        public static Logger Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
        //public static Logger GetInstance()
        //{
        //    if(_logger == null)
        //    {
        //        _logger = new Logger();
        //    }
        //    return _logger;
        //}
    }
}
