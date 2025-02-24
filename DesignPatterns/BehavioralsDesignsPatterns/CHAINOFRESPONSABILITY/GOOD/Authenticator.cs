using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.GOOD
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authenticating");
            var username = request.GetUsername();
            var password = request.GetPassword();

            return !(username == "danny" && password == "123");
        }
    }
}