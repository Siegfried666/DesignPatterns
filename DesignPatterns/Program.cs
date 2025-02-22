using System.Security.Cryptography;
using DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.GOOD;
using DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.BAD;
/* Begavioral Design Patterns
Les Design Patterns Bahaviorial concernent l'interaction entre les objets
Permet de résoudre des problèmes de communication, de responsabilité et d'algorithmique
Separation of concern: séparations entre les objets et les classes
*/

/* 

        Memento Pattern => Permet de faire un snapshot

*/

// using DESIGNPATTERNS.BehavioralsDesignsPatterns.Memento;

// var editor = new Editor();
// var history = new History(editor);
// history.Backup();
// editor.Title = "Test";
// history.Backup();
// editor.Content = "Hello there, my name is Freddy";
// history.Backup();
// editor.Title = "The live of a dev: my mementos";

// Console.WriteLine("Title: " + editor.Title);
// Console.WriteLine("Content: " + editor.Content);

// history.Undo();

// Console.WriteLine("Title: " + editor.Title);
// Console.WriteLine("Content: " + editor.Content);

// history.ShowHistory();

// history.Undo();
// Console.WriteLine("Title: " + editor.Title);
// Console.WriteLine("Content: " + editor.Content);
// history.Undo();
// Console.WriteLine("Title: " + editor.Title);
// Console.WriteLine("Content: " + editor.Content);

/* 

        State Pattern => Permet de changer le fonctionnement d'une fonction en suivant son état
        On l'utilise pour gérer les cas de polymorphismes. Si un objet a besoin de changer souvent d'état, ie faire appel
        a des conditions différentes (if, else...).
        => Il implémente le polymorphisme, le principe de Single Responsability Principle, et l'Open Close Principle

*/

// System.Console.WriteLine("Bad");
// var docBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.Document();
// docBad.State = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.DocumentStates.Moderation;
// // doc.CurrentUserTole = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.UserRoles.Admin;
// docBad.CurrentUserTole = DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD.UserRoles.Editor;
// Console.WriteLine(docBad.State);

// docBad.Publish();
// Console.WriteLine(docBad.State);

// System.Console.WriteLine("Good");
// var docGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.Document(DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.UserRoles.Editor);
// //var docGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.Document(DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD.UserRoles.Admin);
// Console.WriteLine(docGood.State);

// docGood.Publish();
// Console.WriteLine(docGood.State);

// docGood.Publish();
// Console.WriteLine(docGood.State);

/* 

        Strategy Pattern => On passe différents algorithmes ou comportements à un objet

*/

// using DesignPatterns.BehavioralsDesignsPatterns.COMMAND.UNDOABLE;
// using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.BAD;
// using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern;

// using DESIGNPATTERNS.BehavioralsDesignsPatterns.Command;
// using DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD;
// using DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.GOOD;
// using DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator;
// using DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD;

// using Tea = DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.BAD.Tea;

// var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
// videoStorage.Store("video/some-movie");

// videoStorage.SetCompressor(new CompressorMP4());
// videoStorage.SetOverlay(new OverlayNone());
// videoStorage.Store("video/some-movie");

/* 

        Iterator Pattern => Permet d'itérer un objet sans avoir à connaitre la structure interne de cet objet.
        Le fait de changer le fonctionnement interne d'un objet ne doit pas affecter le consommateur

        Pour appliquer le patern Iterator, on doit ajouter des méthodes génériques Next(), Current(), HasNext() mais ça viole le SRP
        On doit donc ajouter une nouvelle Interface Iterator et une classe conrète du type d'itérateur ex: ArrayIterator, ListIterator

*/

// BAD: Si on change l'interieur de l'objet, on va avoir un problème
// DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList listBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList();
// listBad.Push("Milk");
// listBad.Push("Bread");
// listBad.Push("Steak");

// for (int i = 0; i < listBad.GetList().Count; i++)
// {
//         var item = listBad.GetList()[i];
//         System.Console.WriteLine(item);
// }

// GOOD
// DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD.ShoppingList listGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD.ShoppingList();
// listBad.Push("Milk");
// listBad.Push("Bread");
// listBad.Push("Steak");

