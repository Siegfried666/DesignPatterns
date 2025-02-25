using DESIGNPATTERNS.BehavioralsDesignsPatterns.Memento;
using DesignPatterns.BehavioralsDesignsPatterns.COMMAND.UNDOABLE;
using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern;
using DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.GOOD;
using DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD;
using Tea = DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.BAD.Tea;
using DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.BAD;
using DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR;
using DesignPatterns.BehavioralsDesignsPatterns.INTERPRETER;
using DesignPatterns.Utils;

/* Begavioral Design Patterns
Les Design Patterns Bahaviorial concernent l'interaction entre les objets
Permet de résoudre des problèmes de communication, de responsabilité et d'algorithmique
Separation of concern: séparations entre les objets et les classes
*/

namespace DesignPatterns.BehavioralsDesignsPatterns
{

    public class BehavioralsExamples
    {
        /// <summary>
        /// Visitor Pattern => Permet d'ajouter de nouvelles opérations à une structure d'objets sans modifier les classes sur lesquelles elles opèrent.
        /// Autre def: Permet de définir une nouvelle opération sans changer les classes des éléments sur lesquels il opère.
        /// </summary>
        public void VisitorPattern()
        {
            Helpers.SetTitle(nameof(VisitorPattern), ConsoleColor.Blue);

            var retailName = "Debinhams";
            var retailEmail = "team@debinhams.com";
            var restaurantName = "Frankie & Bennys";
            var restaurantEmail = "frankAndBenny@resto.com";
            var lawName = "Hamlin McGil Law Firm";
            var lawEmail = "HamliMcGin@Lawers.com";

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            //BAD: Manager demande d'étendre de plus en plus de features dans chaque client (ex: export PDF, XML etc.)
            // A chaque fois on doit modifier la base CLient et implémenter dans chaque client (OCP) et SRP

            // Getting list from clients (ex: Database)
            var clientsBad = new List<VISITOR.BAD.Client>(){
                                    new VISITOR.BAD.RetailClient(retailName, retailEmail),
                                    new VISITOR.BAD.RestaurantClient(restaurantName, restaurantEmail),
                                    new VISITOR.BAD.LawClient(lawName, lawEmail)
                                    };

            foreach (var client in clientsBad)
            {
                client.SendEmail();
            }

            Helpers.SetTitle("GOOD", ConsoleColor.Green);
            // Getting list from clients (ex: Database)
            var clientsGood = new List<VISITOR.GOOD.Client>(){
                                new VISITOR.GOOD.RetailClient(retailName, retailEmail),
                                new VISITOR.GOOD.RestaurantClient(restaurantName, restaurantEmail),
                                new VISITOR.GOOD.LawClient(lawName, lawEmail)
                                };

            foreach (var client in clientsGood)
            {
                // client.Accept(new EmailVisitor());
                client.Accept(new VISITOR.GOOD.PDFExportVisitor());
            }
        }

        /// <summary>
        /// Template method Pattern
        /// -> On peut se service de Strategy Pattern => Utilise le Polymorphisme (POO principle) et le Pattern Strategy pour regrouper dans une 
        // classe abstraite ce qui se répète dans le code.
        /// Autre def: Permet de redéfinir certaines étapes d’un algorithme sans modifier la structure de l’algorithme.
        /// </summary>
        public void TemplateMethodPattern()
        {
            Helpers.SetTitle(nameof(TemplateMethodPattern), ConsoleColor.Blue);

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            //BAD: Si on ajoute une autre classe, on répète le code (ex: Coffee avec des particularités différentes)
            var teaBad = new Tea();
            teaBad.MakeBeverage();

            Helpers.SetTitle("GOOD Strategy Patterns", ConsoleColor.Green);

            //GOOD Strategy Patterns
            System.Console.WriteLine("GOOD Strategy Patterns");
            var beverageMaker = new BeverageMaker(new TEMPLATE_METHOD.GOOD_StrategyPattern.Tea());
            beverageMaker.MakeBeverage();

            beverageMaker = new BeverageMaker(new TEMPLATE_METHOD.GOOD_StrategyPattern.Coffee());
            beverageMaker.MakeBeverage();

            Helpers.SetTitle("GOOD Template method Pattern", ConsoleColor.Green);
            //GOOD Template method Pattern
            System.Console.WriteLine("GOOD Template method Pattern");
            var tea = new TEMPLATE_METHOD.GOOD_TemplateMethodPattern.Tea();
            tea.Prepare();

            var camomile = new TEMPLATE_METHOD.GOOD_TemplateMethodPattern.Camomile();
            camomile.Prepare();
        }

