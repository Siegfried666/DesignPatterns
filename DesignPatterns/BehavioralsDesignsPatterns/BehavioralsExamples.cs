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

/// <summary>
/// Begavioral Design Patterns
/// Les Design Patterns Bahaviorial concernent l'interaction entre les objets
/// Permet de résoudre des problèmes de communication, de responsabilité et d'algorithmique
/// Separation of concern: séparations entre les objets et les classes
/// </summary>
namespace DesignPatterns.BehavioralsDesignsPatterns
{

    public class BehavioralsExamples
    {
        public void VisitorPattern()
        {
            var description = "Permet d'ajouter de nouvelles opérations à une structure d'objets sans modifier les classes sur lesquelles elles opèrent\nAutre def: Permet de définir une nouvelle opération sans changer les classes des éléments sur lesquels il opère.";
            Helpers.SetTitle(nameof(VisitorPattern), Statut.Title, description);

            var retailName = "Debinhams";
            var retailEmail = "team@debinhams.com";
            var restaurantName = "Frankie & Bennys";
            var restaurantEmail = "frankAndBenny@resto.com";
            var lawName = "Hamlin McGil Law Firm";
            var lawEmail = "HamliMcGin@Lawers.com";

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Manager demande d'étendre de plus en plus de features dans chaque client (ex: export PDF, XML etc.)\nA chaque fois on doit modifier la base CLient et implémenter dans chaque client (OCP) et SRP");

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

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
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

        public void TemplateMethodPattern()
        {
            var description = "On peut se service de Strategy Pattern => Utilise le Polymorphisme (POO principle) et le Pattern Strategy pour regrouper dans une\n classe abstraite ce qui se répète dans le code.\nAutre def: Permet de redéfinir certaines étapes d’un algorithme sans modifier la structure de l’algorithme.";
            Helpers.SetTitle(nameof(TemplateMethodPattern), Statut.Title, description);

            Helpers.SetTitle(nameof(TemplateMethodPattern), Statut.Title);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Si on ajoute une autre classe, on répète le code (ex: Coffee avec des particularités différentes)");
            var teaBad = new Tea();
            teaBad.MakeBeverage();

            Helpers.SetTitle("GOOD Strategy Patterns", Statut.Good);

            Console.WriteLine("GOOD Strategy Patterns");
            var beverageMaker = new BeverageMaker(new TEMPLATE_METHOD.GOOD_StrategyPattern.Tea());
            beverageMaker.MakeBeverage();

            beverageMaker = new BeverageMaker(new Coffee());
            beverageMaker.MakeBeverage();

            Helpers.SetTitle("GOOD Template method Pattern", Statut.Good);

            Console.WriteLine("GOOD Template method Pattern");
            var tea = new TEMPLATE_METHOD.GOOD_TemplateMethodPattern.Tea();
            tea.Prepare();

            var camomile = new TEMPLATE_METHOD.GOOD_TemplateMethodPattern.Camomile();
            camomile.Prepare();
        }

        public void StrategyPattern()
        {
            var description = "Permet de définir une famille d'algorithmes, encapsule chacun d'eux, et les rend interchangeables.\nAutre def: Permet de pouvoir faire permuter des algorithmes au sein d’une application dans certaines conditions";
            Helpers.SetTitle(nameof(StrategyPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad);
            var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
            videoStorage.Store("video/some-movie");

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
            videoStorage.SetCompressor(new CompressorMP4());
            videoStorage.SetOverlay(new OverlayNone());
            videoStorage.Store("video/some-movie");
        }

        public void StatePattern()
        {
            var description = "Permet à un objet de modifier son comportement lorsque son état interne change.\nAutre def: Permet, lorsqu’un objet est altéré, de changer son comportement.\nOn l'utilise pour gérer les cas de polymorphismes. Si un objet a besoin de changer souvent d'état, ie faire appel\na des conditions différentes (if, else...).\n=> Il implémente le polymorphisme, le principe de Single Responsability Principle, et l'Open Close Principle";
            Helpers.SetTitle(nameof(StatePattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad);
            var docBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.Document();
            docBad.State = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.DocumentStates.Moderation;
            // doc.CurrentUserTole = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.UserRoles.Admin;
            docBad.CurrentUserTole = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.UserRoles.Editor;
            Console.WriteLine(docBad.State);

            docBad.Publish();
            Console.WriteLine(docBad.State);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
            var docGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.Document(DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.UserRoles.Editor);
            //var docGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.Document(DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.UserRoles.Admin);
            Console.WriteLine(docGood.State);

            docGood.Publish();
            Console.WriteLine(docGood.State);

            docGood.Publish();
            Console.WriteLine(docGood.State);
        }

        public void ObserverPattern()
        {
            var description = "Définit une dépendance de type one-to-many entre objets, de manière à ce que lorsque un objet change d'état, \ntous ceux qui en dépendent en sont notifiés et mis à jour automatiquement.\nAutre def: Permet de définir une relation Observateur-Obersable entre les objets. Quand un objet de type Observable change d’état, il notifie \ntous les autres objets qui l’observent de son changement pour eux-mêmes changer d’état.";
            Helpers.SetTitle(nameof(ObserverPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Les principes SOLID SRP et OCP sont violés dans cette implémentation.\nSRP => Datasource a 2 responsabilités, stocker les données et gérer les objets dépendants(Sheet2 et BarChart)\nOCP => Si on crée d'autre objets (Sheet1, BarChart2 etc.), on est obligé de modifier Datasource.cs");

            Datasource datasourceBad = new Datasource();
            Sheet2 sheet2Bad = new Sheet2();
            BarChart barChartBad = new BarChart();

            datasourceBad.AddDependent(sheet2Bad);
            datasourceBad.AddDependent(barChartBad);

            datasourceBad.SetValues([5, 1, 10]);
            datasourceBad.SetValues([1, 2, 3]);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good, "SRP => on Créé une classe qui gère les objets\nOCP => on implémente une interface commune aux objets Sheet2 et BarChart");

            OBSERVER.GOOD.Datasource datasource = new OBSERVER.GOOD.Datasource();
            OBSERVER.GOOD.Sheet2 sheet2 = new OBSERVER.GOOD.Sheet2(datasource);
            OBSERVER.GOOD.BarChart barChart = new OBSERVER.GOOD.BarChart(datasource);

            datasource.AddObserver(sheet2);
            datasource.AddObserver(barChart);

            datasource.SetValues([5, 1, 10]);
            datasource.SetValues([1, 2, 3]);
        }

        public void MementoPattern()
        {
            var description = "Permet de sauvegarder et restaurer l'état antérieur d'un objet sans révéler les détails de son implémentation.\nAutre def: Permet de restaurer un état précédent d’un objet (retour arrière) sans violer le principe d’encapsulation.";
            Helpers.SetTitle(nameof(MementoPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
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

        public void MediatorPattern()
        {
            var description = "Réduit le couplage en permettant de communiquer sans se connaître mutuellement, en centralisant les interactions \ncomplexes entre objets étroitement couplés.\nAutre def: permet de construire un objet dont la vocation est la gestion et le contrôle des interactions dans un ensemble d’objets \nsans que ses éléments doivent se connaître mutuellement.";
            Helpers.SetTitle(nameof(MediatorPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
            var postDialogBox = new PostDialogBox();
            postDialogBox.SimulateUserInteraction();

            var postDialogBoxWithObserver = new MEDIATOR.WITHOBSERVER.PostDialogBox();
            postDialogBoxWithObserver.SimulateUserInteraction();
        }

        public void IteratorPattern()
        {
            var description = "Fournit un moyen d'accéder séquentiellement aux éléments d'un objet aggregate sans exposer sa représentation sous-jacente.\nLe fait de changer le fonctionnement interne d'un objet ne doit pas affecter le consommateur\nAurtre def: Permet d’accéder à des éléments d’un agrégat séquentiellement. On pourrait identifier ce pattern au curseur\nPour appliquer le patern Iterator, on doit ajouter des méthodes génériques Next(), Current(), HasNext() mais ça viole le SRP\nOn doit donc ajouter une nouvelle Interface Iterator et une classe conrète du type d'itérateur ex: ArrayIterator, ListIterator";
            Helpers.SetTitle(nameof(IteratorPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad, "Si on change l'interieur de l'objet, on va avoir un problème");
            DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList listBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList();
            listBad.Push("Milk");
            listBad.Push("Bread");
            listBad.Push("Steak");

            for (int i = 0; i < listBad.GetList().Count; i++)
            {
                var item = listBad.GetList()[i];
                Console.WriteLine(item);
            }

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
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

        public void ChainOfResponsabilityPattern()
        {
            var description = "Passe une demande le long d'une chaîne de gestionnaires potentiels jusqu'à ce qu'elle soit traitée.\nAutre def: Permet de construire une chaîne d’objets. La responsabilité de l’objet qui accepte une requête doit la traiter. S’il ne peut \npas le faire, il passe le relais au suivant et ainsi de suite.";
            Helpers.SetTitle(nameof(ChainOfResponsabilityPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad);
            var serverBad = new CHAINOFRESPONSABILITY.BAD.WebServer();
            var requestBad = new CHAINOFRESPONSABILITY.BAD.HttpRequest("danny", "123");
            serverBad.Handle(requestBad);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
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

        public void CommandPattern()
        {
            var description = "Encapsule une demande en tant qu'objet, permettant ainsi de paramétrer les clients avec des queues de requêtes,\ndes demandes et des opérations.\nAutre def: Permet d’encapsuler des requêtes sous forme d’objet.";
            Helpers.SetTitle(nameof(CommandPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Bad.ToString(), Statut.Bad);
            var lightBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD.Light();
            var remoteBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD.RemoteControl(lightBad);

            remoteBad.PressButton(true);
            remoteBad.PressButton(false);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
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
            htmlDoc.Content = "Hello world";
            Console.WriteLine(htmlDoc.Content); // Hello world

            var italicCommand = new ItalicCommand(htmlDoc, history);
            italicCommand.Execute();
            Console.WriteLine(htmlDoc.Content);// <i>Hello world</i>

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(htmlDoc.Content);// Hello world
        }

        public void InterpreterPattern()
        {
            var description = "Permet d'évaluer des phrases dans un language en utilisant une classe abstraite d'expressions\nExemple: Parser et exécuter une requête SQL, Calcul scientifique d'une calculatrice, render HTML etc.";
            Helpers.SetTitle(nameof(InterpreterPattern), Statut.Title, description);

            Helpers.SetTitle(Statut.Good.ToString(), Statut.Good);
            string input = "1 + 2 * 3";

            Context context = new Context();
            Interpreter interpreter = new Interpreter(context);
            var result = interpreter.Interpret(input);
            Console.WriteLine("Result : " + result);
        }
    }
}
