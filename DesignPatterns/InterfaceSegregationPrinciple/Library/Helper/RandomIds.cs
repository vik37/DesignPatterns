using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.Helper
{
    public static class RandomIds
    {
        private static Random random = new Random();
        public static string CreateRandomId()
        {
             int length = 15;
             string chars = "-ABCDEFGHIGKLMNOPQRSTUVWXYZ-abcdefghijklmnopqrstuvwxyz-1234567890-";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