// var iterator = listGood.CreateIterator();

// while (iterator.HasNext())
// {
//         System.Console.WriteLine(iterator.Current());
//         iterator.Next();
// }

/* 
        Command Pattern => Encapsule une commande comme objet
*/

// BAD
// var lightBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD.Light();
// var remoteBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.BAD.RemoteControl(lightBad);

// remoteBad.PressButton(true);
// remoteBad.PressButton(false);

// GOOD
// var lightGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.GOOD.Light();
// var remoteGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Command.GOOD.RemoteControl(new TurnOnCommand(lightGood));
// remoteGood.PressButton(); // light is on
// remoteGood.SetCommand(new DimCommand(lightGood));
// remoteGood.PressButton(); // light is dim
// remoteGood.SetCommand(new TurnOffCommand(lightGood));
// remoteGood.PressButton(); // light is off

// UNDOABLE
// var htmlDoc = new HtmlDocument();
// var history = new History();
// htmlDoc.Content = "Hello wrold";
// System.Console.WriteLine(htmlDoc.Content); // Hello world

// var italicCommand = new ItalicCommand(htmlDoc, history);
// italicCommand.Execute();
// System.Console.WriteLine(htmlDoc.Content);// <i>Hello world</i>

// var undoCommand = new UndoCommand(history);
// undoCommand.Execute();
// System.Console.WriteLine(htmlDoc.Content);// Hello world

/* 
        Template method Pattern
        -> On peut se service de Strategy Pattern => Utilise le Polymorphisme (POO principle) et le Pattern Strategy pour regrouper dans une classe abstraite ce qui se
        répète dans le code
*/

//BAD: Si on ajoute une autre classe, on répète le code (ex: Coffee avec des particularités différentes)
// var teaBad = new Tea();
// teaBad.MakeBeverage();

//GOOD Strategy Patterns
// System.Console.WriteLine("GOOD Strategy Patterns");
// var beverageMaker = new BeverageMaker(new DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern.Tea());
// beverageMaker.MakeBeverage();

// beverageMaker = new BeverageMaker(new DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern.Coffee());
// beverageMaker.MakeBeverage();

// GOOD Template method Pattern
// System.Console.WriteLine("GOOD Template method Pattern");
// var tea = new DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_TemplateMethodPattern.Tea();
// tea.Prepare();

// var camomile = new DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_TemplateMethodPattern.Camomile();
// camomile.Prepare();

/* 
        Observer Pattern => Le "publisher" va notifier les "observers" qui sont abonnés à lui si son état change
*/

// BAD: Les principes SOLID SRP et OCP sont violés dans cette implémentation.
// SRP => Datasource a 2 responsabilités, stocker les données et gérer les objets dépendants (Sheet2 et BarChart)
// OCP => Si on crée d'autre objets (Sheet1, BarChart2 etc.), on est obligé de modifier Datasource.cs

// Datasource datasourceBad = new Datasource();
// Sheet2 sheet2Bad = new Sheet2();
// BarChart barChartBad = new BarChart();

// datasourceBad.AddDependent(sheet2Bad);
// datasourceBad.AddDependent(barChartBad);

// datasourceBad.SetValues([5, 1, 10]);

// datasourceBad.SetValues([1, 2, 3]);

// GOOD:
// SRP => on Créé une classe qui gère les objets
// OCP => on implémente une interface commune aux objets Sheet2 et BarChart

// DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD.Datasource datasource = new DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD.Datasource();

// DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD.Sheet2 sheet2 = new DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD.Sheet2(datasource);
// DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD.BarChart barChart = new DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD.BarChart(datasource);

// datasource.AddObserver(sheet2);
// datasource.AddObserver(barChart);

// datasource.SetValues([5, 1, 10]);

// datasource.SetValues([1, 2, 3]);

/* 
        Mediator Pattern => Un objet appelé le "Mediator" qui décrit l'interraction entre plusieurs objets va réduire les dépendances entre les objets
*/

// var postDialogBox = new PostDialogBox();
// postDialogBox.SimulateUserInteraction();

var postDialogBox = new DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.GOOD.WITHOBSERVER.PostDialogBox();
postDialogBox.SimulateUserInteraction();
