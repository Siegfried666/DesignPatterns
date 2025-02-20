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

using DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD;

var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
videoStorage.Store("video/some-movie");

videoStorage.SetCompressor(new CompressorMP4());
videoStorage.SetOverlay(new OverlayNone());
videoStorage.Store("video/some-movie");

/* 

        Strategy Pattern => On passe différents algorithmes ou comportements à un objet

*/