        /// <summary>
        ///  Strategy Pattern => Permet de définir une famille d'algorithmes, encapsule chacun d'eux, et les rend interchangeables.
        ///  Autre def: Permet de pouvoir faire permuter des algorithmes au sein d’une application dans certaines conditions
        /// </summary>
        public void StrategyPattern()
        {
            Helpers.SetTitle(nameof(StrategyPattern), ConsoleColor.Blue);

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
            videoStorage.Store("video/some-movie");

            Helpers.SetTitle("GOOD", ConsoleColor.Green);
            videoStorage.SetCompressor(new CompressorMP4());
            videoStorage.SetOverlay(new OverlayNone());
            videoStorage.Store("video/some-movie");
        }

        /// <summary>
        ///  State Pattern => Permet à un objet de modifier son comportement lorsque son état interne change.
        ///  Autre def: Permet, lorsqu’un objet est altéré, de changer son comportement.
        ///  On l'utilise pour gérer les cas de polymorphismes. Si un objet a besoin de changer souvent d'état, ie faire appel
        ///  a des conditions différentes (if, else...).
        ///  => Il implémente le polymorphisme, le principe de Single Responsability Principle, et l'Open Close Principle
        /// </summary>
        public void StatePattern()
        {
            Helpers.SetTitle(nameof(StatePattern), ConsoleColor.Blue);


            Helpers.SetTitle("BAD", ConsoleColor.Red);
            var docBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.Document();
            docBad.State = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.DocumentStates.Moderation;
            // doc.CurrentUserTole = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.UserRoles.Admin;
            docBad.CurrentUserTole = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.UserRoles.Editor;
            Console.WriteLine(docBad.State);

            docBad.Publish();
            Console.WriteLine(docBad.State);

            Helpers.SetTitle("GOOD", ConsoleColor.Green);
            var docGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.Document(DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.UserRoles.Editor);
            //var docGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.Document(DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.UserRoles.Admin);
            Console.WriteLine(docGood.State);

            docGood.Publish();
            Console.WriteLine(docGood.State);

            docGood.Publish();
            Console.WriteLine(docGood.State);
        }

        /// <summary>
        /// Observer Pattern => Définit une dépendance de type one-to-many entre objets, de manière à ce que lorsque un objet change d'état, 
        /// tous ceux qui en dépendent en sont notifiés et mis à jour automatiquement.
        /// Autre def: Permet de définir une relation Observateur-Obersable entre les objets. Quand un objet de type Observable change d’état, il notifie 
        /// tous les autres objets qui l’observent de son changement pour eux-mêmes changer d’état.
        /// </summary>
        public void ObserverPattern()
        {

            Helpers.SetTitle(nameof(ObserverPattern), ConsoleColor.Blue);

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            //BAD: Les principes SOLID SRP et OCP sont violés dans cette implémentation.
            //SRP => Datasource a 2 responsabilités, stocker les données et gérer les objets dépendants(Sheet2 et BarChart)
            //OCP => Si on crée d'autre objets (Sheet1, BarChart2 etc.), on est obligé de modifier Datasource.cs
            Datasource datasourceBad = new Datasource();
            Sheet2 sheet2Bad = new Sheet2();
            BarChart barChartBad = new BarChart();

            datasourceBad.AddDependent(sheet2Bad);
            datasourceBad.AddDependent(barChartBad);

            datasourceBad.SetValues([5, 1, 10]);
            datasourceBad.SetValues([1, 2, 3]);

            Helpers.SetTitle("GOOD");
            //SRP => on Créé une classe qui gère les objets
            //OCP => on implémente une interface commune aux objets Sheet2 et BarChart
            OBSERVER.GOOD.Datasource datasource = new OBSERVER.GOOD.Datasource();

            OBSERVER.GOOD.Sheet2 sheet2 = new OBSERVER.GOOD.Sheet2(datasource);
            OBSERVER.GOOD.BarChart barChart = new OBSERVER.GOOD.BarChart(datasource);

            datasource.AddObserver(sheet2);
            datasource.AddObserver(barChart);

            datasource.SetValues([5, 1, 10]);
            datasource.SetValues([1, 2, 3]);
        }

