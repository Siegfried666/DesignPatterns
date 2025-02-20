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

using DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator;
using DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD;

var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
videoStorage.Store("video/some-movie");

videoStorage.SetCompressor(new CompressorMP4());
videoStorage.SetOverlay(new OverlayNone());
videoStorage.Store("video/some-movie");

/* 

        Iterator Pattern => Permet d'itérer un objet sans avoir à connaitre la structure interne de cet objet.
        Le fait de changer le fonctionnement interne d'un objet ne doit pas affecter le consommateur

        Pour appliquer le patern Iterator, on doit ajouter des méthodes génériques Next(), Current(), HasNext() mais ça viole le SRP
        On doit donc ajouter une nouvelle Interface Iterator et une classe conrète du type d'itérateur ex: ArrayIterator, ListIterator

*/

// BAD: Si on change l'interieur de l'objet, on va avoir un problème
DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList listBad = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD.ShoppingList();
listBad.Push("Milk");
listBad.Push("Bread");
listBad.Push("Steak");

for (int i = 0; i < listBad.GetList().Count; i++)
{
        var item = listBad.GetList()[i];
        System.Console.WriteLine(item);
}

// GOOD
DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD.ShoppingList listGood = new DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.GOOD.ShoppingList();
listBad.Push("Milk");
listBad.Push("Bread");
listBad.Push("Steak");

var iterator = listGood.CreateIterator();

while (iterator.HasNext())
{
        System.Console.WriteLine(iterator.Current());
        iterator.Next();
}