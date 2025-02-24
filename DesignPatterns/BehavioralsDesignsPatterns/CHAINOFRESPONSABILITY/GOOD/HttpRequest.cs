using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.GOOD
{
    public class HttpRequest(string username, string password)
    {
        private string _username = username;
        private string _password = password;
        public string ValidatedUsername { get; set; }
        public string ValidatedPassword { get; set; }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}