        /// <summary>
        ///  Memento Pattern =>  Permet de sauvegarder et restaurer l'état antérieur d'un objet sans révéler les détails de son implémentation.
        ///  Autre def: Permet de restaurer un état précédent d’un objet (retour arrière) sans violer le principe d’encapsulation.
        /// </summary>
        public void MementoPattern()
        {
            Helpers.SetTitle(nameof(MementoPattern), ConsoleColor.Blue);

            Helpers.SetTitle("GOOD");
            var editor = new Editor();
            var history = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Memento.History(editor);
            history.Backup();
            editor.Title = "Test";
            history.Backup();
            editor.Content = "Hello there, my name is Freddy";
            history.Backup();
            editor.Title = "The live of a dev: my mementos";

            Console.WriteLine("Title: " + editor.Title);
            Console.WriteLine("Content: " + editor.Content);

            history.Undo();

            Console.WriteLine("Title: " + editor.Title);
            Console.WriteLine("Content: " + editor.Content);

            history.ShowHistory();

            history.Undo();
            Console.WriteLine("Title: " + editor.Title);
            Console.WriteLine("Content: " + editor.Content);
            history.Undo();
            Console.WriteLine("Title: " + editor.Title);
            Console.WriteLine("Content: " + editor.Content);
        }

        /// <summary>
        /// Mediator Pattern => Réduit le couplage en permettant de communiquer sans se connaître mutuellement, en centralisant les interactions 
        /// complexes entre objets étroitement couplés.
        /// Autre def: permet de construire un objet dont la vocation est la gestion et le contrôle des interactions dans un ensemble d’objets 
        /// sans que ses éléments doivent se connaître mutuellement.
        /// </summary>
        public void MediatorPattern()
        {
            Helpers.SetTitle(nameof(MediatorPattern), ConsoleColor.Blue);

            Helpers.SetTitle("GOOD");
            var postDialogBox = new PostDialogBox();
            postDialogBox.SimulateUserInteraction();

            Helpers.SetTitle("GOOD With Observer");
            var postDialogBoxWithObserver = new MEDIATOR.WITHOBSERVER.PostDialogBox();
            postDialogBoxWithObserver.SimulateUserInteraction();
        }

        /// <summary>
        /// Iterator Pattern => Fournit un moyen d'accéder séquentiellement aux éléments d'un objet aggregate sans exposer sa représentation sous-jacente.
        /// Le fait de changer le fonctionnement interne d'un objet ne doit pas affecter le consommateur
        /// Aurtre def: Permet d’accéder à des éléments d’un agrégat séquentiellement. On pourrait identifier ce pattern au curseur
        /// Pour appliquer le patern Iterator, on doit ajouter des méthodes génériques Next(), Current(), HasNext() mais ça viole le SRP
        /// On doit donc ajouter une nouvelle Interface Iterator et une classe conrète du type d'itérateur ex: ArrayIterator, ListIterator
        /// </summary>
        public void IteratorPattern()
        {
            Helpers.SetTitle(nameof(IteratorPattern), ConsoleColor.Blue);

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            //BAD: Si on change l'interieur de l'objet, on va avoir un problème
            DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList listBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList();
            listBad.Push("Milk");
            listBad.Push("Bread");
            listBad.Push("Steak");

            for (int i = 0; i < listBad.GetList().Count; i++)
            {
                var item = listBad.GetList()[i];
                Console.WriteLine(item);
            }

            Helpers.SetTitle("GOOD");
            DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD.ShoppingList listGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD.ShoppingList();
            listBad.Push("Milk");
            listBad.Push("Bread");
            listBad.Push("Steak");

            var iterator = listGood.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }

