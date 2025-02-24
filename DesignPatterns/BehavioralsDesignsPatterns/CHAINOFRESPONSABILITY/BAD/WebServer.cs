using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.BAD
{
    public class WebServer
    {
        // BAD: Ici on effectue à la chaine la validation (Validator), l'authentification (Authenticator) et le log (Logger),
        // Si un jour on veut supprimer le log, ou l'authentication, on est obligé de modifer le code ci-dessous (OCP)
        // le new() 3 fois rend les objets couplés entre eux, il faut séparer les objets 
        public void Handle(HttpRequest request)
        {
            var validator = new DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.BAD.Validator();
            validator.Validate(request);

            var authenticator = new DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.BAD.Authenticator();
            authenticator.Authenticate(request);

            var logger = new DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.BAD.Logger();
            logger.Log(request);
        }
    }
}