        /// <summary>
        ///  Chain of responsability Pattern => Passe une demande le long d'une chaîne de gestionnaires potentiels jusqu'à ce qu'elle soit traitée.
        ///  Autre def: Permet de construire une chaîne d’objets. La responsabilité de l’objet qui accepte une requête doit la traiter. S’il ne peut 
        ///  pas le faire, il passe le relais au suivant et ainsi de suite.
        /// </summary>
        public void ChainOfResponsabilityPattern()
        {
            Helpers.SetTitle(nameof(ChainOfResponsabilityPattern), ConsoleColor.Blue);

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            var serverBad = new CHAINOFRESPONSABILITY.BAD.WebServer();
            var requestBad = new CHAINOFRESPONSABILITY.BAD.HttpRequest("danny", "123");
            serverBad.Handle(requestBad);

            Helpers.SetTitle("GOOD");
            var validator = new CHAINOFRESPONSABILITY.GOOD.Validator();
            var authenticator = new CHAINOFRESPONSABILITY.GOOD.Authenticator();
            var logger = new CHAINOFRESPONSABILITY.GOOD.Logger();

            validator.SetNext(authenticator).SetNext(logger);

            var server = new CHAINOFRESPONSABILITY.GOOD.WebServer(validator);

            var req = new CHAINOFRESPONSABILITY.GOOD.HttpRequest("danny", "123"); // La chaine est correcte
            // ici la pipeline affiche "Validating"->"Authenticating"->"Logging"
            server.Handle(req);

            var req2 = new CHAINOFRESPONSABILITY.GOOD.HttpRequest("danny", "abc"); // Le mdp est faux
            // ici la pipeline affiche "Validating"->"Authenticating"
            server.Handle(req2);

            var req3 = new CHAINOFRESPONSABILITY.GOOD.HttpRequest("", ""); // les chaines sont vides
            // ici la pipeline affiche "Validating"
            server.Handle(req3);
        }

        /// <summary>
        /// Command Pattern => Encapsule une demande en tant qu'objet, permettant ainsi de paramétrer les clients avec des queues de requêtes,
        /// des demandes et des opérations.
        /// Autre def: Permet d’encapsuler des requêtes sous forme d’objet.
        /// </summary>
        public void CommandPattern()
        {
            Helpers.SetTitle(nameof(CommandPattern), ConsoleColor.Blue);

            Helpers.SetTitle("BAD", ConsoleColor.Red);
            var lightBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD.Light();
            var remoteBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD.RemoteControl(lightBad);

            remoteBad.PressButton(true);
            remoteBad.PressButton(false);

            Helpers.SetTitle("GOOD");
            var lightGood = new Light();
            var remoteGood = new RemoteControl(new TurnOnCommand(lightGood));
            remoteGood.PressButton(); // light is on
            remoteGood.SetCommand(new DimCommand(lightGood));
            remoteGood.PressButton(); // light is dim
            remoteGood.SetCommand(new TurnOffCommand(lightGood));
            remoteGood.PressButton(); // light is off

            //UNDOABLE
            var htmlDoc = new HtmlDocument();
            var history = new COMMAND.UNDOABLE.History();
            htmlDoc.Content = "Hello wrold";
            Console.WriteLine(htmlDoc.Content); // Hello world

            var italicCommand = new ItalicCommand(htmlDoc, history);
            italicCommand.Execute();
            Console.WriteLine(htmlDoc.Content);// <i>Hello world</i>

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(htmlDoc.Content);// Hello world
        }

        /// <summary>
        /// Interpreter Pattern => Permet d'évaluer des phrases dans un language en utilisant une classe abstraite d'expressions
        /// Exemple: Parser et exécuter une requête SQL, Calcul scientifique d'une calculatrice, render HTML etc.
        /// </summary>
        public void InterpreterPattern()
        {
            Helpers.SetTitle(nameof(InterpreterPattern), ConsoleColor.Blue);

            Helpers.SetTitle("GOOD");
            string input = "1 + 2 * 3";

            Context context = new Context();
            Interpreter interpreter = new Interpreter(context);
            var result = interpreter.Interpret(input);
            Console.WriteLine("Result : " + result);
        }
    }
}
